using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumidor
{
    public partial class Fatorial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalcularFatorial(object sender, EventArgs e)
        {
            int valor = int.Parse(numero.Text);
            var ws = new WebServer.WebServiceSoapClient();

            var resultado = ws.fatorial(valor);

            Resultado.Text = $"O Fatorial de {valor} é {resultado}";

        }
    }
}