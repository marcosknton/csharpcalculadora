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
            try
            {

                int a=0;
                int b=0;
                multiplicar(a,b);
                sumar(a,b);
                restar(a,b);
                dividir(a,b);
               

            }
            catch (Exception ex)
            {
                //mostrara un mensage si lo introducido
                //es diferente de un numero
                MessageBox.Show("Solo se permiten numeros: " + "\nExcepcion: " + ex.Message);
            }
        }

        public void sumar(int n1,int n2)
        {
            n1 = Int32.Parse(Tboperador1.Text);
            n2 = Int32.Parse(Tboperador2.Text);
            int res = n1 + n2;
            Tbsumar.Text = res.ToString();
            
        }
        public void restar(int n1,int n2)
        {
            n1 = Int32.Parse(Tboperador1.Text);
            n2 = Int32.Parse(Tboperador2.Text);
            int res = n1 - n2;
            Tbresta.Text = res.ToString();
        }
        public void dividir(int n1, int n2)
        {
            n1 = Int32.Parse(Tboperador1.Text);
            n2 = Int32.Parse(Tboperador2.Text);
            int res = n1 / n2;
            Tbdivision.Text = res.ToString();
        }
        public void multiplicar(int n1, int n2)
        {
            n1 = Int32.Parse(Tboperador1.Text);
            n2 = Int32.Parse(Tboperador2.Text);
            int res = n1 * n2;
            Tbmultiplicar.Text = res.ToString();
        }

    }
}
