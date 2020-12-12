using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;

namespace Windows_Forms
{
    public partial class Form1 : Form
    {
        BALClient bl;
        Client dl;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
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
                MessageBox.Show("Succès Ajout de nouveau client.");
            }
            else
            {
                MessageBox.Show("Echec Ajout de nouveau client.");
            }








        }
    }
}
