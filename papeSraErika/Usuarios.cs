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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;
            string res;

            res = systemQuerys.principalQuery("select * from usuario where NOMBRE = '" + user + "' and contraseña = '" + pass + "'");
            
            if(user == "Erika" && pass == "Momi1960")
            {
                Princial m = new Princial();
                m.Show();
                this.Hide();
            }
            else
            {
                if (res == null)
                {
                    MessageBox.Show("Contraseña o usuarios errones");
                }

                else
                {
                    Princial m = new Princial();
                    m.Show();
                }
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNUser_Click(object sender, EventArgs e)
        {
            Contrasena m = new Contrasena(null);
            m.Show();
        }
    }
}