using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP
{
    public class Carro : Veiculo
    {
        public override void LigarMotor()
        {
            Console.WriteLine("Ligar motor filho");
            base.LigarMotor();
        }
    }
}
