using HerenciaGranPremi.Clases;
using System;
using System.Windows.Forms;

namespace HerenciaGranPremi.FormularisGranPremi
{
    public partial class FEliminarGP : Form
    {
        public FEliminarGP()
        {
            InitializeComponent();
        }

        private void FEliminarGP_Load(object sender, EventArgs e)
        {

        }

        private void BElimina_Click(object sender, EventArgs e)
        {
            if (!LBNom.Text.Equals(":"))
            {
                granPremi gp = new granPremi();
                gp.eliminaGranPremi(LBNom.Text);

                // tornem les labels a la situació inicial
                LBAny.Text = "(:)";
                LBPremi.Text = ":";
                LBNom.Text = ":";
                LBGuanyador.Text = ":";
                LBPais.Text = ":";
                TBBusca.Text = "";
            }
        }

        private void BBusca_Click(object sender, EventArgs e)
        {
            // recollim dades
            String nom_gp = TBBusca.Text;

            // Creem l'objecte
            granPremi gp = new granPremi();

            // Cerquem la escuderia
            gp = gp.cercarGranPremi(nom_gp);


            // Introduïm en els labels si existeix la escuderia que hem buscat
            if (gp != null)
            {
                LBNom.Text = gp.Nom;
                LBAny.Text = "( " + Convert.ToString(gp.Any) + " )";
                LBPais.Text = gp.Pais;
                LBPremi.Text = Convert.ToString(gp.Premi);
                String guanyador = null;
                if (gp.Guanyador != null)
                    guanyador = gp.Guanyador.Nom;
                LBGuanyador.Text = guanyador;
                BElimina.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existeix el Gran Premi: " + nom_gp, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BElimina.Enabled = false;
            }
        }

        private void torna()
        {

            this.Close();
        }
        private void BTornar_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void FEliminarGP_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }
    }
}
