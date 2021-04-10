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
    public partial class interfazApartado : Form
    {
        static string codigoProducto = "";
        static string nombreProducto = "";
        static float precio = 0.00F;
        static float restantePagar = 0.00F;
        static string nombreCte = "";
        static int cantidad = 0;
        static float abono = 0.00F;
        
        public interfazApartado()
        {
            InitializeComponent();
        }
        DataTable productos = new DataTable();
        CrearImpresion CrearImpresion = new CrearImpresion();
        KeyEventArgs evento = new KeyEventArgs(Keys.F5);


        private void buscar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                if (codigoBarras.Text != null)
                {
                    string codigo_barras = codigoBarras.Text;
                    string textoSeguro = codigo_barras.Replace(" ", String.Empty);
                    buscarPorCode(Convert.ToString(textoSeguro));
                    codigoBarras.Text = "";
                    
                }
            }
        }
        private void operacion(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (codigoBarras.Text != null)
                {
                    abono = Single.Parse(importe.Text);
                    cantidadRestante.Text = resta(Convert.ToSingle(importe.Text), precio).ToString();
                    restantePagar = resta(Convert.ToSingle(importe.Text), precio);
                    
                }
            }
        }
        private void buscarPorCode(string codigoProd)
        {
            tablaProductos.AllowUserToAddRows = false;
            try
            {
                SqlConnection conectar = BDConnect.connection();
                SqlCommand buscar = new SqlCommand("buscarPtoAparta", conectar);

                buscar.CommandType = CommandType.StoredProcedure;
                buscar.Parameters.AddWithValue("@codigoDeProducto", codigoProd);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = buscar;
                adaptador.Fill(productos);
                tablaProductos.DataSource = productos;

                foreach (DataGridViewRow celda in tablaProductos.Rows)
                {
                    codigoProducto = Convert.ToString(celda.Cells[0].Value);
                    cantidad = Convert.ToInt32(celda.Cells[1].Value);
                    nombreProducto = Convert.ToString(celda.Cells[2].Value);
                    precio = Convert.ToSingle(celda.Cells[4].Value);                    
                }
                suma();
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void guardarInformacion_Click(object sender, EventArgs e)
        {
            nombreCte = nombreCliente.Text;

            if (nombreCte != null && codigoProducto != null && nombreProducto != null)
            {
                SqlConnection conectar = BDConnect.connection();
                SqlCommand insertar = new SqlCommand("insertarApartados", conectar);
                insertar.Parameters.Clear();

                insertar.CommandType = CommandType.StoredProcedure;
                insertar.Parameters.AddWithValue("@nombreCli", nombreCte.ToUpper());
                insertar.Parameters.AddWithValue("@codigo", codigoProducto);
                insertar.Parameters.AddWithValue("@precio", precio);
                insertar.Parameters.AddWithValue("@cantidad", cantidad);
                insertar.Parameters.AddWithValue("@restante", restantePagar);
                insertar.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dateTimePicker1.Text));
                insertar.Parameters.AddWithValue("@abono", abono);

                // el otro procedimiento


                insertar.ExecuteNonQuery();

                if (insertar != null)
                {
                    DialogResult resultado = MessageBox.Show("Datos insertados con exito");
                    if (resultado==DialogResult.OK)
                    {
                        imprimirComprobante();
                        CrearImpresion.ImprimirTiket();
                    }
                }
            }
            else { MessageBox.Show("Llena los campos faltantes,\n si el error aparece de nuevo comuniquese con su proveedor", "ERROR AL INSERTAR LOS DATOS"); }
        }

        private float resta(float precioTotal = 0.00F ,float imp = 0.00F)
        {
            float resultado = 0.00F;

            resultado = -1*(precioTotal - imp);
            return resultado;
        }
        private void imprimirComprobante()
        {
            CrearImpresion.TextoCentro("Ropa y Calzado ROCHA");
            CrearImpresion.TextLeft(" Velia Perez Zavala");
            CrearImpresion.TextLeft(" R.F.C. PEZV-690103-270");
            CrearImpresion.TextLeft(" Aquiles Serdan #105 OTE");
            CrearImpresion.TextLeft(" Colonia centro");
            CrearImpresion.TextLeft(" Gpe. Victoria,DGO C.P 34700");
            CrearImpresion.TextoCentro("Fecha: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            CrearImpresion.TextoCentro("COMPROBANTE DE APARTADO");
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextLeft("Nombre: \n" + nombreCte);
            CrearImpresion.lineasSeparacion();
            CrearImpresion.EncabezadoApartar();//---------------------------------------------------------------------

            CrearImpresion.TextLeft(nombreProducto);
            CrearImpresion.AgregaArticulo(codigoProducto, Convert.ToDecimal(precio), cantidad, Convert.ToDecimal(importe.Text));
            CrearImpresion.lineasSeparacion();//------------------------------------------------------

            CrearImpresion.TextLeft("Usted abono: $"+ importe.Text);
            CrearImpresion.TextLeft("Restan: $"+ Convert.ToString(restantePagar));
            CrearImpresion.TextoCentro("Con este comprobante usted tiene");
            CrearImpresion.TextoCentro("un mes para pagar el articulo");
            CrearImpresion.TextoCentro("Presentar este comprobante");
            CrearImpresion.TextoCentro("al realizar la compra");
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextoCentro("****Gracias por su compra****");
        }

        private void cambios(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow fila in tablaProductos.Rows)
            {
                if(fila.Cells[0].Value != null)
                {
                    int cant = Convert.ToInt32(fila.Cells[1].Value);
                    float precio = Convert.ToSingle(fila.Cells[4].Value);
                    float descuento = Convert.ToSingle(fila.Cells[5].Value);
                    float total = 0.00F;

                    total = (precio - (precio * descuento) / 100) * cant;
                    fila.Cells[6].Value = total;
                }
                suma();
                codigoBarras.Focus();
            }
        }
        public void suma()
        {
            float suma = 0.00F;
            foreach (DataGridViewRow row in tablaProductos.Rows)
            {
                if (row.Cells[5].Value != null) //1 es "Total"
                    suma += Convert.ToSingle(row.Cells[4].Value); //incremento de la suma de todos los elementos que se encuentran es esa celda.
            }
            cantidadRestante.Text = suma.ToString().Replace(" ", String.Empty);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*int total_filas = tablaProductos.RowCount;
            int cont = 0;
            nombreCliente.Text = total_filas.ToString();
            nombreCliente.Clear();
            importe.ClearUndo();
            cantidadRestante.Text = "0.00";*/
        }
    }
}
