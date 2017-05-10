using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
   public class Calculo
    {
        private int a;
        private int b;


       /*
        public int A
        {
            get { return a;}
            set { a = value; }
        }
        
        */

        public int getA()
        {
            return a;
        }

        public int getB()
        {
            return b;
        }
        
        public Calculo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Calculo()
        {

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
