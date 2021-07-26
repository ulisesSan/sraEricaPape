﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace papeSraErika
{
    public partial class productView : Form
    {

        public productView()
        {
            InitializeComponent();
            Table(null);
        }



        public void Table(string data)
        {
            List<object> lista = new List<object>();
            productController _products = new productController();
            productTable.DataSource = _products.Products(data);
        }

        private void Buscar(object sender, EventArgs e)
        {
            string dato = textSearch.Text;

            Table(dato);
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string dato = textSearch.Text;
            Table(dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProduct M = new addProduct();
            M.Show();
        }

        public void actualizar()
        {
            Table(null);
        }

        public interface updateTable
        {
            void actualizar();
        }
    }
}
