using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegramaAsensio2425
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//AERG-2425 ejercicio telegrama
        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
//AERG-2425 Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

 //AERG-2425 Añado la letra o para telegrama ordinario
            char tipoTelegrama = 'o';
            int numPalabras = 0;
//AERG-2425 Iniciamos el valor coste a 0
            double coste = 0;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
//AERG-2425.Cambiamos el checkboton por el redioboton
            if (rbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            //Obtengo el número de palabras que forma el telegrama
            //numPalabras = textoTelegrama.Length;
//!? AERG-2425.Se añade esta funcion para que nos cuente las palabras y nos discrimine los caracteres y espacios.

            numPalabras = textoTelegrama.Split(' ', '.', ':', ';').Length;

            if (rbOrdinario.Checked)
            {
                //Si el telegrama es ordinario
                if (tipoTelegrama == 'o')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 2.5;
                    }
                    else
                    {
                        //!? AERG-2425.Cambiamos la formula del coste con el enunciado dado.
                        coste = 2.5 + 0.5 * (numPalabras - 10);
                        // coste = 0.5 * numPalabras;
                    }
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";

        }
    }
}
