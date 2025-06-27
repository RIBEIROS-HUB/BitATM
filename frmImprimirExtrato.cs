using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace sistemaCaixaEletronico
{
    public partial class frmImprimirExtrato : Form
    {
        private string _conteudoExtrato;

        public frmImprimirExtrato(string conteudoExtrato)
        {
            InitializeComponent();
            _conteudoExtrato = conteudoExtrato;
            lblMsgExtrato.Text = "Pronto para salvar o extrato";
            lblMsgExtrato.MaximumSize = new Size(this.ClientSize.Width - 40, 0);
            AjustarPosicaoBotoes();
        }

        private void btnSalvarExtrato_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
                saveFileDialog.FileName = $"Extrato_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, _conteudoExtrato);
                        MessageBox.Show("Extrato salvo com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar extrato: {ex.Message}",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancImpressao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjustarPosicaoBotoes()
        {
            int marginBottom = 20;
            int yPos = this.ClientSize.Height - btnSalvarExtrato.Height - marginBottom;
            int marginFromRight = 20;
            int btnGerarComprovanteX = this.ClientSize.Width - btnSalvarExtrato.Width - marginFromRight;
            int spacingBetweenButtons = 10;
            int btnCancelarX = btnGerarComprovanteX - btnCancImpressao.Width - spacingBetweenButtons;

            btnSalvarExtrato.Location = new Point(btnGerarComprovanteX, yPos);
            btnCancImpressao.Location = new Point(btnCancelarX, yPos);
        }
    }
}