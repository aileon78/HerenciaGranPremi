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
    public partial class FMostrarEscuderia : Form
    {
        public FMostrarEscuderia()
        {
            InitializeComponent();
        }

        private void BTorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void FMostrarEscuderies_Load(object sender, EventArgs e)
        //{
        //    escuderia[] esc = new escuderia[100];
        //    escuderia e1 = new escuderia();
        //    esc = e1.llegeixEscuderies();
        //    int i = 0;

        //    do
        //    {
        //        RTText.Text = RTText.Text + "Escuderia: " + esc[i].Nom
        //            + " (" + esc[i].Any_fundacio + ")"
        //            + "\nPais: " + esc[i].Pais
        //            + "\nMotor: " + esc[i].Motor + "\n\n";
        //        i++;
        //    } while (esc[i] != null);
        //}


        private void FMostrarEscuderia_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
        }

        private void FMostrarEscuderia_Load(object sender, EventArgs e)
        {
            escuderia[] esc = new escuderia[100];
            escuderia e1 = new escuderia();
            esc = e1.llegeixEscuderies();
            int i = 0;

            do
            {
                RTText.Text = RTText.Text + "Escuderia: " + esc[i].Nom
                    + " (" + esc[i].Any_fundacio + ")"
                    + "\nPais: " + esc[i].Pais
                    + "\nMotor: " + esc[i].Motor + "\n\n";
                i++;
            } while (esc[i] != null);
        }
    }
}
