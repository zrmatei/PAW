namespace Magazin
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
            this.lvMagazin = new System.Windows.Forms.ListView();
            this.chN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbMagazin = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.magazinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLRestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMagazin
            // 
            this.lvMagazin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chN,
            this.chQ,
            this.columnHeader3});
            this.lvMagazin.HideSelection = false;
            this.lvMagazin.Location = new System.Drawing.Point(30, 41);
            this.lvMagazin.Name = "lvMagazin";
            this.lvMagazin.Size = new System.Drawing.Size(475, 254);
            this.lvMagazin.TabIndex = 0;
            this.lvMagazin.UseCompatibleStateImageBehavior = false;
            this.lvMagazin.View = System.Windows.Forms.View.Details;
            this.lvMagazin.SelectedIndexChanged += new System.EventHandler(this.lvMagazin_SelectedIndexChanged);
            this.lvMagazin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvMagazin_MouseDown);
            // 
            // chN
            // 
            this.chN.Text = "Nume";
            // 
            // chQ
            // 
            this.chQ.Text = "Cantitate";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pret";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tbMagazin
            // 
            this.tbMagazin.Location = new System.Drawing.Point(82, 318);
            this.tbMagazin.Name = "tbMagazin";
            this.tbMagazin.Size = new System.Drawing.Size(402, 20);
            this.tbMagazin.TabIndex = 2;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magazinToolStripMenuItem,
            this.fisierToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // magazinToolStripMenuItem
            // 
            this.magazinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaToolStripMenuItem,
            this.adaugaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.magazinToolStripMenuItem.Name = "magazinToolStripMenuItem";
            this.magazinToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.magazinToolStripMenuItem.Text = "Magazin";
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem,
            this.xMLSaveToolStripMenuItem,
            this.xMLRestToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.restaurareToolStripMenuItem.Text = "Restaurare";
            this.restaurareToolStripMenuItem.Click += new System.EventHandler(this.restaurareToolStripMenuItem_Click);
            // 
            // xMLSaveToolStripMenuItem
            // 
            this.xMLSaveToolStripMenuItem.Name = "xMLSaveToolStripMenuItem";
            this.xMLSaveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.xMLSaveToolStripMenuItem.Text = "XML Save";
            this.xMLSaveToolStripMenuItem.Click += new System.EventHandler(this.xMLSaveToolStripMenuItem_Click);
            // 
            // xMLRestToolStripMenuItem
            // 
            this.xMLRestToolStripMenuItem.Name = "xMLRestToolStripMenuItem";
            this.xMLRestToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.xMLRestToolStripMenuItem.Text = "XML Rest";
            this.xMLRestToolStripMenuItem.Click += new System.EventHandler(this.xMLRestToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(547, 105);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(170, 149);
            this.treeView1.TabIndex = 4;
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tbMagazin);
            this.Controls.Add(this.lvMagazin);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader chN;
        private System.Windows.Forms.ColumnHeader chQ;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tbMagazin;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem magazinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLRestToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView lvMagazin;
    }
}