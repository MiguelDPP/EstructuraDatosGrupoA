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
    public partial class FrLista : Form
    {
        public FrLista()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            Tool.resizeWitdhControls((Control)sender, groupBox1, 20);
            Tool.resizeHeightControls((Control)sender, groupBox1, 20);
            Tool.resizeWitdhControls(groupBox1, panelNombre, 10);
            Tool.resizeWitdhControls(groupBox1, panelCedula, 10);
            Tool.resizeWitdhControls(groupBox1, panelDireccion, 10);
            Tool.resizeWitdhControls(groupBox1, panelPrograma, 10);
            Tool.resizeWitdhControls(groupBox1, panelSemestre, 10);
            Tool.resizeWitdhControls(panelNombre, txtNombre, 0);
            Tool.resizeWitdhControls(panelCedula, txtCedula, 0);
            Tool.resizeWitdhControls(panelDireccion, txtDireccion, 0);
            Tool.resizeWitdhControls(panelPrograma, cbPrograma, 0);
            Tool.resizeWitdhControls(panelSemestre, numericSemestre, 0);
            Tool.keepFootPanel(groupBox1, panelPag, 20);
            Tool.keepCenterHorizontallyPanel(groupBox1, panelPag);
        }
    }
}
