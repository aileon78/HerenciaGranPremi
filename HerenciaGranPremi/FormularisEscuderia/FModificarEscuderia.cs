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
    public partial class FModificarEscuderia : Form
    {
        int numEsc = 0;
        escuderia[] esc = new escuderia[100];
        escuderia e1 = new escuderia();

        public FModificarEscuderia()
        {
            InitializeComponent();
        }

        public void torna()
        {

            this.Close();

        }
        private void BTornar_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void FModificarEscuderia_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            // Variables per a recollir dades
            String escuderia, motor, pais;
            int any_fundacio;

            // Omplim les variables
            escuderia = TBNomEscuderia.Text;
            motor = TBMotorEscuderia.Text;
            pais = TBPaisEscuderia.Text;
            any_fundacio = Convert.ToInt32(TBAnyEscuderia.Text);

            // Construïm l'objecte
            escuderia esc = new escuderia(escuderia, pais, any_fundacio, motor);

            // Modifiquem la escuderia
            esc.modificarEscuderia();

            // I tornem a l'estat inicial
            numEsc = 0;
            carregaTextBox();
            Botonera();
        }
        private void carregaTextBox()
        {


            // carreguem els textBox amb la escuderia (i)
            TBNomEscuderia.Text = esc[numEsc].Nom;
            TBAnyEscuderia.Text = Convert.ToString(esc[numEsc].Any_fundacio);
            TBPaisEscuderia.Text = esc[numEsc].Pais;
            TBMotorEscuderia.Text = esc[numEsc].Motor;
        }
        private void Botonera()
        {
            Boolean primers, ultims = true;
            escuderia esc = new escuderia();
            int totalEsc = esc.contaEscuderies();

            // primers botons
            if (numEsc == 0)
                primers = false;
            else
                primers = true;

            // últims botons
            if (numEsc == totalEsc - 1)
                ultims = false;
            else
                ultims = true;


            // apliquem els enabled als botons
            BPrimer.Enabled = primers;
            BAnterior.Enabled = primers;
            BSeguent.Enabled = ultims;
            BUltim.Enabled = ultims;


        }

        private void BPrimer_Click(object sender, EventArgs e)
        {
            numEsc = 0;
            carregaTextBox();
            Botonera();
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            numEsc--;
            carregaTextBox();
            Botonera();
        }

        private void BSeguent_Click(object sender, EventArgs e)
        {
            numEsc++;
            carregaTextBox();
            Botonera();
        }

        private void BUltim_Click(object sender, EventArgs e)
        {
            escuderia esc = new escuderia();
            int totalEsc = esc.contaEscuderies();
            numEsc = totalEsc - 1;

            carregaTextBox();
            Botonera();
        }

        private void FModificarEscuderia_Load(object sender, EventArgs e)
        {
            // carreguem els comboBox amb la primera escuderia
            numEsc = 0;
            esc = e1.llegeixEscuderies();
            carregaTextBox();
            Botonera();
        }
    }
}
