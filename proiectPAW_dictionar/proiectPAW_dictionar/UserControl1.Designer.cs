using System;
using System.Drawing;

namespace proiectPAW_dictionar
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbText = new System.Windows.Forms.Label();
            this.tbSchimb = new System.Windows.Forms.TextBox();
            this.btnSchimb = new System.Windows.Forms.Button();
            this.lbText2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(26, 56);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(59, 13);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Codul Hex:";
            // 
            // tbSchimb
            // 
            this.tbSchimb.Location = new System.Drawing.Point(88, 53);
            this.tbSchimb.Name = "tbSchimb";
            this.tbSchimb.Size = new System.Drawing.Size(145, 20);
            this.tbSchimb.TabIndex = 2;
            // 
            // btnSchimb
            // 
            this.btnSchimb.Location = new System.Drawing.Point(239, 51);
            this.btnSchimb.Name = "btnSchimb";
            this.btnSchimb.Size = new System.Drawing.Size(75, 23);
            this.btnSchimb.TabIndex = 4;
            this.btnSchimb.Text = "OK";
            this.btnSchimb.UseVisualStyleBackColor = true;
            this.btnSchimb.Click += new System.EventHandler(this.btnSchimb_Click);

            // 
            // lbText2
            // 
            this.lbText2.AutoSize = true;
            this.lbText2.Location = new System.Drawing.Point(89, 24);
            this.lbText2.Name = "lbText2";
            this.lbText2.Size = new System.Drawing.Size(138, 13);
            this.lbText2.TabIndex = 5;
            this.lbText2.Text = "Schimba Culoarea Form-ului\r\n";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbText2);
            this.Controls.Add(this.btnSchimb);
            this.Controls.Add(this.tbSchimb);
            this.Controls.Add(this.lbText);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(338, 95);
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox tbSchimb;
        private System.Windows.Forms.Button btnSchimb;
        private System.Windows.Forms.Label lbText2;
    }
}
