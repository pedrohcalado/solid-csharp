using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Contracts
{
    class CustomerRepository : ICustumerRepository
    {
        public void Save(string name)
        {
            Console.WriteLine($"{name} tá salvo meu consagrado");
        }
    }
}
