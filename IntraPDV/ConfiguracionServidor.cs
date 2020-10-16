using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace IntraPDV
{
    public partial class ConfiguracionServidor : Form
    {
        public ConfiguracionServidor()
        {
            InitializeComponent();
            CadenaConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectar();
            this.Close();
        }

        private void ConfiguracionServidor_Load(object sender, EventArgs e)
        {
            cboServer.Items.Add(".");
            cboServer.Items.Add("(local)");
            cboServer.Items.Add(@".\SQLVR");
            cboServer.Items.Add(string.Format(@"{0}\SQLVR", Environment.MachineName));
            cboServer.SelectedIndex = 3;

        }
        private void button2_Click(object sender, EventArgs e)
        {
           AppSetting.GuardarCadenaConexion("r7Conn", dtBase.Text);
            MessageBox.Show("Guardado Exitosamente");
        }
        //FUNCIONES DE IMPLEMENTACION PARA ALTERAR LA CADENA DE CONEXION  
        private void conectar()
        {
            SqlConnection conectar;
            conectar = new SqlConnection(dtBase.Text);

            conectar.Open();
            try
            {
                if (conectar.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexion exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conectar.Close();
            }
        }
        private void CadenaConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["pc_cn"].ConnectionString;
            dtBase.Text = cadena;
        }
    }
}
