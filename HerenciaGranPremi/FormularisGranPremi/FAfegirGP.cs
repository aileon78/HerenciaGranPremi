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

namespace HerenciaGranPremi.FormularisGranPremi
{
    public partial class FAfegirGP : Form
    {
        public FAfegirGP()
        {
            InitializeComponent();
        }



        private void carregaComboPilots(pilot[] p)
        {

            //////////////////////
            // Omplim el comboBox
            //////////////////////            
            //CBEscuderia.Items.Add("hola");
            //CBEscuderia.Items.Add("adeu");
            //CBEscuderia.Text="hola";
            int i = 0;
            CBGuanyador.Items.Add("-");
            do
            {
                CBGuanyador.Items.Add(p[i].Nom);
                i++;
            } while (p[i] != null);


            // Per a que hi haja un sel.leccionat
            CBGuanyador.Text = "-";

        }

        private void BAfegeix_Click(object sender, EventArgs e)
        {
            // creem variables
            String nom, pais, pilotGuanyador = CBGuanyador.Text;
            double premi;
            pilot guanyador = new pilot();

            int any;

            // recollim les dades dels text box
            nom = TBNom.Text;
            pais = TBPais.Text;
            premi = Convert.ToDouble(TBPremi.Text);
            any = Convert.ToInt32(TBAny.Text);

            if (pilotGuanyador.Equals("-"))
                guanyador = null;
            else
                guanyador = guanyador.cercarPilot(CBGuanyador.Text);



            // construim l'objecte
            granPremi gp = new granPremi(nom, pais, premi, guanyador, any);

            // guardem al fitxer
            gp.afegeiGranPremi();

            // buidem els Text Box
            TBNom.Text = "";
            TBPais.Text = "";
            TBPremi.Text = "";
            TBAny.Text = "";
            CBGuanyador.Text = "-";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void torna()
        {

            this.Close();
        }
        private void BTorna_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void CBGuanyador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TBPremi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TBPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBAny_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FAfegirGP_Load(object sender, EventArgs e)
        {
            // carrega comboBox pilots
            pilot[] pilots = new pilot[100];
            pilot p = new pilot();

            pilots = p.llegeixPilotFitxer();
            carregaComboPilots(pilots);
        }

        private void FAfegirGP_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }
    }
}
