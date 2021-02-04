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
        static string numeroFolio = "";
        CrearImpresion Ticket = new CrearImpresion();
        Conversion con = new Conversion();
        public TicketForm()
        {
            InitializeComponent();
        }
        string numero_letra ="";
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
                Ticket.TextLeft(" Colonia Centro");
                Ticket.TextLeft(" Gpe. Victoria,DGO C.P 34700");
                CrearImpresion.lineasSeparacion();//-----------------------------------------
                Ticket.TextLeft("Folio: " + folioTick.Text);
                Ticket.TextoCentro("Fecha: " + DateTime.Today.Day+ "/" +DateTime.Today.Month+ "/" +DateTime.Today.Year);
                Ticket.TextLeft(" Hora:       " + horaText.Text);
                Ticket.TextLeft(" Le atendio:    " + "Fam: Rocha Pérez");
                CrearImpresion.lineasSeparacion();//-----------------------------------------
                CrearImpresion.EncabezadoTicket();

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    Ticket.TextLeft(fila.Cells[1].Value.ToString()+" T: "+ fila.Cells[9].Value.ToString());//Producto arriba descripcion abajo.
                    numeroFolio = Convert.ToString(fila.Cells[8].Value);
                    //Ticket.TextLeft("Desc: "+fila.Cells[5].Value.ToString());
                    //Cabecera -> Codigo producto   Cantidad    Precio   Total.
                    Ticket.AgregaArticulo(fila.Cells[0].Value.ToString() + " ", Convert.ToDecimal(fila.Cells[4].Value),
                        Convert.ToInt32(fila.Cells[3].Value), Convert.ToDecimal(fila.Cells[7].Value));
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
                numero_letra = totalText.Text;
                CrearImpresion.lineasSeparacion();
                Ticket.TextoDerecha("Total: $" + totalText.Text);
                Ticket.TextoDerecha("Pago: $"+ importeText.Text);
                Ticket.TextoDerecha("Cambio: "+ cambioText.Text);
                Ticket.TextLeft(con.enletras(numero_letra).ToUpper());
                CrearImpresion.lineasSeparacion();//-----------------------------------------
                Ticket.TextoCentro("¡Gracias por su compra!");
                CrearImpresion.lineasSeparacion();//-----------------------------------------
                Ticket.ImprimirTiket();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
