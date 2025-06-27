using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCaixaEletronico
{
    public partial class sistemaCaixaEletronico : Form
    {
        private const string V = "Felipe";
        private decimal vlrCaixa = 5000.00m;
        private int contNtsCem = 21;
        private int contNtsCinq = 26;
        private int contNtsVinte = 62;
        private int contNtsDez = 36;

        private decimal sldAtual = 5000.00m; // Saldo inicial do extrato
        private List<string> historicoTransacoes = new List<string>();

        private void AtualizarDisplayCaixa()
        {
            lblVlrCaixa.Text = vlrCaixa.ToString("F2");
            lblContNtsCem.Text = contNtsCem.ToString();
            lblContNtsCinquenta.Text = contNtsCinq.ToString();
            lblContNtsVinte.Text = contNtsVinte.ToString();
            lblContNtsDez.Text = contNtsDez.ToString();
        }

        private void AtualizarExtratoDisplay()
        {
            rtbExtrato.Clear();

            // Formata o saldo atual
            rtbExtrato.SelectionAlignment = HorizontalAlignment.Right;
            rtbExtrato.AppendText("Saldo Atual:\n");
            rtbExtrato.SelectionFont = new Font(rtbExtrato.Font, FontStyle.Bold);
            rtbExtrato.AppendText($"R$ {sldAtual:F2}\n");

            // Histórico de transações
            rtbExtrato.SelectionAlignment = HorizontalAlignment.Left;
            rtbExtrato.SelectionFont = new Font(rtbExtrato.Font, FontStyle.Regular);
            rtbExtrato.AppendText("Últimas Transações:\n");

            int startIndex = Math.Max(0, historicoTransacoes.Count - 7);
            for (int i = startIndex; i < historicoTransacoes.Count; i++)
            {
                rtbExtrato.AppendText(historicoTransacoes[i] + "\n");
            }
        }

        public sistemaCaixaEletronico(string nomeUsuario)
        {
            InitializeComponent();
            tabControl.SelectedTab = tabPagIni;
            lblSaudacao.Text = $"Olá, {V}"; // precisa alterar para o programa entender quem esta
            //logado no sistema e puxar o usuario correto sem estar fixo.
            AtualizarDisplayCaixa();
            historicoTransacoes.Add($"{DateTime.Now:dd/MM/yyyy HH:mm} - Saldo Inicial: R$ {sldAtual:F2}");
        }
        private void grpBxExtrato_Enter(object sender, EventArgs e)
        {
            AtualizarExtratoDisplay();
        }
        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPagIni;
        }

        private void novoSaqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPagSaque;
            txtVlrSacado.Focus();
        }

        private void novoDepósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPagDep;
            txtVlrDepositado.Focus();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Configurado de momento para fechar o programa mas
            //terá de ser configurado para chamar a tela de login
            Application.Exit();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
        }


        private void btnSacar_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPagSaque;
            txtVlrSacado.Focus();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPagDep;
            txtVlrDepositado.Focus();
        }

        private void btnCancSaque_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPagIni;
        }

        private void btnCancDep_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPagIni;
        }

        private void btnConfSaque_Click(object sender, EventArgs e)
        {
            string txtVlrSaque = txtVlrSacado.Text;
            string txtVlrSldSq = lblSldSaque.Text;
            string txtVlrSaldo = lblVlrSaldo.Text;
            string txtVlrSldDeposito = lblSldDeposito.Text;

            decimal convVlrSaque;
            decimal convVlrSldSq;
            decimal convVlrSaldo;
            decimal convVlrSldDeposito;
                                   
            if (!decimal.TryParse(txtVlrSaque, out convVlrSaque) ||
                !decimal.TryParse(txtVlrSldSq, out convVlrSldSq) ||
                !decimal.TryParse(txtVlrSaldo, out convVlrSaldo) ||
                !decimal.TryParse(txtVlrSldDeposito, out convVlrSldDeposito))
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para o saque.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVlrSacado.Focus();
                return;
            }
            // 2. Validações do valor do saque
            if (convVlrSaque <= 0)
            {
                MessageBox.Show("O valor do saque deve ser positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVlrSacado.Focus();
                return;
            }

            if (convVlrSaque % 10 != 0) // Valida se o saque é múltiplo de 10 (mínima nota disponível)
            {
                MessageBox.Show("O caixa só pode dispensar valores múltiplos de R$10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVlrSacado.Focus();
                return;
            }

            if (convVlrSaque > convVlrSaldo && convVlrSaque > convVlrSldSq)
            {
                MessageBox.Show("Valor solicitado é maior que o valor disponível no caixa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVlrSacado.Focus();
                return;
            }

            int tempNotasCem = contNtsCem;
            int tempNotasCinq = contNtsCinq;
            int tempNotasVinte = contNtsVinte;
            int tempNotasDez = contNtsDez;
            decimal valorRestante = convVlrSaque;

            // Tenta distribuir as notas, priorizando as maiores
            int sacarCem = (int)(valorRestante / 100);
            if (sacarCem > tempNotasCem)
            {
                sacarCem = tempNotasCem;
            }
            tempNotasCem -= sacarCem;
            valorRestante -= sacarCem * 100;

            int sacarCinq = (int)(valorRestante / 50);
            if (sacarCinq > tempNotasCinq)
            {
                sacarCinq = tempNotasCinq;
            }
            tempNotasCinq -= sacarCinq;
            valorRestante -= sacarCinq * 50;

            int sacarVinte = (int)(valorRestante / 20);
            if (sacarVinte > tempNotasVinte)
            {
                sacarVinte = tempNotasVinte;
            }
            tempNotasVinte -= sacarVinte;
            valorRestante -= sacarVinte * 20;

            int sacarDez = (int)(valorRestante / 10);
            if (sacarDez > tempNotasDez)
            {
                sacarDez = tempNotasDez;
            }
            tempNotasDez -= sacarDez;
            valorRestante -= sacarDez * 10;

            // Verifica se foi possível dispensar o valor exato
            if (valorRestante > 0)
            {
                MessageBox.Show("Saldo insuficiente ou valor inválido.");
                return;
            }

            contNtsCem -= sacarCem;
            contNtsCinq -= sacarCinq;
            contNtsVinte -= sacarVinte;
            contNtsDez -= sacarDez;

            vlrCaixa -= convVlrSaque; // Atualiza valor das Notas disponiveis da tela inicial
            convVlrSldSq -= convVlrSaque; // Atualiza o saldo da tela de saque
            convVlrSaldo -= convVlrSaque; // Atualiza o saldo do caixa da tela inicial
            convVlrSldDeposito -= convVlrSaque; // Atualiza o saldo da tela de deposito
            lblSldSaque.Text = convVlrSldSq.ToString("F2");
            lblVlrSaldo.Text = convVlrSaldo.ToString("F2");
            lblSldDeposito.Text = convVlrSldDeposito.ToString("F2");
            
            AtualizarDisplayCaixa();

            // --- Parte nova: Preparar e mostrar o comprovante ---
            string mensagemParaUsuario = $"Saque de R$ {convVlrSaque:F2} " +
                $"realizado com sucesso!" +
                $"\nNovo saldo: R$ {convVlrSldSq:F2}";

            sldAtual -= convVlrSaque;
            historicoTransacoes.Add($"{DateTime.Now:dd/MM/yyyy HH:mm} - Saque: R$ {convVlrSaque:F2}");
            AtualizarExtratoDisplay();

            // Detalhes completos para o comprovante em TXT
            string detalhesSaque =
                "--- Comprovante de Saque ---\n\n" +
                $"Data/Hora: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n\n" +
                $"Valor Sacado: R$ {convVlrSaque:F2}\n\n" +
                $"Novo Saldo: R$ {convVlrSldSq:F2}\n\n" +
                "---------------------------";

            // Cria uma instância do seu novo formulário de comprovante
            frmComprovanteSaque comprovanteForm = new frmComprovanteSaque(mensagemParaUsuario, detalhesSaque);
            comprovanteForm.ShowDialog(); // Mostra o formulário como uma caixa de diálogo
            txtVlrSacado.Text = string.Empty;
        }

        private void btnConfDep_Click(object sender, EventArgs e)
        {
            string txtVlrDeposito = txtVlrDepositado.Text;
            string txtVlrSldDep = lblSldDeposito.Text;
            string txtVlrSaldo = lblVlrSaldo.Text;
            string txtVlrSldSq = lblSldSaque.Text;

            decimal convVlrDeposito;
            decimal convVlrSldDep;
            decimal convVlrSaldo;
            decimal convVlrSldSq;

            if (!decimal.TryParse(txtVlrDeposito, out convVlrDeposito) ||
                !decimal.TryParse(txtVlrSldDep, out convVlrSldDep) || 
                !decimal.TryParse(txtVlrSaldo, out convVlrSaldo) || 
                !decimal.TryParse(txtVlrSldSq, out convVlrSldSq))
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para o depósito.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVlrDepositado.Focus();
                return;
            }
            // 2. Validações do valor do saque
            if (convVlrDeposito <= 0)
            {
                MessageBox.Show("O valor do deposito deve ser de R$10,00 para cima.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVlrDepositado.Focus();
                return;
            }

            if (convVlrDeposito % 10 != 0) // Valida se o deposito é múltiplo de 10 (mínima nota pro deposito)
            {
                MessageBox.Show("O caixa só pode receber valores múltiplos de R$10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVlrDepositado.Focus();
                return;
            }

            int depositarCem = (int)(convVlrDeposito / 100);
            decimal resto = convVlrDeposito % 100;

            int depositarCinq = (int)(resto / 50);
            resto = resto % 50;

            int depositarVinte = (int)(resto / 20);
            resto = resto % 20;

            int depositarDez = (int)(resto / 10);
            resto = resto % 10;

            // Verifica se foi possível dispensar o valor exato
            if (resto > 0)
            {
                MessageBox.Show("O valor do depósito deve ser composto por notas de 100, 50, 20 ou 10 reais.");
                return;
            }

            contNtsCem += depositarCem;
            contNtsCinq += depositarCinq;
            contNtsVinte += depositarVinte;
            contNtsDez += depositarDez;

            vlrCaixa += convVlrDeposito; // Atualiza valor das Notas disponiveis da tela inicial
            convVlrSldDep += convVlrDeposito; // Atualiza o saldo da tela de Deposito
            convVlrSldSq += convVlrDeposito;  //Atualiza o saldo da tela de saque
            convVlrSaldo += convVlrDeposito; // Atualiza o saldo do caixa da tela inicial
            lblSldSaque.Text = convVlrSldDep.ToString("F2");
            lblVlrSaldo.Text = convVlrSaldo.ToString("F2");
            lblSldDeposito.Text = convVlrSaldo.ToString("F2");
            
            AtualizarDisplayCaixa();

            // --- Parte nova: Preparar e mostrar o comprovante ---
            string mensagemParaUsuario = $"Depósito de R$ {convVlrDeposito:F2} " +
                $"realizado com sucesso!" +
                $"\nNovo saldo: R$ {convVlrSldDep:F2}";

            sldAtual += convVlrDeposito;
            historicoTransacoes.Add($"{DateTime.Now:dd/MM/yyyy HH:mm} - Depósito: R$ {convVlrDeposito:F2}");
            AtualizarExtratoDisplay();

            // Detalhes completos para o comprovante em TXT
            string detalhesDeposito =
                "--- Comprovante de Depósito ---\n\n" +
                $"Data/Hora: {DateTime.Now:dd/MM/yyyy HH:mm}\n\n" +
                $"Valor Depositado: R$ {convVlrDeposito:F2}\n\n" +
                $"Novo Saldo: R$ {convVlrSldDep:F2}\n\n" +
                "---------------------------";

            // Cria uma instância do seu novo formulário de comprovante
            frmComprovanteDeposito comprovanteForm = new frmComprovanteDeposito(mensagemParaUsuario, detalhesDeposito);
            comprovanteForm.ShowDialog(); // Mostra o formulário como uma caixa de diálogo
            txtVlrDepositado.Text = string.Empty;
        }

        private void btnImprimeExtrato_Click(object sender, EventArgs e)
        {
            // Obtém o conteúdo completo do RichTextBox
            string conteudoExtrato = rtbExtrato.Text;

            // Cria o cabeçalho padrão para o arquivo
            string cabecalho = "=== EXTRATO BANCÁRIO ===\n" +
                             $"Data: {DateTime.Now:dd/MM/yyyy HH:mm}\n" +
                             $"Cliente: Felipe\n\n";

            // Monta o conteúdo completo do arquivo
            string conteudoCompleto = cabecalho + conteudoExtrato;

            // Cria e exibe o formulário de impressão
            frmImprimirExtrato imprimirForm = new frmImprimirExtrato(conteudoCompleto);
            imprimirForm.ShowDialog();           
        }
    }
}