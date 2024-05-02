namespace GerenciamentoDeEstoque
{
    partial class FormListagemVendas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.tbNomeFiltro = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvVendas = new System.Windows.Forms.ListView();
            this.clmCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDesconto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantiaItens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorIntens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFiltrarPor);
            this.panel1.Controls.Add(this.cbFiltro);
            this.panel1.Controls.Add(this.btnSelecionar);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Controls.Add(this.tbNomeFiltro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 110);
            this.panel1.TabIndex = 7;
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Location = new System.Drawing.Point(72, 36);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(50, 13);
            this.lblFiltrarPor.TabIndex = 5;
            this.lblFiltrarPor.Text = "Filtrar por";
            this.lblFiltrarPor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(128, 33);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(127, 21);
            this.cbFiltro.TabIndex = 4;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(460, 33);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(71, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(75, 67);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(108, 27);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(304, 37);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "Item";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNomeFiltro
            // 
            this.tbNomeFiltro.Enabled = false;
            this.tbNomeFiltro.Location = new System.Drawing.Point(335, 33);
            this.tbNomeFiltro.Name = "tbNomeFiltro";
            this.tbNomeFiltro.Size = new System.Drawing.Size(119, 20);
            this.tbNomeFiltro.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 340);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSair);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(71, 372);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 78);
            this.panel4.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(424, 30);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 27);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(531, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 262);
            this.panel2.TabIndex = 14;
            // 
            // lvVendas
            // 
            this.lvVendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCliente,
            this.clmDesconto,
            this.clmQuantiaItens,
            this.clmValorIntens,
            this.clmValorTotal});
            this.lvVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVendas.HideSelection = false;
            this.lvVendas.Location = new System.Drawing.Point(71, 110);
            this.lvVendas.Name = "lvVendas";
            this.lvVendas.Size = new System.Drawing.Size(460, 262);
            this.lvVendas.TabIndex = 15;
            this.lvVendas.UseCompatibleStateImageBehavior = false;
            this.lvVendas.View = System.Windows.Forms.View.Details;
            // 
            // clmCliente
            // 
            this.clmCliente.Text = "Cliente";
            this.clmCliente.Width = 70;
            // 
            // clmDesconto
            // 
            this.clmDesconto.Text = "Desconto(%)";
            this.clmDesconto.Width = 83;
            // 
            // clmQuantiaItens
            // 
            this.clmQuantiaItens.Text = "Qtd Itens";
            this.clmQuantiaItens.Width = 84;
            // 
            // clmValorIntens
            // 
            this.clmValorIntens.Text = "Valor Itens";
            this.clmValorIntens.Width = 114;
            // 
            // clmValorTotal
            // 
            this.clmValorTotal.Text = "Valor Total";
            this.clmValorTotal.Width = 90;
            // 
            // FormListagemVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.lvVendas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormListagemVendas";
            this.Text = "FrmListagemVendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox tbNomeFiltro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.ListView lvVendas;
        private System.Windows.Forms.ColumnHeader clmCliente;
        private System.Windows.Forms.ColumnHeader clmDesconto;
        private System.Windows.Forms.ColumnHeader clmQuantiaItens;
        private System.Windows.Forms.ColumnHeader clmValorIntens;
        private System.Windows.Forms.ColumnHeader clmValorTotal;
    }
}