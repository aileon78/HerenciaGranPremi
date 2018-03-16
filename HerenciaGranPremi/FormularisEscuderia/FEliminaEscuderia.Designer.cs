namespace HerenciaGranPremi.FormularisEscuderia
{
    partial class FEliminaEscuderia
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
            this.BBusca = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LBMotor = new System.Windows.Forms.Label();
            this.LBAny = new System.Windows.Forms.Label();
            this.TBBuscaEscuderia = new System.Windows.Forms.TextBox();
            this.LBPais = new System.Windows.Forms.Label();
            this.LBEscuderia = new System.Windows.Forms.Label();
            this.BTornar = new System.Windows.Forms.Button();
            this.BElimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BBusca
            // 
            this.BBusca.Location = new System.Drawing.Point(204, 58);
            this.BBusca.Name = "BBusca";
            this.BBusca.Size = new System.Drawing.Size(75, 23);
            this.BBusca.TabIndex = 29;
            this.BBusca.Text = "&Busca";
            this.BBusca.UseVisualStyleBackColor = true;
            this.BBusca.Click += new System.EventHandler(this.BBusca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nom escuderia: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LBMotor
            // 
            this.LBMotor.AutoSize = true;
            this.LBMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMotor.Location = new System.Drawing.Point(153, 171);
            this.LBMotor.Name = "LBMotor";
            this.LBMotor.Size = new System.Drawing.Size(13, 13);
            this.LBMotor.TabIndex = 27;
            this.LBMotor.Text = ": ";
            this.LBMotor.Click += new System.EventHandler(this.LBMotor_Click);
            // 
            // LBAny
            // 
            this.LBAny.AutoSize = true;
            this.LBAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAny.Location = new System.Drawing.Point(153, 108);
            this.LBAny.Name = "LBAny";
            this.LBAny.Size = new System.Drawing.Size(10, 13);
            this.LBAny.TabIndex = 26;
            this.LBAny.Text = ":";
            this.LBAny.Click += new System.EventHandler(this.LBAny_Click);
            // 
            // TBBuscaEscuderia
            // 
            this.TBBuscaEscuderia.Location = new System.Drawing.Point(105, 15);
            this.TBBuscaEscuderia.Name = "TBBuscaEscuderia";
            this.TBBuscaEscuderia.Size = new System.Drawing.Size(174, 20);
            this.TBBuscaEscuderia.TabIndex = 25;
            this.TBBuscaEscuderia.TextChanged += new System.EventHandler(this.TBBuscaEscuderia_TextChanged);
            // 
            // LBPais
            // 
            this.LBPais.AutoSize = true;
            this.LBPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPais.Location = new System.Drawing.Point(8, 171);
            this.LBPais.Name = "LBPais";
            this.LBPais.Size = new System.Drawing.Size(13, 13);
            this.LBPais.TabIndex = 24;
            this.LBPais.Text = ": ";
            this.LBPais.Click += new System.EventHandler(this.LBPais_Click);
            // 
            // LBEscuderia
            // 
            this.LBEscuderia.AutoSize = true;
            this.LBEscuderia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEscuderia.Location = new System.Drawing.Point(8, 108);
            this.LBEscuderia.Name = "LBEscuderia";
            this.LBEscuderia.Size = new System.Drawing.Size(13, 13);
            this.LBEscuderia.TabIndex = 23;
            this.LBEscuderia.Text = ": ";
            this.LBEscuderia.Click += new System.EventHandler(this.LBEscuderia_Click);
            // 
            // BTornar
            // 
            this.BTornar.Location = new System.Drawing.Point(179, 223);
            this.BTornar.Name = "BTornar";
            this.BTornar.Size = new System.Drawing.Size(75, 23);
            this.BTornar.TabIndex = 22;
            this.BTornar.Text = "&Tornar";
            this.BTornar.UseVisualStyleBackColor = true;
            this.BTornar.Click += new System.EventHandler(this.BTornar_Click);
            // 
            // BElimina
            // 
            this.BElimina.Enabled = false;
            this.BElimina.Location = new System.Drawing.Point(9, 223);
            this.BElimina.Name = "BElimina";
            this.BElimina.Size = new System.Drawing.Size(75, 23);
            this.BElimina.TabIndex = 21;
            this.BElimina.Text = "&Elimina";
            this.BElimina.UseVisualStyleBackColor = true;
            this.BElimina.Click += new System.EventHandler(this.BElimina_Click);
            // 
            // FEliminaEscuderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BBusca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBMotor);
            this.Controls.Add(this.LBAny);
            this.Controls.Add(this.TBBuscaEscuderia);
            this.Controls.Add(this.LBPais);
            this.Controls.Add(this.LBEscuderia);
            this.Controls.Add(this.BTornar);
            this.Controls.Add(this.BElimina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FEliminaEscuderia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEliminaEscuderia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FEliminaEscuderia_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBMotor;
        private System.Windows.Forms.Label LBAny;
        private System.Windows.Forms.TextBox TBBuscaEscuderia;
        private System.Windows.Forms.Label LBPais;
        private System.Windows.Forms.Label LBEscuderia;
        private System.Windows.Forms.Button BTornar;
        private System.Windows.Forms.Button BElimina;
    }
}