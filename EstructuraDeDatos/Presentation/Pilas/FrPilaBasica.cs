using EstructuraDeDatos.Domain;
using EstructuraDeDatos.DynamicStructure;
using EstructuraDeDatos.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstructuraDeDatos.Presentation.Pilas
{
    public partial class FrPilaBasica : Form
    {
        private Pila<string> _pilaPending;
        private Pila<string> _pilaPaid;

        public FrPilaBasica()
        {
            InitializeComponent();
            _pilaPending = new Pila<string>();
            _pilaPaid = new Pila<string>();
        }

        private void UpdateListView(ListView listView, Pila<string> pila)
        {
            listView.Items.Clear();

            foreach(string producto in pila)
            {
                listView.Items.Add(producto);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddProduct.Text != string.Empty)
            {
                string product = txtAddProduct.Text;
                _pilaPending.Push(product);
                UpdateListView(listViewPilaPendding, _pilaPending);
                txtAddProduct.Text = string.Empty;
            } else
            {
                MessageBox.Show("Error: Campo producto vacio");
            }
        }

        private void btnClearPending_Click(object sender, EventArgs e)
        {
            _pilaPending.Clear();
            UpdateListView(listViewPilaPendding, _pilaPending);
        }

        private void btnPassToPaid_Click(object sender, EventArgs e)
        {
            if (!_pilaPending.IsEmpty)
            {
                string producto = _pilaPending.Pop();
                _pilaPaid.Push(producto);
                UpdateListView(listViewPilaPendding, _pilaPending);
                UpdateListView(listViewPaid, _pilaPaid);
            }
        }

        private void btnPassToPedding_Click(object sender, EventArgs e)
        {
            if (!_pilaPaid.IsEmpty)
            {
                string producto = _pilaPaid.Pop();
                _pilaPending.Push(producto);
                UpdateListView(listViewPilaPendding, _pilaPending);
                UpdateListView(listViewPaid, _pilaPaid);
            }
        }

        private void btnClearPaid_Click(object sender, EventArgs e)
        {
            _pilaPaid.Clear();
            UpdateListView(listViewPaid, _pilaPaid);
        }
    }
}
