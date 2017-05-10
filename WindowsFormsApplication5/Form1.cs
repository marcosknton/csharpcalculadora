using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Bcalcular_Click(object sender, EventArgs e)
        {
            int  a = Int32.Parse(Tboperador1.Text);
            int  b = Int32.Parse(Tboperador2.Text);
            Calculo calculo = new Calculo(a,b);
            Tbsumar.Text = calculo.sumar().ToString();
            Tbresta.Text = calculo.restar().ToString();
            Tbdivision.Text = calculo.dividir().ToString();
            Tbmultiplicar.Text =calculo.multiplicar().ToString();
        }
    }
}
