using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumerosRomanos.ConsoleApp;

namespace NumerosRomanos.Test
{
    [TestClass]
    public class RomanosParaArabe
    {
        RomanoParaArabe romanosParaArabe = new RomanoParaArabe();

        [TestMethod]
        public void DeveParaRetornar1()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("I");

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar4()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("IV");

            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar5()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("V");

            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar9()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("IX");

            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar10()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("X");

            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar50()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("L");

            Assert.AreEqual(50, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar100()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("C");

            Assert.AreEqual(100, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar500()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("D");

            Assert.AreEqual(500, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar1000()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("M");

            Assert.AreEqual(1000, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar10000()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("X̄");

            Assert.AreEqual(10000, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar4000()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("ĪV̄");

            Assert.AreEqual(4000, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar123()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("CXXIII");

            Assert.AreEqual(123, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar1435()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("MCDXXXV");

            Assert.AreEqual(1435, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar11111()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("X̄ĪCXI");

            Assert.AreEqual(11111, resultado);
        }

        [TestMethod]
        public void DeveParaRetornar4503()
        {
            int resultado = romanosParaArabe.NumerosRomanosParaArabicos("ĪV̄DIII");

            Assert.AreEqual(4503, resultado);
        }
    }
}
