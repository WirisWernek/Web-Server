using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumidor
{
    public partial class IMC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalcularIMC(object sender, EventArgs e)
        {
            decimal altura = decimal.Parse(Altura.Text);
            decimal peso = decimal.Parse(Peso.Text);
            var ws = new WebServer.WebServiceSoapClient();

            var resultado = ws.imc(altura, peso);

            Resultado.Text = resultado;
        }
    }
}