﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace papeSraErika
{
    public partial class editProduct : Form
    {
        public string barcode;
        public string name;
        public string brand1;
        public string desc;
        public string price;
        public string stock;

        public editProduct(string barCode, string Name, string Brand, string Desc, string Price, string Stock)
        {
            InitializeComponent();
            barcode = barCode;
            name = Name;
            brand1 = Brand;
            desc = Desc;
            price = Price;
            stock = Stock;

            loadData();
        }

        public void loadData()
        {
            MessageBox.Show(barcode);
            textName.Text = name;
            textBrand.Text = brand1;
            textDesc.Text = desc;
            textPrice.Text = price;
            textStock.Text = stock;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(barcode);
            string saveName = textName.Text;
            string saveBrand = textBrand.Text;
            string saveDesc = textDesc.Text;
            string savePrice = textPrice.Text;
            string saveStock = textStock.Text;

            string sql = "UPDATE productos set NOMBRE = '" + saveName + "',MARCA = '" + saveBrand + "',DESCRIPCION = '" + saveDesc + "',STOCK = '" + saveStock + "'" +
                ",PRECIO = '" + savePrice + "' where CODIGO_BARRAS = '" + barcode + "';";

            systemQuerys.principalQuery(sql);

            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}