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
    
    public partial class Registrar_producto : Form
    {
        CrearImpresion ticket = new CrearImpresion();
        public Registrar_producto()
        {
            InitializeComponent();
            todos();
            toolTip1.SetToolTip(this.textoDescuento, "Inserte el descuento a el producto seleccionado");
            toolTip1.SetToolTip(this.codigoBarras, "Busque un producto");
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
        }

        private void buscarCodigo(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                buscarPorCode(codigoBarras.Text);
            }
        }
        
        private void buscarPorCode(string codigoProd)
        {
            try
            {
                SqlConnection conectar = BDConnect.connection();
                SqlCommand buscar = new SqlCommand("buscarCodigo", conectar);

                buscar.CommandType = CommandType.StoredProcedure;

                buscar.Parameters.AddWithValue("@codigo", codigoProd);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable inventario = new DataTable();
                adaptador.SelectCommand = buscar;
                adaptador.Fill(inventario);
                dataGridView1.DataSource = inventario;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void todos()
        {
            SqlConnection connection = BDConnect.connection();
            try
            {
                SqlCommand giveAllItems = new SqlCommand("consultaProductos", connection);
                giveAllItems.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable inventario = new DataTable();
                adapter.SelectCommand = giveAllItems;
                adapter.Fill(inventario);
                dataGridView1.DataSource = inventario;
                giveAllItems.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }
        }
        private void actualizarDescuento(string codigoProducto,int descuentoNuevo)
        {
            try
            {
                SqlConnection conectar = BDConnect.connection();
                SqlCommand actDesc = new SqlCommand("actualDesc", conectar);
                actDesc.CommandType = CommandType.StoredProcedure;

                //parametros
                actDesc.Parameters.AddWithValue("@codigo", codigoProducto);
                actDesc.Parameters.AddWithValue("@descuento", descuentoNuevo);
                actDesc.ExecuteNonQuery();
                MessageBox.Show("Descuento Actualizado");
                conectar.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void actualizarCantidad(string codigo,int nuevaCantidad)
        {
            try
            {
                SqlConnection conectar = BDConnect.connection();
                SqlCommand actDesc = new SqlCommand("actualizarCant", conectar);
                actDesc.CommandType = CommandType.StoredProcedure;

                //parametros
                actDesc.Parameters.AddWithValue("@codigo", codigo);
                actDesc.Parameters.AddWithValue("@cantidad", nuevaCantidad);
                actDesc.ExecuteNonQuery();
                MessageBox.Show("Cantidad Actualizada");
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void actualizaPrecio(string codigo, decimal nuevaCantidad)
        {
            try
            {
                SqlConnection conectar = BDConnect.connection();
                SqlCommand actDesc = new SqlCommand("actualizaProductos", conectar);
                actDesc.CommandType = CommandType.StoredProcedure;

                //parametros
                actDesc.Parameters.AddWithValue("@codigo", codigo);
                actDesc.Parameters.AddWithValue("@precio", nuevaCantidad);
                actDesc.ExecuteNonQuery();
                MessageBox.Show("Precio Actualizado");
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            if (codigoBarras.Text!="" && textoDescuento.Text !="")
            {
                actualizarDescuento(codigoBarras.Text, Int32.Parse(textoDescuento.Text));
                buscarPorCode(codigoBarras.Text);
            }
            if (codigoBarras.Text != "" && cantidadActual.Text != "")
            {
                actualizarCantidad(codigoBarras.Text, Int32.Parse(cantidadActual.Text));
                buscarPorCode(codigoBarras.Text);
            }
            if(codigoBarras.Text!="" && precioNuevo.Text != "")
            {
                actualizaPrecio(codigoBarras.Text, Convert.ToDecimal(precioNuevo.Text));
                buscarPorCode(codigoBarras.Text);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigoBarras.Clear();
            cantidadActual.Clear();
            textoDescuento.Clear();
            precioNuevo.Clear();
        }

        private void buscarDescr(string descripcion)
        {
            SqlConnection conectar = BDConnect.connection();
            try
            {

                SqlCommand busca = new SqlCommand("buscaProducto", conectar);
                busca.CommandType = CommandType.StoredProcedure;
                busca.Parameters.AddWithValue("@producto", textBox1.Text);

                DataTable tabla = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = busca;
                adp.Fill(tabla);
                dataGridView1.DataSource = tabla;
                busca.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conectar.Close();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                buscarDescr(textBox1.Text);
            }
            else
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }
    }
}
