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
        string codigoProducto = "";
        string nombreProducto = "";
        float restantePagar = 0.00F;
        string idCte = "";
        
        public interfazApartado()
        {
            InitializeComponent();
            consultaClientes();
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        DataTable productos = new DataTable();
        CrearImpresion CrearImpresion = new CrearImpresion();


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
                    suma();   
                }
            }
        }
        private void operacion(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (importe.Text != null)
                {
                    float precio = Convert.ToSingle(cantidadRestante.Text);
                    cantidadRestante.Text = resta(precio, Convert.ToSingle(importe.Text)).ToString();
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
                bool bandera = false;
                buscar.CommandType = CommandType.StoredProcedure;
                buscar.Parameters.AddWithValue("@codigoDeProducto", codigoProd);

                foreach (DataGridViewRow celda in tablaProductos.Rows)
                {
                    nombreProducto = Convert.ToString(celda.Cells[2].Value);
                    string codigoProducto = Convert.ToString(celda.Cells[0].Value);

                    if (codigoProducto == codigoBarras.Text)
                    {
                        int cantidad = Convert.ToInt32(celda.Cells[1].Value);
                        float precio = Convert.ToSingle(celda.Cells[3].Value);
                        celda.Cells[4].Value = 0;
                        float desc = Convert.ToSingle(celda.Cells[4].Value);
                        float total = Convert.ToSingle(celda.Cells[5].Value);

                        cantidad = cantidad + 1;
                        total = (precio - ((precio * desc) / 100)) * cantidad;
                        celda.Cells[1].Value = cantidad;
                        celda.Cells[6].Value = total;
                        bandera = true;       
                    }
                }
                if (bandera == false)
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = buscar;
                    adaptador.Fill(productos);
                    tablaProductos.DataSource = productos;
                }
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void guardarInformacion_Click(object sender, EventArgs e)
        {
            float montoTotal = Convert.ToSingle(totalSumapts.Text);
            float anticipo = Convert.ToSingle(cajaAnticipotxt.Text);
            float restante = Convert.ToSingle(cantidadRestante.Text);
            idCte = idClientetxt.Text;
            apartados operacion = new apartados();
            

            if (idCte != null && codigoProducto != null && nombreProducto != null)
            {
                int cantidad_productos = 0;
                SqlConnection conectar = BDConnect.connection();
                SqlCommand insertar = new SqlCommand("insertarApartados", conectar);
                insertar.Parameters.Clear();

                insertar.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow fila in tablaProductos.Rows)
                {
                    insertar.Parameters.Clear();
                    insertar.Parameters.AddWithValue("@idCliente", idClientetxt.Text);
                    insertar.Parameters.AddWithValue("@codigo", Convert.ToInt32(fila.Cells[0].Value));
                    insertar.Parameters.AddWithValue("@precio", Convert.ToDouble(fila.Cells[3].Value));
                    insertar.Parameters.AddWithValue("@cantidad", Convert.ToInt32(fila.Cells[1].Value));
                    insertar.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dateTimePicker1.Text));
                    cantidad_productos += Convert.ToInt32(fila.Cells[1].Value);
                    insertar.ExecuteNonQuery();
                    insertar.Parameters.Clear();
                }

                // el otro procedimiento
               bool res= operacion.registraApartado(conectar, idCte, cantidad_productos, montoTotal, anticipo, restante, dateTimePicker1.Text);

                if (insertar != null && res)
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
            resultado = precioTotal - imp;
            
            return resultado;
        }
        private void imprimirComprobante()
        {
            CrearImpresion.tituloTicket();
            CrearImpresion.TextoCentro("COMPROBANTE DE APARTADO");
            CrearImpresion.TextLeft(" Velia Perez Zavala");
            CrearImpresion.TextLeft(" R.F.C. PEZV-690103-270");
            CrearImpresion.TextLeft(" Aquiles Serdan #105 OTE");
            CrearImpresion.TextLeft(" Colonia centro");
            CrearImpresion.TextLeft(" Gpe. Victoria,DGO C.P 34700");
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextoCentro("Fecha: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            CrearImpresion.TextLeft("Nombre: " + nombreClientetxt.Text);
            CrearImpresion.lineasSeparacion();
            CrearImpresion.EncabezadoApartar();//---------------------------------------------------------------------


            foreach (DataGridViewRow celda in tablaProductos.Rows)
            {
                CrearImpresion.TextLeft(celda.Cells[2].Value.ToString());
                /*CrearImpresion.AgregaArticulo(celda.Cells[0].Value.ToString()+" ",
                    Convert.ToDecimal(celda.Cells[3].Value),Convert.ToInt32(celda.Cells[1].Value), Convert.ToDecimal(importe.Text));*/
                CrearImpresion.TextLeft(celda.Cells[0].Value.ToString() + "     " + celda.Cells[1].Value.ToString() + "      " + celda.Cells[3].Value.ToString());
                
            }
            
            CrearImpresion.lineasSeparacion();//----------------------------------------------------------
            CrearImpresion.TextoDerecha("Total:   $" + totalSumapts.Text);
            CrearImpresion.TextoDerecha("Pago:  $" + importe.Text);
            CrearImpresion.TextoDerecha("Anticipo:   $"+ cajaAnticipotxt.Text);
            CrearImpresion.TextoDerecha("Cambio:   $" + cambioLabel.Text);
            CrearImpresion.TextoDerecha("Restan:   $"+ Convert.ToString(cantidadRestante.Text));
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextoCentro("Apartado a un mes de plazo \n No se aceptan cambios en apartado");
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
                    float precio = Convert.ToSingle(fila.Cells[3].Value);
                    float descuento = Convert.ToSingle(fila.Cells[4].Value);
                    float total = 0.00F;

                    total = (precio - (precio * descuento) / 100) * cant;
                    fila.Cells[6].Value = total;
                }
                suma();
                codigoBarras.Focus();
            }
        }//PEndiente operaciones
        public void suma()
        {
            float suma = 0.00F;
            foreach (DataGridViewRow row in tablaProductos.Rows)
            {
                if (row.Cells[6].Value != null) //1 es "Total"
                    suma += Convert.ToSingle(row.Cells[6].Value); //incremento de la suma de todos los elementos que se encuentran es esa celda.
            }
            totalSumapts.Text = suma.ToString().Replace(" ", String.Empty);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CrearImpresion.tituloTicket();
            CrearImpresion.TextoCentro("Ropa y calzado");
            CrearImpresion.TextoCentro("ROCHA");
            CrearImpresion.TextoCentro("Comprobante Apartado");
            CrearImpresion.TextLeft(" Velia Perez Zavala");
            CrearImpresion.TextLeft(" R.F.C. PEZV-690103-270");
            CrearImpresion.TextLeft(" Aquiles Serdan #105 OTE");
            CrearImpresion.TextLeft(" Colonia centro");
            CrearImpresion.TextLeft(" Gpe. Victoria,DGO C.P 34700");
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextoCentro("Fecha: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            CrearImpresion.TextLeft("Nombre: " +"XXXXXXXXXX");
            CrearImpresion.lineasSeparacion();
            CrearImpresion.EncabezadoApartar();//---------------------------------------------------------------------

            CrearImpresion.TextLeft("TEXTO PRUEBA");
                /*CrearImpresion.AgregaArticulo(celda.Cells[0].Value.ToString()+" ",
                    Convert.ToDecimal(celda.Cells[3].Value),Convert.ToInt32(celda.Cells[1].Value), Convert.ToDecimal(importe.Text));*/
            CrearImpresion.TextLeft("999999         "+"   4"+"      305"+"      1220");
            CrearImpresion.TextLeft("TEXTO PRUEBA");
            CrearImpresion.TextLeft("12         " + "   1" + "      20" + "      20");


            CrearImpresion.lineasSeparacion();//----------------------------------------------------------
            CrearImpresion.TextoDerecha("Total:     $" + "000.00");
            CrearImpresion.TextoDerecha("Pago:    $" + "000.00");
            CrearImpresion.TextoDerecha("Anticipo:   $" + "000.00");
            CrearImpresion.TextoDerecha("Cambio:   $" + "000.00");
            CrearImpresion.TextoDerecha("Restan:   $" + "000.00");
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextoCentro("Apartado a un mes de plazo \n No se aceptan cambios en apartado");
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextoCentro("****Gracias por su compra****");
            CrearImpresion.ImprimirTiket();
        }
        private void consultaClientes()
        {
          
            SqlConnection sql = BDConnect.connection();
            apartados aps = new apartados();

            tabla_clientes.DataSource = aps.clientes(sql);
        }

        private void table_Clientsclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                try
                {
                    DataGridViewRow fila = tabla_clientes.Rows[e.RowIndex];

                    idClientetxt.Text = Convert.ToString(fila.Cells[0].Value);
                    nombreClientetxt.Text = Convert.ToString(fila.Cells[1].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCliente interfazCliente = new addCliente();
            interfazCliente.groupDelete.Visible = false;
            interfazCliente.cancel_Btn.Visible = false;
            interfazCliente.delete_Btn.Visible = false;

            interfazCliente.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            addCliente interfazCliente = new addCliente();

            interfazCliente.groupBox1.Visible = false;
            interfazCliente.button1.Visible = false;

            interfazCliente.ShowDialog();
            this.Refresh();
        }

        private void addInfo_txtChange(object sender, EventArgs e)
        {
            cajaAnticipotxt.Text = importe.Text;
        }

        private void operation_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                float pago = float.Parse(importe.Text);
                float anticipo = float.Parse(cajaAnticipotxt.Text);

                float restante = float.Parse(cantidadRestante.Text);
                float total = float.Parse(totalSumapts.Text);

                cambioLabel.Text = Convert.ToString(resta(pago, anticipo));

                if (anticipo>= total)
                {
                    float rest = resta(anticipo, total);
                    cambioLabel.Text = Convert.ToString(resta(anticipo, total));

                    if (rest <= total)
                    {
                        cantidadRestante.Text = "" + 0;
                        MessageBox.Show("EL VALOR ES IGUAL A LO QUE CUESTA EL PRODUCTO");
                    }
                    else if (rest>= total)
                    {
                        cantidadRestante.Text = "" + 0;
                        MessageBox.Show("EL VALOR ES IGUAL A LO QUE CUESTA EL PRODUCTO");
                    }
                }
                else if (anticipo<=total)
                {
                    cantidadRestante.Text = resta(total, anticipo).ToString();
                    float rest = float.Parse(cantidadRestante.Text);

                    if (rest<total)
                    {
                        MessageBox.Show("ACTUALIZAR LA COLUMNA DE ANTICIPO");
                    }
                }
            }
        }
    }
}
