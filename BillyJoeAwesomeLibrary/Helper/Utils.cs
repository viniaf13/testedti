using Newtonsoft.Json;
using System;
using System.IO;

namespace BillyJoeAwesomeLibrary.Helper
{
    static class Utils
    {
        public static string ValidacaoAnoString(string anoString, string errorMsg)
        {
            bool isAnoValido = (IsStringInteiroMaiorQueZero(anoString) && (anoString.Length == 4));
            while (!isAnoValido)
            {
                Console.Write(errorMsg, anoString);
                anoString = Console.ReadLine();
                isAnoValido = (IsStringInteiroMaiorQueZero(anoString) && (anoString.Length == 4));
            }
            return anoString;
        }

        public static string ValidacaoInteiroMaiorQueZero(string numeroString, string errorMsg)
        {
            bool isNumeroValido = (IsStringInteiroMaiorQueZero(numeroString));
            while (!isNumeroValido)
            {
                Console.Write(errorMsg, numeroString);
                numeroString = Console.ReadLine();
                isNumeroValido = (IsStringInteiroMaiorQueZero(numeroString));
            }
            return numeroString;
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

        public static object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public static T ReadFromJsonFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
