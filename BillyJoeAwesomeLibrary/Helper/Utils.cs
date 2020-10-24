using System;

namespace BillyJoeAwesomeLibrary.Helper
{
    static class Utils
    {
        /*public int ValidacaoAnoAlbum(string anoString)
        {
            bool isAnoValido = Utils.IsStringInteiroPositivo(anoString);
            while (!isAnoValido)
            {
                Console.Write("\nAno invalido.\nDigite um ano de lancamento valido para o album: ", anoString);
                anoString = Console.ReadLine();
                isAnoValido = Utils.IsStringInteiroPositivo(anoString);
            }
            return Int32.Parse(anoString);
        }*/

        public static bool IsStringInteiroMaiorQueZero(string stringTeste)
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
