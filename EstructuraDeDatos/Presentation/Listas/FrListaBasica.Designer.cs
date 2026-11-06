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
            panelCedula.Location = new Point(29, 33);
            panelCedula.Margin = new Padding(3, 4, 3, 4);
            panelCedula.Name = "panelCedula";
            panelCedula.Size = new Size(274, 31);
            panelCedula.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(154, 0);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(119, 27);
            txtNumero.TabIndex = 2;
            txtNumero.Validating += txtNumero_Validating;
            // 
            // lblNumero
            // 
            lblNumero.Location = new Point(0, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(159, 31);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero o posicion";
            lblNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBoxNumeros
            // 
            listBoxNumeros.FormattingEnabled = true;
            listBoxNumeros.Location = new Point(29, 123);
            listBoxNumeros.Margin = new Padding(3, 4, 3, 4);
            listBoxNumeros.Name = "listBoxNumeros";
            listBoxNumeros.Size = new Size(274, 264);
            listBoxNumeros.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = Properties.Resources.add;
            btnAgregar.Location = new Point(310, 33);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(27, 32);
            btnAgregar.TabIndex = 4;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.deleteIcon;
            btnEliminar.Location = new Point(344, 33);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(27, 32);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 464);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(listBoxNumeros);
            Controls.Add(panelCedula);
            Margin = new Padding(3, 4, 3, 4);
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