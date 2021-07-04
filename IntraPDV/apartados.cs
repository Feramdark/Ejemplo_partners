using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace IntraPDV
{
    class apartados
    {
        //private SqlConnection con = BDConnect.connection();


        public bool insertar(SqlConnection con, string nom)
        {
            SqlCommand query = new SqlCommand(string.Format("INSERT INTO clientes (nombre) values ('{0}')"
                ,new string[] {nom}), con);
            int filasAfectadas = query.ExecuteNonQuery();
            con.Close();
            if (filasAfectadas > 0) return true;
            else return false;
        }

        public DataTable clientes(SqlConnection con)
        {
            SqlCommand consulta = new SqlCommand("SELECT * FROM clientes",con);
            SqlDataAdapter adapter = new SqlDataAdapter(consulta);
            DataSet data = new DataSet();

            adapter.Fill(data, "tabla");
            con.Close();
            return data.Tables["tabla"];

        }

        public String getIdcliente(SqlConnection con,string nombre)
        {
            string id_cliente = "";

            SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM clientes WHERE nombre = '{0}'",new string[] { nombre}), con);
            SqlDataReader lector = consulta.ExecuteReader();

            while (lector.Read())
            {
                id_cliente = lector.GetInt32(0).ToString();
            }
            lector.Close();
            con.Close();
            return id_cliente;
        }
        public bool eliminarClientes(SqlConnection con,string nom)
        {
            SqlCommand query = new SqlCommand(string.Format("DELETE FROM clientes WHERE id_cliente = '{0}'", new string[] { nom }), con);
            int requestResult = query.ExecuteNonQuery();
            con.Close();
            if (requestResult > 0) return true;
            else return false;
        }

        public DataTable listaApartados(SqlConnection con)
        {
            SqlCommand consulta = new SqlCommand("consultaCuenta",con);
            SqlDataAdapter ad = new SqlDataAdapter(consulta);
            DataSet dt = new DataSet();

            ad.Fill(dt, "aps");
            con.Close();
            return dt.Tables["aps"];
        }
        public bool ActualizarRestante(SqlConnection con,string restante,string abono,string id)
        {
            SqlCommand command = new SqlCommand(string.Format("UPDATE cuenta_apartado SET restante = '{0}',abono = '{1}' WHERE id_apartado = {2} ", new string[] { restante, abono, id }), con);
            int resultado = command.ExecuteNonQuery();
            if (resultado > 0) return true;
            else return false;
        }
        public bool RegistraPgo(SqlConnection con,int idAp,int idCl,float restAn,float pagoNvo,float debeN,string date)
        {
            SqlCommand command = new SqlCommand("updateAbono", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idApartado", idAp);
            command.Parameters.AddWithValue("@idCliente", idCl);
            command.Parameters.AddWithValue("@restAnte", restAn);
            command.Parameters.AddWithValue("@pagoNuevo", pagoNvo);
            command.Parameters.AddWithValue("@debe", debeN);
            command.Parameters.AddWithValue("@fecha", Convert.ToDateTime(date));

            int res = command.ExecuteNonQuery();
            command.Parameters.Clear();
            con.Close();
            if (res > 0)
            {
                return true;
            }
            else return false;
        }
        public bool registraApartado(SqlConnection con, string idCl, int cant, float montoTotal, float anticipo, float restante, string date)
        {
            SqlCommand command = new SqlCommand("creacuentaAp", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idCliente",idCl);
            command.Parameters.AddWithValue("@cantidad",cant);
            command.Parameters.AddWithValue("@totalmonto",montoTotal);
            command.Parameters.AddWithValue("@anticipo",anticipo);
            command.Parameters.AddWithValue("@restante",restante);
            command.Parameters.AddWithValue("@fecha",Convert.ToDateTime(date));

            int res = command.ExecuteNonQuery();
            command.Parameters.Clear();
            con.Close();
            if (res > 0) return true;
            else return false;
        }
        
        public DataTable listaProductosApartados(SqlConnection con,string id)
        {
            SqlCommand consulta = new SqlCommand("consultaApartados", con);
            consulta.CommandType = CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@idCliente", id);

            SqlDataAdapter ad = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();

            ad.Fill(ds, "pts_aps");
            con.Close();
            return ds.Tables["pts_aps"];
        }
        public DataTable listaPagos(SqlConnection con,string idCl)
        {
            SqlCommand com = new SqlCommand("consultaPagos",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@idCliente",idCl);


            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            ad.Fill(ds, "pagos");
            con.Close();
            return ds.Tables["pagos"];
        }
        
        public DataTable listaAnticipos(SqlConnection con,string fecha)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand command = new SqlCommand("consultaAnticipos", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha", Convert.ToDateTime(fecha));


            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            ad.Fill(ds, "anti");
            con.Close();
            return ds.Tables["anti"];
        }
        public DataTable listaPagosfecha(SqlConnection con, string fecha){
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand command = new SqlCommand("consultaPagosFecha", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha", Convert.ToDateTime(fecha));


            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            ad.Fill(ds, "pagos");
            con.Close();
            return ds.Tables["pagos"];

        }

        public bool eliminarPtoApartado(SqlConnection con,string idApa)
        {
            SqlCommand command = new SqlCommand(string.Format("DELETE apartados_list WHERE idApartado = '{0}'", new string[] { idApa }), con);
            int result = command.ExecuteNonQuery();
            if (result > 0) { return true; }
            else return false;
        }
        public bool eliminarCtaApartado(SqlConnection con, string idCte)
        {
            SqlCommand command = new SqlCommand(string.Format("DELETE cuenta_apartado WHERE id_cliente = '{0}'", new string[] { idCte }), con);
            int result = command.ExecuteNonQuery();
            if (result > 0) { return true; }
            else return false;
        }

        public bool actualizaCuenta(SqlConnection con, string idCl, int cant, float montoTotal, float anticipo, float restante, string date)
        {

        }
    }   
}
