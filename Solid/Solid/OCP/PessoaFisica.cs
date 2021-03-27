using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string name, string cpf)
            :base(name)
        {
            CPF = cpf;
        }
        public string CPF { get; private set; }

    }
}
