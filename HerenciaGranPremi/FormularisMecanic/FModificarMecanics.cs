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
    public partial class FModificarMecanics : Form
    {
        public int numMecanic;


        escuderia[] esc = new escuderia[100];


        public FModificarMecanics()
        {
            InitializeComponent();
        }

        private void carregaTextBox()
        {
            mecanic[] m = new mecanic[100];
            mecanic m1 = new mecanic();
            m = m1.llegeixMecanicFitxer();

            // carreguem els comboBox amb la escuderia (i)
            TBNom.Text = m[numMecanic].Nom;
            TBTemporades.Text = Convert.ToString(m[numMecanic].Num_temporades);
            TBNacionalitat.Text = m[numMecanic].Nacionalitat;
            TBEspecialitat.Text = m[numMecanic].Especialitat;
            CBEscuderia.Text = m[numMecanic].Esc.Nom;
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
            mecanic m = new mecanic();
            int totalMecanics = m.contaMecanic();

            // primers botons
            if (numMecanic == 0)
                primers = false;
            else
                primers = true;

            // últims botons
            if (numMecanic == totalMecanics - 1)
                ultims = false;
            else
                ultims = true;


            // apliquem els enabled als botons
            BPrimer.Enabled = primers;
            BAnterior.Enabled = primers;
            BSeguent.Enabled = ultims;
            BUltim.Enabled = ultims;


        }

        private void FModificarMecanics_Load(object sender, EventArgs e)
        {
            escuderia e1 = new escuderia();

            esc = e1.llegeixEscuderies();
            carregaComboEscuderies(esc);


            // carreguem els comboBox amb la primera escuderia
            numMecanic = 0;
            carregaTextBox();
            Botonera();
        }

        private void BModifica_Click(object sender, EventArgs e)
        {
            // Variables per a recollir dades
            String nomEscud, nom, nacionalitat,especialitat;
            int temporades;

            // per recollir les dades de la escuderia de dintre de l'objecte pilot
            escuderia esc = new escuderia();

            // Omplim les variables
            nomEscud = CBEscuderia.Text;
            nom = TBNom.Text;
            nacionalitat = TBNacionalitat.Text;
            especialitat = TBEspecialitat.Text;
            temporades = Convert.ToInt32(TBTemporades.Text);

            // cerquem les dades de la escuderia
            esc = esc.CercaEscuderia(nomEscud);

            // Construïm l'objecte
            mecanic m = new mecanic(nom, nacionalitat, esc, especialitat, temporades);

            // Modifiquem el pilot sobre el fitxer
            m.modificarMecanic(m);

            // I tornem a l'estat inicial
            numMecanic = 0;
            carregaTextBox();
            Botonera();
        }



        private void BPrimer_Click(object sender, EventArgs e)
        {
            numMecanic = 0;
            carregaTextBox();
            Botonera();
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            numMecanic--;
            carregaTextBox();
            Botonera();
        }

        private void BSeguent_Click(object sender, EventArgs e)
        {
            numMecanic++;
            carregaTextBox();
            Botonera();
        }

        private void BUltim_Click(object sender, EventArgs e)
        {
            mecanic m = new mecanic();
            int totalMecanics = m.contaMecanic();
            numMecanic = totalMecanics - 1;

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
        private void FModificarMecanics_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }
    }
    
}
