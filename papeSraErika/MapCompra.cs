using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papeSraErika
{
    class MapCompra
    {
        private int id_venta;
        private string vendedor;
        private DateTime fecha_venta;
        private string total;

        
        public string Vendedor { get => vendedor; set => vendedor = value; }
        public DateTime Fecha_venta { get => fecha_venta; set => fecha_venta = value; }
        public string Total { get => total; set => total = value; }
        public int Id_venta { get => id_venta; set => id_venta = value; }
    }
}
