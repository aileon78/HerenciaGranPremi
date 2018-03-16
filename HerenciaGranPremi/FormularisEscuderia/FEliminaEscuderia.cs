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

namespace HerenciaGranPremi.FormularisEscuderia
{
    public partial class FEliminaEscuderia : Form
    {
        public FEliminaEscuderia()
        {
            InitializeComponent();
        }

        private void BTornar_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LBMotor_Click(object sender, EventArgs e)
        {

        }

        private void LBAny_Click(object sender, EventArgs e)
        {

        }

        private void TBBuscaEscuderia_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBPais_Click(object sender, EventArgs e)
        {

        }

        private void LBEscuderia_Click(object sender, EventArgs e)
        {

        }

        private void BBusca_Click(object sender, EventArgs e)
        {
            // recollim dades
            String nom_esc = TBBuscaEscuderia.Text;

            // Creem l'objecte
            escuderia esc = new escuderia();

            // Cerquem la escuderia
            esc = esc.CercaEscuderia(nom_esc);


            // Introduïm en els labels si existeix la escuderia que hem buscat
            if (esc != null)
            {
                LBEscuderia.Text = esc.Nom;
                LBMotor.Text = esc.Motor;
                LBPais.Text = esc.Pais;
                LBAny.Text = "( Any: "+Convert.ToString(esc.Any_fundacio)+ ")";
                BElimina.Enabled = true;
            }
            else
            {
             //   buidaLabels();
                MessageBox.Show("No existeix la escuderia: " + nom_esc, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BElimina.Enabled = false;

            }
        }

        public void torna()
        {
            this.Close();
        }

        private void buidaLabels()
        {
            LBEscuderia.Text = ":";
            LBAny.Text = ":";
            LBMotor.Text = ":";
            LBPais.Text = ":";
            TBBuscaEscuderia.Text = "";

        }


        private void BElimina_Click(object sender, EventArgs e)
        {
            if (!LBEscuderia.Text.Equals(":"))
            {
                ///////////////////////////
                ///// FORMA 1. ELIMINA A PARTIR DEL NOM DE L'ESCUDERIA
                escuderia esc = new escuderia();
                esc.eliminaEscuderia(LBEscuderia.Text);

                //finalment buidem labels
                buidaLabels();

                ///////////////////////////

                ////// FORMA 2. ELIMINAR A PARTIR DE L'OBJECTE //
                //////CONSTRUÏM OBJECTE
                //String escuderi, pais, motor;
                //int any;

                ////recollim les dades
                //escuderi = LBEscuderia.Text;
                //pais = LBPais.Text;
                //motor = LBMotor.Text;
                //any = Convert.ToInt32(LBAny.Text);


                //// construïm l'objecte
                //escuderia es = new escuderia(escuderi, pais, any, motor);


                //// eliminem l'objecte
                //es.eliminaEscuderia();


                //// tornem les labels a la situació inicial
                //buidaLabels();

               

             


            }
        }

        private void FEliminaEscuderia_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }
    }
}
