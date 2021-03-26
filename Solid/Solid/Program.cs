using Solid.SRP;
using Solid.SRP.Repository;
using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor forn = new Fornecedor();
            forn.ChangeName("Pedro");
            IFornecedorRepository rep = new FornecedorRepository();
            rep.Salvar(forn);
        }
    }
}
