using Solid.ISP.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP
{
    class NotaFiscal : IPedido, IEndereco
    {
        public DateTime Data { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public void RealizarPedido()
        {
            
        }
    }
}
