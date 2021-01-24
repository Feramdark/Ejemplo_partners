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
    public partial class TicketForm : Form
    {
        CrearImpresion Ticket = new CrearImpresion();
        public TicketForm()
        {
            InitializeComponent();
        }
        SqlConnection connect_BD = BDConnect.connection();
        public void MyTicket()
        {
            try
            {
                SqlCommand ticke = new SqlCommand("tick", connect_BD);
                ticke.CommandType = CommandType.StoredProcedure;
                ticke.Parameters.AddWithValue("@hora", Convert.ToDateTime(horaText.Text));
                ticke.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dateTimePicker1.Text));
                ticke.ExecuteNonQuery();

                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable tabla = new DataTable();
                adaptador.SelectCommand = ticke;
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
                Ticket.TextoCentro("Ropa y Calzado ROCHA");
                Ticket.TextLeft(" Velia Perez Zavala");
                Ticket.TextLeft(" R.F.C. PEZV-690103-270");
                Ticket.TextLeft(" Aquiles Serdan #105 OTE");
                Ticket.TextLeft(" Colonia centro");
                Ticket.TextLeft(" Gpe. Victoria,DGO C.P 34700");
                CrearImpresion.lineasSeparacion();//-----------------------------------------
                Ticket.TextoCentro("Fecha: " + DateTime.Today.Day+ "/" +DateTime.Today.Month+ "/" +DateTime.Today.Year);
                Ticket.TextLeft(" Hora:       " + horaText.Text);
                Ticket.TextLeft(" Le atendio:    " + "Fam: Rocha Pérez");
                CrearImpresion.lineasSeparacion();//-----------------------------------------
                CrearImpresion.EncabezadoTicket();
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    Ticket.TextLeft(" " + fila.Cells[0].Value.ToString());//Producto arriba descripcion abajo.

                    Ticket.AgregaArticulo(fila.Cells[6].Value.ToString() + " ", Convert.ToDecimal(fila.Cells[3].Value),
                        Convert.ToInt32(fila.Cells[2].Value), Convert.ToDecimal(fila.Cells[5].Value));
                }
            }
            catch{}
            finally { connect_BD.Close(); }

        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Interfaz_1 mainMenu = new Interfaz_1();
            mainMenu.Show();
            try
            {
                CrearImpresion.lineasSeparacion();
                Ticket.TextLeft("Total:         $ "+ totalText.Text);
                Ticket.TextLeft("Importe:     $ "+ importeText.Text);
                Ticket.TextLeft("Cambio:    "+ cambioText.Text);
                CrearImpresion.lineasSeparacion();//-----------------------------------------
                Ticket.TextoCentro("*Gracias por preferirnos*");
                CrearImpresion.lineasSeparacion();//-----------------------------------------
                Ticket.ImprimirTiket();
            }
            catch (Exception)
            {

            }

            this.Close();
        }
    }
}
