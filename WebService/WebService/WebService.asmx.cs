using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Descrição resumida de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }

        [WebMethod]
        public decimal calculadora(decimal valor1, decimal valor2, char operador)
        {
            if ((valor1.Equals(0) && valor2.Equals(0)) || char.IsWhiteSpace(operador))
            {
                return 0;
            }

            switch (operador)
            {
                case '+':
                    return valor1 + valor2;
                case '-':
                    return valor1 - valor2;
                case '*':
                    return valor1 * valor2;
                case '/':
                    return Math.Round((valor1 / valor2), 7);
                default:
                    return 0;
            }
        }

        [WebMethod]
        public Int64 fatorial(int valor)
        {
            long resultado = 0;

            if (valor <=0 )
            {
                return resultado;
            }

            for (resultado = 1; valor >= 1; valor--)
            {
                resultado *= valor;
            }

            if (resultado <= 0)
            {
                return 0;
            }
            else
            {
                return resultado;
            }
        }

        [WebMethod]
        public string imc(decimal altura, decimal peso)
        {
            decimal imc = 0;
            string situacao = "desconhecida";

            if(altura<=0 || peso <= 0)
            {
                return "Dados inválidos, insira novamente";
            }

            imc = Math.Round( peso / (altura * altura), 2);

            if(imc < 17)
            {
                situacao = "está muito abaixo do peso";
                return $"Seu IMC é {imc}. Você {situacao}";
            }

            else if(imc > 17m && imc < 18.49m)
            {
                situacao = "está abaixo do peso";
                return $"Seu IMC é {imc}. Você {situacao}";
            }

            else if(imc > 18.50m && imc < 24.99m)
            {
                situacao = "está no peso normal para você";
                return $"Seu IMC é {imc}. Você {situacao}";
            }

            else if(imc > 25m && imc < 29.99m)
            {
                situacao = "está acima do peso";
                return $"Seu IMC é {imc}. Você {situacao}";
            }

            else if(imc > 30m && imc < 34.99m)
            {
                situacao = "está com obesidade I";
                return $"Seu IMC é {imc}. Você {situacao}";
            }

            else if(imc > 35m && imc < 39.99m)
            {
                situacao = "está com obesidade II(severa)";
                return $"Seu IMC é {imc}. Você {situacao}";
            }

            else if(imc > 40)
            {
                situacao = "está com obesidade III(mórbida)";
                return $"Seu IMC é {imc}. Você {situacao}";
            }
            else
            {
                return "Resultado Inconclusivo";
            }

        }

        [WebMethod]
        public decimal conversor(decimal valorMetros, string tipoMedida)
        {
            decimal resultado = 0;

            if(valorMetros < 0 || tipoMedida.Trim().Length == 0)
            {
                return resultado;
            }

            switch (tipoMedida)
            {
                // kilômetros
                case "km":
                    resultado = valorMetros / 1000m;
                    return resultado;
                // milhas
                case "mi":
                    resultado = valorMetros * 0.00062137m;
                    return resultado;
                // centímetros
                case "cm":
                    resultado = valorMetros / 0.010000m;
                    return resultado;
                // milímetros
                case "mm":
                    resultado = valorMetros / 0.0010000m;
                    return resultado;
                //polegadas
                case "in":
                    resultado = valorMetros * 39.370m;
                    return resultado;
                // pés
                case "ft":
                    resultado = valorMetros * 3.2808m;
                    return resultado;
                // jardas
                case "yd":
                    resultado = valorMetros * 1.0936m;
                    return resultado;
                // decímetros
                case "dm":
                    resultado = valorMetros / 0.10000m;
                    return resultado;
                // micrômetro
                case "um":
                    resultado = valorMetros / 0.0000010000m;
                    return resultado;
                default:
                    return resultado;


            }
        }

    }
}
