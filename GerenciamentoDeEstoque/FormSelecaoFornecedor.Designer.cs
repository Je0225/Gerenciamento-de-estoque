namespace GerenciamentoDeEstoque
{
    partial class FormSelecaoFornecedor
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lvFornecedores = new System.Windows.Forms.ListView();
            this.clmEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(313, 396);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lvFornecedores
            // 
            this.lvFornecedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmEmpresa,
            this.clmMarca});
            this.lvFornecedores.FullRowSelect = true;
            this.lvFornecedores.HideSelection = false;
            this.lvFornecedores.Location = new System.Drawing.Point(26, 22);
            this.lvFornecedores.MultiSelect = false;
            this.lvFornecedores.Name = "lvFornecedores";
            this.lvFornecedores.Size = new System.Drawing.Size(362, 349);
            this.lvFornecedores.TabIndex = 2;
            this.lvFornecedores.UseCompatibleStateImageBehavior = false;
            this.lvFornecedores.View = System.Windows.Forms.View.Details;
            // 
            // clmEmpresa
            // 
            this.clmEmpresa.Text = "Empresa";
            this.clmEmpresa.Width = 174;
            // 
            // clmMarca
            // 
            this.clmMarca.Text = "Marca";
            this.clmMarca.Width = 180;
            // 
            // clmId
            // 
            this.clmId.Text = "Id";
            // 
            // FormSelecaoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 440);
            this.Controls.Add(this.lvFornecedores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSelecaoFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Fornecedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView lvFornecedores;
        private System.Windows.Forms.ColumnHeader clmEmpresa;
        private System.Windows.Forms.ColumnHeader clmMarca;
        private System.Windows.Forms.ColumnHeader clmId;
    }
}