using Solid.DIP;
using Solid.DIP.Contracts;
using Solid.ISP;
using Solid.LSP;
using Solid.OCP;
using Solid.SRP;
using Solid.SRP.Repository;
using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            // SRP
            Fornecedor forn = new Fornecedor();
            forn.ChangeName("Pedro");
            IFornecedorRepository rep = new FornecedorRepository();
            rep.Salvar(forn);

            // OCP
            var p = new Pessoa("Pedro");
            p.ChangeName("Luana");

            var pf = new PessoaFisica("Pedro", "123.123.123-12");
            pf.ChangeName("Joseph");

            // LSP
            var veiculo = new Carro();
            veiculo.LigarMotor();

            // ISP
            NotaFiscal nf = new NotaFiscal();
            nf.RealizarPedido();

            // DIP
            var cr = new CustomerRepository();
            var cs = new CustomerService(cr);
            cs.Register("Caladão");
        }
    }
}
