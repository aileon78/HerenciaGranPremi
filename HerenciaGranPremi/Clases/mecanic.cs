using System;
using System.IO;
using System.Windows.Forms;

namespace HerenciaGranPremi.Clases
{
    [Serializable]
    public class mecanic : persona
    {
        //variables

        String especialitat;
        int num_temporades;

        //constructores
        public mecanic()
        {
        }

        public mecanic(String nom, String nacionalitat, escuderia esc, String especialitat, int num_temporades) : base(nacionalitat, nom, esc)
        {
            this.Especialitat = especialitat;
            this.Num_temporades = num_temporades;
        }
        //GETTERS SETTERS
        public string Especialitat { get => especialitat; set => especialitat = value; }
        public int Num_temporades { get => num_temporades; set => num_temporades = value; }



        //RESTA METODES

        /// <summary>
        /// Cerca un pilot a partir del seu nou
        /// </summary>
        /// <param name="nomMecanic">Nom del pilot a cercar</param>
        /// <returns>Null si no existeix o l'objecte pilot si existeix</returns>
        public mecanic cercarMecanic(String nomMecanic)
        {
            // retorna un objecte pilot si el troba
            // retorna un null si no troba el pilot

            mecanic[] m = new mecanic[100];

            // llegim totes les escuderies
            m = this.llegeixMecanicFitxer();

            int i = 0;
            // busquem el pilot
            do
            {
                if (m[i].Nom.Equals(nomMecanic))
                    return m[i];
                i++;
            } while (m[i] != null);

            // si no troba res torna null
            return null;


        }

        /// <summary>
        /// Conta el nombre de pilots del fitxer
        /// </summary>
        /// <returns>Nombre sencer indicant el nombre de pilots</returns>
        public int contaMecanic()
        {
            // retornarà el número de pilots que hi han al fitxer


            mecanic m1 = new mecanic();

            // llegim tots els pilots
            return m1.contaPersones(llegeixMecanicFitxer());



        }

        /// <summary>
        /// Elimina un pilot del fitxer
        /// </summary>
        /// <param name="nom_m">Nom del Pilot. String</param>
        public void eliminaMecanic(String nom_m)
        {
            String fitxer = "fitxers/mecanics.dat";
            mecanic[] p = new mecanic[100];

            // llegim tots els pilots
            p = llegeixMecanicFitxer();

            // declarem 2 variables: 
            //      -- Per llegir el vector que he extret del fitxer
            //      -- Per crear un nou vector sense la escuderia que vull borrar
            int i = 0;      // per llegir
            int j = 0;      // per comprovar la primera escriptura

            // busquem el pilot
            do
            {
                // quant trobem el que volem borrar no el reescrivim
                if (!p[i].Nom.Equals(nom_m))
                {
                    if (j == 0)
                    {
                        //p[i].afegeixPilotFitxer(fitxer, false);   // generem fitxer nou

                        p[i].afegeixPersonaArxiu("fitxers/mecanics.dat", false);   // generem fitxer nou

                    }
                    else
                    {
                        //p[i].afegeixPilotFitxer(fitxer, true);    // afegim al fitxer

                        p[i].afegeixPersonaArxiu("fitxers/mecanics.dat", true);   // afegim al fitxer nou
                    }
                    j++;
                }
                i++;
            } while (p[i] != null);
        }




        /// <summary>
        /// Retorna el mode d'escriptura del fitxer. Afegir o Sobreescriure
        /// </summary>
        /// <param name="afegir">true: Afegeix al fitxer. false: Sobreescriu el fitxer</param>
        /// <returns><see cref="FileMode"/> (FileMode.Create) o (FileMode.Append)</returns>
        public FileMode modeFitxer(Boolean afegir)
        {
            if (!afegir)
                return FileMode.Create;
            else
                return FileMode.Append;
        }



        /// <summary>
        /// Llegeix fitxer de pilots i els encapsula en vector de pilots
        /// </summary>
        /// <param name="arxiu">ruta del fitxer</param>
        /// <returns>Vector de pilots</returns>
        public mecanic[] llegeixMecanicFitxer(String arxiu = "fitxers/mecanics.dat")
        {
            // //////////////////////// //
            // LLEGIR OBJECTE EN FITXER //
            // //////////////////////// //
            Stream str;
            mecanic[] p = new mecanic[100];
            try
            {
                str = File.Open(arxiu, FileMode.Open);


                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                int q = 0;


                do
                {
                    try
                    {
                        p[q] = (mecanic)formatter.Deserialize(str);
                    }
                    catch
                    {
                        //MessageBox.Show("Error al llegir el fitxer d'Objectes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    q++;
                } while (p[q - 1] != null);
                str.Close();
            }
            catch
            {
                MessageBox.Show("Error al llegir el fitxer d'Objectes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return p;
        }





        /// <summary>
        /// Modifica un pilot a partir de l'objecte d'aquest pilot
        /// </summary>
        /// <param name="pilotAModificar">Objecte pilot a modificar</param>
        public void modificarPilot(mecanic mecanicAModificar)
        {
            // Eliminem el pilot (com que ja l'hem trobat abans,
            // podem dir que està al fitxer
            eliminaMecanic(this.Nom);

            // Afegim el nou pilot
            // L'afegirà al final del fitxer
            this.afegeixPersonaArxiu("fitxers/mecanics.dat");
        }


    }
}
