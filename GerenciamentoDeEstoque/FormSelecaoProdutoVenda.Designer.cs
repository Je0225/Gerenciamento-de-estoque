namespace GerenciamentoDeEstoque
{
    partial class FormSelecaoProdutoVenda
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
            this.lvSelecaoProdutos = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQtdEstoque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSelecaoProdutos
            // 
            this.lvSelecaoProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmDescricao,
            this.clmValor,
            this.clmQtdEstoque,
            this.clmFornecedor});
            this.lvSelecaoProdutos.FullRowSelect = true;
            this.lvSelecaoProdutos.HideSelection = false;
            this.lvSelecaoProdutos.Location = new System.Drawing.Point(22, 24);
            this.lvSelecaoProdutos.MultiSelect = false;
            this.lvSelecaoProdutos.Name = "lvSelecaoProdutos";
            this.lvSelecaoProdutos.Size = new System.Drawing.Size(361, 248);
            this.lvSelecaoProdutos.TabIndex = 0;
            this.lvSelecaoProdutos.UseCompatibleStateImageBehavior = false;
            this.lvSelecaoProdutos.View = System.Windows.Forms.View.Details;
            // 
            // clmId
            // 
            this.clmId.Text = "Id";
            // 
            // clmDescricao
            // 
            this.clmDescricao.Text = "Descrição";
            // 
            // clmValor
            // 
            this.clmValor.Text = "Valor";
            // 
            // clmQtdEstoque
            // 
            this.clmQtdEstoque.Text = "Estoque";
            // 
            // clmFornecedor
            // 
            this.clmFornecedor.Text = "Fornecedor";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(227, 298);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(308, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormSelecaoProdutoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 333);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lvSelecaoProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelecaoProdutoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Produtos da Venda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSelecaoProdutos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ColumnHeader clmDescricao;
        private System.Windows.Forms.ColumnHeader clmValor;
        private System.Windows.Forms.ColumnHeader clmQtdEstoque;
        private System.Windows.Forms.ColumnHeader clmFornecedor;
        private System.Windows.Forms.ColumnHeader clmId;
    }
}