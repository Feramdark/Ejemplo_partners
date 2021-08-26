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
            folioTexto.Text = UltimoFolio();
            
        }
        bool flag = false;
        CrearImpresion CrearImpresion = new CrearImpresion();
        private void showAps(object sender, EventArgs e)
        {
            SqlConnection con = BDConnect.connection();
            apartados aps = new apartados();
            tableCuentas.DataSource = aps.listaApartados(con);
        }
        private float sumaAbonos()
        {
            float resultado = 0.00F;
            foreach (DataGridViewRow fila in listaPagos.Rows)
            {
                resultado += Convert.ToSingle(fila.Cells[3].Value);
            }
            labelSumaPagos.Text = resultado.ToString();
            return resultado;
        }

        private void GetInfoClick(object sender, DataGridViewCellEventArgs e) //Tabla principal de las cuentas
        {
            SqlConnection con = BDConnect.connection();
            apartados aps = new apartados();
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow fila = tableCuentas.Rows[e.RowIndex];
                    nameClient.Text = fila.Cells[2].Value.ToString();
                    idApartLabel.Text = fila.Cells[0].Value.ToString();
                    montoTotaltxt.Text = fila.Cells[7].Value.ToString();
                    idClientLabel.Text = fila.Cells[1].Value.ToString();

                    labelAnticipo.Text = fila.Cells[5].Value.ToString();
                    total_deuda.Text = fila.Cells[4].Value.ToString();


                    string fechaApartado = fila.Cells[8].Value.ToString();

                    DateTime fechaVence = DateTime.Parse(fechaApartado).AddMonths(1);



                    fechaApartadoText.Text = fila.Cells[8].Value.ToString();
                    fechaVencimiento.Text = fechaVence.ToString();
                    


                    string idCliente = idClientLabel.Text;
                    listaPagos.DataSource = aps.listaPagos(con, idCliente);
                    listaProductosCliente.DataSource = aps.listaProductosApartados(con, idCliente);

                    float anticipo = Convert.ToSingle(labelAnticipo.Text);
                    sumaAbonos();

                    float res =  anticipo + sumaAbonos();
                    labelMontoAbonado.Text = res.ToString();

                    marcarColores(res);

                    /*if (comparaPrecioPts(res))
                    {
                        MessageBox.Show("El producto " + nombreAentregar.ToUpper() + "\n puede ser entregado." );
                    }
                    else
                    {
                        MessageBox.Show("No hay ningun producto a entregar");
                    }*/
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.Message);
                }
            }
        }

        string nombreAentregar = "";
        private bool comparaPrecioPts(float restante)
        {
            float precio_producto =0;
            foreach (DataGridViewRow mifila in listaProductosCliente.Rows)
            {
                precio_producto = Convert.ToSingle(mifila.Cells[2].Value);
                nombreAentregar  += (mifila.Cells[1].Value.ToString());
                if (restante >= precio_producto)
                {
                    return true;

                    //entregarProducto.Visible = true;
                }
                else
                {
                    return false;
                    //entregarProducto.Visible = false;
                    //MessageBox.Show("No cumple con el monto  del producto");
                }

            }
            return false;
        }
        private void marcarColores(float restante)
        {
            float precio_producto = 0;
            foreach (DataGridViewRow mifila in listaProductosCliente.Rows)
            {
                precio_producto = Convert.ToSingle(mifila.Cells[3].Value);

                if (restante >= precio_producto)
                {
                    mifila.DefaultCellStyle.BackColor = Color.Aquamarine;
                    entregarProducto.Visible = true;
                }
                else
                {
                    mifila.DefaultCellStyle.BackColor = Color.White;
                    entregarProducto.Visible = false;
                }

            }
            
        }
        private void addQuantity(object sender, EventArgs e)
        {
            cajaAbonotxt.Text = cajaPagotxt.Text;
        }

        private void operationKeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private float resta(float a, float b)
        {
            float resultado = a - b;
            return resultado;
        }
        private void imprimirComprobante()
        {
            CrearImpresion.TextLeft("          ");
            CrearImpresion.TextLeft("          ");
            CrearImpresion.TextoCentro("Velia Perez Zavala");
            CrearImpresion.TextLeft("     R.F.C. PEZV-690103-270");
            CrearImpresion.TextLeft("     Aquiles Serdan #105 OTE");
            CrearImpresion.TextLeft("     Colonia Centro");
            CrearImpresion.TextLeft("     Gpe. Victoria,DGO C.P 34700");
            CrearImpresion.lineasSeparacion();
            CrearImpresion.TextoCentro("Comprobante de Abono");
            CrearImpresion.TextoCentro("Fecha: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            CrearImpresion.TextLeft("Nombre: " + nameClient.Text + " " + "Folio: " + idApartLabel.Text);

            CrearImpresion.lineasSeparacion();
            //CrearImpresion.EncabezadoApartar();//---------------------------------------------------------------------

            /*foreach (DataGridViewRow celda in tablaProductos.Rows)
            {
                CrearImpresion.TextLeft(celda.Cells[2].Value.ToString());
                CrearImpresion.AgregaArticulo(celda.Cells[0].Value.ToString() + " ",
                    Convert.ToDecimal(celda.Cells[3].Value), Convert.ToInt32(celda.Cells[1].Value), Convert.ToDecimal(importe.Text));

            }*/
            if (flag)
            {
                CrearImpresion.TextLeft("Apartado finalizado");
            }
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
                        tableCuentas.DataSource = ap.listaApartados(con);
                        //bajaInventario(idproducto_label.Text,Convert.ToInt32(cantidadProductolabel.Text));
                        ap.eliminarPtoApartado(con, idPtoApartadoLabel.Text);

                        flag = true;

                    }

                    imprimirComprobante();
                    CrearImpresion.ImprimirTiket();

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
                        tableCuentas.DataSource = ap.listaApartados(con);
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
                            tableCuentas.DataSource = ap.listaApartados(con);

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
        private string UltimoFolio()
        {
            SqlConnection con = BDConnect.connection();
            SqlDataReader lector;
            SqlCommand folio = new SqlCommand("ultimoFolio", con);
            folio.CommandType = CommandType.StoredProcedure;
            try
            {
                lector = folio.ExecuteReader();
                if (lector.Read())
                {
                    return lector.GetInt32(0).ToString();
                }
                else { return null; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar" + ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }            
        }
        public void bajaInventario(string idpto,int cantidad) // elimina el producto segun la cantidad de este
        {
            SqlConnection con = BDConnect.connection();
            try
            {
                SqlCommand command = new SqlCommand("BajaInventario", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@codigo", idpto);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                int res = command.ExecuteNonQuery();

                if (res > 0)
                {
                    MessageBox.Show("OPERACION EXITOSA");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        int cant = 0;
        private void button3_Click(object sender, EventArgs e)//Boton para entregar el articulo
        {
            SqlConnection con = BDConnect.connection();
            apartados aps = new apartados();

            float abonoTotal = Convert.ToSingle(labelMontoAbonado.Text);
            float deuda = Convert.ToSingle(total_deuda.Text);

            string idProducto = idproducto_label.Text;
            cant = Convert.ToInt32(cantidadProductolabel.Text);

            if (cant != 0)
            {
                bajaInventario(idProducto, cant);
            }
            else
            {
                MessageBox.Show("Por favor seleccione el producto a entregar","INFORMACIÓN");
            }

            bool result = aps.eliminarPtoApartado(con, idPtoApartadoLabel.Text);

            if (result)
            {
                MessageBox.Show("CAMBIOS REALIZADOS CON EXITO");
            }

            listaPagos.DataSource = aps.listaPagos(con, idClientLabel.Text);
            listaProductosCliente.DataSource = aps.listaProductosApartados(con, idClientLabel.Text);

            int cantidad = 0;
            foreach(DataGridViewRow fila in listaProductosCliente.Rows)
            {
                cantidad += Convert.ToInt32(fila.Cells[2].Value);


            }
            DialogResult respuesta = MessageBox.Show("La cantidad de productos es de: " + cantidad);
            if (respuesta == DialogResult.Yes)
            {
                SqlConnection red = BDConnect.connection();
                bool voz = aps.actualizarCantidadProductos(red, cantidad, idClientLabel.Text);
                if (voz)
                {
                    MessageBox.Show("ACTUALIZO");
                }
                else
                {
                    MessageBox.Show("Pos nope :(");
                }
            }
            tableCuentas.DataSource = aps.listaApartados(con);

        }

        private void Getptos(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                try
                {
                    DataGridViewRow filaPts = listaProductosCliente.Rows[e.RowIndex];

                    idPtoApartadoLabel.Text = filaPts.Cells[0].Value.ToString(); // id del producto
                    idproducto_label.Text = filaPts.Cells[3].Value.ToString(); //codigo producto
                    cantidadProductolabel.Text = filaPts.Cells[2].Value.ToString(); // cantidad de producto a quitar

                    



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*restanteLabel.Text = "0.00";
            pagoClienteLabel.Text = "0.00";
            abonoLabel.Text = "0.00";
            cambioLabel.Text = "0.00";
            restanteLabel.Text = "0.00";
            montoTotaltxt.Text = "0.00";

            cajaPagotxt.Text = null;
            cajaAbonotxt.Text = null;*/


            apartados ap = new apartados();

            bool flag = ap.entreDosFechas(dateTimePicker1.Text, DateTime.Now.ToString());

            if (flag) MessageBox.Show("FUNCIONA EL COMPARADOR");
            else MessageBox.Show("NO FUNCIONA :(");
        }
    }
}
