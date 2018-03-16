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
            pilot p = new pilot();
            int totalPilots = p.contaPilots();

            // primers botons
            if (numMecanic == 0)
                primers = false;
            else
                primers = true;

            // últims botons
            if (numMecanic == totalPilots - 1)
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

        }
    }
}
