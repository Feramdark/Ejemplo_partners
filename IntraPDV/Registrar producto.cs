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

namespace IntraPDV
{
    
    public partial class Registrar_producto : Form
    {
        CrearImpresion ticket = new CrearImpresion();
        public Registrar_producto()
        {
            InitializeComponent();
            //Interfaz_1 main_menu = new Interfaz_1();
            //main_menu.Hide();
            
        }
        DataTable inventario = new DataTable();
        private void apagar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_1 MainMenu = new Interfaz_1();
            MainMenu.Show();
        }

        private void buscarCodigo(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                buscarPorCode(codigoBarras.Text);
            }
        }
        
        private void buscarPorCode(string codigoProd)
        {
            try
            {
                SqlConnection conectar = BDConnect.connection();
                SqlCommand buscar = new SqlCommand("buscarCodigo", conectar);

                buscar.CommandType = CommandType.StoredProcedure;

                buscar.Parameters.AddWithValue("@codigo", codigoProd);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = buscar;
                adaptador.Fill(inventario);
                dataGridView1.DataSource = inventario;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*DataTable dt = new DataTable();
            dt.Rows.Clear();*/
            dataGridView1.Rows.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
