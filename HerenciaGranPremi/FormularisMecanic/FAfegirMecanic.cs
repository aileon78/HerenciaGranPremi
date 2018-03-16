using HerenciaGranPremi.Clases;
using System;
using System.Windows.Forms;

namespace HerenciaGranPremi.FormularisMecanic
{
    public partial class FAfegirMecanic : Form
    {
        public FAfegirMecanic()
        {
            InitializeComponent();
        }

        private void BTAfegir_Click(object sender, EventArgs e)
        {

            //variables para guaardar los datos
            String nom, nacionalitat, especialitat;
            int temporades;
            escuderia esc = new escuderia();



            ///recogemos los datos de los textBox y combo
            nom = TBNomAfMec.Text;
            nacionalitat = TBNacionalitaAfeMec.Text;
            especialitat = TBEspecialitatAfMec.Text;
            temporades = Convert.ToInt32(TBTemporadesAfMec.Text);
            esc = esc.CercaEscuderia(CBEscuderia.Text);
            //construimos el objeto para enviar los datos a guardar.
            mecanic m = new mecanic(nom, nacionalitat, esc, especialitat, temporades);


            //guardamos dentro del fichero
            m.afegeixPersonaArxiu("Fitxers/mecanics.dat");


            //vaciamos los textBox
            TBNomAfMec.Text = "";
            TBNacionalitaAfeMec.Text = "";
            TBEspecialitatAfMec.Text = "";
            TBTemporadesAfMec.Text = "";



        }

        private void FAfegirMecanic_Load(object sender, EventArgs e)
        {

            // carrega escuderies
            escuderia[] esc = new escuderia[100];
            escuderia e1 = new escuderia();

            esc = e1.llegeixEscuderies();
            carregaComboEscuderies(esc);
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
    }
}
