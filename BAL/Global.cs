using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace BAL
{
    class Global
    {
        static public String cs = @"Provider=Microsoft.ACE.OLEDB.12.0; data source=C:\Users\karou\source\repos\Solution 3-tiers couches separees\MaBase.accdb";
        static public OleDbConnection seConnecter(String strCN)
        {
            OleDbConnection objCN = new OleDbConnection();
            try
            {
                objCN.ConnectionString = strCN;
                if (objCN.State == System.Data.ConnectionState.Closed)
                    objCN.Open();

            }
            catch (Exception)
            {

                throw;
            }
            return objCN;
        }

        static public void seDeconnecter(OleDbConnection objCN)
        {
            try
            {
                if (objCN.State == System.Data.ConnectionState.Open)
                    objCN.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        static public int ExecuterOleDBActionNomsParams(string strSQL, OleDbConnection objCN, Object[,] objPM)
        {
            int nb = -1;
            OleDbCommand objCom = new OleDbCommand(strSQL, objCN);
            try
            {
                for (int i = 0; i< objPM.GetLength(0); i++)
                {
                    objCom.Parameters.AddWithValue((String)objPM[i, 0], objPM[i, 1]);
                }
                nb = objCom.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
                //throw;
            }
            return nb;
        }

    }
}
