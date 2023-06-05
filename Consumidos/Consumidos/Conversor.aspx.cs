using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumidor
{
    public partial class Conversor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Converter(object sender, EventArgs e)
        {
            decimal valor = decimal.Parse(metros.Text);
            string unidade = unidadesMedida.SelectedValue;

            var ws = new WebServer.WebServiceSoapClient();

            decimal resultado = ws.conversor(valor, unidade);

            Resultado.Text = $"O resultado da conversão de {valor} metros para {unidade} é {resultado} {unidade}";

        }
    }
}