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
    public partial class venta : Form
    {
        
        public venta()
        {
            InitializeComponent();
            textBox3.Text = "1234";
            
        }

        SqlConnection con = BDConnect.connection();
        DataTable tabDatos = new DataTable();

       /* private void button1_Click(object sender, EventArgs e)
        {
            Cobro cobro = new Cobro();
            cobro.textBox1.Text = textBox2.Text;
            cobro.Show();

            //RegistraVenta();
            //ActualizarInventario();
        }*/

        public void reg()
        {
           
            DataGridViewRow row = new DataGridViewRow();
            bool flag = false;
            SqlCommand datos = new SqlCommand("consulta", con);
            datos.CommandType = CommandType.StoredProcedure;
            datos.Parameters.AddWithValue("@codigo",textBox1.Text);
            datos.Parameters.AddWithValue("@cantidad", 1);
            
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    
                    if (fila.Cells[0].Value.ToString() == textBox1.Text)
                    {
                        int cant = Convert.ToInt32(fila.Cells[5].Value);
                        float precio = Convert.ToSingle(fila.Cells[3].Value);
                        float descuento = Convert.ToSingle(fila.Cells[4].Value);
                        float total = Convert.ToSingle(fila.Cells[6].Value);               
      ///////////////////////////////////////////////////////////////////////
                        cant = cant + 1;
                        total = (precio - ((precio * descuento) / 100)) * cant;
                        fila.Cells[5].Value = cant;
                        fila.Cells[6].Value = total;
                        
                        flag = true;
                        
                    }
                }

            }
            if (flag == false) {
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = datos;
            tabDatos.Rows.Count.ToString();
            sda.Fill(tabDatos);
            dataGridView1.DataSource = tabDatos;

            }

        }

        public void RegistraVenta()
        {
            try
            {
                SqlCommand regVen = new SqlCommand("GuardarVenta", con);
                regVen.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    regVen.Parameters.Clear();

                    regVen.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dateTimePicker1.Text));
                    regVen.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells[5].Value));
                    regVen.Parameters.AddWithValue("@total", Convert.ToDouble(row.Cells[6].Value));
                    regVen.Parameters.AddWithValue("@id_producto", Convert.ToString(row.Cells[0].Value));
                    regVen.Parameters.AddWithValue("@id_empleado", textBox3.Text);
                    regVen.Parameters.AddWithValue("@hora", Convert.ToDateTime(hora.Text));
                    regVen.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                DialogResult respuesta = MessageBox.Show("Venta Realizada","Ropa y Calzado Rocha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (respuesta == DialogResult.Yes)
                {
                    dataGridView1.Rows.Clear();
                }

            }
              
            
        }


        public void ActualizarInventario()
        {
            try
            {
                SqlCommand update = new SqlCommand("BajaInventario", con);
                update.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    update.Parameters.Clear();
                    update.Parameters.AddWithValue("@codigo", Convert.ToString(row.Cells[0].Value));
                    update.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells[5].Value));
                    update.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                reg();
                total();
                textBox1.Text = "";
            }
        }

        public void total()
        {

            float suma = 0.00F;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null) //1 es "Total"
                    suma += Convert.ToSingle(row.Cells[6].Value);
                //dataGridView1.Columns[3].DefaultCellStyle.Format = "#.#";
                //dataGridView1.Columns[6].DefaultCellStyle.Format = "#.#";
            }


            //textBox2.Text = Convert.ToString(suma);
            tottal.Text = Convert.ToString(suma);

        }

        public void cambio()
        {
            decimal efectivo;
            decimal total;
            decimal cambio;

            if (tottal.Text != "")
            {
                efectivo = Convert.ToDecimal(pago.Text);
                total = Convert.ToDecimal(tottal.Text);
                cambio = efectivo - total;
                cambbio.Text = Convert.ToString(cambio);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            float suma = 0.00F;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null) //1 es "Total"
                    suma += Convert.ToSingle(row.Cells[6].Value);
                //dataGridView1.Columns[3].DefaultCellStyle.Format = "#.#";
                //dataGridView1.Columns[6].DefaultCellStyle.Format = "#.#";
            }


            tottal.Text = Convert.ToString(suma);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cambio();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Realizar la Siguiente Venta", "Ropa y Calzado Rocha", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ActualizarInventario();
                RegistraVenta();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report_ventaDiaria report = new report_ventaDiaria();
            report.Show();
        }


        public void regresa_producto()
        {
            try
            {
                SqlCommand regresa_producto = new SqlCommand("regresa_inventario",con);
                regresa_producto.CommandType = CommandType.StoredProcedure;
                regresa_producto.Parameters.AddWithValue("@producto", devolucion.Text);
                regresa_producto.ExecuteNonQuery();

                if (devolucion.Text != "")
                {
                    regresa_producto.ExecuteNonQuery();
                    MessageBox.Show("Devolucion Completada");
                }
                else
                {
                    MessageBox.Show("Error no hay articulo ingresado");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // utilizo el foreach para iterar los registros.
                // con el metodo de RemoveAt. le mando el indice del elemento a eliminar
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
            
        }

        private void devolucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {

                        if (fila.Cells[0].Value.ToString() == devolucion.Text)
                        {
                            int cant = Convert.ToInt32(fila.Cells[5].Value);
                            float precio = Convert.ToSingle(fila.Cells[3].Value);
                            float descuento = Convert.ToSingle(fila.Cells[4].Value);
                            float total = Convert.ToSingle(fila.Cells[6].Value);
                            ///////////////////////////////////////////////////////////////////////
                            cant = cant - 1;
                            total = (precio - ((precio * descuento) / 100)) * cant;
                            fila.Cells[5].Value = cant;
                            fila.Cells[6].Value = total;
                            devolucion.Text = "";
                        }
                    }
                }

            }
        }
    }
        
}

