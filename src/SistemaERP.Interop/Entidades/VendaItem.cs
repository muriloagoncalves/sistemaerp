using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Interop.Entidades
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class VendaItem
    {
        public int IdVendaItem { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string EAN { get; set; }
        public double ValorUnitario { get; set; }
        public double Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public double DescontoItem { get; set; }
        public double AcrescimoItem { get; set; }

    }
}
