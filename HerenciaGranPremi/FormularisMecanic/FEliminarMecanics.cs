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
    public partial class FEliminarMecanics : Form
    {
        public FEliminarMecanics()
        {
            InitializeComponent();
        }

        private void BBuscaMecanic_Click(object sender, EventArgs e)
        {
            // recollim dades
            String nom_mecacnic = TBBuscaMecanic.Text;

            // Creem l'objecte
            mecanic m = new mecanic();

            // Cerquem la escuderia
            m = m.cercarMecanic(nom_mecacnic);


            // Introduïm en els labels si existeix la escuderia que hem buscat
            if (m != null)
            {
                LBEscuderia.Text = m.Esc.Nom;
                LBNom.Text = m.Nom;
                LBPais.Text = m.Nacionalitat;
                LBEspecialitat.Text = "( " + Convert.ToString(m.Especialitat) + " )";
                BEliminaMecanic.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existeix el pilot" + nom_mecacnic, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BEliminaMecanic.Enabled = false;
            }
        }

        private void BEliminaMecanic_Click(object sender, EventArgs e)
        {
            if (!LBNom.Text.Equals(":"))
            {
                mecanic p = new mecanic();
                p.eliminaMecanic(LBNom.Text);


                // tornem les labels a la situació inicial
                LBEscuderia.Text = ":";
                LBNom.Text = ":";
                LBEspecialitat.Text = "(:)";
                LBPais.Text = ":";


            }
        }

        private void FEliminarMecanics_Load(object sender, EventArgs e)
        {

        }





        private void BTornar_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void torna()
        {
            this.Close();
        }

        private void FEliminarMecanics_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }
    }
}
