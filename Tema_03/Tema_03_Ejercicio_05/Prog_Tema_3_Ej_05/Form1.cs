﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAccion_Click(object sender, EventArgs e)
        {
            bool num1esnum = int.TryParse(txtNumero1.Text, out int numero1);
            bool num2esnum = int.TryParse(txtNumero2.Text, out int numero2);
            bool num3esnum = int.TryParse(txtNumero3.Text, out int numero3);

            if (num1esnum && num2esnum && num3esnum)
            {
                if ((numero1 > numero2) && (numero1 > numero2))
                {
                    lblResultado.Text = $"{numero1} es mayor que {numero2} y {numero3}";
                }
            }
            else
            {
                lblResultado.Text = "Introduce números";
            }

        }

    }
}
