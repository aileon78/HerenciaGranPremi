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

namespace HerenciaGranPremi.FormularisPilot
{
    public partial class FMostraPilots : Form
    {
        public FMostraPilots()
        {
            InitializeComponent();
        }

        private void FMostraPilots_Load(object sender, EventArgs e)
        {
            pilot[] p = new pilot[100];
            pilot p1 = new pilot();
            p = p1.llegeixPilotFitxer();

            int i = 0;

            do
            {
                RTText.Text = RTText.Text
                    + "Pilot: " + p[i].Nom + " (" + p[i].Dorsal + ")"
                    + "\nPais: " + p[i].Nacionalitat
                    + "\nEscuderia: " + p[i].Esc.Nom + "\n\n";
                i++;
            } while (p[i] != null);
        }


        public void torna()
        {

            this.Close();

        }




        private void BTorna_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void FMostraPilots_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }

        private void RTText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
