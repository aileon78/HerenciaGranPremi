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
    public partial class FMostrarGP : Form
    {
        public FMostrarGP()
        {
            InitializeComponent();
        }

        private void FMostrarGP_Load(object sender, EventArgs e)
        {
            granPremi[] gps = new granPremi[100];
            granPremi gp = new granPremi();
            gps = gp.llegeixGranPremiFitxer();
            String guanyador;

            int i = 0;

            do
            {
                // com potser que hi hagin valors nulls (si encara no ha guanyat el gran premi) 
                // ho comprovem primer
                if (gps[i].Guanyador == null)
                    guanyador = "-";
                else
                    guanyador = gps[i].Guanyador.Nom;


                // Ara imprimim tot
                RTText.Text = RTText.Text + "GP: " + gps[i].Nom + " " + gps[i].Pais + " (" + gps[i].Any + ")" + "\nPremi: " + gps[i].Premi + "\nGuanyador: " + guanyador + "\n\n";
                i++;
            } while (gps[i] != null);
        }



        private void torna()
        {
            this.Close();
        }
        private void BTorna_Click(object sender, EventArgs e)
        {
            torna();
        }

        private void FMostrarGP_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }
    }
}
