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
    public partial class FAfegirEscuderia : Form
    {
        public FAfegirEscuderia()
        {
            InitializeComponent();
        }

        private void BTornar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostra = new FormPrincipal();
            mostra.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TBAnyEscuderia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TBPaisEscuderia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBNomEscuderia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBMotorEscuderia_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAfegir_Click(object sender, EventArgs e)
        {
            // recollim dades
            String nom_esc = TBNomEscuderia.Text;
            String pais_esc = TBPaisEscuderia.Text;
            String motor_esc = TBMotorEscuderia.Text;
            int any_esc = Convert.ToInt32(TBAnyEscuderia.Text);

            // construïm l'objecte
            escuderia esc = new escuderia(nom_esc, pais_esc, any_esc, motor_esc);

            // escrivim al fitxer
            esc.afegeixEscuderia();

            // tornar a posar els text box en blanc
            TBNomEscuderia.Text = "";
            TBPaisEscuderia.Text = "";
            TBAnyEscuderia.Text = "";
            TBMotorEscuderia.Text = "";
        }
    }
}
