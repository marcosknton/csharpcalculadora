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
        [TestMethod()]
        public void sumarTest()
        {
           Calculo calculo = new Calculo(10, 3);
            Assert.IsFalse(calculo.b < calculo.a,"la segunda variable no puede ser menor que la primera ");
            Assert.IsNotNull(calculo.a, "la variable no puede ser nula");


        }
    }
}