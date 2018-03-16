namespace HerenciaGranPremi.FormularisPilot
{
    partial class FEliminarPilots
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
            this.LBEscuderia = new System.Windows.Forms.Label();
            this.LBDorsal = new System.Windows.Forms.Label();
            this.TBBusca = new System.Windows.Forms.TextBox();
            this.LBPais = new System.Windows.Forms.Label();
            this.LBNom = new System.Windows.Forms.Label();
            this.BTornar = new System.Windows.Forms.Button();
            this.BElimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BBusca
            // 
            this.BBusca.Location = new System.Drawing.Point(229, 72);
            this.BBusca.Name = "BBusca";
            this.BBusca.Size = new System.Drawing.Size(75, 23);
            this.BBusca.TabIndex = 38;
            this.BBusca.Text = "&Busca";
            this.BBusca.UseVisualStyleBackColor = true;
            this.BBusca.Click += new System.EventHandler(this.BBusca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nom pilot:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LBEscuderia
            // 
            this.LBEscuderia.AutoSize = true;
            this.LBEscuderia.Location = new System.Drawing.Point(178, 185);
            this.LBEscuderia.Name = "LBEscuderia";
            this.LBEscuderia.Size = new System.Drawing.Size(13, 13);
            this.LBEscuderia.TabIndex = 36;
            this.LBEscuderia.Text = ": ";
            this.LBEscuderia.Click += new System.EventHandler(this.LBEscuderia_Click);
            // 
            // LBDorsal
            // 
            this.LBDorsal.AutoSize = true;
            this.LBDorsal.Location = new System.Drawing.Point(178, 122);
            this.LBDorsal.Name = "LBDorsal";
            this.LBDorsal.Size = new System.Drawing.Size(22, 13);
            this.LBDorsal.TabIndex = 35;
            this.LBDorsal.Text = "( : )";
            this.LBDorsal.Click += new System.EventHandler(this.LBDorsal_Click);
            // 
            // TBBusca
            // 
            this.TBBusca.Location = new System.Drawing.Point(130, 29);
            this.TBBusca.Name = "TBBusca";
            this.TBBusca.Size = new System.Drawing.Size(174, 20);
            this.TBBusca.TabIndex = 34;
            this.TBBusca.TextChanged += new System.EventHandler(this.TBBusca_TextChanged);
            // 
            // LBPais
            // 
            this.LBPais.AutoSize = true;
            this.LBPais.Location = new System.Drawing.Point(33, 185);
            this.LBPais.Name = "LBPais";
            this.LBPais.Size = new System.Drawing.Size(13, 13);
            this.LBPais.TabIndex = 33;
            this.LBPais.Text = ": ";
            this.LBPais.Click += new System.EventHandler(this.LBPais_Click);
            // 
            // LBNom
            // 
            this.LBNom.AutoSize = true;
            this.LBNom.Location = new System.Drawing.Point(33, 122);
            this.LBNom.Name = "LBNom";
            this.LBNom.Size = new System.Drawing.Size(13, 13);
            this.LBNom.TabIndex = 32;
            this.LBNom.Text = ": ";
            this.LBNom.Click += new System.EventHandler(this.LBNom_Click);
            // 
            // BTornar
            // 
            this.BTornar.Location = new System.Drawing.Point(204, 237);
            this.BTornar.Name = "BTornar";
            this.BTornar.Size = new System.Drawing.Size(75, 23);
            this.BTornar.TabIndex = 31;
            this.BTornar.Text = "&Tornar";
            this.BTornar.UseVisualStyleBackColor = true;
            this.BTornar.Click += new System.EventHandler(this.BTornar_Click);
            // 
            // BElimina
            // 
            this.BElimina.Enabled = false;
            this.BElimina.Location = new System.Drawing.Point(34, 237);
            this.BElimina.Name = "BElimina";
            this.BElimina.Size = new System.Drawing.Size(75, 23);
            this.BElimina.TabIndex = 30;
            this.BElimina.Text = "&Elimina";
            this.BElimina.UseVisualStyleBackColor = true;
            this.BElimina.Click += new System.EventHandler(this.BElimina_Click);
            // 
            // FEliminarPilots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 288);
            this.Controls.Add(this.BBusca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBEscuderia);
            this.Controls.Add(this.LBDorsal);
            this.Controls.Add(this.TBBusca);
            this.Controls.Add(this.LBPais);
            this.Controls.Add(this.LBNom);
            this.Controls.Add(this.BTornar);
            this.Controls.Add(this.BElimina);
            this.Name = "FEliminarPilots";
            this.Text = "FEliminarPilots";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FEliminarPilots_FormClosed);
            this.Load += new System.EventHandler(this.FEliminarPilots_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBEscuderia;
        private System.Windows.Forms.Label LBDorsal;
        private System.Windows.Forms.TextBox TBBusca;
        private System.Windows.Forms.Label LBPais;
        private System.Windows.Forms.Label LBNom;
        private System.Windows.Forms.Button BTornar;
        private System.Windows.Forms.Button BElimina;
    }
}