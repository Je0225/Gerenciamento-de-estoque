namespace GerenciamentoDeEstoque
{
    partial class FormRealizaVenda
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
            this.components = new System.ComponentModel.Container();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lvItensVenda = new System.Windows.Forms.ListView();
            this.clmProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorUnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.lblValorItens = new System.Windows.Forms.Label();
            this.tbTotalItens = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFecharVenda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotalVenda = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(459, 33);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lvItensVenda
            // 
            this.lvItensVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmProduto,
            this.clmQuantidade,
            this.clmValorUnt});
            this.lvItensVenda.FullRowSelect = true;
            this.lvItensVenda.HideSelection = false;
            this.lvItensVenda.Location = new System.Drawing.Point(66, 84);
            this.lvItensVenda.MultiSelect = false;
            this.lvItensVenda.Name = "lvItensVenda";
            this.lvItensVenda.Size = new System.Drawing.Size(387, 155);
            this.lvItensVenda.TabIndex = 3;
            this.lvItensVenda.UseCompatibleStateImageBehavior = false;
            this.lvItensVenda.View = System.Windows.Forms.View.Details;
            // 
            // clmProduto
            // 
            this.clmProduto.Text = "Produto";
            this.clmProduto.Width = 91;
            // 
            // clmQuantidade
            // 
            this.clmQuantidade.Text = "Quantidade";
            this.clmQuantidade.Width = 94;
            // 
            // clmValorUnt
            // 
            this.clmValorUnt.Text = "Valor Unitário";
            this.clmValorUnt.Width = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(66, 35);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(387, 20);
            this.tbCliente.TabIndex = 7;
            // 
            // lblValorItens
            // 
            this.lblValorItens.AutoSize = true;
            this.lblValorItens.Location = new System.Drawing.Point(195, 262);
            this.lblValorItens.Name = "lblValorItens";
            this.lblValorItens.Size = new System.Drawing.Size(78, 13);
            this.lblValorItens.TabIndex = 10;
            this.lblValorItens.Text = "Valor dos ítens";
            this.lblValorItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTotalItens
            // 
            this.tbTotalItens.Enabled = false;
            this.tbTotalItens.Location = new System.Drawing.Point(279, 257);
            this.tbTotalItens.Name = "tbTotalItens";
            this.tbTotalItens.Size = new System.Drawing.Size(105, 20);
            this.tbTotalItens.TabIndex = 9;
            this.tbTotalItens.TextChanged += new System.EventHandler(this.tbTotalItens_TextChanged);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(397, 260);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(67, 13);
            this.lblDesconto.TabIndex = 12;
            this.lblDesconto.Text = "Desconto(%)";
            this.lblDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(470, 255);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(58, 20);
            this.tbDesconto.TabIndex = 11;
            this.tbDesconto.TextChanged += new System.EventHandler(this.tbDesconto_TextChanged);
            this.tbDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDesconto_KeyDown);
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(0, 259);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(62, 13);
            this.lblModalidade.TabIndex = 13;
            this.lblModalidade.Text = "Modalidade";
            this.lblModalidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbModalidade
            // 
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cbModalidade.Location = new System.Drawing.Point(66, 256);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(118, 21);
            this.cbModalidade.TabIndex = 14;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(459, 125);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFecharVenda
            // 
            this.btnFecharVenda.Location = new System.Drawing.Point(330, 323);
            this.btnFecharVenda.Name = "btnFecharVenda";
            this.btnFecharVenda.Size = new System.Drawing.Size(98, 23);
            this.btnFecharVenda.TabIndex = 16;
            this.btnFecharVenda.Text = "Fechar Venda";
            this.btnFecharVenda.UseVisualStyleBackColor = true;
            this.btnFecharVenda.Click += new System.EventHandler(this.btnFecharVenda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(445, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(459, 170);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(459, 85);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(61, 23);
            this.btnAdicionar.TabIndex = 19;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTotalVenda
            // 
            this.tbTotalVenda.Enabled = false;
            this.tbTotalVenda.Location = new System.Drawing.Point(66, 293);
            this.tbTotalVenda.Name = "tbTotalVenda";
            this.tbTotalVenda.Size = new System.Drawing.Size(105, 20);
            this.tbTotalVenda.TabIndex = 20;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FormRealizaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotalVenda);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFecharVenda);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cbModalidade);
            this.Controls.Add(this.lblModalidade);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.tbDesconto);
            this.Controls.Add(this.lblValorItens);
            this.Controls.Add(this.tbTotalItens);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.lvItensVenda);
            this.Controls.Add(this.btnSelecionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRealizaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.ListView lvItensVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label lblValorItens;
        private System.Windows.Forms.TextBox tbTotalItens;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.ComboBox cbModalidade;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFecharVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotalVenda;
        private System.Windows.Forms.ColumnHeader clmProduto;
        private System.Windows.Forms.ColumnHeader clmQuantidade;
        private System.Windows.Forms.ColumnHeader clmValorUnt;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}