using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitATM
{
    public partial class BitATM : Form
    {
        public BitATM()
        {
            InitializeComponent();
        }

        private void txtAgencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BitATMimg_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            List<(Agencia agencia, Conta conta, Senha senha)> usuarios = new List<(Agencia, Conta, Senha)>
    {
        (new Agencia("001-2"), new Conta("12345-7"), new Senha("54433221")),
        (new Agencia("033-1"), new Conta("23456-8"), new Senha("4321")),
        //(new Agencia("104-4"), new Conta("34567-9"), new Senha("5678")),
        //(new Agencia("237-0"), new Conta("45678-0"), new Senha("8765")),
        //(new Agencia("341-7"), new Conta("56789-1"), new Senha("2580")),
        //(new Agencia("745-3"), new Conta("67890-2"), new Senha("7890")),
        //(new Agencia("260-2"), new Conta("78901-3"), new Senha("1357")),
        //(new Agencia("077-9"), new Conta("89012-4"), new Senha("2468")),
        //(new Agencia("380-6"), new Conta("90123-5"), new Senha("0000")),
        //(new Agencia("399-8"), new Conta("01234-6"), new Senha("senha1")),
    };


            string agenciaInput = txtAgencia.Text.Trim();
            string contaInput = txtConta.Text.Trim();
            string senhaInput = txtSenha.Text.Trim();

            // Nome do usuário fictício (você pode evoluir para um dicionário depois)
            string nomeUsuario = "Felipe"; // isso pode vir de um objeto Conta, no futuro

            bool acessoAutorizado = usuarios.Any(u =>
                u.agencia.Numero == agenciaInput &&
                u.conta.Numero == contaInput &&
                u.senha.Validar(senhaInput));

            if (acessoAutorizado)
            {
                this.Hide();
                sistemaCaixaEletronico.sistemaCaixaEletronico caixaForm = new sistemaCaixaEletronico.sistemaCaixaEletronico(nomeUsuario);
                caixaForm.FormClosed += (s, args) => this.Close();
                caixaForm.Show();
            }
            else
            {
                MessageBox.Show("Agência, conta ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         
   


        }
    }
}

