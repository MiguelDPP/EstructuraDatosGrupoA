namespace EstructuraDeDatos.Presentation.Pilas
{
    partial class FrHanoiTower
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
            lbTitle = new Label();
            panelPilas = new Panel();
            panelPila3 = new Panel();
            panelPila2 = new Panel();
            panelPila1 = new Panel();
            btnReboot = new Button();
            txtDiskNumber = new TextBox();
            lbMovements = new Label();
            panelPilas.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI", 15F);
            lbTitle.ForeColor = Color.Blue;
            lbTitle.Location = new Point(23, 27);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(869, 48);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Torre de Hanoi";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPilas
            // 
            panelPilas.BackColor = SystemColors.Control;
            panelPilas.Controls.Add(panelPila3);
            panelPilas.Controls.Add(panelPila2);
            panelPilas.Controls.Add(panelPila1);
            panelPilas.Location = new Point(23, 105);
            panelPilas.Margin = new Padding(3, 4, 3, 4);
            panelPilas.Name = "panelPilas";
            panelPilas.Size = new Size(869, 479);
            panelPilas.TabIndex = 1;
            // 
            // panelPila3
            // 
            panelPila3.BackColor = SystemColors.ActiveBorder;
            panelPila3.Cursor = Cursors.Hand;
            panelPila3.Location = new Point(590, 27);
            panelPila3.Margin = new Padding(3, 4, 3, 4);
            panelPila3.Name = "panelPila3";
            panelPila3.Size = new Size(258, 425);
            panelPila3.TabIndex = 2;
            panelPila3.Click += panelPila_Click;
            // 
            // panelPila2
            // 
            panelPila2.BackColor = SystemColors.ActiveBorder;
            panelPila2.Cursor = Cursors.Hand;
            panelPila2.Location = new Point(305, 27);
            panelPila2.Margin = new Padding(3, 4, 3, 4);
            panelPila2.Name = "panelPila2";
            panelPila2.Size = new Size(258, 425);
            panelPila2.TabIndex = 1;
            panelPila2.Click += panelPila_Click;
            // 
            // panelPila1
            // 
            panelPila1.BackColor = SystemColors.ActiveBorder;
            panelPila1.Cursor = Cursors.Hand;
            panelPila1.Location = new Point(23, 27);
            panelPila1.Margin = new Padding(3, 4, 3, 4);
            panelPila1.Name = "panelPila1";
            panelPila1.Size = new Size(258, 425);
            panelPila1.TabIndex = 0;
            panelPila1.Click += panelPila_Click;
            // 
            // btnReboot
            // 
            btnReboot.Location = new Point(144, 28);
            btnReboot.Margin = new Padding(3, 4, 3, 4);
            btnReboot.Name = "btnReboot";
            btnReboot.Size = new Size(86, 31);
            btnReboot.TabIndex = 2;
            btnReboot.Text = "Reiniciar";
            btnReboot.UseVisualStyleBackColor = true;
            btnReboot.Click += btnReboot_Click;
            // 
            // txtDiskNumber
            // 
            txtDiskNumber.Location = new Point(23, 28);
            txtDiskNumber.Margin = new Padding(3, 4, 3, 4);
            txtDiskNumber.Name = "txtDiskNumber";
            txtDiskNumber.Size = new Size(114, 27);
            txtDiskNumber.TabIndex = 3;
            // 
            // lbMovements
            // 
            lbMovements.AutoSize = true;
            lbMovements.Location = new Point(23, 75);
            lbMovements.Name = "lbMovements";
            lbMovements.Size = new Size(195, 20);
            lbMovements.TabIndex = 0;
            lbMovements.Text = "Cantidad de movimientos: 0";
            // 
            // FrHanoiTower
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lbMovements);
            Controls.Add(txtDiskNumber);
            Controls.Add(btnReboot);
            Controls.Add(panelPilas);
            Controls.Add(lbTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrHanoiTower";
            Text = "FrHanoiTower";
            SizeChanged += FrHanoiTower_SizeChanged;
            panelPilas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Panel panelPilas;
        private Panel panelPila3;
        private Panel panelPila2;
        private Panel panelPila1;
        private Button btnReboot;
        private TextBox txtDiskNumber;
        private Label lbMovements;
    }
}