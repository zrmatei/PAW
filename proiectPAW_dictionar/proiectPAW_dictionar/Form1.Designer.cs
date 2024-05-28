using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lvCuvRo = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExpl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tvCuvinte = new System.Windows.Forms.TreeView();
            this.cuvantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataSet = new proiectPAW_dictionar.ModelDataSet();
            this.btnInsert = new System.Windows.Forms.Button();
            this.userControl1 = new proiectPAW_dictionar.UserControl1();
            this.cuvantTableAdapter = new proiectPAW_dictionar.ModelDataSetTableAdapters.CuvantTableAdapter();
            this.tableAdapterManager = new proiectPAW_dictionar.ModelDataSetTableAdapters.TableAdapterManager();
            this.cuvantDataGridView = new System.Windows.Forms.DataGridView();
            this.rODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explicatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuvantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuvantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).BeginInit();
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
            this.lvCuvRo.MultiSelect = false;
            this.lvCuvRo.Name = "lvCuvRo";
            this.lvCuvRo.Size = new System.Drawing.Size(383, 226);
            this.lvCuvRo.TabIndex = 0;
            this.lvCuvRo.UseCompatibleStateImageBehavior = false;
            this.lvCuvRo.View = System.Windows.Forms.View.Details;
            this.lvCuvRo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvCuvEng_MouseDown);
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
            // chData
            // 
            this.chData.Text = "Data Inregistrare";
            this.chData.Width = 99;
            // 
            // chExpl
            // 
            this.chExpl.Text = "Explicatii";
            this.chExpl.Width = 137;
            // 
            // lvCuvEng
            // 
            this.lvCuvEng.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTraducereEng,
            this.chTraducereRo,
            this.chDataEng});
            this.lvCuvEng.HideSelection = false;
            this.lvCuvEng.Location = new System.Drawing.Point(501, 65);
            this.lvCuvEng.MultiSelect = false;
            this.lvCuvEng.Name = "lvCuvEng";
            this.lvCuvEng.Size = new System.Drawing.Size(443, 206);
            this.lvCuvEng.TabIndex = 1;
            this.lvCuvEng.UseCompatibleStateImageBehavior = false;
            this.lvCuvEng.View = System.Windows.Forms.View.Details;
            this.lvCuvEng.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvCuvEng_MouseDown);
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
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
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
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
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
            this.salvareBinaraToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salvareBinaraToolStripMenuItem.Text = "Salvare binar";
            this.salvareBinaraToolStripMenuItem.Click += new System.EventHandler(this.salvareBinaraToolStripMenuItem_Click);
            // 
            // restaurareBinarToolStripMenuItem
            // 
            this.restaurareBinarToolStripMenuItem.Name = "restaurareBinarToolStripMenuItem";
            this.restaurareBinarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.restaurareBinarToolStripMenuItem.Text = "Restaurare binar";
            this.restaurareBinarToolStripMenuItem.Click += new System.EventHandler(this.restaurareBinarToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // tvCuvinte
            // 
            this.tvCuvinte.AllowDrop = true;
            this.tvCuvinte.CheckBoxes = true;
            this.tvCuvinte.LabelEdit = true;
            this.tvCuvinte.Location = new System.Drawing.Point(84, 288);
            this.tvCuvinte.Name = "tvCuvinte";
            this.tvCuvinte.Size = new System.Drawing.Size(158, 116);
            this.tvCuvinte.TabIndex = 4;
            this.tvCuvinte.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvCuvinte_DragDrop);
            this.tvCuvinte.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvCuvinte_DragEnter);
            // 
            // cuvantBindingSource
            // 
            this.cuvantBindingSource.DataMember = "Cuvant";
            this.cuvantBindingSource.DataSource = this.modelDataSet;
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(312, 537);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(329, 309);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(338, 95);
            this.userControl1.TabIndex = 3;
            this.userControl1.Schimb += new System.EventHandler<System.Drawing.Color>(this.uc_schimb);
            // 
            // cuvantTableAdapter
            // 
            this.cuvantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CuvantTableAdapter = this.cuvantTableAdapter;
            this.tableAdapterManager.UpdateOrder = proiectPAW_dictionar.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cuvantDataGridView
            // 
            this.cuvantDataGridView.AllowUserToOrderColumns = true;
            this.cuvantDataGridView.AutoGenerateColumns = false;
            this.cuvantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuvantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rODataGridViewTextBoxColumn,
            this.genDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.explicatieDataGridViewTextBoxColumn});
            this.cuvantDataGridView.DataSource = this.cuvantBindingSource;
            this.cuvantDataGridView.Location = new System.Drawing.Point(84, 428);
            this.cuvantDataGridView.Name = "cuvantDataGridView";
            this.cuvantDataGridView.Size = new System.Drawing.Size(559, 103);
            this.cuvantDataGridView.TabIndex = 6;
            // 
            // rODataGridViewTextBoxColumn
            // 
            this.rODataGridViewTextBoxColumn.DataPropertyName = "RO";
            this.rODataGridViewTextBoxColumn.HeaderText = "RO";
            this.rODataGridViewTextBoxColumn.Name = "rODataGridViewTextBoxColumn";
            // 
            // genDataGridViewTextBoxColumn
            // 
            this.genDataGridViewTextBoxColumn.DataPropertyName = "Gen";
            this.genDataGridViewTextBoxColumn.HeaderText = "Gen";
            this.genDataGridViewTextBoxColumn.Name = "genDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // explicatieDataGridViewTextBoxColumn
            // 
            this.explicatieDataGridViewTextBoxColumn.DataPropertyName = "Explicatie";
            this.explicatieDataGridViewTextBoxColumn.HeaderText = "Explicatie";
            this.explicatieDataGridViewTextBoxColumn.Name = "explicatieDataGridViewTextBoxColumn";
            // 
            // grafic
            // 
            chartArea1.Name = "ChartArea1";
            this.grafic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafic.Legends.Add(legend1);
            this.grafic.Location = new System.Drawing.Point(652, 313);
            this.grafic.Name = "grafic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Masculin";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Feminin";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Neutru";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Altele";
            this.grafic.Series.Add(series1);
            this.grafic.Series.Add(series2);
            this.grafic.Series.Add(series3);
            this.grafic.Series.Add(series4);
            this.grafic.Size = new System.Drawing.Size(361, 218);
            this.grafic.TabIndex = 8;
            this.grafic.Text = "Genuri";
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(786, 537);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(124, 23);
            this.btnChart.TabIndex = 9;
            this.btnChart.Text = "UPDATE CHART";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 667);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.grafic);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cuvantDataGridView);
            this.Controls.Add(this.tvCuvinte);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.lvCuvEng);
            this.Controls.Add(this.lvCuvRo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuvantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuvantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).EndInit();
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
        private UserControl1 userControl1;
        private System.Windows.Forms.TreeView tvCuvinte;
        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource cuvantBindingSource;
        private ModelDataSetTableAdapters.CuvantTableAdapter cuvantTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView cuvantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn rODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explicatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafic;
        private System.Windows.Forms.Button btnChart;
    }
}