using System;
using System.Configuration;
using System.Web.UI;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void VisualizzaCandidato_Click(object sender, EventArgs e)
        {
            parNome.InnerText = ConfigurationManager.AppSettings["nome"];
            parCognome.InnerText = ConfigurationManager.AppSettings["cognome"];
        }
    }
}