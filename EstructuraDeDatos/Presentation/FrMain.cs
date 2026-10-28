using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstructuraDeDatos.Presentation
{
    public partial class FrMain : Form
    {
        public FrMain()
        {
            InitializeComponent();
        }

        private void navegacionListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrLista frLista = new FrLista();
            frLista.MdiParent = this;
            frLista.Show();
        }
    }
}
