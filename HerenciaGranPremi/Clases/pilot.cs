using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaGranPremi.Clases
{
    [Serializable]
   public class pilot : persona
    {

        // PROPIETATS
      
        /// <summary>
        /// dorsal del pilot
        /// </summary>
        private int dorsal;
       
      


        // CONSTRUCTORS //   
        /// <summary>
        /// Constructor per defecte
        /// </summary>
        public pilot()
        {
            // Constructor per defecte sense paràmetres (en aquest cas públic)
            // Es crea un objecte pilot però no introduem les dades encara
            // sempre es poden introduïr quant vullga'm

        }
        /// <summary>
        /// Constructor per defecte
        /// </summary>
        /// <param name="nom">Nom del pilot</param>
        /// <param name="nacionalitat">Nacionalitat del pilot</param>
        /// <param name="dorsal">Dorsal del pilot</param>
        /// <param name="esc">escuderia del pilot. Objecte <see cref="escuderia"/></param>
        public pilot(String nom, String nacionalitat,escuderia esc,int dorsal):base (nacionalitat,nom,esc)
        {
           
            this.dorsal = dorsal;
          
        }

        // GETTERS & SETTERS
       
       
        /// <summary>
        /// dorsal del pilot
        /// </summary>
        public int Dorsal { get => dorsal; }


        // ALTRES MÈTODES //


        /// <summary>
        /// Cerca un pilot a partir del seu nou
        /// </summary>
        /// <param name="nomPilot">Nom del pilot a cercar</param>
        /// <returns>Null si no existeix o l'objecte pilot si existeix</returns>
        public pilot cercarPilot(String nomPilot)
        {
            // retorna un objecte pilot si el troba
            // retorna un null si no troba el pilot

            pilot[] p = new pilot[100];

            // llegim totes les escuderies
            p = this.llegeixPilotFitxer();

            int i = 0;
            // busquem el pilot
            do
            {
                if (p[i].Nom.Equals(nomPilot))
                    return p[i];
                i++;
            } while (p[i] != null);

            // si no troba res torna null
            return null;


        }

        /// <summary>
        /// Conta el nombre de pilots del fitxer
        /// </summary>
        /// <returns>Nombre sencer indicant el nombre de pilots</returns>
        public int contaPilots()
        {
            // retornarà el número de pilots que hi han al fitxer


            pilot p1 = new pilot();

            // llegim tots els pilots
            return p1.contaPersones(llegeixPilotFitxer());



        }

        /// <summary>
        /// Elimina un pilot del fitxer
        /// </summary>
        /// <param name="nom_p">Nom del Pilot. String</param>
        public void eliminaPilot(String nom_p)
        {
            String fitxer = "fitxers/pilots.dat";
            pilot[] p = new pilot[100];

            // llegim tots els pilots
            p = llegeixPilotFitxer();

            // declarem 2 variables: 
            //      -- Per llegir el vector que he extret del fitxer
            //      -- Per crear un nou vector sense la escuderia que vull borrar
            int i = 0;      // per llegir
            int j = 0;      // per comprovar la primera escriptura

            // busquem el pilot
            do
            {
                // quant trobem el que volem borrar no el reescrivim
                if (!p[i].Nom.Equals(nom_p))
                {
                    if (j == 0)
                    {
                        //p[i].afegeixPilotFitxer(fitxer, false);   // generem fitxer nou

                        p[i].afegeixPersonaArxiu("fitxers/pilots.dat", false);   // generem fitxer nou

                    }
                    else
                    {
                        //p[i].afegeixPilotFitxer(fitxer, true);    // afegim al fitxer

                        p[i].afegeixPersonaArxiu("fitxers/pilots.dat", true);   // afegim al fitxer nou
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
        /// Afegeix el pilot p al fitxer arxiu
        /// </summary>
        /// <param name="p">Objecte pilot</param>
        /// <param name="arxiu">Ruta de l'arxiu</param>
        /// <param name="afegir">true=afegir. false=reescriu arxiu</param>
        //public void afegeixPilotFitxer(String arxiu = "fitxers/pilots.dat", bool afegir = true)
        //{
        //    // ///////////////////////// //
        //    // INSERIR OBJECTE EN FITXER //
        //    // ///////////////////////// //
        //    FileMode mode = modeFitxer(afegir);

        //    Stream str = File.Open(arxiu, mode);
        //    var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        //    formatter.Serialize(str, this);
        //    str.Close();
        //}

        /// <summary>
        /// Llegeix fitxer de pilots i els encapsula en vector de pilots
        /// </summary>
        /// <param name="arxiu">ruta del fitxer</param>
        /// <returns>Vector de pilots</returns>
        public pilot[] llegeixPilotFitxer(String arxiu = "fitxers/pilots.dat")
        {
            // //////////////////////// //
            // LLEGIR OBJECTE EN FITXER //
            // //////////////////////// //
            Stream str;
            pilot[] p = new pilot[100];
            try
            {
                str = File.Open(arxiu, FileMode.Open);


                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                int q = 0;


                do
                {
                    try
                    {
                        p[q] = (pilot)formatter.Deserialize(str);
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
        public void modificarPilot(pilot pilotAModificar)
        {
            // Eliminem el pilot (com que ja l'hem trobat abans,
            // podem dir que està al fitxer
            eliminaPilot(this.Nom);

            // Afegim el nou pilot
            // L'afegirà al final del fitxer
            this.afegeixPersonaArxiu("fitxers/pilots.dat");
        }

        
    }
}
