namespace EstructuraDeDatos.Presentation
{
    partial class FrListaBasica
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
            components = new System.ComponentModel.Container();
            panelCedula = new Panel();
            txtNumero = new TextBox();
            lblNumero = new Label();
            listBoxNumeros = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            imageList1 = new ImageList(components);
            panelCedula.SuspendLayout();
            SuspendLayout();
            // 
            // panelCedula
            // 
            panelCedula.Controls.Add(txtNumero);
            panelCedula.Controls.Add(lblNumero);
            panelCedula.Location = new Point(25, 25);
            panelCedula.Name = "panelCedula";
            panelCedula.Size = new Size(240, 23);
            panelCedula.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(135, 0);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(105, 23);
            txtNumero.TabIndex = 2;
            txtNumero.Validating += txtNumero_Validating;
            // 
            // lblNumero
            // 
            lblNumero.Location = new Point(0, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(139, 23);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero o posicion";
            lblNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBoxNumeros
            // 
            listBoxNumeros.FormattingEnabled = true;
            listBoxNumeros.Location = new Point(25, 92);
            listBoxNumeros.Name = "listBoxNumeros";
            listBoxNumeros.Size = new Size(240, 199);
            listBoxNumeros.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = Properties.Resources.add;
            btnAgregar.Location = new Point(271, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(24, 24);
            btnAgregar.TabIndex = 4;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.deleteIcon;
            btnEliminar.Location = new Point(301, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(24, 24);
            btnEliminar.TabIndex = 5;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // FrListaBasica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 348);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(listBoxNumeros);
            Controls.Add(panelCedula);
            Name = "FrListaBasica";
            Text = "FrListaBasica";
            panelCedula.ResumeLayout(false);
            panelCedula.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCedula;
        private TextBox txtNumero;
        private Label lblNumero;
        private ListView listView1;
        private ListBox listBoxNumeros;
        private Button btnAgregar;
        private Button btnEliminar;
        private ImageList imageList1;
    }
}