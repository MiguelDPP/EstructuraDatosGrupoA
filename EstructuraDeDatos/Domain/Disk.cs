using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDeDatos.Domain
{
    internal class Disk
    {
        public int DiskNumber { get; set; }
        public Panel PanelDisk { get; set; }

        public Disk(int diskNumber, Color color)
        {
            DiskNumber = diskNumber;
            PanelDisk = new Panel
            {
                BackColor = color,
            };

            Label label = new Label
            {
                Text = diskNumber.ToString(),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            PanelDisk.Controls.Add(label);
        }

        public void SetSize(int width, int height)
        {
            PanelDisk.Width = width;
            PanelDisk.Height = height;
        }

        public void SetLocation(int x, int y)
        {
            //Panel.Top = y;
            //Panel.Left = x;
            PanelDisk.Location = new Point(x, y);
        }
    }
}
