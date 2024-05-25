namespace proiectPAW_dictionar
{
    partial class Form1
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
            this.lvCuvRo = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExpl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCuvEng = new System.Windows.Forms.ListView();
            this.chTraducereEng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTraducereRo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDataEng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuvinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCuvRo
            // 
            this.lvCuvRo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chGen,
            this.chData,
            this.chExpl});
            this.lvCuvRo.HideSelection = false;
            this.lvCuvRo.Location = new System.Drawing.Point(84, 56);
            this.lvCuvRo.Name = "lvCuvRo";
            this.lvCuvRo.Size = new System.Drawing.Size(383, 226);
            this.lvCuvRo.TabIndex = 0;
            this.lvCuvRo.UseCompatibleStateImageBehavior = false;
            this.lvCuvRo.View = System.Windows.Forms.View.Details;
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            this.chNume.Width = 62;
            // 
            // chGen
            // 
            this.chGen.Text = "Gen";
            this.chGen.Width = 59;
            // 
            // chExpl
            // 
            this.chExpl.Text = "Explicatii";
            this.chExpl.Width = 137;
            // 
            // chData
            // 
            this.chData.Text = "Data Inregistrare";
            this.chData.Width = 99;
            // 
            // lvCuvEng
            // 
            this.lvCuvEng.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTraducereEng,
            this.chTraducereRo,
            this.chDataEng});
            this.lvCuvEng.HideSelection = false;
            this.lvCuvEng.Location = new System.Drawing.Point(501, 65);
            this.lvCuvEng.Name = "lvCuvEng";
            this.lvCuvEng.Size = new System.Drawing.Size(443, 206);
            this.lvCuvEng.TabIndex = 1;
            this.lvCuvEng.UseCompatibleStateImageBehavior = false;
            this.lvCuvEng.View = System.Windows.Forms.View.Details;
            // 
            // chTraducereEng
            // 
            this.chTraducereEng.Text = "ENG";
            this.chTraducereEng.Width = 76;
            // 
            // chTraducereRo
            // 
            this.chTraducereRo.Text = "RO";
            this.chTraducereRo.Width = 63;
            // 
            // chDataEng
            // 
            this.chDataEng.Text = "Data";
            this.chDataEng.Width = 146;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuvinteToolStripMenuItem,
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuvinteToolStripMenuItem
            // 
            this.cuvinteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.cuvinteToolStripMenuItem.Name = "cuvinteToolStripMenuItem";
            this.cuvinteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cuvinteToolStripMenuItem.Text = "Cuvinte";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareBinaraToolStripMenuItem,
            this.restaurareBinarToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareBinaraToolStripMenuItem
            // 
            this.salvareBinaraToolStripMenuItem.Name = "salvareBinaraToolStripMenuItem";
            this.salvareBinaraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvareBinaraToolStripMenuItem.Text = "Salvare binar";
            this.salvareBinaraToolStripMenuItem.Click += new System.EventHandler(this.salvareBinaraToolStripMenuItem_Click);
            // 
            // restaurareBinarToolStripMenuItem
            // 
            this.restaurareBinarToolStripMenuItem.Name = "restaurareBinarToolStripMenuItem";
            this.restaurareBinarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaurareBinarToolStripMenuItem.Text = "Restaurare binar";
            this.restaurareBinarToolStripMenuItem.Click += new System.EventHandler(this.restaurareBinarToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 508);
            this.Controls.Add(this.lvCuvEng);
            this.Controls.Add(this.lvCuvRo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCuvRo;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chGen;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.ColumnHeader chExpl;
        private System.Windows.Forms.ListView lvCuvEng;
        private System.Windows.Forms.ColumnHeader chTraducereEng;
        private System.Windows.Forms.ColumnHeader chTraducereRo;
        private System.Windows.Forms.ColumnHeader chDataEng;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuvinteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBinaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}