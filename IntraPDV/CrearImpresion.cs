using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace IntraPDV
{
    class CrearImpresion
    {
        public static Font printFont;
        public static StreamReader streamToPrint;
        public static StringBuilder line = new StringBuilder();

        string ticket = "";
        string parte1, parte2;
        ////////////////////variables///////////////////////
        public static int max = 40;
        int cort;

        //CONSTANTES
        public static string lineasSeparacion()
        {
            string guion = "----------------------------------------";

            return line.AppendLine(guion).ToString();
        }
        //CONSTANTES
        public static void EncabezadoTicket()
        {
            string LineaEncabezado = "Articulo       Cant   P.Unit    Valor";

            line.AppendLine(LineaEncabezado);
        }

        ///////////////////////////////POSICION DEL TEXTO////////////////////////////
        public void TextLeft(string par1)
        {
            max = par1.Length;
            if (max > 40)                                 // **********
            {
                cort = max - 40;
                parte1 = par1.Remove(40, cort);        // si es mayor que 40 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            line.AppendLine(ticket = parte1);
        }
        public void TextoDerecha(string par1)
        {
            ticket = "";
            max = par1.Length;
            if (max > 40)
            {
                cort = max - 40;
                parte1 = par1.Remove(40, cort);
            }
            else { parte1 = par1; }                      // **********
            max = 40 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
            for (int i = 0; i < max; i++)
            {
                ticket += " ";                          // agrega espacios para alinear a la derecha
            }
            line.AppendLine(ticket += parte1 + "\n");
        }
        public void TextoCentro(string par1)
        {
            ticket = "";
            max = par1.Length;
            if (max > 40)                                 // **********
            {
                cort = max - 40;
                parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios antes del texto a centrar
            }                                            // **********
            line.AppendLine(ticket += parte1 + "\n");

        }
        public void TextoExtremos(string par1, string par2)
        {
            max = par1.Length;
            if (max > 18)
            {
                cort = max - 18;
                parte1 = par1.Remove(18, cort);
            }
            else { parte2 = par2; }
            max = 40 - (parte1.Length + parte2.Length);
            for (int i = 0; i < max; i++)
            {
                ticket += " ";
            }
            line.AppendLine(ticket += parte2 + "\n");

        }
        public void AgregarArticulo(string par1, double total)
        {
            max = par1.Length;
            if (max > 25)
            {
                cort = max - 25;
                parte1 = par1.Remove(25, cort);
            }
            else { parte1 = par1; }

            ticket = parte1;
            parte2 = total.ToString() + "$";
            max = 40 - (parte1.Length + parte2.Length);
            for (int i = 0; i < max; i++)
            {
                ticket += " ";
            }
            line.AppendLine(ticket += parte2 + "\n");

        }
        public void AgregaArticulo(string Articulo, decimal precio, int cant, decimal subtotal)
        {
            if (cant.ToString().Length <= 3 && precio.ToString("c").Length <= 10 && subtotal.ToString("c").Length <= 11) // valida que cant precio y total esten dentro de rango
            {
                string elementos = "", espacios = "";
                bool bandera = false;
                int nroEspacios = 0;

                if (Articulo.Length > 40)                                 // **********
                {
                    //cort = max - 16;
                    //parte1 = Articulo.Remove(16, cort);          // corta a 16 la descripcion del articulo
                    nroEspacios = (3 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elementos += espacios + cant.ToString();

                    // colocamos el precio a la derecha
                    nroEspacios = (10 - precio.ToString().Length);
                    espacios = "";

                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elementos += espacios + precio.ToString();

                    //colocar el subtotal a la dercha
                    nroEspacios = (11 - subtotal.ToString().Length);
                    espacios = "";

                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elementos += espacios + subtotal.ToString();

                    int CaracterActual = 0;// indica en que caracter se quedo
                    for (int Longtext = Articulo.Length; Longtext > 16; Longtext++)
                    {
                        if (bandera == false)
                        {
                            line.AppendLine(Articulo.Substring(CaracterActual, 16) + elementos);
                            bandera = true;
                        }
                        else
                        {
                            line.AppendLine(Articulo.Substring(CaracterActual, 16));

                        }
                        CaracterActual += 16;
                    }
                    line.AppendLine(Articulo.Substring(CaracterActual, Articulo.Length - CaracterActual));


                }
                else
                {
                    for (int i = 0; i < (16 - Articulo.Length); i++)
                    {
                        espacios += " ";

                    }
                    elementos = Articulo + espacios;
                    nroEspacios = (3 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elementos += espacios + cant.ToString();

                    // colocamos el precio a la derecha
                    nroEspacios = (10 - precio.ToString().Length);
                    espacios = "";

                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elementos += espacios + precio.ToString();

                    //colocar el subtotal a la dercha
                    nroEspacios = (11 - subtotal.ToString().Length);
                    espacios = "";

                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elementos += espacios + subtotal.ToString();
                    line.AppendLine(elementos);

                }
            }
            else
            {
                //  MessageBox.Show("Valores fuera de rango");

            }
        }
        public void ImprimirTiket()
        {
            File.WriteAllText("factura.text", line.ToString());

            line = new StringBuilder();

            try
            {
                streamToPrint = new StreamReader("factura.text");
                try
                {
                    
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += Pd_PrintPage;
                    pd.DocumentName = "factura" + DateTime.Now.ToString();
                   

                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            printFont = new Font("Arial", 9);
            //e.Graphics.DrawString("texto prueba", printFont, Brushes.Black, new RectangleF(0, 10, 120, 20));



            // Calculate the number of lines per page.
            linesPerPage = e.MarginBounds.Height /
               printFont.GetHeight(e.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(e.Graphics));

                e.Graphics.DrawString(line, printFont, Brushes.Black,-2, yPos, new StringFormat());
                count++;

            }

            // If more lines exist, print another page.
            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }
    }
}
