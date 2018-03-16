namespace HerenciaGranPremi.FormularisPilot
{
    partial class FModificaPilot
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
            this.BUltim = new System.Windows.Forms.Button();
            this.BSeguent = new System.Windows.Forms.Button();
            this.BAnterior = new System.Windows.Forms.Button();
            this.BPrimer = new System.Windows.Forms.Button();
            this.BTorna = new System.Windows.Forms.Button();
            this.CBEscuderia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBDorsal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNacionalitat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.BModifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BUltim
            // 
            this.BUltim.Location = new System.Drawing.Point(233, 173);
            this.BUltim.Name = "BUltim";
            this.BUltim.Size = new System.Drawing.Size(41, 23);
            this.BUltim.TabIndex = 41;
            this.BUltim.Text = ">>";
            this.BUltim.UseVisualStyleBackColor = true;
            this.BUltim.Click += new System.EventHandler(this.BUltim_Click);
            // 
            // BSeguent
            // 
            this.BSeguent.Location = new System.Drawing.Point(170, 173);
            this.BSeguent.Name = "BSeguent";
            this.BSeguent.Size = new System.Drawing.Size(41, 23);
            this.BSeguent.TabIndex = 40;
            this.BSeguent.Text = ">";
            this.BSeguent.UseVisualStyleBackColor = true;
            this.BSeguent.Click += new System.EventHandler(this.BSeguent_Click);
            // 
            // BAnterior
            // 
            this.BAnterior.Location = new System.Drawing.Point(88, 173);
            this.BAnterior.Name = "BAnterior";
            this.BAnterior.Size = new System.Drawing.Size(41, 23);
            this.BAnterior.TabIndex = 39;
            this.BAnterior.Text = "<";
            this.BAnterior.UseVisualStyleBackColor = true;
            this.BAnterior.Click += new System.EventHandler(this.BAnterior_Click);
            // 
            // BPrimer
            // 
            this.BPrimer.Location = new System.Drawing.Point(29, 173);
            this.BPrimer.Name = "BPrimer";
            this.BPrimer.Size = new System.Drawing.Size(41, 23);
            this.BPrimer.TabIndex = 38;
            this.BPrimer.Text = "<<";
            this.BPrimer.UseVisualStyleBackColor = true;
            this.BPrimer.Click += new System.EventHandler(this.BPrimer_Click);
            // 
            // BTorna
            // 
            this.BTorna.Location = new System.Drawing.Point(193, 215);
            this.BTorna.Name = "BTorna";
            this.BTorna.Size = new System.Drawing.Size(75, 23);
            this.BTorna.TabIndex = 37;
            this.BTorna.Text = "&Torna";
            this.BTorna.UseVisualStyleBackColor = true;
            this.BTorna.Click += new System.EventHandler(this.BTorna_Click);
            // 
            // CBEscuderia
            // 
            this.CBEscuderia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEscuderia.FormattingEnabled = true;
            this.CBEscuderia.Location = new System.Drawing.Point(193, 131);
            this.CBEscuderia.Name = "CBEscuderia";
            this.CBEscuderia.Size = new System.Drawing.Size(121, 21);
            this.CBEscuderia.TabIndex = 36;
            this.CBEscuderia.SelectedIndexChanged += new System.EventHandler(this.CBEscuderia_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "escuderia:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TBDorsal
            // 
            this.TBDorsal.Location = new System.Drawing.Point(29, 131);
            this.TBDorsal.Name = "TBDorsal";
            this.TBDorsal.Size = new System.Drawing.Size(100, 20);
            this.TBDorsal.TabIndex = 34;
            this.TBDorsal.TextChanged += new System.EventHandler(this.TBDorsal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "dorsal:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TBNacionalitat
            // 
            this.TBNacionalitat.Location = new System.Drawing.Point(193, 59);
            this.TBNacionalitat.Name = "TBNacionalitat";
            this.TBNacionalitat.Size = new System.Drawing.Size(100, 20);
            this.TBNacionalitat.TabIndex = 32;
            this.TBNacionalitat.TextChanged += new System.EventHandler(this.TBNacionalitat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "nacionalitat:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBNom
            // 
            this.TBNom.Enabled = false;
            this.TBNom.Location = new System.Drawing.Point(29, 59);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(100, 20);
            this.TBNom.TabIndex = 30;
            this.TBNom.TextChanged += new System.EventHandler(this.TBNom_TextChanged);
            // 
            // BModifica
            // 
            this.BModifica.Location = new System.Drawing.Point(29, 215);
            this.BModifica.Name = "BModifica";
            this.BModifica.Size = new System.Drawing.Size(75, 23);
            this.BModifica.TabIndex = 29;
            this.BModifica.Text = "&Modifica";
            this.BModifica.UseVisualStyleBackColor = true;
            this.BModifica.Click += new System.EventHandler(this.BModifica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "nom:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FModificaPilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 272);
            this.Controls.Add(this.BUltim);
            this.Controls.Add(this.BSeguent);
            this.Controls.Add(this.BAnterior);
            this.Controls.Add(this.BPrimer);
            this.Controls.Add(this.BTorna);
            this.Controls.Add(this.CBEscuderia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBDorsal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNacionalitat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.BModifica);
            this.Controls.Add(this.label1);
            this.Name = "FModificaPilot";
            this.Text = "ModificaPilot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FModificaPilot_FormClosed);
            this.Load += new System.EventHandler(this.FModificaPilot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUltim;
        private System.Windows.Forms.Button BSeguent;
        private System.Windows.Forms.Button BAnterior;
        private System.Windows.Forms.Button BPrimer;
        private System.Windows.Forms.Button BTorna;
        private System.Windows.Forms.ComboBox CBEscuderia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBDorsal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNacionalitat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.Button BModifica;
        private System.Windows.Forms.Label label1;
    }
}