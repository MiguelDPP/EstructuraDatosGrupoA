namespace EstructuraDeDatos.Presentation
{
    partial class FrLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            toolStripLabelTitle = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonAddEstudiante = new ToolStripButton();
            toolStripButtonUpdateEstudiante = new ToolStripButton();
            toolStripButtonDeleteEstudiante = new ToolStripButton();
            toolStripButtonClearEstudiante = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabelTitleSearch = new ToolStripLabel();
            toolStripTextBoxSearchEstudiante = new ToolStripTextBox();
            toolStripButton1 = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            panelPag = new Panel();
            btnPagLast = new Button();
            btnPagNext = new Button();
            txtPag = new TextBox();
            btnPagBack = new Button();
            btnPagHead = new Button();
            panelPrograma = new Panel();
            cbPrograma = new ComboBox();
            lbPrograma = new Label();
            panelSemestre = new Panel();
            numericSemestre = new NumericUpDown();
            lbSemestre = new Label();
            panelDireccion = new Panel();
            txtDireccion = new TextBox();
            lbDireccion = new Label();
            panelNombre = new Panel();
            txtNombre = new TextBox();
            lbNombre = new Label();
            panelCedula = new Panel();
            txtCedula = new TextBox();
            lblCedula = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            panelPag.SuspendLayout();
            panelPrograma.SuspendLayout();
            panelSemestre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSemestre).BeginInit();
            panelDireccion.SuspendLayout();
            panelNombre.SuspendLayout();
            panelCedula.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabelTitle, toolStripSeparator1, toolStripButtonAddEstudiante, toolStripButtonUpdateEstudiante, toolStripButtonDeleteEstudiante, toolStripButtonClearEstudiante, toolStripSeparator2, toolStripLabelTitleSearch, toolStripTextBoxSearchEstudiante, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(884, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelTitle
            // 
            toolStripLabelTitle.Name = "toolStripLabelTitle";
            toolStripLabelTitle.Size = new Size(129, 22);
            toolStripLabelTitle.Text = "Listados de estudiantes";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButtonAddEstudiante
            // 
            toolStripButtonAddEstudiante.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddEstudiante.Image = Properties.Resources.add;
            toolStripButtonAddEstudiante.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddEstudiante.Name = "toolStripButtonAddEstudiante";
            toolStripButtonAddEstudiante.Size = new Size(23, 22);
            toolStripButtonAddEstudiante.Text = "toolStripButton1";
            // 
            // toolStripButtonUpdateEstudiante
            // 
            toolStripButtonUpdateEstudiante.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUpdateEstudiante.Image = Properties.Resources.updateIcon;
            toolStripButtonUpdateEstudiante.ImageTransparentColor = Color.Magenta;
            toolStripButtonUpdateEstudiante.Name = "toolStripButtonUpdateEstudiante";
            toolStripButtonUpdateEstudiante.Size = new Size(23, 22);
            toolStripButtonUpdateEstudiante.Text = "toolStripButtonUpdate";
            // 
            // toolStripButtonDeleteEstudiante
            // 
            toolStripButtonDeleteEstudiante.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeleteEstudiante.Image = Properties.Resources.deleteIcon;
            toolStripButtonDeleteEstudiante.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteEstudiante.Name = "toolStripButtonDeleteEstudiante";
            toolStripButtonDeleteEstudiante.Size = new Size(23, 22);
            toolStripButtonDeleteEstudiante.Text = "toolStripButton1";
            // 
            // toolStripButtonClearEstudiante
            // 
            toolStripButtonClearEstudiante.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonClearEstudiante.Image = Properties.Resources.clearIcon;
            toolStripButtonClearEstudiante.ImageTransparentColor = Color.Magenta;
            toolStripButtonClearEstudiante.Name = "toolStripButtonClearEstudiante";
            toolStripButtonClearEstudiante.Size = new Size(23, 22);
            toolStripButtonClearEstudiante.Text = "toolStripButton2";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabelTitleSearch
            // 
            toolStripLabelTitleSearch.Name = "toolStripLabelTitleSearch";
            toolStripLabelTitleSearch.Size = new Size(77, 22);
            toolStripLabelTitleSearch.Text = "Buscar por ID";
            // 
            // toolStripTextBoxSearchEstudiante
            // 
            toolStripTextBoxSearchEstudiante.Name = "toolStripTextBoxSearchEstudiante";
            toolStripTextBoxSearchEstudiante.Size = new Size(150, 25);
            toolStripTextBoxSearchEstudiante.Tag = "";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.searchIcon;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.SizeChanged += splitContainer1_Panel1_SizeChanged;
            splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ActiveBorder;
            splitContainer1.Panel2MinSize = 500;
            splitContainer1.Size = new Size(884, 425);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(panelPag);
            groupBox1.Controls.Add(panelPrograma);
            groupBox1.Controls.Add(panelSemestre);
            groupBox1.Controls.Add(panelDireccion);
            groupBox1.Controls.Add(panelNombre);
            groupBox1.Controls.Add(panelCedula);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 396);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Estudiante";
            // 
            // panelPag
            // 
            panelPag.Controls.Add(btnPagLast);
            panelPag.Controls.Add(btnPagNext);
            panelPag.Controls.Add(txtPag);
            panelPag.Controls.Add(btnPagBack);
            panelPag.Controls.Add(btnPagHead);
            panelPag.Location = new Point(10, 351);
            panelPag.Name = "panelPag";
            panelPag.Size = new Size(240, 23);
            panelPag.TabIndex = 6;
            // 
            // btnPagLast
            // 
            btnPagLast.Location = new Point(193, 0);
            btnPagLast.Name = "btnPagLast";
            btnPagLast.Size = new Size(47, 23);
            btnPagLast.TabIndex = 4;
            btnPagLast.Text = ">>";
            btnPagLast.UseVisualStyleBackColor = true;
            // 
            // btnPagNext
            // 
            btnPagNext.Location = new Point(146, -1);
            btnPagNext.Name = "btnPagNext";
            btnPagNext.Size = new Size(47, 23);
            btnPagNext.TabIndex = 3;
            btnPagNext.Text = ">";
            btnPagNext.UseVisualStyleBackColor = true;
            // 
            // txtPag
            // 
            txtPag.Location = new Point(94, 0);
            txtPag.Name = "txtPag";
            txtPag.Size = new Size(52, 23);
            txtPag.TabIndex = 2;
            // 
            // btnPagBack
            // 
            btnPagBack.Location = new Point(47, 0);
            btnPagBack.Name = "btnPagBack";
            btnPagBack.Size = new Size(47, 23);
            btnPagBack.TabIndex = 1;
            btnPagBack.Text = "<";
            btnPagBack.UseVisualStyleBackColor = true;
            // 
            // btnPagHead
            // 
            btnPagHead.Location = new Point(0, 0);
            btnPagHead.Name = "btnPagHead";
            btnPagHead.Size = new Size(47, 23);
            btnPagHead.TabIndex = 0;
            btnPagHead.Text = "<<";
            btnPagHead.UseVisualStyleBackColor = true;
            // 
            // panelPrograma
            // 
            panelPrograma.Controls.Add(cbPrograma);
            panelPrograma.Controls.Add(lbPrograma);
            panelPrograma.Location = new Point(10, 152);
            panelPrograma.Name = "panelPrograma";
            panelPrograma.Size = new Size(240, 23);
            panelPrograma.TabIndex = 5;
            // 
            // cbPrograma
            // 
            cbPrograma.FormattingEnabled = true;
            cbPrograma.Location = new Point(70, 0);
            cbPrograma.Name = "cbPrograma";
            cbPrograma.Size = new Size(170, 23);
            cbPrograma.TabIndex = 7;
            // 
            // lbPrograma
            // 
            lbPrograma.Location = new Point(0, 0);
            lbPrograma.Name = "lbPrograma";
            lbPrograma.Size = new Size(70, 23);
            lbPrograma.TabIndex = 6;
            lbPrograma.Text = "Programa";
            lbPrograma.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelSemestre
            // 
            panelSemestre.Controls.Add(numericSemestre);
            panelSemestre.Controls.Add(lbSemestre);
            panelSemestre.Location = new Point(10, 119);
            panelSemestre.Name = "panelSemestre";
            panelSemestre.Size = new Size(240, 23);
            panelSemestre.TabIndex = 4;
            // 
            // numericSemestre
            // 
            numericSemestre.Location = new Point(70, 0);
            numericSemestre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericSemestre.Name = "numericSemestre";
            numericSemestre.Size = new Size(170, 23);
            numericSemestre.TabIndex = 1;
            numericSemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbSemestre
            // 
            lbSemestre.Location = new Point(0, 0);
            lbSemestre.Name = "lbSemestre";
            lbSemestre.Size = new Size(70, 23);
            lbSemestre.TabIndex = 0;
            lbSemestre.Text = "Semestre";
            lbSemestre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelDireccion
            // 
            panelDireccion.Controls.Add(txtDireccion);
            panelDireccion.Controls.Add(lbDireccion);
            panelDireccion.Location = new Point(10, 86);
            panelDireccion.Name = "panelDireccion";
            panelDireccion.Size = new Size(240, 23);
            panelDireccion.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(70, 0);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(170, 23);
            txtDireccion.TabIndex = 1;
            // 
            // lbDireccion
            // 
            lbDireccion.Location = new Point(0, 0);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(70, 23);
            lbDireccion.TabIndex = 0;
            lbDireccion.Text = "Dirección";
            lbDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelNombre
            // 
            panelNombre.Controls.Add(txtNombre);
            panelNombre.Controls.Add(lbNombre);
            panelNombre.Location = new Point(10, 53);
            panelNombre.Name = "panelNombre";
            panelNombre.Size = new Size(240, 23);
            panelNombre.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(70, 0);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 1;
            // 
            // lbNombre
            // 
            lbNombre.Location = new Point(0, 0);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(70, 23);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            lbNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCedula
            // 
            panelCedula.Controls.Add(txtCedula);
            panelCedula.Controls.Add(lblCedula);
            panelCedula.Location = new Point(10, 20);
            panelCedula.Name = "panelCedula";
            panelCedula.Size = new Size(240, 23);
            panelCedula.TabIndex = 0;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(70, 0);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(170, 23);
            txtCedula.TabIndex = 2;
            // 
            // lblCedula
            // 
            lblCedula.Location = new Point(0, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(70, 23);
            lblCedula.TabIndex = 0;
            lblCedula.Text = "Cedula";
            lblCedula.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "FrLista";
            Tag = "";
            Text = "FrLista";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panelPag.ResumeLayout(false);
            panelPag.PerformLayout();
            panelPrograma.ResumeLayout(false);
            panelSemestre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericSemestre).EndInit();
            panelDireccion.ResumeLayout(false);
            panelDireccion.PerformLayout();
            panelNombre.ResumeLayout(false);
            panelNombre.PerformLayout();
            panelCedula.ResumeLayout(false);
            panelCedula.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabelTitle;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonAddEstudiante;
        private ToolStripButton toolStripButtonUpdateEstudiante;
        private ToolStripButton toolStripButtonDeleteEstudiante;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripTextBox toolStripTextBoxSearchEstudiante;
        private ToolStripButton toolStripButtonClearEstudiante;
        private ToolStripLabel toolStripLabelTitleSearch;
        private ToolStripButton toolStripButton1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Panel panelCedula;
        private Label lblCedula;
        private Panel panelNombre;
        private TextBox textBox2;
        private Label lbNombre;
        private Panel panelDireccion;
        private TextBox txtDireccion;
        private Label lbDireccion;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private Panel panelPrograma;
        private Panel panelSemestre;
        private Label lbSemestre;
        private Label lbPrograma;
        private ComboBox cbPrograma;
        private NumericUpDown numericSemestre;
        private Panel panelPag;
        private Button btnPagNext;
        private Button btnPagLast;
        private TextBox txtPag;
        private Button btnPagBack;
        private Button btnPagHead;
    }
}