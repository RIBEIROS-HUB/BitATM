using System;
using System.Windows.Forms;

namespace sistemaCaixaEletronico
{
    partial class frmComprovanteDeposito : Form
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
        /// 

        private void InitializeComponent()
        {
            this.lblMsgComprovante = new System.Windows.Forms.Label();
            this.btnGerarComprovanteDep = new System.Windows.Forms.Button();
            this.btnCancelarDep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMsgComprovante
            // 
            this.lblMsgComprovante.AutoSize = true;
            this.lblMsgComprovante.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblMsgComprovante.Location = new System.Drawing.Point(20, 20);
            this.lblMsgComprovante.Name = "lblMsgComprovante";
            this.lblMsgComprovante.Size = new System.Drawing.Size(162, 20);
            this.lblMsgComprovante.TabIndex = 0;
            this.lblMsgComprovante.Text = "Carregando Mensagem...";
            // 
            // btnGerarComprovanteDep
            // 
            this.btnGerarComprovanteDep.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGerarComprovanteDep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnGerarComprovanteDep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerarComprovanteDep.Location = new System.Drawing.Point(206, 233);
            this.btnGerarComprovanteDep.Name = "btnGerarComprovanteDep";
            this.btnGerarComprovanteDep.Size = new System.Drawing.Size(140, 34);
            this.btnGerarComprovanteDep.TabIndex = 1;
            this.btnGerarComprovanteDep.Text = "Gerar Comprovante";
            this.btnGerarComprovanteDep.UseVisualStyleBackColor = false;
            this.btnGerarComprovanteDep.Click += new System.EventHandler(this.btnGerarComprovanteDep_Click);
            // 
            // btnCancelarDep
            // 
            this.btnCancelarDep.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelarDep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelarDep.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarDep.Location = new System.Drawing.Point(119, 233);
            this.btnCancelarDep.Name = "btnCancelarDep";
            this.btnCancelarDep.Size = new System.Drawing.Size(80, 34);
            this.btnCancelarDep.TabIndex = 2;
            this.btnCancelarDep.Text = "Cancelar";
            this.btnCancelarDep.UseVisualStyleBackColor = false;
            this.btnCancelarDep.Click += new System.EventHandler(this.btnCancelarDep_Click);
            // 
            // frmComprovanteDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.btnCancelarDep);
            this.Controls.Add(this.btnGerarComprovanteDep);
            this.Controls.Add(this.lblMsgComprovante);
            this.Name = "frmComprovanteDeposito";
            this.Text = "Comprovante de Deposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsgComprovante;
        private System.Windows.Forms.Button btnGerarComprovanteDep;
        private System.Windows.Forms.Button btnCancelarDep;
    }
}