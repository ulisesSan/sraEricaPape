﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papeSraErika
{
    class MapCompra
    {
        private int id_venta;
        private string fecha_venta;
        private int num_prod;
        private float total;

        public int Id_venta { get => id_venta; set => id_venta = value; }
        public string Fecha_venta { get => fecha_venta; set => fecha_venta = value; }
        public int Num_prod { get => num_prod; set => num_prod = value; }
        public float Total { get => total; set => total = value; }
    }
}
