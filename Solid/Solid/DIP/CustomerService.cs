using Solid.DIP.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP
{
    public class CustomerService
    {
        private readonly ICustumerRepository _repository;
        public CustomerService(ICustumerRepository repository)
        {
            _repository = repository;
        }
        public void Register(string name)
        {
            _repository.Save(name);
        }
    }
}
