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
    public partial class FEliminarPilots : Form
    {
        public FEliminarPilots()
        {
            InitializeComponent();
        }



        private void torna()
        {

            this.Close();
        }
        private void BTornar_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void BBusca_Click(object sender, EventArgs e)
        {
            // recollim dades
            String nom_pilot = TBBusca.Text;

            // Creem l'objecte
            pilot p = new pilot();

            // Cerquem la escuderia
            p = p.cercarPilot(nom_pilot);


            // Introduïm en els labels si existeix la escuderia que hem buscat
            if (p != null)
            {
                LBEscuderia.Text = p.Nom;
                LBNom.Text = p.Nom;
                LBPais.Text = p.Nacionalitat;
                LBDorsal.Text = "( " + Convert.ToString(p.Dorsal) + " )";
                BElimina.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existeix el pilot" + nom_pilot, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BElimina.Enabled = false;
            }
        }

        private void BElimina_Click(object sender, EventArgs e)
        {
            if (!LBNom.Text.Equals(":"))
            {
                pilot p = new pilot();
                p.eliminaPilot(LBNom.Text);


                // tornem les labels a la situació inicial
                LBEscuderia.Text = ":";
                LBNom.Text = ":";
                LBDorsal.Text = "(:)";
                LBPais.Text = ":";


            }
        }

        private void FEliminarPilots_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LBEscuderia_Click(object sender, EventArgs e)
        {

        }

        private void LBDorsal_Click(object sender, EventArgs e)
        {

        }

        private void TBBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBPais_Click(object sender, EventArgs e)
        {

        }

        private void LBNom_Click(object sender, EventArgs e)
        {

        }

        private void FEliminarPilots_Load(object sender, EventArgs e)
        {

        }
    }
}
