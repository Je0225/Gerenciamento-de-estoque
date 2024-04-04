namespace GerenciamentoDeEstoque
{
    partial class FormPrincipal
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.tsmParceiros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosPorFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmParceiros,
            this.tsmVendas,
            this.tsmEstoque,
            this.listagemToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 34);
            this.Menu.TabIndex = 0;
            // 
            // tsmParceiros
            // 
            this.tsmParceiros.AutoSize = false;
            this.tsmParceiros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes,
            this.tsmiFornecedores});
            this.tsmParceiros.Name = "tsmParceiros";
            this.tsmParceiros.Size = new System.Drawing.Size(100, 30);
            this.tsmParceiros.Text = "Parceiros";
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(180, 22);
            this.tsmiClientes.Text = "Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiFornecedores
            // 
            this.tsmiFornecedores.Name = "tsmiFornecedores";
            this.tsmiFornecedores.Size = new System.Drawing.Size(180, 22);
            this.tsmiFornecedores.Text = "Fornecedores";
            this.tsmiFornecedores.Click += new System.EventHandler(this.tsmiFornecedores_Click);
            // 
            // tsmVendas
            // 
            this.tsmVendas.AutoSize = false;
            this.tsmVendas.Name = "tsmVendas";
            this.tsmVendas.Size = new System.Drawing.Size(100, 30);
            this.tsmVendas.Text = "Vendas";
            // 
            // tsmEstoque
            // 
            this.tsmEstoque.AutoSize = false;
            this.tsmEstoque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmEstoque.Name = "tsmEstoque";
            this.tsmEstoque.Size = new System.Drawing.Size(100, 30);
            this.tsmEstoque.Text = "Estoque";
            // 
            // listagemToolStripMenuItem
            // 
            this.listagemToolStripMenuItem.AutoSize = false;
            this.listagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosPorFornecedorToolStripMenuItem,
            this.vendasPorClienteToolStripMenuItem});
            this.listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            this.listagemToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.listagemToolStripMenuItem.Text = "Listagem";
            // 
            // produtosPorFornecedorToolStripMenuItem
            // 
            this.produtosPorFornecedorToolStripMenuItem.Name = "produtosPorFornecedorToolStripMenuItem";
            this.produtosPorFornecedorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.produtosPorFornecedorToolStripMenuItem.Text = "Produtos por fornecedor";
            // 
            // vendasPorClienteToolStripMenuItem
            // 
            this.vendasPorClienteToolStripMenuItem.Name = "vendasPorClienteToolStripMenuItem";
            this.vendasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.vendasPorClienteToolStripMenuItem.Text = "Vendas por cliente";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.Name = "FormPrincipal";
            this.Text = "Gerenciamento de vendas/estoque";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmParceiros;
        private System.Windows.Forms.ToolStripMenuItem tsmVendas;
        private System.Windows.Forms.ToolStripMenuItem tsmEstoque;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiFornecedores;
        private System.Windows.Forms.ToolStripMenuItem listagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosPorFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasPorClienteToolStripMenuItem;
    }
}

