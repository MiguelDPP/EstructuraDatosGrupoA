using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstructuraDeDatos.Presentation
{
    public partial class FrListaBasica : Form
    {
        public FrListaBasica()
        {
            InitializeComponent();
            numeros = new List<int>();
        }

        private List<int> numeros;

        public long validateNumber(Control control)
        {
            long number = -1;
            if (!long.TryParse(control.Text, out number))
            {
                control.BackColor = Color.Red;
                control.Focus();
            }
            else
            {
                control.BackColor = Color.White;
            }

            return number;
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            validateNumber((Control)sender);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            long number = validateNumber(txtNumero);
            if (number != -1)
            {
                numeros.Add((int)number);
                listBoxNumeros.Items.Add(number);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            long position = validateNumber(txtNumero);

            if (position >= 0 && position < numeros.Count)
            {
                numeros.RemoveAt((int)position);

                listBoxNumeros.Items.RemoveAt((int)position);
            }
            else
            {
                MessageBox.Show("Posición inválida");
            }
        }
    }
}
