﻿using System.ComponentModel;

namespace VaccinationManagement.Views
{
    partial class Frmverification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVerification = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "verificacion de su cita de vacunacion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnVerification
            // 
            this.btnVerification.Location = new System.Drawing.Point(31, 117);
            this.btnVerification.Name = "btnVerification";
            this.btnVerification.Size = new System.Drawing.Size(153, 37);
            this.btnVerification.TabIndex = 2;
            this.btnVerification.Text = "verificar";
            this.btnVerification.UseVisualStyleBackColor = true;
            this.btnVerification.Click += new System.EventHandler(this.btnVerification_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "DUI";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(235, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "estado";
            // 
            // Frmverification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 197);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerification);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frmverification";
            this.Text = "Frmverification";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnVerification;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}