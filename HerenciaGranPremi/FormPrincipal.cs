using HerenciaGranPremi.Clases;
using HerenciaGranPremi.FormularisEscuderia;
using HerenciaGranPremi.FormularisGranPremi;
using HerenciaGranPremi.FormularisMecanic;
using HerenciaGranPremi.FormularisPilot;
using System;
using System.Windows.Forms;

namespace HerenciaGranPremi
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private Boolean comprovaDades(String dades)
        {
            // comprova si existeixen dades de pilot i d'escuderia
            // per obrir els formularis de pilots i de grans premis
            // o per no obrir-los
            switch (dades)
            {
                case "pilot":
                    pilot p = new pilot();
                    if (p.contaPilots() > 0)
                        return true; ;
                    break;
                case "escuderia":
                    escuderia e = new escuderia();
                    if (e.contaEscuderies() > 0)
                        return true;
                    break;
                case "gp":
                    granPremi gp = new granPremi();
                    if (gp.contaGPs() > 0)
                        return true; ;
                    break;
                case "mecanic":
                    mecanic mec = new mecanic();
                    if (mec.contaMecanic() > 0)
                        return true; ;
                    break;
            }
            return false;

        }

        private void afegeixEscuderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAfegirEscuderia mostra = new FAfegirEscuderia();
            mostra.Show();

        }

        private void mostraEscuderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("escuderia"))
            {
                FMostrarEscuderia f = new FMostrarEscuderia();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminaEscuderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("escuderia"))
            {
                FEliminaEscuderia f = new FEliminaEscuderia();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificaEscuderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("escuderia"))
            {
                FModificarEscuderia f = new FModificarEscuderia();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void afegirPilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("escuderia"))
            {
                FAfegirPilot f = new FAfegirPilot();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar pilots", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarPilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("pilot") && comprovaDades("escuderia"))
            {
                FModificaPilot f = new FModificaPilot();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar pilots i o escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarPilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("pilot") && comprovaDades("escuderia"))
            {
                FEliminarPilots f = new FEliminarPilots();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar pilots i o escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarPilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("pilot") && comprovaDades("escuderia"))
            {
                FMostraPilots f = new FMostraPilots();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar pilots i o escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void afegirGranPremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("pilot"))
            {
                FAfegirGP f = new FAfegirGP();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar pilots", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarÇGranPremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("pilot") && comprovaDades("gp"))
            {
                FMostrarGP f = new FMostrarGP();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar pilots i o escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarGranPremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("pilot") && comprovaDades("gp"))
            {
                FEliminarGP f = new FEliminarGP();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar pilots i o escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarGranPremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("pilot") && comprovaDades("gp"))
            {
                FModificarGP f = new FModificarGP();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar pilots i o escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarMecanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("mecanic") && comprovaDades("escuderia"))
            {
                FMostraMecanics f = new FMostraMecanics();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar pilots i o escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void afegirMecanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("escuderia"))
            {
                FAfegirMecanic f = new FAfegirMecanic();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar mecanics", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarMecanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("mecanic") && comprovaDades("escuderia"))
            {
                FEliminarMecanics f = new FEliminarMecanics();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar mecanic i o escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarMecanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprovaDades("mecanic") && comprovaDades("escuderia"))
            {
                FModificarMecanics f = new FModificarMecanics();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'insertar mecanic i o escuderies", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
