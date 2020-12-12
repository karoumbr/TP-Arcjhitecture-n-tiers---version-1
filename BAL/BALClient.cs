using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using DAL;

namespace BAL
{
    public class BALClient
    {
        public int AjouterClient(DAL.Client dl)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] tabPMNomes =
            {
                {"@id", dl.id },
                {"@nom", dl.nom },
                {"@adresse", dl.adresse },
                {"@solde", dl.solde }

            };
            res = Global.ExecuterOleDBActionNomsParams(@"insert into clients(id,nom,adresse,solde) values" +
                                " (@id,@nom,@adresse,@solde)", cn, tabPMNomes);
            Global.seDeconnecter(cn);
            return res;
        }
    }
}
