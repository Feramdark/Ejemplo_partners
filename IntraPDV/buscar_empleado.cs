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
    public partial class buscar_empleado : Form
    {
        public buscar_empleado()
        {
            InitializeComponent();
            buscarEmp();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_1 MainMenu = new Interfaz_1();
            MainMenu.Show();
        }


        public void buscarEmp()
        {
            SqlConnection conect = BDConnect.connection();

            try
            {
                /*Procedimiento almacenado para buscar los datos del empleado*/
                SqlCommand buscaEm = new SqlCommand("busca_empleados", conect);
                buscaEm.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable tabla = new DataTable();
                adaptador.SelectCommand = buscaEm;
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally

            {
                conect.Close();
            }
        }
    }
}
