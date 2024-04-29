namespace GerenciamentoDeEstoque
{
    partial class SelecaoClienteVenda
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
            this.lvSelecaoCliente = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSelecaoCliente
            // 
            this.lvSelecaoCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmSobrenome});
            this.lvSelecaoCliente.FullRowSelect = true;
            this.lvSelecaoCliente.HideSelection = false;
            this.lvSelecaoCliente.Location = new System.Drawing.Point(25, 22);
            this.lvSelecaoCliente.MultiSelect = false;
            this.lvSelecaoCliente.Name = "lvSelecaoCliente";
            this.lvSelecaoCliente.Size = new System.Drawing.Size(361, 248);
            this.lvSelecaoCliente.TabIndex = 0;
            this.lvSelecaoCliente.UseCompatibleStateImageBehavior = false;
            this.lvSelecaoCliente.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 137;
            // 
            // clmSobrenome
            // 
            this.clmSobrenome.Text = "Sobrenome";
            this.clmSobrenome.Width = 117;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(311, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(230, 291);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // SelecaoClienteVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 333);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lvSelecaoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelecaoClienteVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Cliente Consumidor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSelecaoCliente;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ColumnHeader clmSobrenome;
    }
}