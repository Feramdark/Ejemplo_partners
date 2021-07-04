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
    public partial class devoPostCompra : Form
    {
        public devoPostCompra()
        {
            InitializeComponent();
        }


        

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_1 MainMenu = new Interfaz_1();
            MainMenu.Show();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folios.Text != "")
            {
                buscarVenta();
            }
            else {
                MessageBox.Show("Favor de Ingresar el Folio de la venta que desea buscar");


            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codVent.Text != "" && codProduct.Text != "" && cantidad.Text != "")
            {
                Convert.ToInt32(cantidad.Text);
                DevolverVenta();
                devolverProducto();
                buscarVenta();
                MessageBox.Show("Producto devuelto","OPERACION EXITOSA");
            }
            else
            {
                MessageBox.Show("Favor de Ingresar todos los datos completos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (codVent.Text != "")
            {
                DialogResult pregunta = MessageBox.Show("Esta Seguro de eliminar la siguiente venta", "ELIMINAR VENTA!", MessageBoxButtons.YesNo);
                if (pregunta == DialogResult.Yes)
                {
                    Convert.ToInt32(codVent.Text);
                    eliminarVenta();
                    buscarVenta();
                    MessageBox.Show("Venta eliminada", "OPERACION EXITOSA");
                }
            }

        }

        public void buscarVenta()
        {
            SqlConnection con = BDConnect.connection();
            try
            {
                SqlCommand buscar = new SqlCommand("buscaVentaXFolio", con);
                buscar.CommandType = CommandType.StoredProcedure;
                buscar.Parameters.AddWithValue("@folio", Convert.ToInt32(folios.Text));


                SqlDataAdapter adatador = new SqlDataAdapter();
                DataTable tablaventas = new DataTable();
                adatador.SelectCommand = buscar;
                adatador.Fill(tablaventas);
                dataGridView1.DataSource = tablaventas;
                buscar.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        public void DevolverVenta() {
            SqlConnection con = BDConnect.connection();

            try
            {
                SqlCommand devoluVen = new SqlCommand("ActualizaVenta", con);
                devoluVen.CommandType = CommandType.StoredProcedure;
                devoluVen.Parameters.AddWithValue("@codigo", codVent.Text);
                devoluVen.Parameters.AddWithValue("@cantidad", cantidad.Text);
                devoluVen.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        public void devolverProducto()
        {
            SqlConnection con = BDConnect.connection();

            try
            {
                SqlCommand devoluProduct = new SqlCommand("DevoProduct", con);
                devoluProduct.CommandType = CommandType.StoredProcedure;
                devoluProduct.Parameters.AddWithValue("@codigo", codProduct.Text);
                devoluProduct.Parameters.AddWithValue("@cantidad", cantidad.Text);
                devoluProduct.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        public void eliminarVenta()
        {
            SqlConnection con = BDConnect.connection();

            try
            {
                SqlCommand elimVent = new SqlCommand("EliminarVenta", con);
                elimVent.CommandType = CommandType.StoredProcedure;
                elimVent.Parameters.AddWithValue("@codigo", codVent.Text);
                elimVent.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void llenarCampos(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                codVent.Text = fila.Cells[1].Value.ToString();
                codProduct.Text = fila.Cells[4].Value.ToString();
            }
        }
    }
}
