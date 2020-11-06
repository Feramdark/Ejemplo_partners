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
                Ticket.TextoCentro("Ropa y Calzado Rocha");
                CrearImpresion.EncabezadoTicket();
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    Ticket.AgregaArticulo(fila.Cells[0].Value.ToString(), Convert.ToDecimal(fila.Cells[2].Value), Convert.ToInt32(fila.Cells[1].Value),
                        Convert.ToDecimal(fila.Cells[4].Value));
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Interfaz_1 mainMenu = new Interfaz_1();
            mainMenu.Show();
            this.Close();
            try
            {
                Ticket.TextoCentro("Ropa y Calzado Rocha ");

                CrearImpresion.lineasSeparacion();
                Ticket.ImprimirTiket();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
