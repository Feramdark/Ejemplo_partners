using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;

namespace IntraPDV
{
    public partial class Form1 : Form
    {
        //Estilo redondeado del formulario Cargado al inicio de cada componente. 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
      int nLeftRect,  // x-coordinate of upper-left corner 
      int nTopRect,  // y-coordinate of upper-left corner 
      int nRightRect, // x-coordinate of lower-right corner 
      int nBottomRect, // y-coordinate of lower-right corner 
      int nWidthEllipse, // height of ellipse 
      int nHeightEllipse // width of ellipse 
     );
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width, Height, 20, 20));
        }

        //BOTON PARA INICIAR SESION, ERROR DE PROGRAMACION (LISTO, ya puedo comparar si es usuario administrador o usuario normal)
        //PENDIENTE REDIRECCIONAR A LAS INTERFACEZ CORRESPONDIENTES
        private void button1_Click(object sender, EventArgs e)
        {
            //string cadena = ConfigurationManager.ConnectionStrings["pc_cn"].ConnectionString;
            //InicioDeSesion(Usser_Name.Text, PassWord.Text);
            Interfaz_1 MenuPrincipal = new Interfaz_1();            
            this.Hide();
            MenuPrincipal.Show();
        }

        //Boton para mostrar la contraseña en caso de olvidar(LISTO)
        private void ShowPass_Click(object sender, EventArgs e)
        { 
            if (PassWord.PasswordChar == '*')
            {
                PassWord.PasswordChar = '\0';
                ShowPass.BackColor = Color.Salmon;
            }
            else
            {
                PassWord.PasswordChar = '*';
                ShowPass.BackColor = Color.Transparent;
            }
        }

        /*Boton de cerrar y comprobacion de cerrar LISTO*/
        private void apagar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /*Configuracion_de_Servidor, ya funciona el resultado de servidor, usted puede cambiar de computadora 
         * e instalar el S.I. en cualquier ordenador EXPLICACION EN LA CLASE ('AppSetting.cs')*/ 
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ConfiguracionServidor configuracion = new ConfiguracionServidor();
            configuracion.ShowDialog();
        }

        /*Funcion de inicio de sesion, ya admite si eres usuario administrador o usuario normal, falta verificar la interfaz que le
         * corresponde a cada usuario*/
        public void InicioDeSesion(string Nombre_Usuario,string contraseña_usuario)
        {
            if (Nombre_Usuario == "")
            {
                MessageBox.Show("Por favor, llena los campos correctamente", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            if (contraseña_usuario == "")
            {
                MessageBox.Show("Por favor, llena los campos correctamente","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                return;
            }
            try
            {
                SqlConnection sql = BDConnect.connection();

                SqlCommand ConsultaUsuarios = new SqlCommand ("ConsultaUsuarios", sql);
                ConsultaUsuarios.CommandType = CommandType.StoredProcedure;

                ConsultaUsuarios.Parameters.AddWithValue("@UserName", Nombre_Usuario);
                ConsultaUsuarios.Parameters.AddWithValue("@UserPass", contraseña_usuario);
                //sql.Open();

                SqlDataReader lector_bd = ConsultaUsuarios.ExecuteReader();
                /*Aqui se quedo pendiente, necesito consultar las "Memorias de cache" para manejar esos datos en las diferentes
                 * interfaces, es importante mencionar que necesitamos esas cache para conocer que usuario esta en el sistema*/
                if (lector_bd.Read() == true)
                {
                    Interfaz_1 MenuPrincipal = new Interfaz_1();

                    string rol = lector_bd["rol"].ToString();
                    if (rol == "administrador")
                    {
                        this.Hide();
                        MenuPrincipal.Show();
                    }
                 }
                 else
                 {
                    MessageBox.Show("El usuario y contraseña no existen, \n verifique sus credenciales"
                    ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                 }
                 if (sql.State == ConnectionState.Open)
                 {
                     sql.Dispose();
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error con la conexion del servidor llame a su operador","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
        }

       
    }
}
