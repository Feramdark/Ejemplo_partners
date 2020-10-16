using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IntraPDV
{
   public class AppSetting
    {
        public static string ObtenerCadenaConexion(string cadena_conexion)
        {
            Configuration appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings stringSettings = appConfig.ConnectionStrings.ConnectionStrings[cadena_conexion];
            return stringSettings.ConnectionString;
        }
        public static void GuardarCadenaConexion(string NombreCadena_conexion,string CadenaCon)
        {
            Configuration appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            appConfig.ConnectionStrings.ConnectionStrings[NombreCadena_conexion].ConnectionString = CadenaCon;
            appConfig.Save();
        }
        
    }
}
