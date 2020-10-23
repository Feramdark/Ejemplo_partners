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
            inicio_sesion.Dispose();
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

            suma();
            String total = TotalPagar.Text;
            //RegistrarVenta();
            Cobro cajacobro = new Cobro(total);
            cajacobro.Show();
        }
        private void CodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarProducto();
                //Despues de ejecutar el codigo de reg limpia el cuadro de busqueda
                CodigoBarras.Text = "";
            }
        }

        public void BuscarProducto()
        {
            bool identificador = false;

            DataGridViewRow FilaTabla = new DataGridViewRow();

            SqlCommand datos = new SqlCommand("consulta", conexion_BD);
            datos.CommandType = CommandType.StoredProcedure;

            datos.Parameters.AddWithValue("@codigo", CodigoBarras.Text);
            datos.Parameters.AddWithValue("@cantidad", 1);
            /*CELDAS
           * 0-> Codigo barras.
           * 1-> Nombre Del Producto.
           * 2-> Modelo del producto.
           * 3-> Precio del producto.
           * 4-> Descuento, aparece en 0 en caso de no existir
           * 5-> Cantidad de productos adquiridos, incrementa en caso de ser el mismo producto
           * 6-> Muestra el total del producto, con o sin descuento*/
           foreach(DataGridViewRow FilaCreada in dataGridView1.Rows)
            {
                if (FilaCreada.Cells[0].Value != null)
                {
                    if (FilaCreada.Cells[0].Value.ToString() == CodigoBarras.Text)
                    {
                     //Variables de valores
                        int CeldaCantidad = Convert.ToInt32(FilaCreada.Cells[5].Value);

                        float CeldaPrecio = Convert.ToSingle(FilaCreada.Cells[3].Value);
                        float CeldaDescuento = Convert.ToSingle(FilaCreada.Cells[4].Value);
                        float CeldaTotal = Convert.ToSingle(FilaCreada.Cells[6].Value);
                     //Cierre de variables de valores
                        //OPERACIONES//
                        CeldaCantidad = CeldaCantidad + 1;
                        CeldaTotal= (CeldaPrecio - ((CeldaPrecio * CeldaDescuento) / 100)) * CeldaCantidad;

                        //Impresion de resultados
                        FilaCreada.Cells[5].Value = CeldaCantidad;
                        FilaCreada.Cells[6].Value = CeldaTotal;

                        identificador = true;
                    }
                }
            }
            //Termina el foreach
            if (identificador == false) //llena la tabla con los datos de arriba
            {
                SqlDataAdapter AdaptadorDatos = new SqlDataAdapter();
                AdaptadorDatos.SelectCommand = datos;
                TablaDatos.Rows.Count.ToString();
                AdaptadorDatos.Fill(TablaDatos);
                dataGridView1.DataSource = TablaDatos;
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
                    RealizarVen.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dateTimePicker1.Text));
                    RealizarVen.Parameters.AddWithValue("@cantidad", row.Cells[5].Value);
                    RealizarVen.Parameters.AddWithValue("@total", row.Cells[6].Value);
                    RealizarVen.Parameters.AddWithValue("@id_producto", row.Cells[0].Value);
                    RealizarVen.Parameters.AddWithValue("@id_empleado", IdUsuario.Text);
                    RealizarVen.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void suma()
        {
            float suma = 0.00F;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null) //1 es "Total"
                    suma += Convert.ToSingle(row.Cells[6].Value);
                
            }
            TotalPagar.Text = Convert.ToString(suma);
        }
    }
}
