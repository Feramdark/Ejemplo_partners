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
    public partial class lista_apartados : Form
    {
        public lista_apartados()
        {
            InitializeComponent();
        }
        CrearImpresion CrearImpresion = new CrearImpresion();
        private void showAps(object sender, EventArgs e)
        {
            SqlConnection con = BDConnect.connection();  
            apartados aps = new apartados();
            tableApartados.DataSource=aps.listaApartados(con);
        }

        private void GetInfoClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = BDConnect.connection();
            apartados aps = new apartados();
            if (e.RowIndex>=0)
            {
                try
                {
                    DataGridViewRow fila = tableApartados.Rows[e.RowIndex];
                    nameClient.Text = fila.Cells[2].Value.ToString();
                    idApartLabel.Text = fila.Cells[0].Value.ToString();
                    montoTotaltxt.Text = fila.Cells[7].Value.ToString();
                    idClientLabel.Text = fila.Cells[1].Value.ToString();
               

                    string idCliente = idClientLabel.Text;
                    listaPagos.DataSource = aps.listaPagos(con,idCliente);
                    listaProductosCliente.DataSource = aps.listaProductosApartados(con, idCliente);

                    /*float val = Convert.ToSingle(montoTotaltxt.Text);
                    comparaPrecioPts(val);*/
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.Message);
                }
            }
        }

        private void comparaPrecioPts(float restante)
        {
            float precio_producto;
            foreach(DataGridViewRow mifila in listaProductosCliente.Rows)
            {
                precio_producto = Convert.ToSingle(mifila.Cells[2].Value);
                if (precio_producto<restante)
                {
                    mifila.DefaultCellStyle.BackColor = Color.MediumSpringGreen;
                }
                else
                {
                    mifila.DefaultCellStyle.BackColor = Color.Transparent;
                }

            }
        }

        private void addQuantity(object sender, EventArgs e)
        {
            cajaAbonotxt.Text = cajaPagotxt.Text;
        }

        private void operationKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                apartados ap = new apartados();
                float importe = float.Parse(cajaPagotxt.Text);
                float abono = float.Parse(cajaAbonotxt.Text);
                float total = float.Parse(montoTotaltxt.Text);
                //restante= total-abono 


                pagoClienteLabel.Text = importe.ToString();
                abonoLabel.Text = abono.ToString();
                cambioLabel.Text = Convert.ToString(resta(importe,abono));

                if (abono >= total)
                {
                    restanteLabel.Text = Convert.ToString(resta(abono, total));
                    cambioLabel.Text = Convert.ToString(resta(abono, total));

                    SqlConnection con = BDConnect.connection();


                    float restante = float.Parse(restanteLabel.Text);
                    int idApart = Convert.ToInt32(idApartLabel.Text);
                    int idClie = Convert.ToInt32(idClientLabel.Text);
                    float restAnt = float.Parse(montoTotaltxt.Text);//restante Anterior
                    float pagoNvo = float.Parse(cajaAbonotxt.Text);
                    float debe = restante;
                    string fecha = dateTimePicker1.Text;

                    if (restante <= total)
                    {
                        bool update = ap.ActualizarRestante(con, restante.ToString(), abonoLabel.Text, idApartLabel.Text);
                        bool insert = ap.RegistraPgo(con, idApart, idClie, restAnt, pagoNvo, debe, fecha);
                        if (insert && update)
                        {
                            restanteLabel.Text = "" + 0;
                            MessageBox.Show("Apartado liquidado");
                            tableApartados.DataSource = ap.listaApartados(con);

                        }

                        /*imprimirComprobante();
                        CrearImpresion.ImprimirTiket();*/

                        //update tabla productos resta cantidad del producto a el producto
                        //delete apartado x id
                        //delete pagos x id
                        //imprimir ticket
                    }
                    else if (restante>=total)
                    {
                        bool update = ap.ActualizarRestante(con, restante.ToString(), abonoLabel.Text, idApartLabel.Text);
                        bool insert = ap.RegistraPgo(con, idApart, idClie, restAnt, pagoNvo, debe, fecha);

                        if (insert && update)
                        {
                            restanteLabel.Text = "" + 0;
                            MessageBox.Show("Apartado liquidado");
                            tableApartados.DataSource = ap.listaApartados(con);
                        }

                        /*imprimirComprobante();
                        CrearImpresion.ImprimirTiket();*/
                    }

                }
                else if (abono <= total)
                {

                    restanteLabel.Text = Convert.ToString(resta(total,abono));
                    float restante = float.Parse(restanteLabel.Text);
                    //variables insertar
                    int idApart = Convert.ToInt32(idApartLabel.Text);
                    int idClie = Convert.ToInt32(idClientLabel.Text);
                    float restAnt = float.Parse(montoTotaltxt.Text);//restante Anterior
                    float pagoNvo = float.Parse(cajaAbonotxt.Text);
                    float debe = restante;
                    string fecha = dateTimePicker1.Text;

                    SqlConnection con = BDConnect.connection();

                    if (restante < total)
                    {
                        try
                        {
                            bool update = ap.ActualizarRestante(con,restante.ToString(),abonoLabel.Text,idApartLabel.Text);
                            bool insert = ap.RegistraPgo(con, idApart, idClie, restAnt, pagoNvo, debe, fecha);
                            if (update && insert)
                            {
                                MessageBox.Show("Actualizacion Exitosa","PAGO REGISTRADO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                tableApartados.DataSource = ap.listaApartados(con);

                            }
                            else MessageBox.Show(insert.ToString());


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        //registrar el pago
                    }
                }
            }
        }
        private float resta(float a,float b)
        {
            float resultado = a - b;
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
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextoCentro("Comprobante de Abono");
            CrearImpresion.TextoCentro("Fecha: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            CrearImpresion.TextLeft("Nombre: " + nameClient.Text + " "+"Folio: "+ idApartLabel.Text);
            
            CrearImpresion.lineasSeparacion();
            CrearImpresion.EncabezadoApartar();//---------------------------------------------------------------------

            /*foreach (DataGridViewRow celda in tablaProductos.Rows)
            {
                CrearImpresion.TextLeft(celda.Cells[2].Value.ToString());
                CrearImpresion.AgregaArticulo(celda.Cells[0].Value.ToString() + " ",
                    Convert.ToDecimal(celda.Cells[3].Value), Convert.ToInt32(celda.Cells[1].Value), Convert.ToDecimal(importe.Text));

            }*/
            CrearImpresion.lineasSeparacion();//----------------------------------------------------------
            CrearImpresion.TextLeft("Pago: $" + pagoClienteLabel.Text);
            CrearImpresion.TextLeft("Usted abono: $" + abonoLabel.Text);
            CrearImpresion.TextLeft("Restan: $" + restanteLabel.Text);
            CrearImpresion.TextLeft("Cambio: $" + cambioLabel.Text);
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextoCentro("Apartado a un mes de plazo");
            CrearImpresion.TextoCentro("No se aceptan cambios en apartado");
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextoCentro("****Gracias por su compra****");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            apartados ap = new apartados();
            float importe = float.Parse(cajaPagotxt.Text);
            float abono = float.Parse(cajaAbonotxt.Text);
            float total = float.Parse(montoTotaltxt.Text);
            //restante= total-abono 


            pagoClienteLabel.Text = importe.ToString();
            abonoLabel.Text = abono.ToString();
            cambioLabel.Text = Convert.ToString(resta(importe, abono));

            if (abono >= total)
            {
                restanteLabel.Text = Convert.ToString(resta(abono, total));
                cambioLabel.Text = Convert.ToString(resta(abono, total));

                SqlConnection con = BDConnect.connection();


                float restante = float.Parse(restanteLabel.Text);
                int idApart = Convert.ToInt32(idApartLabel.Text);
                int idClie = Convert.ToInt32(idClientLabel.Text);
                float restAnt = float.Parse(montoTotaltxt.Text);//restante Anterior
                float pagoNvo = float.Parse(cajaAbonotxt.Text);
                float debe = restante;
                string fecha = dateTimePicker1.Text;

                if (restante <= total)
                {
                    bool update = ap.ActualizarRestante(con, restante.ToString(), abonoLabel.Text, idApartLabel.Text);
                    bool insert = ap.RegistraPgo(con, idApart, idClie, restAnt, pagoNvo, debe, fecha);
                    if (insert && update)
                    {
                        restanteLabel.Text = "" + 0;
                        MessageBox.Show("Apartado liquidado");
                        tableApartados.DataSource = ap.listaApartados(con);

                    }

                    /*imprimirComprobante();
                    CrearImpresion.ImprimirTiket();*/

                    //update tabla productos resta cantidad del producto a el producto
                    //delete apartado x id
                    //delete pagos x id
                    //imprimir ticket
                }
                else if (restante >= total)
                {
                    bool update = ap.ActualizarRestante(con, restante.ToString(), abonoLabel.Text, idApartLabel.Text);
                    bool insert = ap.RegistraPgo(con, idApart, idClie, restAnt, pagoNvo, debe, fecha);

                    if (insert && update)
                    {
                        restanteLabel.Text = "" + 0;
                        MessageBox.Show("Apartado liquidado");
                        tableApartados.DataSource = ap.listaApartados(con);
                    }

                    /*imprimirComprobante();
                    CrearImpresion.ImprimirTiket();*/
                }

            }
            else if (abono <= total)
            {

                restanteLabel.Text = Convert.ToString(resta(total, abono));
                float restante = float.Parse(restanteLabel.Text);
                //variables insertar
                int idApart = Convert.ToInt32(idApartLabel.Text);
                int idClie = Convert.ToInt32(idClientLabel.Text);
                float restAnt = float.Parse(montoTotaltxt.Text);//restante Anterior
                float pagoNvo = float.Parse(cajaAbonotxt.Text);
                float debe = restante;
                string fecha = dateTimePicker1.Text;

                SqlConnection con = BDConnect.connection();

                if (restante < total)
                {
                    try
                    {
                        bool update = ap.ActualizarRestante(con, restante.ToString(), abonoLabel.Text, idApartLabel.Text);
                        bool insert = ap.RegistraPgo(con, idApart, idClie, restAnt, pagoNvo, debe, fecha);
                        if (update && insert)
                        {
                            MessageBox.Show("Actualizacion Exitosa", "PAGO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tableApartados.DataSource = ap.listaApartados(con);

                        }
                        else MessageBox.Show(insert.ToString());


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //registrar el pago
                }
            }
            /*imprimirComprobante();
            CrearImpresion.ImprimirTiket();*/
        }
    }
}
