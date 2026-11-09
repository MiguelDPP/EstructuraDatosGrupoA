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
    public partial class FrHanoiTower : Form
    {
        private Pila<Disk> _pila1;
        private Pila<Disk> _pila2;
        private Pila<Disk> _pila3;
        private Pila<Disk> _current;
        private int _diskNumber;

        public FrHanoiTower()
        {
            InitializeComponent();
            _pila1 = new Pila<Disk>();
            _pila2 = new Pila<Disk>();
            _pila3 = new Pila<Disk>();
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

        private void SetDiskSize()
        {
            int minWidth = (int)(panelPila1.Width * 0.2);
            int step = (panelPila1.Width - minWidth) / _diskNumber;
            int diskWidth = minWidth;
            int diskHeight = panelPila1.Height / _diskNumber;
            foreach (Disk disk in _pila1)
            {
                disk.SetSize(diskWidth, diskHeight);
                diskWidth += step;
            }
        }

        private void SetLocation(Panel panel, Pila<Disk> pila)
        {
            panel.Controls.Clear();

            int positionY = 0;
            int positionX = 0;

            foreach (Disk disk in pila)
            {
                positionX = (panel.Width - disk.PanelDisk.Width) / 2;
                disk.SetLocation(positionX, positionY);
                positionY += disk.PanelDisk.Height;
                panel.Controls.Add(disk.PanelDisk);
            }
        }

        private void Restart()
        {
            txtDiskNumber.Text = string.Empty;
            _pila1.Clear();
            _pila2.Clear();
            _pila3.Clear();

            Random random = new Random();
            int r, g, b;

            for (int i = _diskNumber; i > 0; i--)
            {
                r = random.Next(0, 255);
                g = random.Next(0, 255);
                b = random.Next(0, 255);
                Disk disk = new Disk(i, Color.FromArgb(r, g, b));
                _pila1.Push(disk);
            }

            SetDiskSize();
            SetLocation(panelPila1, _pila1);
            SetLocation(panelPila2, _pila2);
            SetLocation(panelPila3, _pila3);
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDiskNumber.Text, out _diskNumber))
            {
                Restart();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }
        private void panelPila_Click(object sender, EventArgs e)
        {

        }
    }
}
