namespace sistemaCaixaEletronico
{
    partial class frmImprimirExtrato
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnCancImpressao = new System.Windows.Forms.Button();
            this.btnSalvarExtrato = new System.Windows.Forms.Button();
            this.lblMsgExtrato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancImpressao
            // 
            this.btnCancImpressao.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancImpressao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancImpressao.Location = new System.Drawing.Point(108, 235);
            this.btnCancImpressao.Name = "btnCancImpressao";
            this.btnCancImpressao.Size = new System.Drawing.Size(90, 33);
            this.btnCancImpressao.TabIndex = 0;
            this.btnCancImpressao.Text = "Cancelar";
            this.btnCancImpressao.UseVisualStyleBackColor = false;
            this.btnCancImpressao.Click += new System.EventHandler(this.btnCancImpressao_Click);
            // 
            // btnSalvarExtrato
            // 
            this.btnSalvarExtrato.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvarExtrato.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvarExtrato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarExtrato.Location = new System.Drawing.Point(204, 235);
            this.btnSalvarExtrato.Name = "btnSalvarExtrato";
            this.btnSalvarExtrato.Size = new System.Drawing.Size(134, 33);
            this.btnSalvarExtrato.TabIndex = 1;
            this.btnSalvarExtrato.Text = "Salvar Extrato";
            this.btnSalvarExtrato.UseVisualStyleBackColor = false;
            this.btnSalvarExtrato.Click += new System.EventHandler(this.btnSalvarExtrato_Click);
            // 
            // lblMsgExtrato
            // 
            this.lblMsgExtrato.AutoSize = true;
            this.lblMsgExtrato.Location = new System.Drawing.Point(25, 23);
            this.lblMsgExtrato.Name = "lblMsgExtrato";
            this.lblMsgExtrato.Size = new System.Drawing.Size(162, 20);
            this.lblMsgExtrato.TabIndex = 2;
            this.lblMsgExtrato.Text = "Carregando Mensagem...";
            // 
            // frmImprimirExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.lblMsgExtrato);
            this.Controls.Add(this.btnSalvarExtrato);
            this.Controls.Add(this.btnCancImpressao);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmImprimirExtrato";
            this.Text = "Imprimir Extrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancImpressao;
        private System.Windows.Forms.Button btnSalvarExtrato;
        private System.Windows.Forms.Label lblMsgExtrato;
    }
}