namespace HerenciaGranPremi.FormularisMecanic
{
    partial class FEliminarMecanics
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
            this.BBuscaMecanic = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LBEscuderia = new System.Windows.Forms.Label();
            this.LBTemporades = new System.Windows.Forms.Label();
            this.TBBuscaMecanic = new System.Windows.Forms.TextBox();
            this.LBPais = new System.Windows.Forms.Label();
            this.LBNom = new System.Windows.Forms.Label();
            this.BTornar = new System.Windows.Forms.Button();
            this.BEliminaMecanic = new System.Windows.Forms.Button();
            this.LBEspecialitat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BBuscaMecanic
            // 
            this.BBuscaMecanic.Location = new System.Drawing.Point(237, 87);
            this.BBuscaMecanic.Name = "BBuscaMecanic";
            this.BBuscaMecanic.Size = new System.Drawing.Size(75, 23);
            this.BBuscaMecanic.TabIndex = 47;
            this.BBuscaMecanic.Text = "&Busca";
            this.BBuscaMecanic.UseVisualStyleBackColor = true;
            this.BBuscaMecanic.Click += new System.EventHandler(this.BBuscaMecanic_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nom mecanic";
            // 
            // LBEscuderia
            // 
            this.LBEscuderia.AutoSize = true;
            this.LBEscuderia.Location = new System.Drawing.Point(158, 200);
            this.LBEscuderia.Name = "LBEscuderia";
            this.LBEscuderia.Size = new System.Drawing.Size(13, 13);
            this.LBEscuderia.TabIndex = 45;
            this.LBEscuderia.Text = ": ";
            // 
            // LBTemporades
            // 
            this.LBTemporades.AutoSize = true;
            this.LBTemporades.Location = new System.Drawing.Point(244, 200);
            this.LBTemporades.Name = "LBTemporades";
            this.LBTemporades.Size = new System.Drawing.Size(22, 13);
            this.LBTemporades.TabIndex = 44;
            this.LBTemporades.Text = "( : )";
            // 
            // TBBuscaMecanic
            // 
            this.TBBuscaMecanic.Location = new System.Drawing.Point(138, 44);
            this.TBBuscaMecanic.Name = "TBBuscaMecanic";
            this.TBBuscaMecanic.Size = new System.Drawing.Size(174, 20);
            this.TBBuscaMecanic.TabIndex = 43;
            // 
            // LBPais
            // 
            this.LBPais.AutoSize = true;
            this.LBPais.Location = new System.Drawing.Point(41, 200);
            this.LBPais.Name = "LBPais";
            this.LBPais.Size = new System.Drawing.Size(13, 13);
            this.LBPais.TabIndex = 42;
            this.LBPais.Text = ": ";
            // 
            // LBNom
            // 
            this.LBNom.AutoSize = true;
            this.LBNom.Location = new System.Drawing.Point(41, 137);
            this.LBNom.Name = "LBNom";
            this.LBNom.Size = new System.Drawing.Size(13, 13);
            this.LBNom.TabIndex = 41;
            this.LBNom.Text = ": ";
            // 
            // BTornar
            // 
            this.BTornar.Location = new System.Drawing.Point(212, 252);
            this.BTornar.Name = "BTornar";
            this.BTornar.Size = new System.Drawing.Size(75, 23);
            this.BTornar.TabIndex = 40;
            this.BTornar.Text = "&Tornar";
            this.BTornar.UseVisualStyleBackColor = true;
            this.BTornar.Click += new System.EventHandler(this.BTornar_Click);
            // 
            // BEliminaMecanic
            // 
            this.BEliminaMecanic.Enabled = false;
            this.BEliminaMecanic.Location = new System.Drawing.Point(42, 252);
            this.BEliminaMecanic.Name = "BEliminaMecanic";
            this.BEliminaMecanic.Size = new System.Drawing.Size(75, 23);
            this.BEliminaMecanic.TabIndex = 39;
            this.BEliminaMecanic.Text = "&Elimina";
            this.BEliminaMecanic.UseVisualStyleBackColor = true;
            this.BEliminaMecanic.Click += new System.EventHandler(this.BEliminaMecanic_Click);
            // 
            // LBEspecialitat
            // 
            this.LBEspecialitat.AutoSize = true;
            this.LBEspecialitat.Location = new System.Drawing.Point(158, 137);
            this.LBEspecialitat.Name = "LBEspecialitat";
            this.LBEspecialitat.Size = new System.Drawing.Size(13, 13);
            this.LBEspecialitat.TabIndex = 48;
            this.LBEspecialitat.Text = ": ";
            // 
            // FEliminarMecanics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 318);
            this.Controls.Add(this.LBEspecialitat);
            this.Controls.Add(this.BBuscaMecanic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBEscuderia);
            this.Controls.Add(this.LBTemporades);
            this.Controls.Add(this.TBBuscaMecanic);
            this.Controls.Add(this.LBPais);
            this.Controls.Add(this.LBNom);
            this.Controls.Add(this.BTornar);
            this.Controls.Add(this.BEliminaMecanic);
            this.Name = "FEliminarMecanics";
            this.Text = "FEliminarMecanics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FEliminarMecanics_FormClosed);
            this.Load += new System.EventHandler(this.FEliminarMecanics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBuscaMecanic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBEscuderia;
        private System.Windows.Forms.Label LBTemporades;
        private System.Windows.Forms.TextBox TBBuscaMecanic;
        private System.Windows.Forms.Label LBPais;
        private System.Windows.Forms.Label LBNom;
        private System.Windows.Forms.Button BTornar;
        private System.Windows.Forms.Button BEliminaMecanic;
        private System.Windows.Forms.Label LBEspecialitat;
    }
}