using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.SRP.Services;

namespace Solid.SRP
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void ChangeName (string name)
        {
            this.Name = name;
            // Disparar evento para informar o RH sobre mudança de nome (isso não deve ficar como responsabilidade do fornecedor)
            NotificationService.Notify("rg@gmail.com");
        }
       

    }
}
