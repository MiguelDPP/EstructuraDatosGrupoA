using EstructuraDeDatos.Tools;
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
            Tool.openForm<FrLista>(this);
        }


        private void listaBasicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tool.openForm<FrListaBasica>(this);
        }
    }
}
