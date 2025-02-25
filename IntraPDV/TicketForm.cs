﻿using System;
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
        Conversion con = new Conversion();
        public TicketForm()
        {
            InitializeComponent();
        }
        string numero_letra ="";
        int productos = 0;
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
                // Cortamos codigo porque esta parte no se porque no jala :(

                Ticket.TextLeft("          ");
                Ticket.TextLeft("          ");
                Ticket.TextoCentro("Velia Perez Zavala");
                Ticket.TextLeft("     R.F.C. PEZV-690103-270");
                Ticket.TextLeft("     Aquiles Serdan #105 OTE");
                Ticket.TextLeft("     Colonia Centro");
                Ticket.TextLeft("     Gpe. Victoria,DGO C.P 34700");
                Ticket.TextLeft("Folio: " + folioTick.Text);
                CrearImpresion.lineasSeparacion();//-----------------------------------------
                Ticket.TextoCentro("Fecha: " + DateTime.Today.Day+ "/" +DateTime.Today.Month+ "/" +DateTime.Today.Year);
                Ticket.TextLeft(" Hora:       " + horaText.Text);
                Ticket.TextLeft(" Le atendio:   " + "Fam: Rocha Pérez");
                CrearImpresion.lineasSeparacion();//-----------------------------------------
                CrearImpresion.EncabezadoTicket();
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    int desc = Convert.ToInt32(fila.Cells[5].Value);

                    if (desc == 0)
                    {
                        Ticket.TextLeft(fila.Cells[0].Value.ToString());
                        Ticket.TextLeft(fila.Cells[1].Value.ToString());
                        Ticket.TextLeft("                 " + "      " + fila.Cells[3].Value.ToString() + "      " + fila.Cells[4].Value.ToString() + "      " + fila.Cells[7].Value.ToString());
                    }
                    else
                    {
                        Ticket.TextLeft(fila.Cells[0].Value.ToString());
                        Ticket.TextLeft(fila.Cells[1].Value.ToString() + "  -" + fila.Cells[5].Value.ToString()+" %");
                        Ticket.TextLeft("                        "+"p.u $"+fila.Cells[4].Value.ToString() + "   -" + fila.Cells[6].Value.ToString());//total-descuento
                        Ticket.TextLeft("                 " + "      " + fila.Cells[3].Value.ToString() + "      " + fila.Cells[4].Value.ToString() + "      " + fila.Cells[7].Value.ToString());
                    }

                }
        
                }
            catch{}
            finally { connect_BD.Close(); }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MyTicket();
            Interfaz_1 mainMenu = new Interfaz_1();
            mainMenu.Show();
            try
            {
                numero_letra = totalText.Text;
                CrearImpresion.lineasSeparacion();
                Ticket.TextLeft("N° articulos: " + numProd.Text);
                Ticket.TextoDerecha("  Total:   $" + totalText.Text);
                Ticket.TextoDerecha("Pago:  $"+ importeText.Text);
                Ticket.TextoDerecha("Cambio: "+ cambioText.Text);
                Ticket.TextLeft("("+con.enletras(numero_letra).ToLower());
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

        private void cancelPrint_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Interfaz_1 mainInterfaz = new Interfaz_1();
            mainInterfaz.Show();
        }
    }
}
