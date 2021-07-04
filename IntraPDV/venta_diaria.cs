using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntraPDV
{
    public partial class venta_diaria : Form
    {
        public venta_diaria()
        {
            InitializeComponent();
            totalApartados.Visible = false;
            pagosDiarios.Visible = false;
            labelAnticipo.Visible = false;
            labelPagos.Visible = false;
        }
       
        static string nombre = "";
        static string cantidad = "";
        static string descuento = "";
        static string desc = "";
        static string precio = "";
        static string totalPro = "";
        static string totalDia = "";
        static string hora = "";
        SqlConnection conexion = BDConnect.connection();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            buscarVenta();
            totalEnTexto.Text = totalDia;

            suma();
            sumaPagos();

            
            if(totalEnTexto.Text != "")
            {
                float a = suma();
                float b = sumaPagos();
                float c = Convert.ToSingle(totalEnTexto.Text);

                //-------------------------
                float res = a + b + c;
                totalDiario.Text = res.ToString();

            }
            else
            {
                float a = suma();
                float b = sumaPagos();

                float res = a + b;
                totalDiario.Text = res.ToString();
            }
        }
        public void buscarVenta()
        {
            apartados ap = new apartados();
            try
            {
                SqlCommand buscar_venta = new SqlCommand("busca_VentaDiaria", conexion);
                buscar_venta.CommandType = CommandType.StoredProcedure;

                buscar_venta.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dateTimePicker1.Text));

                totalApartados.DataSource = ap.listaAnticipos(conexion, dateTimePicker1.Text);
                pagosDiarios.DataSource = ap.listaPagosfecha(conexion, dateTimePicker1.Text);



                SqlCommand total = new SqlCommand("sumaTotal_Venta",conexion); 
                total.CommandType = CommandType.StoredProcedure;
                total.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dateTimePicker1.Text));

                SqlDataAdapter adaptador = new SqlDataAdapter();
                SqlDataAdapter adap = new SqlDataAdapter();
                DataTable tabla = new DataTable();
                DataTable totalVenta = new DataTable();
                adaptador.SelectCommand = buscar_venta;
                adap.SelectCommand = total;
                adaptador.Fill(tabla);
                adap.Fill(totalVenta);
                dataGridView1.DataSource = tabla;
                dataGridTotal.DataSource = totalVenta;

                foreach (DataGridViewRow item in dataGridTotal.Rows)
                {
                    totalDia = item.Cells[0].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
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

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            //Interfaz_1 MainMenu = new Interfaz_1();
            //MainMenu.Show();
            this.Dispose();
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            CrearImpresion Ticket = new CrearImpresion();
            Conversion letras = new Conversion();
            Ticket.TextLeft("          ");
            Ticket.TextLeft("          ");
            Ticket.TextoCentro("Velia Perez Zavala");
            Ticket.TextLeft("     R.F.C. PEZV-690103-270");
            Ticket.TextLeft("     Aquiles Serdan #105 OTE");
            Ticket.TextLeft("     Colonia Centro");
            Ticket.TextLeft("     Gpe. Victoria,DGO C.P 34700");
            CrearImpresion.lineasSeparacion();//-----------------------------------------
            Ticket.TextoCentro("Corte del día");
            Ticket.TextLeft("Fecha: " + dateTimePicker1.Value.ToString());//DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            CrearImpresion.lineasSeparacion();//-----------------------------------------
            CrearImpresion.EncabezadoTicket();

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                int desc = Convert.ToInt32(fila.Cells[6].Value);
                if (desc == 0)
                {
                    Ticket.TextLeft(fila.Cells[3].Value.ToString()); //Codigo producto
                    Ticket.TextLeft(fila.Cells[4].Value.ToString()); // Nombre producto

                    //                                                      cantidad                             Precio unitario                             Precio*cantidad            
                    Ticket.TextLeft("                 " + "      " + fila.Cells[8].Value.ToString() + "      " + fila.Cells[5].Value.ToString() + "      " + fila.Cells[9].Value.ToString());
                }
                else
                {
                    Ticket.TextLeft(fila.Cells[3].Value.ToString()); // codigo producto
                    //              Nombre producto                   MENOS         tanto porciento                                    
                    Ticket.TextLeft(fila.Cells[4].Value.ToString() + "  -" + fila.Cells[6].Value.ToString() + " %");
                    //                                                      precio unitario - lo que es de porcentaje                    
                    Ticket.TextLeft("                        " + "p.u $" + fila.Cells[5].Value.ToString() + "   -" + fila.Cells[7].Value.ToString());//total-descuento

                    //                                                      cantidad                             Precio unitario                             Precio*cantidad            
                    Ticket.TextLeft("                 " + "      " + fila.Cells[8].Value.ToString() + "      " + fila.Cells[5].Value.ToString() + "      " + fila.Cells[9].Value.ToString());
                }

            }

            if (labelAnticipos.Text != "0")
            {
                Ticket.TextoCentro("-------------APARTADOS------------");
                foreach (DataGridViewRow item in totalApartados.Rows)
                {
                    string celdaCodigo = item.Cells[0].Value.ToString();

                    if (celdaCodigo != null)
                    {

                        //Ticket.TextLeft(item.Cells[0].Value.ToString()); //Codigo Apartado
                        Ticket.TextLeft(item.Cells[2].Value.ToString()); // Nombre cliente

                        //Ticket.TextLeft("                 " + "      " + "Anticipo: " + "      " + item.Cells[3].Value.ToString() + "      " + "---");
                        Ticket.TextLeft("Anticipo: " + "      " + item.Cells[3].Value.ToString() + "      " + "---");

                    }
                }
            }
            if (labelPagoText.Text !="0")
            {
                foreach (DataGridViewRow fila in pagosDiarios.Rows)
                {
                    string celdaCodigo = fila.Cells[0].Value.ToString();

                    if (celdaCodigo != null)
                    {
                        //Ticket.TextLeft(fila.Cells[0].Value.ToString()); //Codigo Pago
                        Ticket.TextLeft(fila.Cells[1].Value.ToString()); // Nombre cliente

                        //Ticket.TextLeft("                 " + "      " + "Anticipo: " + "      " + item.Cells[3].Value.ToString() + "      " + "---");
                        Ticket.TextLeft("Pago: " + "      " + fila.Cells[4].Value.ToString() + "      " + "---");
                    }
                }
            }
            
            CrearImpresion.lineasSeparacion();//-------------------------------------------
            Ticket.TextLeft("Ventas: $" + totalEnTexto.Text);//nombre
            Ticket.TextLeft("Anticipos: $" + labelAnticipos.Text);//nombre
            Ticket.TextLeft("Pagos: $" + labelPagoText.Text);//nombre
            Ticket.TextLeft("TOTAL DÍA: $"+ totalDiario.Text);//nombre
            Ticket.TextLeft("("+letras.enletras(totalDiario.Text).ToLower());
            Ticket.ImprimirTiket();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToLongTimeString();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (totalApartados.Visible == false && pagosDiarios.Visible == false)
            {

                pagosDiarios.Visible = true;
                totalApartados.Visible = true;
                labelAnticipo.Visible = true;
                labelPagos.Visible = true;
                dataGridView1.Visible = false;
                button2.Text = "Regresar a ventas";
            }
            else if(dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
                labelAnticipo.Visible = false;
                labelPagos.Visible = false;
                totalApartados.Visible = false;
                pagosDiarios.Visible = false;
                button2.Text = "Ver Pagos";

            }
        }

        private float suma()
        {
            float resultado = 0.00F;
            foreach(DataGridViewRow fila in totalApartados.Rows)
            {
                resultado += Convert.ToSingle(fila.Cells[3].Value);
            }
            labelAnticipos.Text = resultado.ToString();
            return resultado;
        }
        private float sumaPagos()
        {
            float resultado = 0.00F;
            foreach (DataGridViewRow fila in pagosDiarios.Rows)
            {
                resultado += Convert.ToSingle(fila.Cells[4].Value);
            }
            labelPagoText.Text = resultado.ToString();
            return resultado;
        }
    }
}
