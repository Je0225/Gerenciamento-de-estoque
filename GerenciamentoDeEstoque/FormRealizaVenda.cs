﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormRealizaVenda: Form {

        private Int32 Id { get; set; }

        private List<KeyValuePair<Produto, Int32>> ItensVenda { get; }

        private Cliente Cliente { get; set; }

        private String Modalidade { get; set; }

        private Double ValorItens { get; set; }

        private Double PercentualDesconto { get; set; }

        private Double TotalVenda { get; set; }

        public FormRealizaVenda() {
            InitializeComponent();
            ItensVenda = new List<KeyValuePair<Produto, Int32>>();
            cbModalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (String forma in Repository.Banco.ModalidadesPagamento) {
                cbModalidade.Items.Add(forma);
            }
            Id = Repository.Banco.Vendas.Count > 0 ? Repository.Banco.Vendas.Count + 1: 1;
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            FormSelecao<Cliente> formSelecao = new FormSelecao<Cliente>(Repository.Banco.Clientes, Cliente.GetColumnNames());
            formSelecao.ShowDialog();
            if (formSelecao.DialogResult != DialogResult.OK) {
                tbCliente.Enabled = true;
                return;
            }
            Cliente = formSelecao.SelecionadoCast;
            tbCliente.Text = $@"{Cliente.Nome} {Cliente.Sobrenome}";
            tbCliente.Enabled = false;
            formSelecao.Dispose();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormInformaProdutoVenda frmProdutoVenda = new FormInformaProdutoVenda(null, 0);
            frmProdutoVenda.ShowDialog();

            if (frmProdutoVenda.DialogResult != DialogResult.OK) {
                tbCliente.Enabled = false;
                return;
            }
            foreach (KeyValuePair<Produto, Int32> kvp in ItensVenda) {
                if (kvp.Key.Equals(frmProdutoVenda.ProdutoSelecionado)) {
                    MessageBox.Show("Este item já está na lista de items da venda");
                    return;
                }
            }
            ItensVenda.Add(new KeyValuePair<Produto, Int32>(frmProdutoVenda.ProdutoSelecionado, frmProdutoVenda.Quantidade));
            AddItemListView();
            ValorItens = CalculaValorItens();
            tbTotalItens.Text = ValorItens.ToString("F2");
            frmProdutoVenda.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (lvItensVenda.SelectedItems.Count > 0) {
                foreach (KeyValuePair<Produto, Int32> kvp in ItensVenda) {
                    if (lvItensVenda.SelectedItems[0].Tag.Equals(kvp.Key)) {
                        ItensVenda.Remove(kvp);
                        lvItensVenda.Items.Remove(lvItensVenda.SelectedItems[0]);
                        ValorItens = CalculaValorItens();
                        tbTotalItens.Text = ValorItens.ToString("F2");
                        return;
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (lvItensVenda.SelectedItems.Count == 0) {
                return;
            }
            foreach (KeyValuePair<Produto, Int32> kvp in ItensVenda) {
                if (lvItensVenda.SelectedItems[0].Tag.Equals(kvp.Key)) {
                    FormInformaProdutoVenda frmInformaProdutoVenda = new FormInformaProdutoVenda(kvp.Key, kvp.Value);
                    frmInformaProdutoVenda.ShowDialog();

                    if (frmInformaProdutoVenda.DialogResult != DialogResult.OK) {
                        tbCliente.Enabled = false;
                        return;
                    }
                    ItensVenda.Remove(kvp);
                    ItensVenda.Add(new KeyValuePair<Produto, Int32>(frmInformaProdutoVenda.ProdutoSelecionado, frmInformaProdutoVenda.Quantidade));
                    AddItemListView();
                    ValorItens = CalculaValorItens();
                    tbTotalItens.Text = ValorItens.ToString("F2");
                    frmInformaProdutoVenda.Dispose();
                    return;
                }
            }
        }

        private Double CalculaValorItens() {
            Double valor = 0;
            foreach (KeyValuePair<Produto, Int32> kvp in ItensVenda) {
                valor += kvp.Key.Valor * kvp.Value;
            }
            return valor;
        }

        private Double CalculaTotalVenda() {
            Double valorItens = CalculaValorItens();
            Double total = 0;
            if (PercentualDesconto.Equals(0)) {
                return valorItens;
            }
            if (!ValorItens.Equals(0)) {
                foreach (KeyValuePair<Produto, Int32> kvp in ItensVenda) {
                    total = valorItens - (valorItens * (PercentualDesconto / 100));
                }
            }
            return total;
        }

        private void tbTotalItens_TextChanged(object sender, EventArgs e) {
            TotalVenda = CalculaTotalVenda();
            tbTotalVenda.Text = TotalVenda.ToString("F2");
        }

        private void tbDesconto_TextChanged(object sender, EventArgs e) {
            PercentualDesconto = !tbDesconto.Text.Trim().Equals("") ? Convert.ToDouble(tbDesconto.Text) : 0;
            TotalVenda = CalculaTotalVenda();
            tbTotalVenda.Text = TotalVenda.ToString("F2");
        }

        private void btnFecharVenda_Click(object sender, EventArgs e) {
            if (tbCliente.Text.Trim().Equals("")) {
                MessageBox.Show(@"Selecione um cliente para fechar a venda");
                return;
            }
            if (lvItensVenda.Items.Count.Equals(0)) {
                MessageBox.Show(@"Informe algum item para fechar a venda");
                return;
            }
            if (cbModalidade.SelectedItem == null) {
                MessageBox.Show(@"Selecione uma modalidade para fechar a venda");
                return;
            }
            AtualizaEstoque();
            Modalidade = cbModalidade.SelectedItem.ToString();
            Venda venda = new Venda(Id, Cliente, ItensVenda, Modalidade, PercentualDesconto, ValorItens, TotalVenda);
            Repository.Banco.Vendas.Add(venda);
            Id++;
            Repository.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddItemListView() {
            if (lvItensVenda.Items.Count > 0) {
                lvItensVenda.Items.Clear();
            }
            foreach (KeyValuePair<Produto, Int32> kvp in ItensVenda) {
                lvItensVenda.Items.Add(new ListViewItem(new[] {
                    kvp.Key.Descricao,
                    kvp.Value.ToString(),
                    kvp.Key.Valor.ToString("F2")
                }) { Tag = kvp.Key });
            }
        }

        private void AtualizaEstoque() {
            foreach (KeyValuePair<Produto, Int32> kvp in ItensVenda) {
                kvp.Key.QuantidadeEstoque -= kvp.Value;
            }
        }

        private void tbDesconto_KeyDown(object sender, KeyEventArgs e) {
            e.Handled = true;
            if ((e.KeyValue > 47 && e.KeyValue < 58)  || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.PrintScreen) {
                e.Handled = false;
                
            } 
        }
    }

}