namespace HerenciaGranPremi.FormularisMecanic
{
    partial class FAfegirMecanic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBNomAfMec = new System.Windows.Forms.TextBox();
            this.TBNacionalitaAfeMec = new System.Windows.Forms.TextBox();
            this.TBEspecialitatAfMec = new System.Windows.Forms.TextBox();
            this.TBTemporadesAfMec = new System.Windows.Forms.TextBox();
            this.CBEscuderia = new System.Windows.Forms.ComboBox();
            this.BTAfegir = new System.Windows.Forms.Button();
            this.BTTorna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nacionalitat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "especialitat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "escuderia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "temporades:";
            // 
            // TBNomAfMec
            // 
            this.TBNomAfMec.Location = new System.Drawing.Point(24, 37);
            this.TBNomAfMec.Name = "TBNomAfMec";
            this.TBNomAfMec.Size = new System.Drawing.Size(100, 20);
            this.TBNomAfMec.TabIndex = 5;
            // 
            // TBNacionalitaAfeMec
            // 
            this.TBNacionalitaAfeMec.Location = new System.Drawing.Point(207, 37);
            this.TBNacionalitaAfeMec.Name = "TBNacionalitaAfeMec";
            this.TBNacionalitaAfeMec.Size = new System.Drawing.Size(100, 20);
            this.TBNacionalitaAfeMec.TabIndex = 6;
            // 
            // TBEspecialitatAfMec
            // 
            this.TBEspecialitatAfMec.Location = new System.Drawing.Point(24, 124);
            this.TBEspecialitatAfMec.Name = "TBEspecialitatAfMec";
            this.TBEspecialitatAfMec.Size = new System.Drawing.Size(100, 20);
            this.TBEspecialitatAfMec.TabIndex = 7;
            // 
            // TBTemporadesAfMec
            // 
            this.TBTemporadesAfMec.Location = new System.Drawing.Point(24, 202);
            this.TBTemporadesAfMec.Name = "TBTemporadesAfMec";
            this.TBTemporadesAfMec.Size = new System.Drawing.Size(100, 20);
            this.TBTemporadesAfMec.TabIndex = 8;
            // 
            // CBEscuderia
            // 
            this.CBEscuderia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEscuderia.FormattingEnabled = true;
            this.CBEscuderia.Location = new System.Drawing.Point(207, 124);
            this.CBEscuderia.Name = "CBEscuderia";
            this.CBEscuderia.Size = new System.Drawing.Size(121, 21);
            this.CBEscuderia.TabIndex = 19;
            // 
            // BTAfegir
            // 
            this.BTAfegir.Location = new System.Drawing.Point(24, 268);
            this.BTAfegir.Name = "BTAfegir";
            this.BTAfegir.Size = new System.Drawing.Size(75, 23);
            this.BTAfegir.TabIndex = 20;
            this.BTAfegir.Text = "&Afegeix";
            this.BTAfegir.UseVisualStyleBackColor = true;
            this.BTAfegir.Click += new System.EventHandler(this.BTAfegir_Click);
            // 
            // BTTorna
            // 
            this.BTTorna.Location = new System.Drawing.Point(207, 268);
            this.BTTorna.Name = "BTTorna";
            this.BTTorna.Size = new System.Drawing.Size(75, 23);
            this.BTTorna.TabIndex = 21;
            this.BTTorna.Text = "&Torna";
            this.BTTorna.UseVisualStyleBackColor = true;
            // 
            // FAfegirMecanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 317);
            this.Controls.Add(this.BTTorna);
            this.Controls.Add(this.BTAfegir);
            this.Controls.Add(this.CBEscuderia);
            this.Controls.Add(this.TBTemporadesAfMec);
            this.Controls.Add(this.TBEspecialitatAfMec);
            this.Controls.Add(this.TBNacionalitaAfeMec);
            this.Controls.Add(this.TBNomAfMec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAfegirMecanic";
            this.Text = "FAfegirMecanic";
            this.Load += new System.EventHandler(this.FAfegirMecanic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBNomAfMec;
        private System.Windows.Forms.TextBox TBNacionalitaAfeMec;
        private System.Windows.Forms.TextBox TBEspecialitatAfMec;
        private System.Windows.Forms.TextBox TBTemporadesAfMec;
        private System.Windows.Forms.ComboBox CBEscuderia;
        private System.Windows.Forms.Button BTAfegir;
        private System.Windows.Forms.Button BTTorna;
    }
}