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
    public partial class FModificaPilot : Form
    {
        /// <summary>
        /// variable global contadora de pilots
        /// </summary>
        public int numPilot;

        /// <summary>
        /// escuderies global
        /// </summary>
        escuderia[] esc = new escuderia[100];

        /// <summary>
        /// Initializes a new instance of the <see cref="FModificaPilot"/> class.
        /// </summary>




        public FModificaPilot()
        {
            InitializeComponent();
        }

        private void carregaTextBox()
        {
            pilot[] p = new pilot[100];
            pilot p1 = new pilot();
            p = p1.llegeixPilotFitxer();

            // carreguem els comboBox amb la escuderia (i)
            TBNom.Text = p[numPilot].Nom;
            TBDorsal.Text = Convert.ToString(p[numPilot].Dorsal);
            TBNacionalitat.Text = p[numPilot].Nacionalitat;
            CBEscuderia.Text = p[numPilot].Esc.Nom;
        }
        private void carregaComboEscuderies(escuderia[] esc)
        {

            //////////////////////
            // Omplim el comboBox
            //////////////////////            
            //CBEscuderia.Items.Add("hola");
            //CBEscuderia.Items.Add("adeu");
            //CBEscuderia.Text="hola";
            int i = 0;
            do
            {
                CBEscuderia.Items.Add(esc[i].Nom);
                i++;
            } while (esc[i] != null);


            // Per a que hi haja un sel.leccionat
            CBEscuderia.Text = esc[0].Nom;

        }
        private void Botonera()
        {
            Boolean primers, ultims = true;
            pilot p = new pilot();
            int totalPilots = p.contaPilots();

            // primers botons
            if (numPilot == 0)
                primers = false;
            else
                primers = true;

            // últims botons
            if (numPilot == totalPilots - 1)
                ultims = false;
            else
                ultims = true;


            // apliquem els enabled als botons
            BPrimer.Enabled = primers;
            BAnterior.Enabled = primers;
            BSeguent.Enabled = ultims;
            BUltim.Enabled = ultims;


        }

        private void BModifica_Click(object sender, EventArgs e)
        {
            // Variables per a recollir dades
            String nomEscud, nom, pais;
            int dorsal;

            // per recollir les dades de la escuderia de dintre de l'objecte pilot
            escuderia esc = new escuderia();

            // Omplim les variables
            nomEscud = CBEscuderia.Text;
            nom = TBNom.Text;
            pais = TBNacionalitat.Text;
            dorsal = Convert.ToInt32(TBDorsal.Text);

            // cerquem les dades de la escuderia
            esc = esc.CercaEscuderia(nomEscud);

            // Construïm l'objecte
            pilot p = new pilot(nom, pais,  esc,dorsal);

            // Modifiquem el pilot sobre el fitxer
            p.modificarPilot(p);

            // I tornem a l'estat inicial
            numPilot = 0;
            carregaTextBox();
            Botonera();
        }

        private void BSeguent_Click(object sender, EventArgs e)
        {
            numPilot++;
            carregaTextBox();
            Botonera();
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            numPilot--;
            carregaTextBox();
            Botonera();
        }

        private void BPrimer_Click(object sender, EventArgs e)
        {
            numPilot = 0;
            carregaTextBox();
            Botonera();
        }



        private void CBEscuderia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TBDorsal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TBNacionalitat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void BUltim_Click(object sender, EventArgs e)
        {
            pilot p = new pilot();
            int totalPilots = p.contaPilots();
            numPilot = totalPilots - 1;

            carregaTextBox();
            Botonera();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FModificaPilot_Load(object sender, EventArgs e)
        {
            escuderia e1 = new escuderia();

            esc = e1.llegeixEscuderies();
            carregaComboEscuderies(esc);


            // carreguem els comboBox amb la primera escuderia
            numPilot = 0;
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
        private void FModificaPilot_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }
    }
}
