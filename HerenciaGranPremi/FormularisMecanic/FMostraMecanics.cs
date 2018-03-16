using HerenciaGranPremi.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaGranPremi.FormularisMecanic
{
    public partial class FMostraMecanics : Form
    {
        public FMostraMecanics()
        {
            InitializeComponent();
        }



        public void torna()
        {

            this.Close();

        }

        private void BTorna_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void FMostraMecanics_Load(object sender, EventArgs e)
        {
            mecanic[] m = new mecanic[100];
            mecanic m1 = new mecanic();
            m = m1.llegeixMecanicFitxer();

            int i = 0;

            do
            {
                RTText.Text = RTText.Text
                    + "Mecanic: " + m[i].Nom + " (Numero de temporades" + m[i].Num_temporades + ")"
                    + "\nPais: " + m[i].Nacionalitat
                    + "\nEspecialitat: "+ m[i].Especialitat
                    + "\nEscuderia: " + m[i].Esc.Nom + "\n\n";
                i++;
            } while (m[i] != null);
        }
    }
}
