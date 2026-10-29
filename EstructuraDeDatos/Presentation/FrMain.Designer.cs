namespace EstructuraDeDatos.Presentation
{
    partial class FrMain
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
            menuStripMain = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            gestionDominioToolStripMenuItem = new ToolStripMenuItem();
            navegacionListasToolStripMenuItem = new ToolStripMenuItem();
            pilasToolStripMenuItem = new ToolStripMenuItem();
            colasToolStripMenuItem = new ToolStripMenuItem();
            listaBasicaToolStripMenuItem = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, gestionDominioToolStripMenuItem, pilasToolStripMenuItem, colasToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(800, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // gestionDominioToolStripMenuItem
            // 
            gestionDominioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaBasicaToolStripMenuItem, navegacionListasToolStripMenuItem });
            gestionDominioToolStripMenuItem.Name = "gestionDominioToolStripMenuItem";
            gestionDominioToolStripMenuItem.Size = new Size(48, 20);
            gestionDominioToolStripMenuItem.Text = "Listas";
            // 
            // navegacionListasToolStripMenuItem
            // 
            navegacionListasToolStripMenuItem.Name = "navegacionListasToolStripMenuItem";
            navegacionListasToolStripMenuItem.Size = new Size(180, 22);
            navegacionListasToolStripMenuItem.Text = "Navegacion Listas";
            navegacionListasToolStripMenuItem.Click += navegacionListasToolStripMenuItem_Click;
            // 
            // pilasToolStripMenuItem
            // 
            pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            pilasToolStripMenuItem.Size = new Size(43, 20);
            pilasToolStripMenuItem.Text = "Pilas";
            // 
            // colasToolStripMenuItem
            // 
            colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            colasToolStripMenuItem.Size = new Size(48, 20);
            colasToolStripMenuItem.Text = "Colas";
            // 
            // listaBasicaToolStripMenuItem
            // 
            listaBasicaToolStripMenuItem.Name = "listaBasicaToolStripMenuItem";
            listaBasicaToolStripMenuItem.Size = new Size(180, 22);
            listaBasicaToolStripMenuItem.Text = "Lista Basica";
            listaBasicaToolStripMenuItem.Click += listaBasicaToolStripMenuItem_Click;
            // 
            // FrMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripMain);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMain;
            Name = "FrMain";
            Text = "FrMain";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem gestionDominioToolStripMenuItem;
        private ToolStripMenuItem navegacionListasToolStripMenuItem;
        private ToolStripMenuItem pilasToolStripMenuItem;
        private ToolStripMenuItem colasToolStripMenuItem;
        private ToolStripMenuItem listaBasicaToolStripMenuItem;
    }
}