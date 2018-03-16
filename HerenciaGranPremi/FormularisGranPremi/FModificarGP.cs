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
    public partial class FModificarGP : Form
    {

        /// <summary>
        /// variable global que contarà els grans premis
        /// </summary>
        public int numGP;

        /// <summary>
        /// Vector de pilots global
        /// </summary>
        pilot[] pilots = new pilot[100];
        public FModificarGP()
        {
            InitializeComponent();
        }

        private void Botonera()
        {
            Boolean primers, ultims = true;
            granPremi gp = new granPremi();
            int totalPilots = gp.contaGPs();

            // primers botons
            if (numGP == 0)
                primers = false;
            else
                primers = true;

            // últims botons
            if (numGP == totalPilots - 1)
                ultims = false;
            else
                ultims = true;


            // apliquem els enabled als botons
            BPrimer.Enabled = primers;
            BAnterior.Enabled = primers;
            BSeguent.Enabled = ultims;
            BUltim.Enabled = ultims;


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
        private void carregaTextBox()
        {
            granPremi[] gps = new granPremi[100];
            granPremi gp = new granPremi();
            gps = gp.llegeixGranPremiFitxer();

            // carreguem els comboBox amb la escuderia (i)
            TBNom.Text = gps[numGP].Nom;
            TBAny.Text = Convert.ToString(gps[numGP].Any);
            TBPais.Text = gps[numGP].Pais;
            TBPremi.Text = Convert.ToString(gps[numGP].Premi);
            String guanyador = "-";
            if (gps[numGP].Guanyador != null)
                guanyador = gps[numGP].Guanyador.Nom;
            CBGuanyador.Text = guanyador;

        }

        private void FModificarGP_Load(object sender, EventArgs e)
        {
            numGP = 0;
            pilot p = new pilot();
            pilots = p.llegeixPilotFitxer();
            carregaComboPilots(pilots);
            carregaTextBox();
            Botonera();
        }


        private void torna()
        {

            this.Close();
        }

        private void BTorna_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void BModifica_Click(object sender, EventArgs e)
        {
            // Variables per a recollir dades
            String nom, pais;
            double premi;
            int any;

            // per recollir les dades del pilot dintre de l'objecte granPremi
            String nomGuanyador;
            pilot guanyador = new pilot();


            // Omplim les variables
            //nomEscud = CBEscuderia.Text;
            nom = TBNom.Text;
            pais = TBPais.Text;
            any = Convert.ToInt32(TBAny.Text);
            premi = Convert.ToDouble(TBPremi.Text);
            nomGuanyador = CBGuanyador.Text;

            guanyador = guanyador.cercarPilot(nomGuanyador);



            // Construïm l'objecte
            granPremi gp = new granPremi(nom, pais, premi, guanyador, any);

            // Modifiquem gp sobre el fitxer
            gp.modificarGP();

            // I tornem a l'estat inicial
            numGP = 0;
            carregaTextBox();
            Botonera();
        }

        private void BPrimer_Click(object sender, EventArgs e)
        {
            numGP = 0;
            carregaTextBox();
            Botonera();
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            numGP--;
            carregaTextBox();
            Botonera();
        }

        private void BSeguent_Click(object sender, EventArgs e)
        {
            numGP++;
            carregaTextBox();
            Botonera();
        }

        private void BUltim_Click(object sender, EventArgs e)
        {
            granPremi gp = new granPremi();
            int totalGPs = gp.contaGPs();
            numGP = totalGPs - 1;

            carregaTextBox();
            Botonera();
        }

        private void FModificarGP_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }
    }
}
