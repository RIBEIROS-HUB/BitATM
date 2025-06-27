using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sistemaCaixaEletronico
{
    public partial class frmComprovanteDeposito : Form
    {
        private string _detalhesSaque; // Variável para armazenar os detalhes do saque
        // Construtor que aceita os detalhes do saque
        public frmComprovanteDeposito(string mensagemComprovante, string detalhesSaque)
        {
            InitializeComponent();
            lblMsgComprovante.MaximumSize = new Size(this.ClientSize.Width - 40, 0);
            lblMsgComprovante.Text = mensagemComprovante;
            _detalhesSaque = detalhesSaque; // Armazena os detalhes para o arquivo
            AjustarPosicaoBotoes();
        }

        private void btnGerarComprovanteDep_Click(object sender, EventArgs e)
        {
            // Abre uma caixa de diálogo para o usuário escolher onde salvar o arquivo
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
                // Nome sugerido para o arquivo caso usuario nao renomeie
                saveFileDialog.FileName = $"ComprovanteDeposito_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

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

        private void btnCancelarDep_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário do comprovante
        }

        // Método para ajustar a posição dos botões
        private void AjustarPosicaoBotoes()
        {
            // Define a margem inferior para os botões.
            int marginBottom = 20;

            // Calcula a posição Y para ambos os botões (altura do formulário - altura do botão - margem inferior)
            int yPos = this.ClientSize.Height - btnGerarComprovanteDep.Height - marginBottom;

            // Posição para o botão "Gerar Comprovante" (à direita)
            // Deixe uma margem à direita do formulário (ex: 20 pixels)
            int marginFromRight = 20;
            int btnGerarComprovanteX = this.ClientSize.Width - btnGerarComprovanteDep.Width - marginFromRight;

            // Posição para o botão "Cancelar" (à esquerda do "Gerar Comprovante")
            // Deixe um espaçamento entre os botões (ex: 10 pixels)
            int spacingBetweenButtons = 10;
            int btnCancelarX = btnGerarComprovanteX - btnCancelarDep.Width - spacingBetweenButtons;

            // Aplica as novas posições
            btnGerarComprovanteDep.Location = new Point(btnGerarComprovanteX, yPos);
            btnCancelarDep.Location = new Point(btnCancelarX, yPos);
        }
    }
}