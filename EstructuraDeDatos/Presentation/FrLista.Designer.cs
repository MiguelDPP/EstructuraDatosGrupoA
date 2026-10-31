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
            toolStripButtonSyncEstudiante = new ToolStripButton();
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabelTitle, toolStripSeparator1, toolStripButtonAddEstudiante, toolStripButtonUpdateEstudiante, toolStripButtonDeleteEstudiante, toolStripButtonClearEstudiante, toolStripButtonSyncEstudiante, toolStripSeparator2, toolStripLabelTitleSearch, toolStripTextBoxSearchEstudiante, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1010, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelTitle
            // 
            toolStripLabelTitle.Name = "toolStripLabelTitle";
            toolStripLabelTitle.Size = new Size(163, 24);
            toolStripLabelTitle.Text = "Listados de estudiantes";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButtonAddEstudiante
            // 
            toolStripButtonAddEstudiante.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddEstudiante.Image = Properties.Resources.add;
            toolStripButtonAddEstudiante.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddEstudiante.Name = "toolStripButtonAddEstudiante";
            toolStripButtonAddEstudiante.Size = new Size(29, 24);
            toolStripButtonAddEstudiante.Text = "Agregar Estudiante";
            toolStripButtonAddEstudiante.Click += toolStripButtonAddEstudiante_Click;
            // 
            // toolStripButtonUpdateEstudiante
            // 
            toolStripButtonUpdateEstudiante.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUpdateEstudiante.Image = Properties.Resources.updateIcon;
            toolStripButtonUpdateEstudiante.ImageTransparentColor = Color.Magenta;
            toolStripButtonUpdateEstudiante.Name = "toolStripButtonUpdateEstudiante";
            toolStripButtonUpdateEstudiante.Size = new Size(29, 24);
            toolStripButtonUpdateEstudiante.Text = "Actualizar Estudiante";
            toolStripButtonUpdateEstudiante.Click += toolStripButtonUpdateEstudiante_Click;
            // 
            // toolStripButtonDeleteEstudiante
            // 
            toolStripButtonDeleteEstudiante.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeleteEstudiante.Image = Properties.Resources.deleteIcon;
            toolStripButtonDeleteEstudiante.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteEstudiante.Name = "toolStripButtonDeleteEstudiante";
            toolStripButtonDeleteEstudiante.Size = new Size(29, 24);
            toolStripButtonDeleteEstudiante.Text = "Eliminar Estudiante";
            toolStripButtonDeleteEstudiante.Click += toolStripButtonDeleteEstudiante_Click;
            // 
            // toolStripButtonClearEstudiante
            // 
            toolStripButtonClearEstudiante.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonClearEstudiante.Image = Properties.Resources.clearIcon;
            toolStripButtonClearEstudiante.ImageTransparentColor = Color.Magenta;
            toolStripButtonClearEstudiante.Name = "toolStripButtonClearEstudiante";
            toolStripButtonClearEstudiante.Size = new Size(29, 24);
            toolStripButtonClearEstudiante.Text = "Limpiar Estudiante";
            toolStripButtonClearEstudiante.Click += toolStripButtonClearEstudiante_Click;
            // 
            // toolStripButtonSyncEstudiante
            // 
            toolStripButtonSyncEstudiante.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSyncEstudiante.Image = Properties.Resources.syncIcon;
            toolStripButtonSyncEstudiante.ImageTransparentColor = Color.Magenta;
            toolStripButtonSyncEstudiante.Name = "toolStripButtonSyncEstudiante";
            toolStripButtonSyncEstudiante.Size = new Size(29, 24);
            toolStripButtonSyncEstudiante.Text = "Guardar en archivo";
            toolStripButtonSyncEstudiante.Click += toolStripButtonSyncEstudiante_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripLabelTitleSearch
            // 
            toolStripLabelTitleSearch.Name = "toolStripLabelTitleSearch";
            toolStripLabelTitleSearch.Size = new Size(98, 24);
            toolStripLabelTitleSearch.Text = "Buscar por ID";
            // 
            // toolStripTextBoxSearchEstudiante
            // 
            toolStripTextBoxSearchEstudiante.Name = "toolStripTextBoxSearchEstudiante";
            toolStripTextBoxSearchEstudiante.Size = new Size(171, 27);
            toolStripTextBoxSearchEstudiante.Tag = "";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.searchIcon;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "Buscar";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
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
            splitContainer1.Size = new Size(1010, 573);
            splitContainer1.SplitterDistance = 342;
            splitContainer1.SplitterWidth = 5;
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
            groupBox1.Location = new Point(23, 27);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(297, 528);
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
            panelPag.Location = new Point(11, 468);
            panelPag.Margin = new Padding(3, 4, 3, 4);
            panelPag.Name = "panelPag";
            panelPag.Size = new Size(274, 31);
            panelPag.TabIndex = 6;
            // 
            // btnPagLast
            // 
            btnPagLast.Location = new Point(221, 0);
            btnPagLast.Margin = new Padding(3, 4, 3, 4);
            btnPagLast.Name = "btnPagLast";
            btnPagLast.Size = new Size(54, 31);
            btnPagLast.TabIndex = 4;
            btnPagLast.Text = ">>";
            btnPagLast.UseVisualStyleBackColor = true;
            // 
            // btnPagNext
            // 
            btnPagNext.Location = new Point(167, -1);
            btnPagNext.Margin = new Padding(3, 4, 3, 4);
            btnPagNext.Name = "btnPagNext";
            btnPagNext.Size = new Size(54, 31);
            btnPagNext.TabIndex = 3;
            btnPagNext.Text = ">";
            btnPagNext.UseVisualStyleBackColor = true;
            // 
            // txtPag
            // 
            txtPag.Location = new Point(107, 0);
            txtPag.Margin = new Padding(3, 4, 3, 4);
            txtPag.Name = "txtPag";
            txtPag.Size = new Size(59, 27);
            txtPag.TabIndex = 2;
            txtPag.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPagBack
            // 
            btnPagBack.Location = new Point(54, 0);
            btnPagBack.Margin = new Padding(3, 4, 3, 4);
            btnPagBack.Name = "btnPagBack";
            btnPagBack.Size = new Size(54, 31);
            btnPagBack.TabIndex = 1;
            btnPagBack.Text = "<";
            btnPagBack.UseVisualStyleBackColor = true;
            // 
            // btnPagHead
            // 
            btnPagHead.Location = new Point(0, 0);
            btnPagHead.Margin = new Padding(3, 4, 3, 4);
            btnPagHead.Name = "btnPagHead";
            btnPagHead.Size = new Size(54, 31);
            btnPagHead.TabIndex = 0;
            btnPagHead.Text = "<<";
            btnPagHead.UseVisualStyleBackColor = true;
            // 
            // panelPrograma
            // 
            panelPrograma.Controls.Add(cbPrograma);
            panelPrograma.Controls.Add(lbPrograma);
            panelPrograma.Location = new Point(11, 203);
            panelPrograma.Margin = new Padding(3, 4, 3, 4);
            panelPrograma.Name = "panelPrograma";
            panelPrograma.Size = new Size(274, 31);
            panelPrograma.TabIndex = 5;
            // 
            // cbPrograma
            // 
            cbPrograma.FormattingEnabled = true;
            cbPrograma.Items.AddRange(new object[] { "Administración de Empresas", "Contaduría Pública", "Derecho", "Economía", "Ingeniería Agroindustrial", "Ingeniería Ambiental y Sanitaria", "Ingeniería de Sistemas" });
            cbPrograma.Location = new Point(80, 0);
            cbPrograma.Margin = new Padding(3, 4, 3, 4);
            cbPrograma.Name = "cbPrograma";
            cbPrograma.Size = new Size(194, 28);
            cbPrograma.TabIndex = 7;
            // 
            // lbPrograma
            // 
            lbPrograma.Location = new Point(0, 0);
            lbPrograma.Name = "lbPrograma";
            lbPrograma.Size = new Size(80, 31);
            lbPrograma.TabIndex = 6;
            lbPrograma.Text = "Programa";
            lbPrograma.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelSemestre
            // 
            panelSemestre.Controls.Add(numericSemestre);
            panelSemestre.Controls.Add(lbSemestre);
            panelSemestre.Location = new Point(11, 159);
            panelSemestre.Margin = new Padding(3, 4, 3, 4);
            panelSemestre.Name = "panelSemestre";
            panelSemestre.Size = new Size(274, 31);
            panelSemestre.TabIndex = 4;
            // 
            // numericSemestre
            // 
            numericSemestre.Location = new Point(80, 0);
            numericSemestre.Margin = new Padding(3, 4, 3, 4);
            numericSemestre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericSemestre.Name = "numericSemestre";
            numericSemestre.Size = new Size(194, 27);
            numericSemestre.TabIndex = 1;
            numericSemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbSemestre
            // 
            lbSemestre.Location = new Point(0, 0);
            lbSemestre.Name = "lbSemestre";
            lbSemestre.Size = new Size(80, 31);
            lbSemestre.TabIndex = 0;
            lbSemestre.Text = "Semestre";
            lbSemestre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelDireccion
            // 
            panelDireccion.Controls.Add(txtDireccion);
            panelDireccion.Controls.Add(lbDireccion);
            panelDireccion.Location = new Point(11, 115);
            panelDireccion.Margin = new Padding(3, 4, 3, 4);
            panelDireccion.Name = "panelDireccion";
            panelDireccion.Size = new Size(274, 31);
            panelDireccion.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(80, 0);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(194, 27);
            txtDireccion.TabIndex = 1;
            txtDireccion.Validating += txt_Validating;
            // 
            // lbDireccion
            // 
            lbDireccion.Location = new Point(0, 0);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(80, 31);
            lbDireccion.TabIndex = 0;
            lbDireccion.Text = "Dirección";
            lbDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelNombre
            // 
            panelNombre.Controls.Add(txtNombre);
            panelNombre.Controls.Add(lbNombre);
            panelNombre.Location = new Point(11, 71);
            panelNombre.Margin = new Padding(3, 4, 3, 4);
            panelNombre.Name = "panelNombre";
            panelNombre.Size = new Size(274, 31);
            panelNombre.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 0);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 27);
            txtNombre.TabIndex = 1;
            txtNombre.Validating += txt_Validating;
            // 
            // lbNombre
            // 
            lbNombre.Location = new Point(0, 0);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(80, 31);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            lbNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCedula
            // 
            panelCedula.Controls.Add(txtCedula);
            panelCedula.Controls.Add(lblCedula);
            panelCedula.Location = new Point(11, 27);
            panelCedula.Margin = new Padding(3, 4, 3, 4);
            panelCedula.Name = "panelCedula";
            panelCedula.Size = new Size(274, 31);
            panelCedula.TabIndex = 0;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(80, 0);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(194, 27);
            txtCedula.TabIndex = 2;
            txtCedula.Validating += txtCedula_Validating;
            // 
            // lblCedula
            // 
            lblCedula.Location = new Point(0, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(80, 31);
            lblCedula.TabIndex = 0;
            lblCedula.Text = "Cedula";
            lblCedula.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 600);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolStripButton toolStripButtonSyncEstudiante;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}