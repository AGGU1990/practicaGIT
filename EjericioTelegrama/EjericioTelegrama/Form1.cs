using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjericioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama = txtTelegrama.Text.Trim();
            char tipoTelegrama = 'o'; // Por defecto, tipo ordinario
            int numPalabras;
            double coste;

            // Verificar si es urgente u ordinario
            if (rbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else if (rbOrdinario.Checked)
            {
                tipoTelegrama = 'o';
            }

            // Obtener el número de palabras en el telegrama
            numPalabras = textoTelegrama.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Calcular el coste según el tipo de telegrama
            if (tipoTelegrama == 'o') // Ordinario
            {
                if (numPalabras <= 10)
                {
                    coste = 3;
                }
                else
                {
                    coste = 3 + 0.5 * (numPalabras - 10);
                }
            }
            else if (tipoTelegrama == 'u') // Urgente
            {
                if (numPalabras <= 10)
                {
                    coste = 6;
                }
                else
                {
                    coste = 6 + 0.75 * (numPalabras - 10);
                }
            }
            else
            {
                coste = 0; // Caso por defecto si no se selecciona nada
            }

            txtPrecio.Text = coste.ToString("F2") + " euros";

        }
    }
}
