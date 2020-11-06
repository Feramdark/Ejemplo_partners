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
            venta_diaria venta = new venta_diaria();
            this.Hide();
            venta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Realizar la Siguiente Venta", "Ropa y Calzado Rocha", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ActualizarInventario();
                RegistrarVenta();
                horaRecibida.Text = label6.Text;
                TicketForm ticket = new TicketForm();
                ticket.horaText.Text = horaRecibida.Text;
                ticket.totalText.Text = TotalPagar.Text;
                ticket.importeText.Text = Importe.Text;
                ticket.cambioText.Text = TextCambio.Text;
                this.Hide();
                this.Dispose();
                ticket.Show();
                ticket.MyTicket();


            }
            

        }

        private void CodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarProducto();
                //Despues de ejecutar el codigo de reg limpia el cuadro de busqueda
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
                        int cant = Convert.ToInt32(fila.Cells[4].Value);
                        float precio = Convert.ToSingle(fila.Cells[2].Value);
                        float descuento = Convert.ToSingle(fila.Cells[3].Value);
                        float total = Convert.ToSingle(fila.Cells[5].Value);
                        ///////////////////////////////////////////////////////////////////////
                        cant = cant + 1;
                        total = (precio - ((precio * descuento) / 100)) * cant;
                        fila.Cells[4].Value = cant;
                        fila.Cells[5].Value = total;
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
        public void RegistrarVenta()
        {
            try
            {
                SqlCommand RealizarVen = new SqlCommand("GuardarVenta", conexion_BD);
                RealizarVen.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    RealizarVen.Parameters.Clear();

                    RealizarVen.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dateTimePicker1.Text));
                    RealizarVen.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells[4].Value));
                    RealizarVen.Parameters.AddWithValue("@total", Convert.ToDouble(row.Cells[5].Value));
                    RealizarVen.Parameters.AddWithValue("@id_producto",Convert.ToString(row.Cells[0].Value));
                    RealizarVen.Parameters.AddWithValue("@id_empleado", IdUsuario.Text);
                    RealizarVen.Parameters.AddWithValue("@hora", Convert.ToDateTime(label6.Text));
                    RealizarVen.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Venta realizada","Exito");
                //MessageBox.Show(ex.Message);
            }
        }
        public void suma()
        {
            float suma = 0.000F;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null) //1 es "Total"
                    suma += Convert.ToSingle(row.Cells[5].Value);
                
                
            }
            TotalPagar.Text = Convert.ToString(suma);
        }

        public void Cambio(decimal importe, decimal total)
        {
            decimal cambio;

            cambio = total - importe;
            TextCambio.Text = Convert.ToString("$ "+ cambio);
            
        }
        private void dar_cambio(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                Cambio(Convert.ToDecimal(TotalPagar.Text), Convert.ToDecimal(Importe.Text));
            }
        }
        public void FuncionImprimir()
        {
            SqlDataAdapter Tabla = new SqlDataAdapter();
            Ticket.TextLeft("Ropa y Calzado Rocha");
            CrearImpresion.lineasSeparacion();

            Ticket.TextLeft("Direccion: Zona centro");
            Ticket.TextLeft("Fecha: " + DateTime.Now.ToShortDateString());
            CrearImpresion.lineasSeparacion();

            CrearImpresion.EncabezadoTicket();

            foreach(DataGridViewRow fila in dataGridView1.Rows)
            {//                               Nombre//                       Precio//                                        Cantidad                                     //TOTAL
                Ticket.AgregaArticulo(fila.Cells[1].Value.ToString(),decimal.Parse(fila.Cells[3].Value.ToString()), int.Parse(fila.Cells[5].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
                //Ticket.TextLeft(fila.Cells[1].Value.ToString());
            }
            CrearImpresion.lineasSeparacion();
            Ticket.ImprimirTiket();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();
        }
        public void ActualizarInventario()
        {
            try
            {
                SqlCommand update = new SqlCommand("BajaInventario", conexion_BD);
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
        }
    }
}
