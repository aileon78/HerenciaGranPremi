﻿namespace HerenciaGranPremi.FormularisGranPremi
{
    partial class FMostrarGP
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
            this.RTText = new System.Windows.Forms.RichTextBox();
            this.BTorna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTText
            // 
            this.RTText.BackColor = System.Drawing.SystemColors.Control;
            this.RTText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTText.Location = new System.Drawing.Point(14, 22);
            this.RTText.Name = "RTText";
            this.RTText.Size = new System.Drawing.Size(293, 185);
            this.RTText.TabIndex = 7;
            this.RTText.Text = "";
            // 
            // BTorna
            // 
            this.BTorna.Location = new System.Drawing.Point(118, 224);
            this.BTorna.Name = "BTorna";
            this.BTorna.Size = new System.Drawing.Size(75, 23);
            this.BTorna.TabIndex = 6;
            this.BTorna.Text = "&Torna";
            this.BTorna.UseVisualStyleBackColor = true;
            this.BTorna.Click += new System.EventHandler(this.BTorna_Click);
            // 
            // FMostrarGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 269);
            this.Controls.Add(this.RTText);
            this.Controls.Add(this.BTorna);
            this.Name = "FMostrarGP";
            this.Text = "FMostrarGranPremi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMostrarGP_FormClosed);
            this.Load += new System.EventHandler(this.FMostrarGP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTText;
        private System.Windows.Forms.Button BTorna;
    }
}