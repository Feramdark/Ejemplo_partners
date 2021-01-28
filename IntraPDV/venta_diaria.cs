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
        SqlConnection conexion = BDConnect.connection();
        private void button1_Click(object sender, EventArgs e)
        {
            buscarVenta();
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
                adaptador.SelectCommand = buscar_venta;
                adap.SelectCommand = total;
                adaptador.Fill(tabla);
                adap.Fill(tabla);
                dataGridView1.DataSource = tabla;
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
            Interfaz_1 MainMenu = new Interfaz_1();
            MainMenu.Show();
            this.Dispose();
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            CrearImpresion Ticket = new CrearImpresion();
            Ticket.TextoCentro("INFORME VENTA DIARIA");
            Ticket.TextLeft(" Velia Perez Zavala");
            Ticket.TextLeft(" R.F.C. PEZV-690103-270");
            Ticket.TextLeft(" Aquiles Serdan #105 OTE");
            Ticket.TextLeft(" Colonia centro");
            Ticket.TextLeft(" Gpe. Victoria,DGO C.P 34700");
            CrearImpresion.lineasSeparacion();//-----------------------------------------
            Ticket.TextoCentro("Fecha: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            Ticket.TextLeft(" Hora:       " + DateTime.Today.TimeOfDay);
            Ticket.TextLeft(" Le atendio:    " + "Fam: Rocha Pérez");
            CrearImpresion.lineasSeparacion();//-----------------------------------------
            CrearImpresion.EncabezadoTicket();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                Ticket.TextoCentro(item.Cells[0].Value.ToString());
                
            }
            Ticket.ImprimirTiket();
        }
    }
}
