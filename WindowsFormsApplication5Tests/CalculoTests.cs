using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5.Tests
{
    [TestClass()]
    public class CalculoTests
    {
        Calculo calculo = new Calculo(5,8);

       
        [TestMethod()]
        public void aMayorB()
        {
            Assert.IsTrue(calculo.getA() > calculo.getB(), "la primera variable no pueder ser menor que la segunda");
           
        }

        [TestMethod()]
        public void aMayor0()
        {
            Assert.IsTrue(calculo.getA() > 0,"la primera variable no puede ser negativa");
           
        }

        [TestMethod()]
        public void bMayor0()
        {
            Assert.IsTrue(calculo.getB() > 0, "la segunda variable no puede ser negativa");

        }


        
    }
}