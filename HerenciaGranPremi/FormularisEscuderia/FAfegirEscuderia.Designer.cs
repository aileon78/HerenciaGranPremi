namespace HerenciaGranPremi.FormularisEscuderia
{
    partial class FAfegirEscuderia
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
            this.TBMotorEscuderia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBAnyEscuderia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBPaisEscuderia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNomEscuderia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTornar = new System.Windows.Forms.Button();
            this.BAfegir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBMotorEscuderia
            // 
            this.TBMotorEscuderia.Location = new System.Drawing.Point(166, 140);
            this.TBMotorEscuderia.Name = "TBMotorEscuderia";
            this.TBMotorEscuderia.Size = new System.Drawing.Size(100, 20);
            this.TBMotorEscuderia.TabIndex = 19;
            this.TBMotorEscuderia.TextChanged += new System.EventHandler(this.TBMotorEscuderia_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Motor: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TBAnyEscuderia
            // 
            this.TBAnyEscuderia.Location = new System.Drawing.Point(166, 77);
            this.TBAnyEscuderia.Name = "TBAnyEscuderia";
            this.TBAnyEscuderia.Size = new System.Drawing.Size(100, 20);
            this.TBAnyEscuderia.TabIndex = 17;
            this.TBAnyEscuderia.TextChanged += new System.EventHandler(this.TBAnyEscuderia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Any fundació ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TBPaisEscuderia
            // 
            this.TBPaisEscuderia.Location = new System.Drawing.Point(21, 140);
            this.TBPaisEscuderia.Name = "TBPaisEscuderia";
            this.TBPaisEscuderia.Size = new System.Drawing.Size(100, 20);
            this.TBPaisEscuderia.TabIndex = 15;
            this.TBPaisEscuderia.TextChanged += new System.EventHandler(this.TBPaisEscuderia_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pais escuderia: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBNomEscuderia
            // 
            this.TBNomEscuderia.Location = new System.Drawing.Point(21, 77);
            this.TBNomEscuderia.Name = "TBNomEscuderia";
            this.TBNomEscuderia.Size = new System.Drawing.Size(100, 20);
            this.TBNomEscuderia.TabIndex = 13;
            this.TBNomEscuderia.TextChanged += new System.EventHandler(this.TBNomEscuderia_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom escuderia: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTornar
            // 
            this.BTornar.Location = new System.Drawing.Point(191, 186);
            this.BTornar.Name = "BTornar";
            this.BTornar.Size = new System.Drawing.Size(75, 23);
            this.BTornar.TabIndex = 11;
            this.BTornar.Text = "&Tornar";
            this.BTornar.UseVisualStyleBackColor = true;
            this.BTornar.Click += new System.EventHandler(this.BTornar_Click);
            // 
            // BAfegir
            // 
            this.BAfegir.Location = new System.Drawing.Point(21, 186);
            this.BAfegir.Name = "BAfegir";
            this.BAfegir.Size = new System.Drawing.Size(75, 23);
            this.BAfegir.TabIndex = 10;
            this.BAfegir.Text = "&Afegir";
            this.BAfegir.UseVisualStyleBackColor = true;
            this.BAfegir.Click += new System.EventHandler(this.BAfegir_Click);
            // 
            // FAfegirEscuderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TBMotorEscuderia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBAnyEscuderia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBPaisEscuderia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNomEscuderia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTornar);
            this.Controls.Add(this.BAfegir);
            this.Name = "FAfegirEscuderia";
            this.Text = "FAfegirEscuderia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBMotorEscuderia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBAnyEscuderia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBPaisEscuderia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNomEscuderia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTornar;
        private System.Windows.Forms.Button BAfegir;
    }
}