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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }


        DataTable TablaInventario = new DataTable();

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
        //Boton de actualizar
        private void button1_Click(object sender, EventArgs e)
        {
            InsertarProductos();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_1 MainMenu = new Interfaz_1();
            MainMenu.Show(); 
        }
        public void InsertarProductos()
        {
            SqlConnection conexion_BD = BDConnect.connection();
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                SqlCommand InsertarInventario = new SqlCommand("RegistrarProducto", conexion_BD);
                InsertarInventario.CommandType = CommandType.StoredProcedure;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fila.Cells[6].Value != null && fila.Cells[7].Value != null && fila.Cells[8].Value != null)
                    {

                        InsertarInventario.Parameters.AddWithValue("@id_pro", fila.Cells["Codigo"].Value.ToString().Replace(" ",String.Empty).Trim());
                        InsertarInventario.Parameters.AddWithValue("@name_pro", fila.Cells["nombre_producto"].Value.ToString().Trim());
                        InsertarInventario.Parameters.AddWithValue("@cantidad", Convert.ToInt32(fila.Cells["cantidad_producto"].Value));
                        InsertarInventario.Parameters.AddWithValue("@precio", fila.Cells["precio_producto"].Value);
                        InsertarInventario.Parameters.AddWithValue("@modelo", fila.Cells["model_producto"].Value.ToString().Trim());
                        InsertarInventario.Parameters.AddWithValue("@tipo", fila.Cells["tipo_producto"].Value.ToString().Trim());
                        InsertarInventario.Parameters.AddWithValue("@talla", fila.Cells["talla_producto"].Value);
                        InsertarInventario.Parameters.AddWithValue("@departamento", fila.Cells["depto_producto"].Value);
                        InsertarInventario.Parameters.AddWithValue("@descuento", fila.Cells["descuento_produc"].Value);
                        InsertarInventario.Parameters.AddWithValue("@fecha_ingr", Convert.ToDateTime(dateTimePicker1.Text));

                        InsertarInventario.ExecuteNonQuery();//->Ejecuta el procedimiento por cada linea.
                        InsertarInventario.Parameters.Clear();//->limpia los parametros de cada fila.
                    }
                    else{
                        MessageBox.Show("Asegurese de llenar todos los campos", "ERROR CON LA INSERCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                DialogResult respuesta = MessageBox.Show("Productos Guardados Exitosamente", "OPERACION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (respuesta == DialogResult.OK)
                {
                    dataGridView1.AllowUserToAddRows = true;
                    dataGridView1.Rows.Clear();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion_BD.Close(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            this.Refresh();
        }
    }
}
