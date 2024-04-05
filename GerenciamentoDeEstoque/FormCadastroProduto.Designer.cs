namespace GerenciamentoDeEstoque
{
    partial class FormCadastroProduto
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescontoMax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbDescontoMax = new System.Windows.Forms.TextBox();
            this.tbQtdEstoque = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(320, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(230, 198);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Location = new System.Drawing.Point(39, 63);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(68, 13);
            this.lblFornecedor.TabIndex = 3;
            this.lblFornecedor.Text = "Fornecedor";
            this.lblFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(72, 95);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescontoMax
            // 
            this.lblDescontoMax.Location = new System.Drawing.Point(27, 126);
            this.lblDescontoMax.Name = "lblDescontoMax";
            this.lblDescontoMax.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoMax.TabIndex = 5;
            this.lblDescontoMax.Text = "Desconto Máx.";
            this.lblDescontoMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Qtd em Estoque";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(113, 27);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(192, 20);
            this.tbDescricao.TabIndex = 7;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Location = new System.Drawing.Point(48, 30);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(59, 13);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.Enabled = false;
            this.tbFornecedor.Location = new System.Drawing.Point(113, 60);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(192, 20);
            this.tbFornecedor.TabIndex = 13;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(113, 92);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(111, 20);
            this.tbValor.TabIndex = 14;
            // 
            // tbDescontoMax
            // 
            this.tbDescontoMax.Enabled = false;
            this.tbDescontoMax.Location = new System.Drawing.Point(113, 123);
            this.tbDescontoMax.Name = "tbDescontoMax";
            this.tbDescontoMax.Size = new System.Drawing.Size(111, 20);
            this.tbDescontoMax.TabIndex = 15;
            // 
            // tbQtdEstoque
            // 
            this.tbQtdEstoque.Location = new System.Drawing.Point(113, 154);
            this.tbQtdEstoque.Name = "tbQtdEstoque";
            this.tbQtdEstoque.Size = new System.Drawing.Size(111, 20);
            this.tbQtdEstoque.TabIndex = 16;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSelecionar.Location = new System.Drawing.Point(320, 58);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(65, 23);
            this.btnSelecionar.TabIndex = 17;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 252);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.tbQtdEstoque);
            this.Controls.Add(this.tbDescontoMax);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbFornecedor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDescontoMax);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescontoMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tbFornecedor;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbDescontoMax;
        private System.Windows.Forms.TextBox tbQtdEstoque;
        private System.Windows.Forms.Button btnSelecionar;
    }
}