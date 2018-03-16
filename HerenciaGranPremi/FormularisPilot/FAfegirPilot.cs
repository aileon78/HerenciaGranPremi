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
    public partial class FAfegirPilot : Form
    {
        public FAfegirPilot()
        {
            InitializeComponent();
        }


        public void torna()
        {

            this.Close();

        }
        private void BTorna_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void BAfegeix_Click(object sender, EventArgs e)
        {
            // creem variables
            String nom, nacionalitat;
            int dorsal;
            escuderia esc = new escuderia();

            // recollim les dades dels text box
            nom = TBNom.Text;
            nacionalitat = TBNacionalitat.Text;
            dorsal = Convert.ToInt32(TBDorsal.Text);
            esc = esc.CercaEscuderia(CBEscuderia.Text);

            // construim l'objecte
            pilot p = new pilot(nom, nacionalitat,  esc, dorsal);

            // guardem al fitxer
            p.afegeixPersonaArxiu("fitxers/pilots.dat");

            // buidem els Text Box
            TBNom.Text = "";
            TBDorsal.Text = "";
            TBNacionalitat.Text = "";
        }

        private void FAfegirPilot_Load(object sender, EventArgs e)
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

        private void FAfegirPilot_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }
    }
}
