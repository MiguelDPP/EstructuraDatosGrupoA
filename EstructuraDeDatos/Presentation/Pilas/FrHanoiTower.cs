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
    public partial class FrHanoiTower : Form
    {
        

        public FrHanoiTower()
        {
            InitializeComponent();
        }

        private void FrHanoiTower_SizeChanged(object sender, EventArgs e)
        {
            Tool.resizeWitdhControls(this, lbTitle, 20);
            Tool.resizeHeightControls(this, panelPilas, 60);
            Tool.resizeWitdhControls(this, panelPilas, 40);

            Tool.resizeHeightControls(panelPilas, panelPila1, 20);
            Tool.resizeHeightControls(panelPilas, panelPila2, 20);
            Tool.resizeHeightControls(panelPilas, panelPila3, 20);

            resizeHorizontalControls(panelPilas, 20);
        }

        //Mirar si lo agrego al tool o lo dejo aqui
        private void resizeHorizontalControls(Control parent, int margin)
        {
            int width;
            if (parent.Controls.Count > 0)
            {
                width = (parent.Width - (parent.Controls.Count * margin)) / parent.Controls.Count;
            }
            else
            {
                return;
            }
            int positionX = margin;
            foreach (Control control in parent.Controls)
            {
                control.Width = width;
                control.Left = positionX;
                positionX += width + margin;
            }
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
        }
    }
}
