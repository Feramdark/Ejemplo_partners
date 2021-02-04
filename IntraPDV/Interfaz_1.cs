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
        CrearImpresion Ticket = new CrearImpresion();
        public Interfaz_1()
        {
            InitializeComponent();
            Form1 inicio_sesion = new Form1();
            inicio_sesion.Close();
            inicio_sesion.Dispose();

            UltimoFolio();

        }

        //CONEXION CON BASE DE DATOS
        SqlConnection conexion_BD = BDConnect.connection();
        //TABLA DE DATOS GRIDVIEW
        DataTable tabDatos = new DataTable();
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
        private void actualizarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
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
            venta_diaria venta = new venta_diaria();
            this.Hide();
            venta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Realizar la Siguiente Venta", "Ropa y Calzado Rocha", MessageBoxButtons.YesNo) == DialogResult.Yes){
                ActualizarInventario();
                num_venta();
                RegistrarVenta();
                horaRecibida.Text = label6.Text;
                TicketForm ticket = new TicketForm();
                ticket.horaText.Text = horaRecibida.Text;
                ticket.totalText.Text = TotalPagar.Text;
                ticket.importeText.Text = Importe.Text;
                ticket.cambioText.Text = TextCambio.Text;
                ticket.folioTick.Text = folio.Text;
                this.Hide();
                this.Dispose();
                ticket.Show();
                ticket.MyTicket();
             }
          
            //MessageBox.Show("Inserta el importe \nPor Favor", "FALTA EL IMPORTE", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void CodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarProducto();
                CodigoBarras.Text = "";
                suma();
            }
        }

        public void BuscarProducto()
        {
            DataGridViewRow row = new DataGridViewRow();
            bool flag = false;
            SqlCommand datos = new SqlCommand("consulta", conexion_BD);
            datos.CommandType = CommandType.StoredProcedure;
            datos.Parameters.AddWithValue("@codigo", CodigoBarras.Text);
            datos.Parameters.AddWithValue("@cantidad", 1);

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    if (fila.Cells[0].Value.ToString() == CodigoBarras.Text)
                    {
                        int cant = Convert.ToInt32(fila.Cells[5].Value);// -> cantidad 
                        float precio = Convert.ToSingle(fila.Cells[2].Value);// -> precio
                        fila.Cells[3].Value = 0;
                        float descuento = Convert.ToSingle(fila.Cells[3].Value);// -> descuento
                        float total = Convert.ToSingle(fila.Cells[6].Value);//5
                        ///////////////////////////////////////////////////////////////////////
                        cant = cant + 1;
                        total = (precio - ((precio * descuento) / 100)) * cant;
                        fila.Cells[5].Value = cant;
                        fila.Cells[6].Value = total;
                        flag = true;
                    }
                }
            }
            if (flag == false)
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = datos;
                tabDatos.Rows.Count.ToString();
                sda.Fill(tabDatos);
                dataGridView1.DataSource = tabDatos;
            }
        }

        //Termina funcion para buscar producto
        public void RegistrarVenta()//Modificar para agregar el nuevo valor de la venta. el folio
        {
            try
            {
                SqlConnection con = BDConnect.connection();
                SqlCommand RealizarVen = new SqlCommand("GuardarVenta", con);
                RealizarVen.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    RealizarVen.Parameters.Clear();

                    RealizarVen.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dateTimePicker1.Text));
                    RealizarVen.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells[5].Value));
                    RealizarVen.Parameters.AddWithValue("@total", Convert.ToDouble(row.Cells[6].Value));
                    RealizarVen.Parameters.AddWithValue("@id_producto", Convert.ToString(row.Cells[0].Value));
                    RealizarVen.Parameters.AddWithValue("@id_empleado", IdUsuario.Text);
                    RealizarVen.Parameters.AddWithValue("@hora", Convert.ToDateTime(label6.Text));
                    RealizarVen.Parameters.AddWithValue("@folio", folio.Text); // -> numero de nota
                    RealizarVen.Parameters.AddWithValue("@descuento", Convert.ToDecimal(row.Cells[3].Value));// -> el descuento a aplicar
                    RealizarVen.Parameters.AddWithValue("@descuento_equi", Convert.ToDouble(row.Cells[4].Value));// -> lo que se va a descontar
                    RealizarVen.ExecuteNonQuery();
                    RealizarVen.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {conexion_BD.Close();}
        }
        public void suma()
        {
            float suma = 0.00F;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null) //1 es "Total"
                    suma += Convert.ToSingle(row.Cells[6].Value); //incremento de la suma de todos los elementos que se encuentran es esa celda.
            }
            TotalPagar.Text = Convert.ToString(suma);//Cantidad total de la suma de todos los elementos
        }

        public void Cambio(decimal importe, decimal total)
        {
            decimal cambio;

            cambio = total - importe;
            TextCambio.Text = Convert.ToString("$ "+ cambio);
            
        }
        private void dar_cambio(object sender, KeyPressEventArgs e)
        {
          
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Cambio(Convert.ToDecimal(TotalPagar.Text), Convert.ToDecimal(Importe.Text));
                }
         
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();
        }
        public void ActualizarInventario()
        {
            try
            {
                SqlConnection connection = BDConnect.connection();
                SqlCommand update = new SqlCommand("BajaInventario", connection);
                update.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    update.Parameters.Clear();
                    update.Parameters.AddWithValue("@codigo", Convert.ToString(row.Cells[0].Value));
                    update.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells[5].Value));
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion_BD.Close(); }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            suma();//Volver a realizar la suma
        }

        private void devolucionPosCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devoPostCompra devolu = new devoPostCompra();
            devolu.Show();
            this.Hide();
           
        }

        /*Boton hacia la interfaz de apartado*/

        private void sistemaDeApartadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interfazApartado sistema_apartado = new interfazApartado();
            sistema_apartado.ShowDialog();
        }
        private void num_venta()
        {
            SqlCommand siguienteFolio = new SqlCommand("SiguienteFolio", conexion_BD);
            siguienteFolio.CommandType = CommandType.StoredProcedure;

            try
            {
                if (conexion_BD.State == ConnectionState.Closed)
                {
                    conexion_BD.Open();
                    siguienteFolio.ExecuteNonQuery();
                    UltimoFolio();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar" + ex.Message);
            }
            finally
            {
                conexion_BD.Close();
            }
        }
        public void UltimoFolio()
        {
            SqlDataReader lector;
            SqlCommand foli = new SqlCommand("ultimoFolio", conexion_BD);
            foli.CommandType = CommandType.StoredProcedure;
            try
            {
                lector = foli.ExecuteReader();
                if (lector.Read())
                {
                    folio.Text = lector.GetInt32(0).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar" + ex.Message);
            }
            finally
            {
                conexion_BD.Close();
            }
        }
        public void aplicaCambios()
        {
            float totalDesc = 0.00F;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    int cantidad = Convert.ToInt32(fila.Cells[5].Value);
                    float precio = Convert.ToSingle(fila.Cells[2].Value);
                    float descuento = Convert.ToSingle(fila.Cells[3].Value);
                    float total = Convert.ToSingle(fila.Cells[4].Value);

                    //cuando se edita la celda
                    total = (precio - (precio * descuento) / 100) * cantidad;
                    totalDesc = (precio * descuento) / 100;
                    fila.Cells[4].Value = totalDesc;
                    fila.Cells[5].Value = cantidad;
                    fila.Cells[6].Value = total;
                }
            }
            suma();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            aplicaCambios();
        }


    }
}
