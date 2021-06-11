using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumerosRomanos.ConsoleApp;

namespace NumerosRomanos.Test
{
    [TestClass]
    public class ArabeParaRomanos
    {
        ArabeParaRomano arabeParaRomano = new ArabeParaRomano();

        [TestMethod]
        public void DeveParaRetornarI()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(1);

            Assert.AreEqual("I", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarV()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(5);

            Assert.AreEqual("V", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarIV()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(4);

            Assert.AreEqual("IV", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarX()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(10);

            Assert.AreEqual("X", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarL()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(50);

            Assert.AreEqual("L", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarC()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(100);

            Assert.AreEqual("C", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarD()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(500);

            Assert.AreEqual("D", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarM()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(1000);

            Assert.AreEqual("M", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarĪV̄()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(4000);

            Assert.AreEqual("ĪV̄", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarĪV̄DIII()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(4503);

            Assert.AreEqual("ĪV̄DIII", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarĪX̄DXXXII()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(9532);

            Assert.AreEqual("ĪX̄DXXXII", resultado);
        }

        [TestMethod]
        public void DeveParaRetornarMCDXXXV()
        {
            string resultado = arabeParaRomano.NumerosArabicosParaRomanos(1435);

            Assert.AreEqual("MCDXXXV", resultado);
        }
    }
}
