using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitATM
{
    internal class Senha
    {
        public string Valor { get; set; }

        public Senha(string valor)
        {
            Valor = valor;
        }

        public bool Validar(string tentativa)
        {
            return Valor == tentativa;
        }
    }
}

