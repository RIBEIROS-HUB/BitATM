namespace BitATM
{
    partial class BitATM
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.BitATMimg = new System.Windows.Forms.PictureBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BitATMimg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(12, 38);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(49, 13);
            this.lblAgencia.TabIndex = 1;
            this.lblAgencia.Text = "Agência:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(12, 118);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(38, 13);
            this.lblConta.TabIndex = 2;
            this.lblConta.Text = "Conta:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(209, 118);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // BitATMimg
            // 
            this.BitATMimg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BitATMimg.Image = global::BitATM.Properties.Resources.input_onlinepngtools;
            this.BitATMimg.Location = new System.Drawing.Point(-4, -1);
            this.BitATMimg.Name = "BitATMimg";
            this.BitATMimg.Size = new System.Drawing.Size(559, 363);
            this.BitATMimg.TabIndex = 4;
            this.BitATMimg.TabStop = false;
            this.BitATMimg.Click += new System.EventHandler(this.BitATMimg_Click);
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(67, 38);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(137, 20);
            this.txtAgencia.TabIndex = 5;
            this.txtAgencia.Text = "Agência com  Digito:";
            this.txtAgencia.TextChanged += new System.EventHandler(this.txtAgencia_TextChanged);
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(69, 111);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 6;
            this.txtConta.Text = "Conta com Digito:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(265, 111);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.Text = "Insira sua Senha:";
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEntrar.Location = new System.Drawing.Point(383, 311);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // BitATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1339, 896);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.BitATMimg);
            this.Name = "BitATM";
            this.Text = "BitATM";
            ((System.ComponentModel.ISupportInitialize)(this.BitATMimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox BitATMimg;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
    }
}

