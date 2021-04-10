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
            toolTip1.SetToolTip(this.textBox1, "Inserte el nombre del producto");
            toolTip1.SetToolTip(this.codigoBarras, "Busque un producto");

            //Se llena la lista de departamentos
            llenarLista();
            contadores();

            /*int valores = dataGridView1.RowCount;
            label1.Text = valores.ToString();*/
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
            SqlConnection conectar = BDConnect.connection();
            try
            {
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
                conectar.Close();
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { connection.Close(); }
        }


        private void actualizarDescuento(string codigoProducto,int descuentoNuevo)
        {
            SqlConnection conectar = BDConnect.connection();
            try
            {
                SqlCommand actDesc = new SqlCommand("actualDesc", conectar);
                actDesc.CommandType = CommandType.StoredProcedure;

                //parametros
                actDesc.Parameters.AddWithValue("@codigo", codigoProducto);
                actDesc.Parameters.AddWithValue("@descuento", descuentoNuevo);
                actDesc.ExecuteNonQuery();
                MessageBox.Show("Descuento Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {conectar.Close();}
        }
        private void actualizarCantidad(string codigo,int nuevaCantidad)
        {
            SqlConnection conectar = BDConnect.connection();
            try
            {
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
            finally { conectar.Close(); }
        }
        private void actualizaPrecio(string codigo, decimal nuevaCantidad)
        {
            SqlConnection conectar = BDConnect.connection();
            try
            {
                SqlCommand actDesc = new SqlCommand("actualizaProductos", conectar);
                actDesc.CommandType = CommandType.StoredProcedure;

                //parametros
                actDesc.Parameters.AddWithValue("@codigo", codigo);
                actDesc.Parameters.AddWithValue("@precio", nuevaCantidad);
                actDesc.ExecuteNonQuery();
                MessageBox.Show("Precio Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally{ conectar.Close();}
        }
        private void actualizarNombre(string codigo, string nombreNew, string modelo) {

            SqlConnection conectar = BDConnect.connection();
            try
            {
                SqlCommand cmd = new SqlCommand(string.Format("update productos set nombre = '{0}', modelo = '{1}' where codigo_barras = '{2}'",
                    new string[] { nombreNew, modelo, codigo}), conectar);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Los datos han sido actualizados", "Informacion Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conectar.Close(); }
        }

        private void eliminarProducto(string code)
        {
            SqlConnection con = BDConnect.connection();
            try
            {
                SqlCommand cmd = new SqlCommand(string.Format("DELETE FROM productos WHERE codigo_barras = '{0}'", code), con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Los datos se han removido del sistema", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            if (groupUpdate.Enabled == true)
            {
                if (codigoBarras.Text != "" && textoDescuento.Text != "")
                {
                    actualizarDescuento(codigoBarras.Text, Int32.Parse(textoDescuento.Text));
                    buscarPorCode(codigoBarras.Text);
                    textoDescuento.Clear();
                }
                if (codigoBarras.Text != "" && cantidadActual.Text != "")
                {
                    actualizarCantidad(codigoBarras.Text, Int32.Parse(cantidadActual.Text));
                    buscarPorCode(codigoBarras.Text);
                    cantidadActual.Clear();
                }
                if (codigoBarras.Text != "" && precioNuevo.Text != "")
                {
                    actualizaPrecio(codigoBarras.Text, Convert.ToDecimal(precioNuevo.Text));
                    buscarPorCode(codigoBarras.Text);
                    precioNuevo.Clear();
                }
                if (codigoBarras.Text != "" && nombrePto.Text != "" && descPto.Text != "")
                {
                    string cd = codigoBarras.Text.Trim();
                    string nom = nombrePto.Text.Trim();
                    string mod = descPto.Text.Trim();

                    actualizarNombre(cd, nom, mod);
                    buscarPorCode(codigoBarras.Text);

                    codigoBarras.Clear();
                    nombrePto.Clear();
                    descPto.Clear();
                }
            }
            else
            {
                MessageBox.Show("Habilite los campos de Edicion","Imposible actualizar",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            codigoBarras.Clear();
            textBox1.Clear();
            cantidadActual.Clear();
            textoDescuento.Clear();
            precioNuevo.Clear();
            todos();
        }

        private void buscarDescr(string descripcion)
        {
            SqlConnection conectar = BDConnect.connection();
            try
            {
                SqlCommand busca = new SqlCommand("buscaProducto", conectar);
                busca.CommandType = CommandType.StoredProcedure;
                busca.Parameters.AddWithValue("@producto", descripcion);

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
            {conectar.Close();}
            contadores();
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void contadores()
        {
            float suma = 0.00F;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null) 
                    suma += Convert.ToSingle(row.Cells[3].Value); //incremento de la suma de todos los elementos que se encuentran es esa celda.
            }
            label1.Text = Convert.ToString(suma);//Cantidad total de la suma de todos los elementos
        }

        private List<string> showDeptos()
        {
            List<string> vs = new List<string>();//lista para regresar lo leido
            try
            {
                SqlConnection con = BDConnect.connection();
                SqlCommand cmd = new SqlCommand("select distinct departamento from productos", con);
                SqlDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    vs.Add(lector.GetString(0).ToUpper());
                }
                lector.Close();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return vs;
            /*DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(cmd,con);
            ad.Fill(ds,"depto");
            con.Close();

            dptos.DataSource = ds.Tables[0].DefaultView;
            dptos.Items.ToString().ToUpper();
            dptos.ValueMember = "departamento";*/
        }
        private void llenarLista()
        {
            List<string> deptos = showDeptos();

            foreach (string item in deptos)
            {
                dptos.Items.Add(item.ToString().ToUpper());
            }
        }

        private void add_click(object sender, DataGridViewCellEventArgs e)
        {
            // evento para añadir valores de la fila en campos editables 
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                    codigoBarras.Text = Convert.ToString(fila.Cells[0].Value);
                    nombrePto.Text = Convert.ToString(fila.Cells[2].Value);
                    descPto.Text = Convert.ToString(fila.Cells[4].Value);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void delete_pro_Click(object sender, EventArgs e)
        {
            string codigo = codigoBarras.Text;
            DialogResult result;
            result=MessageBox.Show("Esta a punto de eliminar uno o varios productos \n ¿Desea continuar con la operacion?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result==DialogResult.Yes)
            {
                eliminarProducto(codigo.Trim());
            }
        }

        private void search_click(object sender, EventArgs e)
        {
            string departamento = dptos.SelectedItem.ToString();

            if (departamento != null)
            {
                SqlConnection con = BDConnect.connection();
                try
                {
                    SqlCommand cmd = new SqlCommand("buscarDpto", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@depto", departamento);
                    SqlDataAdapter adap = new SqlDataAdapter();
                    DataTable data = new DataTable();

                    adap.SelectCommand = cmd;
                    adap.Fill(data);
                    dataGridView1.DataSource = data;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }
            }
        }

        private void habilitar(object sender, EventArgs e)
        {
            if (editCheck.Checked)
            {
                groupUpdate.Enabled = true;
            }
            else if (!editCheck.Checked)
            {
                groupUpdate.Enabled = false;
            }
        }
    }
}
