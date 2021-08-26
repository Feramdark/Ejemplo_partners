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
            UltimoFolio();
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
            //Variables para insertar
            float montoTotal = Convert.ToSingle(totalSumapts.Text);
            float anticipo = Convert.ToSingle(cajaAnticipotxt.Text);
            float restante = Convert.ToSingle(cantidadRestante.Text);

            idCte = idClientetxt.Text;

            apartados operacion = new apartados();
            

            if (idCte != null && codigoProducto != null && nombreProducto != null)
            {
                SqlConnection conectar = BDConnect.connection();
                //operaciones de comprobacion xd

                SqlDataReader lector;
                SqlCommand command = new SqlCommand(string.Format("SELECT * FROM cuenta_apartado WHERE id_cliente = '{0}'", new string[] { idClientetxt.Text }), conectar);
                lector = command.ExecuteReader();
               
                    if (lector.Read())
                    { 
                        string id = idClientetxt.Text;
                        string encontrado = lector.GetInt32(1).ToString();
                        if (id == encontrado)
                        {
                            int cantidad_productos = 0;

                            SqlCommand insertar = new SqlCommand("insertarApartados", conectar);
                            insertar.Parameters.Clear();

                            insertar.CommandType = CommandType.StoredProcedure;
                        
                            foreach (DataGridViewRow fila in tablaProductos.Rows)
                            {
                                lector.Close();
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
                        }
                    }
                    else
                    {
                        lector.Close();
                        int cantidad_productos = 0;

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


                        bool res = operacion.registraApartado(conectar, idCte, cantidad_productos, montoTotal, anticipo, restante, dateTimePicker1.Text,dateTimePicker1.Text);

                        if (insertar != null && res)
                        {
                            DialogResult resultado = MessageBox.Show("Apartado realizado exitosamente", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (resultado == DialogResult.OK)
                            {
                                imprimirComprobante();
                                CrearImpresion.ImprimirTiket();
                            }
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
            Conversion con = new Conversion();
            string numero = "";

            CrearImpresion.TextoCentro("        ");
            CrearImpresion.TextoCentro("        ");
            CrearImpresion.TextLeft(" Velia Perez Zavala");
            CrearImpresion.TextLeft(" R.F.C. PEZV-690103-270");
            CrearImpresion.TextLeft(" Aquiles Serdan #105 OTE");
            CrearImpresion.TextLeft(" Colonia centro");
            CrearImpresion.TextLeft(" Gpe. Victoria,DGO C.P 34700");
            CrearImpresion.lineasSeparacion();//---------------------------------------------------------------------
            CrearImpresion.TextoCentro("Nota de Apartado");
            CrearImpresion.TextoCentro("Fecha: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            CrearImpresion.TextLeft("Nombre: " + nombreClientetxt.Text);
            CrearImpresion.lineasSeparacion();//---------------------------------------------------------------------
            CrearImpresion.EncabezadoTicket();
            int found = 0;
            string data;

            foreach (DataGridViewRow celda in tablaProductos.Rows)
            {
                data = celda.Cells[6].Value.ToString();
                found = data.IndexOf(".");
                CrearImpresion.TextLeft(celda.Cells[0].Value.ToString());
                CrearImpresion.TextLeft(celda.Cells[2].Value.ToString());
                CrearImpresion.TextLeft("                 " + "      " + celda.Cells[1].Value.ToString() + "      " + celda.Cells[3].Value.ToString() + "      " + celda.Cells[6].Value.ToString().Substring(0,found + 3));
            }
            

            CrearImpresion.lineasSeparacion();//----------------------------------------------------------
            numero = totalSumapts.Text.Trim();
            CrearImpresion.TextoDerecha("Total:      $" + totalSumapts.Text);
            CrearImpresion.TextoDerecha("Pago:   $" + importe.Text);
            CrearImpresion.TextoDerecha("Anticipo:   $"+ cajaAnticipotxt.Text);
            CrearImpresion.TextoDerecha("Cambio:   $" + cambioLabel.Text);
            CrearImpresion.TextoDerecha("Restan:   $"+ Convert.ToString(cantidadRestante.Text));
            CrearImpresion.TextLeft("(" + con.enletras(numero).ToLower());
            CrearImpresion.lineasSeparacion();//---------------------------------------------------------------------
            CrearImpresion.TextoCentro("Apartado a un mes de plazo");
            CrearImpresion.TextoCentro("No se aceptan cambios en apartado");
            CrearImpresion.lineasSeparacion();//---------------------------------------------------------------------
            CrearImpresion.TextoCentro("****Gracias por su compra****");
        }

        private void cambios(object sender, DataGridViewCellEventArgs e)
        {
            float totalDesc = 0.00F;
            foreach (DataGridViewRow fila in tablaProductos.Rows)
            {
                if(fila.Cells[0].Value != null)
                {
                    int cant = Convert.ToInt32(fila.Cells[1].Value);
                    float precio = Convert.ToSingle(fila.Cells[3].Value);
                    float descuento = Convert.ToSingle(fila.Cells[4].Value);
                    float total = 0.00F;

                    total = (precio - (precio * descuento) / 100) * cant;
                    totalDesc = (precio * descuento) / 100;
                    fila.Cells[6].Value = total;
                    fila.Cells[5].Value = totalDesc;
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
            this.Close();
           
        } //PRUEBAS
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
                    idClienteDelete.Text = Convert.ToString(fila.Cells[0].Value);
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
            this.Hide();
            addCliente interfazCliente = new addCliente();
            interfazCliente.groupDelete.Visible = false;
            interfazCliente.cancel_Btn.Visible = false;
            interfazCliente.delete_Btn.Visible = false;

            interfazCliente.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = BDConnect.connection();
            apartados aps = new apartados();
            string id = idClienteDelete.Text.Trim();
            this.Hide();
            bool respuesta = MessageBox.Show("El cliente " + nombreClientetxt.Text.ToUpper() + " será eliminado de la base de datos \n esta operacion no se puede revertir", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
            if (respuesta)
            {
                bool queryResult = aps.eliminarClientes(con, id);
                if (queryResult) MessageBox.Show("Cliente eliminado con exito", "Operación Exitosa");
                this.Show();
            }
        }

        private void addInfo_txtChange(object sender, EventArgs e)
        {
            cajaAnticipotxt.Text = importe.Text;
        }
        public void UltimoFolio()
        {
            SqlConnection con = BDConnect.connection();
            SqlDataReader lector;
            SqlCommand foli = new SqlCommand("ultimoFolio", con);
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
                con.Close();
            }
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

                }
                else if (anticipo<=total)
                {
                    cantidadRestante.Text = resta(total, anticipo).ToString();
                    float rest = float.Parse(cantidadRestante.Text);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float pago = float.Parse(importe.Text);
            float anticipo = float.Parse(cajaAnticipotxt.Text);

            float restante = float.Parse(cantidadRestante.Text);
            float total = float.Parse(totalSumapts.Text);

            cambioLabel.Text = Convert.ToString(resta(pago, anticipo));

            if (anticipo >= total) //Son dos casos diferentes, el anticipo no puede ser mayor a lo que se debe.
            {
                
                float rest = resta(anticipo, total);
                cambioLabel.Text = Convert.ToString(resta(anticipo, total));

            }
            else if (anticipo <= total)
            {
                //Actualiza la cantidad anticipo.
                cantidadRestante.Text = resta(total, anticipo).ToString();
                float rest = float.Parse(cantidadRestante.Text);
            }
            guardarInformacion.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaActual.Text = DateTime.Now.ToLongTimeString();
        }

        private void aumentaFechas(string fechaActual)
        {
            var fechaInicial = fechaActual;
            var fechaLimite = DateTime.Parse(fechaInicial).AddMonths(1);


            MessageBox.Show("HOY ES " + fechaActual + "Mas UN mes" + fechaLimite);
        }
    }
}
