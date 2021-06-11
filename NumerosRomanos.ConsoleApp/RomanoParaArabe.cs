using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class RomanoParaArabe
    {
        public int NumeroArabico { get; private set; }
        public string NumeroRomano { get; set; }

        private Dictionary<string, int> valoresConvertidos = new Dictionary<string, int>()
        {
            { "m", 10000 }, { "c", 5000 },
            { "u", 1000 },  { "M", 1000 },
            { "D", 500 },   { "C", 100 },
            { "L", 50 },    { "X", 10 },
            { "V", 5 },     { "I", 1 }
        };

        private List<string> valoresQuePodemDiminuir = new List<string>()
        {
            "u", "m", "c", "I", "X", "C"
        };

        public int NumerosRomanosParaArabicos(string numeroRomano)
        {
            NumeroRomano = numeroRomano;
            NumeroArabico = Converter(numeroRomano);
            return NumeroArabico;
        }
        private int Converter(string numeroRomano)
        {
            numeroRomano = replaceNumerosBugados(numeroRomano);

            char[] valoresParaConversao = numeroRomano.ToCharArray();
            int saida = 0;

            for (int i = 0; i < valoresParaConversao.Length; i++)
            {
                string valor = valoresParaConversao[i].ToString();
                int valorASerAdicionado = 0;

                if (PodeAvancarMaisUmaPosicao(valoresParaConversao, i))
                {
                    string proximoValor = valoresParaConversao[i + 1].ToString();

                    if (valoresQuePodemDiminuir.Contains(valor) && ProximoValorEhMaiorQueOAtual(valor, proximoValor))
                    {
                        valorASerAdicionado = valoresConvertidos[proximoValor] - valoresConvertidos[valor];
                        i++;
                    }
                }
                if (valorASerAdicionado == 0)
                {
                    valorASerAdicionado = valoresConvertidos[valor];
                }

                saida += valorASerAdicionado;
            }

            return saida;
        }

        private static string replaceNumerosBugados(string str)
        {
            str = str.ToUpper();

            str = str.Replace("Ī", "u");
            str = str.Replace("V̄", "c");
            str = str.Replace("X̄", "m");

            return str;
        }

        private bool ProximoValorEhMaiorQueOAtual(string valor, string proximoValor)
        {
            return valoresConvertidos[proximoValor] > valoresConvertidos[valor];
        }

        private static bool PodeAvancarMaisUmaPosicao(char[] valoresParaConversao, int i)
        {
            return i + 1 < valoresParaConversao.Length;
        }
    }
}
  

