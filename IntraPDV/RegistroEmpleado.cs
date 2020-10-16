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
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        /*public void registrar()
        {
            SqlConnection conect = BDConnect.connection();

            try
            {
                SqlCommand regDat = new SqlCommand("registrarEmpleado", conect);
                regDat.CommandType = CommandType.StoredProcedure;
                regDat.Parameters.AddWithValue("@id", id.Text);
                regDat.Parameters.AddWithValue("@nom", nombre.Text);
                regDat.Parameters.AddWithValue("@ap", apellidoP.Text);
                regDat.Parameters.AddWithValue("@am", apellidoM.Text);
                regDat.Parameters.AddWithValue("@pass", password.Text);
                regDat.Parameters.AddWithValue("@tel", tel.Text);
                regDat.Parameters.AddWithValue("@cel", cel.Text);
                regDat.Parameters.AddWithValue("@lug", lugar.Text);
                regDat.Parameters.AddWithValue("@cal", calle.Text);
                regDat.Parameters.AddWithValue("@num", nmero.Text);



                if (id.Text != "" && nombre.Text != "" && apellidoP.Text != "" && apellidoM.Text != "" && password.Text != "" && tel.Text != "" && cel.Text != "" && lugar.Text != "" && calle.Text != "" && nmero.Text != "" && password.Text == verifpass.Text)
                {
                    Convert.ToInt16(nmero.Text);
                    Convert.ToInt64(cel.Text);
                    Convert.ToInt64(tel.Text);
                    regDat.ExecuteNonQuery();
                    MessageBox.Show("Datos Registrados");
                }

                else
                {
                    MessageBox.Show("Datos Incorrectos");
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


       /* public void eliminarDatosEmpleado()
        {
            SqlConnection conect = BDConnect.connection();
            try
            {
                SqlCommand eliminarEmp = new SqlCommand("eliminarEmpleado", conect);
                eliminarEmp.CommandType = CommandType.StoredProcedure;
                eliminarEmp.Parameters.AddWithValue("@id", id.Text);

                if (id.Text != "")
                {
                    if (MessageBox.Show("¿Estas seguro que eliminar la información de empleado de forma permante?", "Ropa y Calzado Rocha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        eliminarEmp.ExecuteNonQuery();
                        MessageBox.Show("Datos Eliminados");
                    }

                    else
                    {
                        MessageBox.Show("Favor de LLenar el campo Id a eliminar");
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            act_DatEmpleado actEmp = new act_DatEmpleado();
            actEmp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //registrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //eliminarDatosEmpleado();
        }

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
    }
}
