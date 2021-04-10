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
        }
        public void buscarVenta()
        {
            try
            {
                SqlCommand buscar_venta = new SqlCommand("busca_VentaDiaria", conexion);
                buscar_venta.CommandType = CommandType.StoredProcedure;

                buscar_venta.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dateTimePicker1.Text));

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
            Ticket.TextoCentro("INFORME VENTA DIARIA");
            Ticket.TextLeft(" Velia Perez Zavala");
            Ticket.TextLeft(" R.F.C. PEZV-690103-270");
            Ticket.TextLeft(" Aquiles Serdan #105 OTE");
            Ticket.TextLeft(" Colonia centro");
            Ticket.TextLeft(" Gpe. Victoria,DGO C.P 34700");
            CrearImpresion.lineasSeparacion();//-----------------------------------------
            Ticket.TextLeft("Fecha: " + dateTimePicker1.Value.ToString());//DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            Ticket.TextLeft(" Hora:       " + hora);
            CrearImpresion.lineasSeparacion();//-----------------------------------------
            CrearImpresion.EncabezadoTicket();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                Ticket.TextLeft(item.Cells[4].Value.ToString());
                Ticket.AgregaArticulo(item.Cells[3].Value.ToString()+" "
                    ,Convert.ToDecimal(item.Cells[5].Value),Convert.ToInt32(item.Cells[8].Value),Convert.ToDecimal(item.Cells[9].Value));
            }
            CrearImpresion.lineasSeparacion();//-------------------------------------------
            Ticket.TextLeft("TOTAL: "+totalDia);//nombre
            Ticket.TextLeft(letras.enletras(totalDia).ToLower());
            Ticket.ImprimirTiket();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToLongTimeString();
        }
    }
}
