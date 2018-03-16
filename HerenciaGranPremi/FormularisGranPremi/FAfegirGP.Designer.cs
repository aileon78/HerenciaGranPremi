namespace HerenciaGranPremi.FormularisGranPremi
{
    partial class FAfegirGP
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
            this.TBAny = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTorna = new System.Windows.Forms.Button();
            this.CBGuanyador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPremi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.BAfegeix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBAny
            // 
            this.TBAny.Location = new System.Drawing.Point(119, 108);
            this.TBAny.Name = "TBAny";
            this.TBAny.Size = new System.Drawing.Size(100, 20);
            this.TBAny.TabIndex = 33;
            this.TBAny.TextChanged += new System.EventHandler(this.TBAny_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "any:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BTorna
            // 
            this.BTorna.Location = new System.Drawing.Point(202, 220);
            this.BTorna.Name = "BTorna";
            this.BTorna.Size = new System.Drawing.Size(75, 23);
            this.BTorna.TabIndex = 31;
            this.BTorna.Text = "&Torna";
            this.BTorna.UseVisualStyleBackColor = true;
            this.BTorna.Click += new System.EventHandler(this.BTorna_Click);
            // 
            // CBGuanyador
            // 
            this.CBGuanyador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGuanyador.FormattingEnabled = true;
            this.CBGuanyador.Location = new System.Drawing.Point(202, 173);
            this.CBGuanyador.Name = "CBGuanyador";
            this.CBGuanyador.Size = new System.Drawing.Size(121, 21);
            this.CBGuanyador.TabIndex = 30;
            this.CBGuanyador.SelectedIndexChanged += new System.EventHandler(this.CBGuanyador_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "guanyador:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TBPremi
            // 
            this.TBPremi.Location = new System.Drawing.Point(38, 174);
            this.TBPremi.Name = "TBPremi";
            this.TBPremi.Size = new System.Drawing.Size(100, 20);
            this.TBPremi.TabIndex = 28;
            this.TBPremi.TextChanged += new System.EventHandler(this.TBPremi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "premi ($):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TBPais
            // 
            this.TBPais.Location = new System.Drawing.Point(202, 67);
            this.TBPais.Name = "TBPais";
            this.TBPais.Size = new System.Drawing.Size(100, 20);
            this.TBPais.TabIndex = 26;
            this.TBPais.TextChanged += new System.EventHandler(this.TBPais_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "pais:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(38, 67);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(100, 20);
            this.TBNom.TabIndex = 24;
            this.TBNom.TextChanged += new System.EventHandler(this.TBNom_TextChanged);
            // 
            // BAfegeix
            // 
            this.BAfegeix.Location = new System.Drawing.Point(38, 220);
            this.BAfegeix.Name = "BAfegeix";
            this.BAfegeix.Size = new System.Drawing.Size(75, 23);
            this.BAfegeix.TabIndex = 23;
            this.BAfegeix.Text = "&Afegeix";
            this.BAfegeix.UseVisualStyleBackColor = true;
            this.BAfegeix.Click += new System.EventHandler(this.BAfegeix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "nom:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FAfegirGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 284);
            this.Controls.Add(this.TBAny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTorna);
            this.Controls.Add(this.CBGuanyador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBPremi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.BAfegeix);
            this.Controls.Add(this.label1);
            this.Name = "FAfegirGP";
            this.Text = "FAfegirGP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FAfegirGP_FormClosed);
            this.Load += new System.EventHandler(this.FAfegirGP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBAny;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTorna;
        private System.Windows.Forms.ComboBox CBGuanyador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPremi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.Button BAfegeix;
        private System.Windows.Forms.Label label1;
    }
}