namespace GerenciamentoDeEstoque
{
    partial class FormCadastroCliente
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(136, 29);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(198, 20);
            this.tbNome.TabIndex = 1;
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Location = new System.Drawing.Point(136, 64);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(198, 20);
            this.tbSobrenome.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(256, 120);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(352, 120);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(58, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 23);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.Location = new System.Drawing.Point(58, 64);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(63, 23);
            this.lblSobrenome.TabIndex = 9;
            this.lblSobrenome.Text = "Sobrenome";
            this.lblSobrenome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 168);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbSobrenome);
            this.Controls.Add(this.tbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
    }
}