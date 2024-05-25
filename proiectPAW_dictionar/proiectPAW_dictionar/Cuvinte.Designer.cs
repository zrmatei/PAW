namespace proiectPAW_dictionar
{
    partial class Cuvinte
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
            this.tbRO = new System.Windows.Forms.TextBox();
            this.tbGen = new System.Windows.Forms.TextBox();
            this.tbExpl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.boxDatInreg = new System.Windows.Forms.DateTimePicker();
            this.lbGen = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbExpl = new System.Windows.Forms.Label();
            this.lbRO = new System.Windows.Forms.Label();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.lbENG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRO
            // 
            this.tbRO.Location = new System.Drawing.Point(314, 141);
            this.tbRO.Name = "tbRO";
            this.tbRO.Size = new System.Drawing.Size(100, 20);
            this.tbRO.TabIndex = 0;
            // 
            // tbGen
            // 
            this.tbGen.Location = new System.Drawing.Point(314, 179);
            this.tbGen.Name = "tbGen";
            this.tbGen.Size = new System.Drawing.Size(100, 20);
            this.tbGen.TabIndex = 1;
            // 
            // tbExpl
            // 
            this.tbExpl.Location = new System.Drawing.Point(314, 259);
            this.tbExpl.Name = "tbExpl";
            this.tbExpl.Size = new System.Drawing.Size(100, 20);
            this.tbExpl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(256, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(398, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // boxDatInreg
            // 
            this.boxDatInreg.Location = new System.Drawing.Point(314, 226);
            this.boxDatInreg.Name = "boxDatInreg";
            this.boxDatInreg.Size = new System.Drawing.Size(200, 20);
            this.boxDatInreg.TabIndex = 6;
            // 
            // lbGen
            // 
            this.lbGen.AutoSize = true;
            this.lbGen.Location = new System.Drawing.Point(232, 186);
            this.lbGen.Name = "lbGen";
            this.lbGen.Size = new System.Drawing.Size(27, 13);
            this.lbGen.TabIndex = 8;
            this.lbGen.Text = "Gen";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(232, 226);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(57, 13);
            this.lbData.TabIndex = 9;
            this.lbData.Text = "Data Inreg";
            // 
            // lbExpl
            // 
            this.lbExpl.AutoSize = true;
            this.lbExpl.Location = new System.Drawing.Point(232, 262);
            this.lbExpl.Name = "lbExpl";
            this.lbExpl.Size = new System.Drawing.Size(48, 13);
            this.lbExpl.TabIndex = 10;
            this.lbExpl.Text = "Explicatii";
            // 
            // lbRO
            // 
            this.lbRO.AutoSize = true;
            this.lbRO.Location = new System.Drawing.Point(232, 144);
            this.lbRO.Name = "lbRO";
            this.lbRO.Size = new System.Drawing.Size(23, 13);
            this.lbRO.TabIndex = 11;
            this.lbRO.Text = "RO";
            // 
            // tbEng
            // 
            this.tbEng.Location = new System.Drawing.Point(511, 141);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(100, 20);
            this.tbEng.TabIndex = 12;
            // 
            // lbENG
            // 
            this.lbENG.AutoSize = true;
            this.lbENG.Location = new System.Drawing.Point(456, 147);
            this.lbENG.Name = "lbENG";
            this.lbENG.Size = new System.Drawing.Size(30, 13);
            this.lbENG.TabIndex = 13;
            this.lbENG.Text = "ENG";
            // 
            // Cuvinte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 458);
            this.Controls.Add(this.lbENG);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.lbRO);
            this.Controls.Add(this.lbExpl);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbGen);
            this.Controls.Add(this.boxDatInreg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbExpl);
            this.Controls.Add(this.tbGen);
            this.Controls.Add(this.tbRO);
            this.Name = "Cuvinte";
            this.Text = "Cuvinte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRO;
        private System.Windows.Forms.TextBox tbGen;
        private System.Windows.Forms.TextBox tbExpl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker boxDatInreg;
        private System.Windows.Forms.Label lbGen;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbExpl;
        private System.Windows.Forms.Label lbRO;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.Label lbENG;
    }
}