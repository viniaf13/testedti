using System;

namespace BillyJoeAwesomeLibrary.Helper
{
    static class Utils
    {
        public static int ValidacaoAnoString(string anoString, string errorMsg)
        {
            bool isAnoValido = (Utils.IsStringInteiroMaiorQueZero(anoString) && (anoString.Length == 4));
            while (!isAnoValido)
            {
                Console.Write(errorMsg, anoString);
                anoString = Console.ReadLine();
                isAnoValido = (Utils.IsStringInteiroMaiorQueZero(anoString) && (anoString.Length == 4));
            }
            return Int32.Parse(anoString);
        }

        public static int ValidacaoInteiroMaiorQueZero(string numeroString, string errorMsg)
        {
            bool isNumeroValido = (Utils.IsStringInteiroMaiorQueZero(numeroString));
            while (!isNumeroValido)
            {
                Console.Write(errorMsg, numeroString);
                numeroString = Console.ReadLine();
                isNumeroValido = (Utils.IsStringInteiroMaiorQueZero(numeroString));
            }
            return Int32.Parse(numeroString);
        }

        private static bool IsStringInteiroMaiorQueZero(string stringTeste)
        {
            try
            {
                int numero = Int32.Parse(stringTeste);
                return (numero > 0) ? true : false;
            }
            catch
            {
                return false;
            }
        }
    }
}
