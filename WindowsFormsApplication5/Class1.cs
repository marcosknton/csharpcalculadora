using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
   public class Calculo
    {
        public int a { get; set; }
        public int b { get; set; }

        public Calculo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int sumar()
        {
            return a + b;
        }

        public int restar()
        {
           
            return  a - b;
           
        }
        public int  dividir()
        {
           
            return  a / b;
        }

        public int  multiplicar()
        {
            
            return a * b;
            
        }

    }
}
