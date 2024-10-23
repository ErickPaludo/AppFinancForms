using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosForms.MVC.Models
{
    public class Util
    {
        public static int Converter(string valor)
        {
            int retorno = 0;
            switch (valor)
            {
                case "Débito":
                    retorno = 1;
                    break;
                case "Crédito":
                    retorno = 2;
                    break;
                case "Alimentação":
                    retorno = 3;
                    break;
            }
                
            return retorno;
        }
        public static string Desconverter(int valor)
        {
            string retorno = string.Empty;
            switch (valor)
            {
                case 1:
                    retorno = "Débito";
                    break;
                case 2:
                    retorno = "Crédito";
                    break;
                case 3:
                    retorno = "Alimentação";
                    break;
            }
            return retorno;
        }
    }
}
