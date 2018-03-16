using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaGranPremi.Clases
{
    [Serializable]
    public class granPremi
    {
        // PROPIETATS
        /// <summary>
        /// Any de celebració del GP
        /// </summary>
        private int any;
        /// <summary>
        /// Nom del GP
        /// </summary>
        private String nom;
        /// <summary>
        /// Pais del GP
        /// </summary>
        private String pais;
        /// <summary>
        /// Quantitat de $ guanyats per GP
        /// </summary>
        private double premi;
        /// <summary>
        /// Guanyador del GranPremi
        /// </summary>
        private pilot guanyador;



        // MÈTODES CLASSE    
        /// <summary>
        /// Constructor per defecte sense parÃ metres (en aquest cas pÃºblic)
        /// Es crea un objecte alumne perÃ² no introduÃ¯m les dades encara
        /// sempre es poden introduÃ¯r quant vullga'm
        /// </summary>
        public granPremi()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom">nom gp</param>
        /// <param name="pais">pais gp</param>
        /// <param name="premi">premi en $ per aquest gp</param>
        /// <param name="guanyador"><see cref="pilot"/>guanyador</param>
        /// <param name="any">any del gp</param>
        public granPremi(String nom, String pais, double premi, pilot guanyador, int any)
        {
            this.nom = nom;
            this.pais = pais;
            //this.ordre_sortida=ordre_sortida;
            //this.podi = podi;
            this.premi = premi;
            this.guanyador = guanyador;
            this.any = any;
        }



        /// <summary>
        /// any del gp
        /// </summary>
        public int Any { get => any; }
        /// <summary>
        /// nom del gp
        /// </summary>
        public string Nom { get => nom; }
        /// <summary>
        /// pais del gp
        /// </summary>
        public string Pais { get => pais; }
        /// <summary>
        /// premi del gp
        /// </summary>
        public double Premi { get => premi; }
        /// <summary>
        /// <see cref="pilot"/> guanyador del gp
        /// </summary>
        public pilot Guanyador { get => guanyador; }

        // RESTA MÈTODES //
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
        /// afegeix un gp al fitxer de granPremis
        /// </summary>
        /// <param name="arxiu">String representant la ruta del fitxer</param>
        /// <param name="afegir">true: afegim el fitxer. false: reescrivim el fitxer</param>
        public void afegeiGranPremi(String arxiu = "fitxers/granPremis.dat", bool afegir = true)
        {

            // ///////////////////////// //
            // INSERIR OBJECTE EN FITXER //
            // ///////////////////////// //
            FileMode mode = modeFitxer(afegir);


            Stream str = File.Open(arxiu, mode);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(str, this);
            str.Close();
        }

        /// <summary>
        /// retorna els grans premis del fitxer en un vector d'objectes de <see cref="granPremi"/>
        /// </summary>
        /// <param name="arxiu">ruta del fitxer granPremis</param>
        /// <returns>vector de <see cref="granPremi"/> amb la informació del fitxer</returns>
        public granPremi[] llegeixGranPremiFitxer(String arxiu = "fitxers/granPremis.dat")
        {
            // //////////////////////// //
            // LLEGIR OBJECTE EN FITXER //
            // //////////////////////// //
            Stream str = File.Open(arxiu, FileMode.Open);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            int q = 0;
            granPremi[] gps = new granPremi[100];

            do
            {
                try
                {
                    gps[q] = (granPremi)formatter.Deserialize(str);
                }
                catch
                {
                    //MessageBox.Show("Error al llegir el fitxer d'Objectes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                q++;
            } while (gps[q - 1] != null);

            str.Close();
            return gps;
        }

        /// <summary>
        /// Elimina un Gran premi a partir del seu nom
        /// </summary>
        /// <param name="nom_gp">String amb el nom del GP a eliminar</param>
        public void eliminaGranPremi(String nom_gp)
        {
            String fitxer = "fitxers/granPremis.dat";
            granPremi[] gps = new granPremi[100];

            // llegim tots els pilots
            gps = llegeixGranPremiFitxer();

            // declarem 2 variables: 
            //      -- Per llegir el vector que he extret del fitxer
            //      -- Per crear un nou vector sense la escuderia que vull borrar
            int i = 0;      // per llegir
            int j = 0;      // per comprovar la primera escriptura

            // busquem el pilot
            do
            {
                // quant trobem el que volem borrar no el reescrivim
                if (!gps[i].nom.Equals(nom_gp))
                {
                    if (j == 0)
                    {
                        gps[i].afegeiGranPremi(fitxer, false);   // generem fitxer nou
                    }
                    else
                    {
                        gps[i].afegeiGranPremi(fitxer, true);    // afegim al fitxer
                    }
                    j++;
                }
                i++;
            } while (gps[i] != null);
        }

        /// <summary>
        /// Cerca un GP a partir del seu nom
        /// </summary>
        /// <param name="nomGranPremi">String amb el nom del GP</param>
        /// <returns>null si no troba el objecte, o l'objecte <see cref="granPremi"/> si existeix al fitxer</returns>
        public granPremi cercarGranPremi(String nomGranPremi)
        {
            // retorna un objecte gp si el troba
            // retorna un null si no troba el gp

            granPremi[] gp = new granPremi[100];

            // llegim tots els gps
            gp = this.llegeixGranPremiFitxer();

            int i = 0;
            // busquem el gp
            do
            {
                if (gp[i].nom.Equals(nomGranPremi))
                    return gp[i];
                i++;
            } while (gp[i] != null);

            // si no troba res torna null
            return null;


        }

        /// <summary>
        /// Modifica un granPremi a partir del seu objecte
        /// </summary>
        public void modificarGP()
        {
            // Eliminem el gp (com que ja l'hem trobat abans,
            // podem dir que està al fitxer
            eliminaGranPremi(this.nom);

            // Afegim el nou GP
            // L'afegirà al final del fitxer
            this.afegeiGranPremi();
        }

        /// <summary>
        /// Conta el número de GP's que hi han al fitxer
        /// </summary>
        /// <returns>Número sencer amb la quantitat de GP's al fitxer</returns>
        public int contaGPs()
        {
            // retornarà el número de pilots que hi han al fitxer
            int total = 0;

            granPremi[] gps = new granPremi[100];

            // llegim tots els pilots
            gps = llegeixGranPremiFitxer();

            // contem els gps
            while (gps[total] != null)
            {
                total++;
            }
            return total;
        }
    }
}
