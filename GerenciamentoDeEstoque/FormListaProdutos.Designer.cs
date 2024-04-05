﻿namespace GerenciamentoDeEstoque
{
    partial class FormListaProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvProdutos = new System.Windows.Forms.ListView();
            this.clmDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clmValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescontoMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQtdEstoque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvProdutos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.panel2.Size = new System.Drawing.Size(597, 350);
            this.panel2.TabIndex = 4;
            // 
            // lvProdutos
            // 
            this.lvProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDescricao,
            this.clmFornecedor,
            this.clmValor,
            this.clmDescontoMax,
            this.clmQtdEstoque});
            this.lvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProdutos.FullRowSelect = true;
            this.lvProdutos.HideSelection = false;
            this.lvProdutos.Location = new System.Drawing.Point(30, 30);
            this.lvProdutos.MultiSelect = false;
            this.lvProdutos.Name = "lvProdutos";
            this.lvProdutos.Size = new System.Drawing.Size(567, 320);
            this.lvProdutos.TabIndex = 0;
            this.lvProdutos.UseCompatibleStateImageBehavior = false;
            this.lvProdutos.View = System.Windows.Forms.View.Details;
            // 
            // clmDescricao
            // 
            this.clmDescricao.Text = "Descrição";
            this.clmDescricao.Width = 157;
            // 
            // clmFornecedor
            // 
            this.clmFornecedor.Text = "Fornecedor";
            this.clmFornecedor.Width = 141;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(597, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 350);
            this.panel1.TabIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(54, 120);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 38);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(54, 32);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(108, 38);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 100);
            this.panel3.TabIndex = 5;
            // 
            // clmValor
            // 
            this.clmValor.Text = "Valor";
            this.clmValor.Width = 73;
            // 
            // clmDescontoMax
            // 
            this.clmDescontoMax.Text = "Desconto Máx.";
            this.clmDescontoMax.Width = 90;
            // 
            // clmQtdEstoque
            // 
            this.clmQtdEstoque.Text = "Qtd em Estoque";
            this.clmQtdEstoque.Width = 102;
            // 
            // FormListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FormListaProdutos";
            this.Text = "FormListaProdutos";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvProdutos;
        private System.Windows.Forms.ColumnHeader clmDescricao;
        private System.Windows.Forms.ColumnHeader clmFornecedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader clmValor;
        private System.Windows.Forms.ColumnHeader clmDescontoMax;
        private System.Windows.Forms.ColumnHeader clmQtdEstoque;
    }
}