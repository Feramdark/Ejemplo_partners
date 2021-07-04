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
    public partial class addCliente : Form
    {
        public addCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = BDConnect.connection();
            apartados objApartados = new apartados();

            bool estado = objApartados.insertar(connection, clname.Text);

            if (estado)
            {
                MessageBox.Show("datos insertados con exito");
                this.Dispose();
                this.Close();
                client_List.Items.Clear();
                interfazApartado ap = new interfazApartado();
                ap.ShowDialog();

            }
            else MessageBox.Show("Error con la insercion");
           

        }

        private bool comprobar(string num)
        {
            int maxVal = num.Length;
            if (maxVal == 10) {  
                return true;
            }
            return false;
        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = BDConnect.connection();
            apartados apds = new apartados();
            string nombre = client_List.SelectedItem.ToString();
            bool result = apds.eliminarClientes(con, nombre);

            if (result)
            {
                MessageBox.Show("Se ha eliminado el cliente");
                //consultaClientes();
            }
            else MessageBox.Show("Ha ocurrido un error");
        
        }
        /*private void consultaClientes()
        {

            SqlConnection sql = BDConnect.connection();
            apartados aps = new apartados();

            List<string> cls = aps.clientes(sql);

            foreach (string item in cls)
            {
                client_List.Items.Add(item.ToString());
            }
        }*/

        private void consultaClientes(object sender, EventArgs e)
        {
            client_List.Items.Clear();
            //consultaClientes();
        }
    }
    
}
