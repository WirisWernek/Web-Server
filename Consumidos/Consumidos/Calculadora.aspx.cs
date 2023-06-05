using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumidor
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calcular(object sender, EventArgs e)
        {
            var ws = new WebServer.WebServiceSoapClient();

            decimal primeiroValor = decimal.Parse(valor1.Text);
            decimal segundoValor = decimal.Parse(valor2.Text);
            char operacao = operacoes.SelectedValue.First();

            var resultado = ws.calculadora(primeiroValor, segundoValor, operacao);
            Resultado.Text = $"O resultado de {primeiroValor} {operacao} {segundoValor} = {resultado}";
        }

    }
}