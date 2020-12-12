using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BAL;

namespace Web_Application
{
    public partial class AjouterClient : System.Web.UI.Page
    {
        BALClient bl;
        Client dl;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAjouterClient_click(object sender, EventArgs e)
        {
            int res;
            bl = new BALClient();
            dl = new Client();
            dl.id = Int32.Parse(txtIdClient.Text);
            dl.nom = txtNom.Text;
            dl.adresse = txtAdresse.Text;
            dl.solde = decimal.Parse(txtSolde.Text);
            res = bl.AjouterClient(dl);
            if (res == 1)
            {
                lblResultat.Text ="Succès Ajout de nouveau client.";
            }
            else
            {
                lblResultat.Text = "Echec Ajout de nouveau client.";
            }
        }
    }
}