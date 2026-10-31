using EstructuraDeDatos.Domain;
using EstructuraDeDatos.DynamicStructure;
using EstructuraDeDatos.Infraestructure;
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
        private RepositorioEstudiantes _repositorio;
        private Lista<Estudiante> _estudiantes;
        private int currenIndex = 0;

        private long cedula = 0;

        public FrLista()
        {
            InitializeComponent();

            _repositorio = RepositorioEstudiantes.GetInstance("estudiantes.txt");
            _estudiantes = _repositorio.GetAll();
            this.Shown += FrLista_Show;
        }

        private void FillEstudiante(Estudiante estudiante)
        {

            estudiante.Id = cedula;
            estudiante.Nombre = txtNombre.Text;
            estudiante.Direccion = txtDireccion.Text;
            estudiante.Semestre = (int)numericSemestre.Value;
            estudiante.Programa = cbPrograma.SelectedItem.ToString() ?? string.Empty;

        }

        private void FrLista_Show(object sender, EventArgs e)
        {
            if (_estudiantes == null || _estudiantes.Count == 0) return;
            Estudiante estudiante = _estudiantes.ElementAt(currenIndex);
            SetEstudiante(estudiante);
            DisplayCounter();
        }


        // -------------- Paginacion ------------------
        private void DisplayCounter()
        {
            txtPag.Text = (currenIndex + 1) + " / " + _estudiantes.Count.ToString();
        }

        private void Navegar_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_estudiantes == null || _estudiantes.Count == 0) return;

            switch (button.Text)
            {
                case "<<":
                    currenIndex = 0;
                    break;
                case "<":
                    //if(currenIndex > 0)
                    //{
                    //currenIndex--;
                    //}
                    currenIndex = (currenIndex > 0) ? currenIndex - 1 : 0;
                    break;
                case ">":
                    currenIndex = (currenIndex < _estudiantes.Count - 1) ? currenIndex + 1 : 0;
                    //currenIndex++;
                    break;
                case ">>":
                    currenIndex = _estudiantes.Count - 1;
                    break;
            }

            Estudiante estudiante = _estudiantes.ElementAt(currenIndex);
            SetEstudiante(estudiante);

            DisplayCounter();

        }

        // -------------- ///// ------------------

        private void SetEstudiante(Estudiante estudiante)
        {

            txtCedula.Text = estudiante.Id.ToString();
            txtNombre.Text = estudiante.Nombre.ToString();
            txtDireccion.Text = estudiante.Direccion.ToString();
            numericSemestre.Value = int.Parse(estudiante.Semestre.ToString());
            cbPrograma.SelectedItem = estudiante.Programa.ToString();

        }

        public long validateNumber(Control control)
        {
            long number = 0;
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


        public void validateEmpty(Control control)
        {
            if (control.Text == string.Empty)
            {
                control.BackColor = Color.Red;
                control.Focus();
            }
            else
            {
                control.BackColor = Color.White;
            }
        }

        //private void textBox_Validating(object sender, EventArgs e)
        //{
        //    TextBox box = (TextBox)sender;
        //    if (box.Name == "textBox2")
        //    {


        //        if (!long.TryParse(box.Text, out cedula))
        //        {
        //            box.BackColor = Color.Red;
        //            box.Focus();
        //        }
        //        else
        //        {
        //            box.BackColor = Color.White;
        //        }
        //    }
        //    if (box.Name == "textBox3")
        //    {
        //        if (box.Text == string.Empty)
        //        {
        //            box.BackColor = Color.Red;
        //            box.Focus();
        //        }
        //        else
        //        {
        //            box.BackColor = Color.White;
        //        }
        //    }
        //}

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

        private void toolStripButtonClearEstudiante_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            numericSemestre.Value = numericSemestre.Minimum;
            cbPrograma.SelectedItem = -1;
        }

        private void toolStripButtonDeleteEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = Estudiante.Create();

            FillEstudiante(estudiante);

            if (txtCedula.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la cedula del estudiante");
            }

            if (_repositorio.Exist(cedula))
            {
                _repositorio.Delete(cedula);
                MessageBox.Show("Estudiante eliminado");
            }
            else
            {
                MessageBox.Show("El estudiante no existe");
            }
        }

        private void toolStripButtonUpdateEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = Estudiante.Create();
            FillEstudiante(estudiante);
            _repositorio.Update(estudiante);
            MessageBox.Show("Estudiante actualizado correctamente");
        }

        private void toolStripButtonSyncEstudiante_Click(object sender, EventArgs e)
        {
            _repositorio.Commit();
            MessageBox.Show("¿desea guardad los cambios?", "s", MessageBoxButtons.YesNo);
            DisplayCounter();
        }

        private void toolStripButtonAddEstudiante_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la cedula del estudiante");
                return;
            }

            if (!_repositorio.Exist(cedula))
            {
                Estudiante estudiante = Estudiante.Create();
                FillEstudiante(estudiante);
                _repositorio.Add(estudiante);
                MessageBox.Show("Estudiante agregado correctamente");
                DisplayCounter();
            }
        }

        private void txtCedula_Validating(object sender, CancelEventArgs e)
        {
            cedula = validateNumber((Control)sender);
        }


        private void txt_Validating(object sender, CancelEventArgs e)
        {
            validateEmpty((Control)sender);
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
