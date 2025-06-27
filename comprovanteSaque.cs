using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace sistemaCaixaEletronico
{
    public partial class frmComprovanteSaque : Form
    {
        private Label lblMsgComprovante;
        private Button btnGerarComprovante;
        private Button btnCancComp;
        private string _detalhesSaque; // Variável para armazenar os detalhes do saque

        // Construtor que aceita os detalhes do saque
        public frmComprovanteSaque(string mensagemComprovante, string detalhesSaque)
        {
            InitializeComponent();
            lblMsgComprovante.MaximumSize = new Size(this.ClientSize.Width - 40, 0);
            lblMsgComprovante.Text = mensagemComprovante;
            _detalhesSaque = detalhesSaque; // Armazena os detalhes para o arquivo
        }

        private void InitializeComponent()
        {
            this.lblMsgComprovante = new System.Windows.Forms.Label();
            this.btnGerarComprovante = new System.Windows.Forms.Button();
            this.btnCancComp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMsgComprovante
            // 
            this.lblMsgComprovante.AutoSize = true;
            this.lblMsgComprovante.Location = new System.Drawing.Point(20, 20);
            this.lblMsgComprovante.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblMsgComprovante.Name = "lblMsgComprovante";
            this.lblMsgComprovante.Size = new System.Drawing.Size(162, 20);
            this.lblMsgComprovante.TabIndex = 0;
            this.lblMsgComprovante.Text = "Carregando Mensagem...";
            
            // 
            // btnGerarComprovante
            // 
            this.btnGerarComprovante.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGerarComprovante.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnGerarComprovante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerarComprovante.Location = new System.Drawing.Point(208, 235);
            this.btnGerarComprovante.Name = "btnGerarComprovante";
            this.btnGerarComprovante.Size = new System.Drawing.Size(138, 33);
            this.btnGerarComprovante.TabIndex = 1;
            this.btnGerarComprovante.Text = "Gerar Comprovante";
            this.btnGerarComprovante.UseVisualStyleBackColor = false;
            this.btnGerarComprovante.Click += new System.EventHandler(this.btnGerarComprovante_Click_1);
            // 
            // btnCancComp
            // 
            this.btnCancComp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancComp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancComp.Location = new System.Drawing.Point(125, 235);
            this.btnCancComp.Name = "btnCancComp";
            this.btnCancComp.Size = new System.Drawing.Size(75, 33);
            this.btnCancComp.TabIndex = 2;
            this.btnCancComp.Text = "Cancelar";
            this.btnCancComp.UseVisualStyleBackColor = false;
            this.btnCancComp.Click += new System.EventHandler(this.btnCancComp_Click);
            // 
            // frmComprovanteSaque
            // 
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.btnCancComp);
            this.Controls.Add(this.btnGerarComprovante);
            this.Controls.Add(this.lblMsgComprovante);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Name = "frmComprovanteSaque";
            this.Text = "Comprovante de Saque";
            this.Load += new System.EventHandler(this.frmComprovanteSaque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmComprovanteSaque_Load(object sender, EventArgs e)
        {
            AjustarPosicaoBotoes();
        }

        private void btnGerarComprovante_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
                saveFileDialog.FileName = $"ComprovanteSaque_{DateTime.Now:yyyyMMdd_HHmmss}.txt"; // Nome sugerido para o arquivo

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Escreve o conteúdo na pasta/arquivo escolhido pelo usuário
                        File.WriteAllText(saveFileDialog.FileName, _detalhesSaque);
                        MessageBox.Show("Comprovante gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao gerar o comprovante: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancComp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Novo método para ajustar a posição dos botões dinamicamente
        private void AjustarPosicaoBotoes()
        {
            // Define a margem inferior para os botões.
            // Você pode ajustar este valor conforme a necessidade.
            int marginBottom = 20;

            // Calcula a posição Y para ambos os botões (altura do formulário
            // - altura do botão - margem inferior)
            int yPos = this.ClientSize.Height - btnGerarComprovante.Height - marginBottom;

            // Posição para o botão "Gerar Comprovante" (à direita)
            // Deixe uma margem à direita do formulário (ex: 20 pixels)
            int marginFromRight = 20;
            int btnGerarComprovanteX = this.ClientSize.Width - btnGerarComprovante.Width - marginFromRight;

            // Posição para o botão "Cancelar" (à esquerda do "Gerar Comprovante")
            // Deixe um espaçamento entre os botões (ex: 10 pixels)
            int spacingBetweenButtons = 10;
            int btnCancCompX = btnGerarComprovanteX - btnCancComp.Width - spacingBetweenButtons;

            // Aplica as novas posições
            btnGerarComprovante.Location = new Point(btnGerarComprovanteX, yPos);
            btnCancComp.Location = new Point(btnCancCompX, yPos);
        }
    }
}
