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
    public partial class act_DatEmpleado : Form
    {
        public act_DatEmpleado()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      /*  public void actualizar()
        {
            //SqlConnection conect = BDConnect.connection();

            try
            {
                SqlCommand actPass = new SqlCommand("actPass", conect);
                actPass.CommandType = CommandType.StoredProcedure;
                actPass.Parameters.AddWithValue("@id", id.Text);
                actPass.Parameters.AddWithValue("@pass", password.Text);

                SqlCommand actTel = new SqlCommand("actTel", conect);
                actTel.CommandType = CommandType.StoredProcedure;
                actTel.Parameters.AddWithValue("@id", id.Text);
                actTel.Parameters.AddWithValue("@tel", tel.Text);

                SqlCommand actCel = new SqlCommand("actCel", conect);
                actTel.CommandType = CommandType.StoredProcedure;
                actTel.Parameters.AddWithValue("@id", id.Text);
                actTel.Parameters.AddWithValue("@cel", cel.Text);

                if (id.Text != "" && password.Text != "")
                {
                    actPass.ExecuteNonQuery();
                }
                if (id.Text != "" && tel.Text != "")
                {
                    actTel.ExecuteNonQuery();
                }
                if (id.Text != "" && cel.Text != "")
                {
                    actCel.ExecuteNonQuery();
                }

                if (id.Text != "" && password.Text != "" && tel.Text != "" && cel.Text != "")
                {
                    MessageBox.Show("Favor de Llenar los Campos que desee Actualizar", "Ropa y Calzado Rocha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conect.Close();
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            //actualizar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            buscar_empleado buscar = new buscar_empleado();
            buscar.Show();
        }
    }
}
