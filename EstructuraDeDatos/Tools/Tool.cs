using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDeDatos.Tools
{
    internal class Tool
    {
        public static bool IsNumeric(string value)
        {
            return long.TryParse(value, out _);
        }

        public static void openForm<TForm>(Form parent) where TForm : Form, new()
        {
            TForm? form = Application.OpenForms.OfType<TForm>().FirstOrDefault();

            if (form == null || form.IsDisposed)
            {
                form = new TForm();
                form.MdiParent = parent;
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
        }
        public static void showProgressbar(StatusStrip strip, string message)
        {

            ToolStripLabel label = new ToolStripLabel(message);
            ToolStripProgressBar progressBar = new ToolStripProgressBar();

            strip.Items.Add(label);
            strip.Items.Add(progressBar);

            progressBar.Maximum = 100;
            progressBar.Minimum = 0;
            progressBar.Step = 1;

            for (int i = 0; i <= 100; i++)
            {
                progressBar.Value = i;
                strip.Refresh();
                System.Threading.Thread.Sleep(10);
            }

            strip.Items.Remove(label);
            strip.Items.Remove(progressBar);
        }

        public static void resizeWitdhControls(Control parent, Control toResize, int margin)
        {
            
            foreach (Control control in parent.Controls)
            {
                if (control.GetType() == toResize.GetType() && control.Name == toResize.Name)
                {
                    int newWidth = parent.Width - control.Left - margin;
                    control.Width = newWidth;
                }
            }
        }

        public static void resizeHeightControls(Control parent, Control toResize, int margin)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.GetType() == toResize.GetType() && control.Name == toResize.Name)
                {
                    int newHeight = parent.Height - control.Top - margin;
                    control.Height = newHeight;
                }
            }
        }

        public static void keepFootPanel(Control parent, Control toKeep, int margin)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.GetType() == toKeep.GetType() && control.Name == toKeep.Name)
                {
                    int newTop = parent.Height - control.Height - margin;
                    control.Top = newTop;
                }
            }
        }

        public static void keepCenterHorizontallyPanel(Control parent, Control toKeep)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.GetType() == toKeep.GetType() && control.Name == toKeep.Name)
                {
                    int newLeft = (parent.Width - control.Width) / 2;
                    int newTop = (parent.Height - control.Height) / 2;
                    control.Left = newLeft;
                }
            }
        }
    }
}
