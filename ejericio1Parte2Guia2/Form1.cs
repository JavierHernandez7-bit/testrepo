using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejericio1Parte2Guia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double salarioGer, salarioSub, salarioSec, montoGer=20, montoSub=15, montoSec=5;
            if (radBGerente.Checked == true) 
            {
                salarioGer = (100) / (20);
                //montoGer = 20 %;
                tbDescuento.Text = montoGer.ToString();
                tbSneto.Text = salarioGer.ToString();
            }
            else if (radBSubgerente.Checked == true)
            {
                salarioSub = (100) / (15);
                tbDescuento.Text = montoSub.ToString();
                tbSneto.Text = salarioGer.ToString();
            }
            else if (radBSecretaria.Checked == true)
            {
                salarioSec = (100) / (5);
                tbDescuento.Text = montoSec.ToString();
                tbSneto.Text = salarioGer.ToString();
            }
        }

        private void radBGerente_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radBSubgerente_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radBSecretaria_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
