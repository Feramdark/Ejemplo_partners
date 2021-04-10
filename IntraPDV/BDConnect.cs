using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace IntraPDV
{
    public class BDConnect
    {
        /*Metodo para conectarme a la base de datos, recordar en este punto que cuando se ejecute este metodo LA CONEXION SERA ABIERTA 
         * no repetir el abrir en la conexion*/ 
        
        public static SqlConnection connection()
        {
            string StringConect = ConfigurationManager.ConnectionStrings["pc_cn"].ConnectionString;
            SqlConnection sqlQuery = new SqlConnection(StringConect); 
            sqlQuery.Open();
            //MessageBox.Show("Conexion lista");
            return sqlQuery;
        }

        /*public DataTable showItems() {
            SqlCommand cmd = new SqlCommand ("updateContent")
        }*/
    }
}
