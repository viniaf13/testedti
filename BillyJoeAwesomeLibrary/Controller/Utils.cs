using System;

namespace BillyJoeAwesomeLibrary.Controller
{
    static class Utils
    {
        public static bool IsStringInteiroPositivo(string stringTeste)
        {
            bool validacao = false;
            try
            {
                int numero = Int32.Parse(stringTeste);
                if (numero >= 0)
                {
                    validacao = true;
                }
            }
            catch
            {
            }

            return validacao;
        }








    }
}
