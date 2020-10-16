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
            this.Dispose();
        }

        public void actualizar()
        {
            SqlConnection conect = BDConnect.connection();

            try
            {
                /*Procedimiento almacenado para actualizar la contraseña*/
                SqlCommand actPass = new SqlCommand("actPass", conect);
                actPass.CommandType = CommandType.StoredProcedure;

                /*Variables del procedimiento*/
                actPass.Parameters.AddWithValue("@id", id.Text);
                actPass.Parameters.AddWithValue("@pass", password.Text);
                //----------------------------------------------------------------------------------------------------

                /*Procedimiento almacenado para actualizar el telefono fijo_se da por entendido que
                 se llama telefono fijo a el telefono de casa*/
                SqlCommand actTel = new SqlCommand("actTel", conect);
                actTel.CommandType = CommandType.StoredProcedure;

                /*Variables del procedimiento*/
                actTel.Parameters.AddWithValue("@id", id.Text);
                actTel.Parameters.AddWithValue("@tel", tel.Text);
                //----------------------------------------------------------------------------------------------------

                /*Procedimiento almacenado para actualizar el celular del empleado*/
                SqlCommand actCel = new SqlCommand("actCel", conect);
                actTel.CommandType = CommandType.StoredProcedure;
                /*Variables del procedimiento*/
                actTel.Parameters.AddWithValue("@id", id.Text);
                actTel.Parameters.AddWithValue("@cel", cel.Text);
                //----------------------------------------------------------------------------------------------------

                /*Las siguientes condicionales, posibilitan a que el sistema falle po alguna negligencia
                 del usuario, como dejar algun campo vacio*/

                /*Actualizar unicamente la contraseña*/
                if (id.Text != "" && password.Text != "")
                {
                    actPass.ExecuteNonQuery();
                }
                /*Por si va a actualizar unicamente el telefono*/
                if (id.Text != "" && tel.Text != "")
                {
                    actTel.ExecuteNonQuery();
                }
                /*Por si va a actualizar unicamente el telefono CELULAR*/
                if (id.Text != "" && cel.Text != "")
                {
                    actCel.ExecuteNonQuery();
                }
                if (id.Text != "" && password.Text != "" && tel.Text != "" && cel.Text != "")
                {
                    MessageBox.Show("Favor de Llenar los Campos que desee Actualizar",
                        "Ropa y Calzado Rocha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //Si existe un error, muestra el error aqui PENSANDO SI MODIFICAR ESE MENSAJE
                MessageBox.Show(ex.Message);
            }
            finally //Finalmente, si la conexion esta abierta a este punto cerrarla. UTILIZAR DISPOSE?
            {
                conect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            buscar_empleado buscar = new buscar_empleado();
            buscar.Show();
        }
    }
}
