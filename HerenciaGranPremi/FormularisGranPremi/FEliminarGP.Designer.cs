namespace HerenciaGranPremi.FormularisGranPremi
{
    partial class FEliminarGP
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
            this.LBPremi = new System.Windows.Forms.Label();
            this.BBusca = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LBGuanyador = new System.Windows.Forms.Label();
            this.LBAny = new System.Windows.Forms.Label();
            this.TBBusca = new System.Windows.Forms.TextBox();
            this.LBPais = new System.Windows.Forms.Label();
            this.LBNom = new System.Windows.Forms.Label();
            this.BTornar = new System.Windows.Forms.Button();
            this.BElimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBPremi
            // 
            this.LBPremi.AutoSize = true;
            this.LBPremi.Location = new System.Drawing.Point(36, 183);
            this.LBPremi.Name = "LBPremi";
            this.LBPremi.Size = new System.Drawing.Size(13, 13);
            this.LBPremi.TabIndex = 49;
            this.LBPremi.Text = ": ";
            // 
            // BBusca
            // 
            this.BBusca.Location = new System.Drawing.Point(232, 70);
            this.BBusca.Name = "BBusca";
            this.BBusca.Size = new System.Drawing.Size(75, 23);
            this.BBusca.TabIndex = 48;
            this.BBusca.Text = "&Busca";
            this.BBusca.UseVisualStyleBackColor = true;
            this.BBusca.Click += new System.EventHandler(this.BBusca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nom GP:";
            // 
            // LBGuanyador
            // 
            this.LBGuanyador.AutoSize = true;
            this.LBGuanyador.Location = new System.Drawing.Point(181, 183);
            this.LBGuanyador.Name = "LBGuanyador";
            this.LBGuanyador.Size = new System.Drawing.Size(13, 13);
            this.LBGuanyador.TabIndex = 46;
            this.LBGuanyador.Text = ": ";
            // 
            // LBAny
            // 
            this.LBAny.AutoSize = true;
            this.LBAny.Location = new System.Drawing.Point(172, 120);
            this.LBAny.Name = "LBAny";
            this.LBAny.Size = new System.Drawing.Size(22, 13);
            this.LBAny.TabIndex = 45;
            this.LBAny.Text = "( : )";
            // 
            // TBBusca
            // 
            this.TBBusca.Location = new System.Drawing.Point(133, 27);
            this.TBBusca.Name = "TBBusca";
            this.TBBusca.Size = new System.Drawing.Size(174, 20);
            this.TBBusca.TabIndex = 44;
            // 
            // LBPais
            // 
            this.LBPais.AutoSize = true;
            this.LBPais.Location = new System.Drawing.Point(247, 120);
            this.LBPais.Name = "LBPais";
            this.LBPais.Size = new System.Drawing.Size(13, 13);
            this.LBPais.TabIndex = 43;
            this.LBPais.Text = ": ";
            // 
            // LBNom
            // 
            this.LBNom.AutoSize = true;
            this.LBNom.Location = new System.Drawing.Point(36, 120);
            this.LBNom.Name = "LBNom";
            this.LBNom.Size = new System.Drawing.Size(13, 13);
            this.LBNom.TabIndex = 42;
            this.LBNom.Text = ": ";
            // 
            // BTornar
            // 
            this.BTornar.Location = new System.Drawing.Point(207, 235);
            this.BTornar.Name = "BTornar";
            this.BTornar.Size = new System.Drawing.Size(75, 23);
            this.BTornar.TabIndex = 41;
            this.BTornar.Text = "&Tornar";
            this.BTornar.UseVisualStyleBackColor = true;
            this.BTornar.Click += new System.EventHandler(this.BTornar_Click);
            // 
            // BElimina
            // 
            this.BElimina.Enabled = false;
            this.BElimina.Location = new System.Drawing.Point(37, 235);
            this.BElimina.Name = "BElimina";
            this.BElimina.Size = new System.Drawing.Size(75, 23);
            this.BElimina.TabIndex = 40;
            this.BElimina.Text = "&Elimina";
            this.BElimina.UseVisualStyleBackColor = true;
            this.BElimina.Click += new System.EventHandler(this.BElimina_Click);
            // 
            // FEliminarGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 285);
            this.Controls.Add(this.LBPremi);
            this.Controls.Add(this.BBusca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBGuanyador);
            this.Controls.Add(this.LBAny);
            this.Controls.Add(this.TBBusca);
            this.Controls.Add(this.LBPais);
            this.Controls.Add(this.LBNom);
            this.Controls.Add(this.BTornar);
            this.Controls.Add(this.BElimina);
            this.Name = "FEliminarGP";
            this.Text = "FEliminarGranPremi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FEliminarGP_FormClosed);
            this.Load += new System.EventHandler(this.FEliminarGP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBPremi;
        private System.Windows.Forms.Button BBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBGuanyador;
        private System.Windows.Forms.Label LBAny;
        private System.Windows.Forms.TextBox TBBusca;
        private System.Windows.Forms.Label LBPais;
        private System.Windows.Forms.Label LBNom;
        private System.Windows.Forms.Button BTornar;
        private System.Windows.Forms.Button BElimina;
    }
}