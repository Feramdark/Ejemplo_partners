using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IntraPDV
{
    public partial class Interfaz_1 : Form
    {
        static string cadena = ConfigurationManager.ConnectionStrings["pc_cn"].ConnectionString;
        public Interfaz_1()
        {
            InitializeComponent();
            Form1 inicio_sesion = new Form1();
            inicio_sesion.Close();
        }
        //CONEXION CON BASE DE DATOS
        SqlConnection conexion_BD = BDConnect.connection();
        //TABLA DE DATOS GRIDVIEW
        DataTable TablaDatos = new DataTable();
        //TABLA DE DATOS GRIDVIEW

        private void apagar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta= MessageBox.Show("¿Desea salir de la aplicación?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }
        private void minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_producto añadir = new Registrar_producto();
            añadir.Show();
            this.Hide();
        }

        private void checarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inventario_form = new Inventario();
            inventario_form.Show(); 
            this.Hide();
            
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEmpleado registroEmpleado = new RegistroEmpleado();
            registroEmpleado.Show();
            this.Hide();
        }

        private void cambioDeConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracionServidor configuracion = new ConfiguracionServidor();
            configuracion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TestCon(cadena);
        }
        /*public void TestCon(string cadena)
        {
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexion Exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }*/
        public void RegistrarProducto()
        {
            SqlCommand datos = new SqlCommand("consulta", conexion_BD);
            datos.CommandType = CommandType.StoredProcedure;
            
        }
    }
}
