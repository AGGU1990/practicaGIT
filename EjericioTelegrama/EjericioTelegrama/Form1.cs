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

            // Verificar si es urgente
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }

            // Obtener el número de palabras en el telegrama
            numPalabras = textoTelegrama.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Calcular el coste según el tipo de telegrama
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else // Tipo urgente
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

            txtPrecio.Text = coste.ToString("F2") + " euros";

        }
    }
}
