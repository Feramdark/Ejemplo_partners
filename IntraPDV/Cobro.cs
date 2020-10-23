using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntraPDV
{
    public partial class Cobro : Form
    {
        /*public Cobro()
        {
            InitializeComponent();
        }*/
        //Se crea un nuevo constructor que recibe los datos desde otro formulario
        public Cobro(String texto)
        {
            InitializeComponent();
            TotalVenta.Text = texto;//Aqui se asigna a que elemento del formulario se le asignara ese texto 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cambio(Convert.ToInt32(CantidadPago.Text),Convert.ToInt32(TotalVenta.Text));
        }
        //Funcion para dar el cambio
        public string Cambio(int a, int b)
        {
            int resultado;

            a = Convert.ToInt32(CantidadPago.Text);
            b = Convert.ToInt32(TotalVenta.Text);
            if (b == 0)
            {
                MessageBox.Show("Parece que no haz cobrado nada");
            }
            resultado = a - b;//resta el total de la venta a  la cantidad con la que pago
            DarCambio.Text = Convert.ToString(resultado);
            return "0";
        }
    }
}
