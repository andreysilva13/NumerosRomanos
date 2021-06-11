using System.Collections.Generic;
using System.Text;

namespace NumerosRomanos.ConsoleApp
{
    public class ArabeParaRomano
    {
        public int NumeroArabico { get; private set; }
        public string NumeroRomano { get; set; }

        private Dictionary<int, string> valoresConvertidos = new Dictionary<int, string>()
        {
            { 10000, "X̄" }, { 9000, "ĪX̄" },
            { 8000, "V̄ĪĪĪ" },   { 7000, "V̄ĪĪ" },
            { 6000, "V̄Ī" }, { 5000, "V̄" },
            { 4000, "ĪV̄" }, { 1000, "M" },
            { 900, "CM" },  { 500, "D" },
            { 400, "CD"},   { 100, "C"},
            { 90, "XC" },   { 50, "L" },
            { 40, "XL" },   { 10, "X"},
            { 9, "IX"},     { 5, "V"},
            { 4, "IV"},     { 1, "I"},
        };

        private Dictionary<int, string> valoresMacron = new Dictionary<int, string>()
        {
            { 1000, "Ī" }
        };

        public string NumerosArabicosParaRomanos(int valorArabico)
        {
            NumeroArabico = valorArabico;
            NumeroRomano = Conversor(NumeroArabico);

            return NumeroRomano;
        }

        private string Conversor(int valorArabico)
        {
            string saida = "";
            int valorParaConversao = valorArabico;

            foreach (int valor in valoresConvertidos.Keys)
            {
                while (valorParaConversao >= valor)
                {   
                    saida += (valoresConvertidos[valor]);
                    valorParaConversao -= valor;
                }
            }
            return saida;
        }
    }
}



