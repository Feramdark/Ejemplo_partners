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
        
        public Registrar_producto()
        {
            InitializeComponent();
            //Interfaz_1 main_menu = new Interfaz_1();
            //main_menu.Hide();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*funcion_insercion(Bar_Code.Text, Name_Pro.Text, Tipo_Prod.Text, Model.Text, Talla_prod.Text, Dpto_gen.SelectedItem.ToString(),
                 Convert.ToInt32(Cant_pro.Text), Convert.ToDecimal(Precio_prod.Text));*/
            }
            catch
            {
                MessageBox.Show("Llene los campos antes de registrar el producto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        /*public void funcion_insercion(string code,string name_art,string tipo,string mod,string talla, string departamento,int cant=0,decimal price=0)
        {
            SqlConnection conectar_DB = BDConnect.connection();

            try
            {
               SqlCommand INSERT = new SqlCommand("RegistrarProducto", conectar_DB);
               INSERT.CommandType = CommandType.StoredProcedure;
                //Variables para guardar a los productos
                INSERT.Parameters.AddWithValue("@Art_id_pro", code);
                INSERT.Parameters.AddWithValue("@Art_cantidad", cant);
                INSERT.Parameters.AddWithValue("@Art_precio", price);
                INSERT.Parameters.AddWithValue("@Art_model", mod);
                INSERT.Parameters.AddWithValue("@Art_tipo", tipo);
                INSERT.Parameters.AddWithValue("@Art_talla", talla);
                INSERT.Parameters.AddWithValue("@Art_genre", departamento);
                INSERT.Parameters.AddWithValue("@Art_nombre",name_art);

                if (code.Length !=0 && name_art.Length >0 && tipo.Length > 0 && mod.Length >0 && talla.Length >0 && departamento.Length !=0)
                {
                    INSERT.ExecuteNonQuery();
                    MessageBox.Show("Producto guardado");
                }
            }
            catch
            {
                MessageBox.Show("No se han podido insertar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar_DB.Close();
            }

            
        }*/

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

        private void button2_Click(object sender, EventArgs e)
        {
            //Dpto_gen.Items.Add("HOLA");
        }

        private void Registrar_producto_Load(object sender, EventArgs e)
        {

        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_1 MainMenu = new Interfaz_1();
            MainMenu.Show();
        }
    }
}
