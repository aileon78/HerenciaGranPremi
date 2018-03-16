using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaGranPremi.Clases
{
    [Serializable]
   public class escuderia
    {



        // PROPIETATS
        /// <summary>
        /// Nom escuderia
        /// </summary>
        private String nom;
        /// <summary>
        /// pais escuderia
        /// </summary>
        private String pais;
        /// <summary>
        /// primer any de la escuderia en la categoria
        /// </summary>
        private int any_fundacio;
        /// <summary>
        /// Motor que utilitza
        /// </summary>
        private String motor;

        // CONSTRUCTORS
        /// <summary>
        /// Constructor per defecte
        /// </summary>
        public escuderia()
        {
            // Constructor per defecte sense parÃ metres (en aquest cas pÃºblic)
            // Es crea un objecte alumne perÃ² no introduÃ¯m les dades encara
            // sempre es poden introduÃ¯r quant vullga'm
        }
        /// <summary>
        /// Constructor amb totes les dades
        /// </summary>
        /// <param name="nom">Nom Escuderia</param>
        /// <param name="pais">Pais Escuderia</param>
        /// <param name="any_fundacio">Any Fundació Escuderia</param>
        /// <param name="motor">Motor de la escuderia</param>
        public escuderia(String nom, String pais, int any_fundacio, String motor)
        {
            this.nom = nom;
            this.pais = pais;
            this.any_fundacio = any_fundacio;
            this.motor = motor;
        }


        /// <summary>
        /// Representa el nom de la escuderia
        /// </summary>
        public string Nom { get => nom; }
        /// <summary>
        /// Representa el pais de la escuderia
        /// </summary>
        public string Pais { get => pais; }
        /// <summary>
        /// Any de fundació d ela escuderia
        /// </summary>
        public int Any_fundacio { get => any_fundacio; }
        /// <summary>
        /// Motor de la escuderia
        /// </summary>
        public string Motor { get => motor; }


        // ALTRES MÈTODES //
        /// <summary>
        /// Retorna el mode d'escriptura del fitxer. Afegir o Sobreescriure
        /// </summary>
        /// <param name="afegir">true: Afegeix al fitxer. false: Sobreescriu el fitxer</param>
        /// <returns><see cref="FileMode"/> (FileMode.Create) o (FileMode.Append)</returns>
        private FileMode modeFitxer(Boolean afegir)
        {
            if (!afegir)
                return FileMode.Create;
            else
                return FileMode.Append;
        }

        /// <summary>
        /// Afegeix escuderia al fitxer
        /// </summary>
        /// <param name="afegir">afegir o substituir</param>
        /// <param name="arxiu">ruta de l'arxiu</param>
        public void afegeixEscuderia(Boolean afegir = true, String arxiu = "fitxers/escuderies.dat")
        {

            FileMode mode = modeFitxer(afegir);

            Stream str = File.Open(arxiu, mode);


            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(str, this);
            str.Close();

        }

        /// <summary>
        /// Llegeix escuderies del fitxer i retorna vector d'escuderies
        /// </summary>
        /// <param name="arxiu">ruta del fitxer</param>
        /// <returns>Vector d'escuderies</returns>
        public escuderia[] llegeixEscuderies(String arxiu = "fitxers/escuderies.dat")
        {
            // //////////////////////// //
            // LLEGIR OBJECTE EN FITXER //
            // //////////////////////// //
            Stream str = File.Open(arxiu, FileMode.Open);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            int q = 0;
            escuderia[] esc = new escuderia[100];

            do
            {
                try
                {
                    esc[q] = (escuderia)formatter.Deserialize(str);
                }
                catch
                {
                    //MessageBox.Show("Error al llegir el fitxer d'Objectes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                q++;
            } while (esc[q - 1] != null);

            str.Close();
            return esc;

        }

        /// <summary>
        /// Conta les escuderies que hi han al fitxer
        /// </summary>
        /// <returns>Nombre d'escuderies que hi han al fitxer</returns>
        public int contaEscuderies()
        {
            int total = 0;

            escuderia[] esc = new escuderia[100];

            // llegim totes les escuderies
            esc = llegeixEscuderies();

            // busquem la escuderia
            while (esc[total] != null)
            {
                total++;
            }
            return total;
        }

        /// <summary>
        /// Modifica un objecte escuderia
        /// </summary>
        public void modificarEscuderia()
        {
            // Eliminem la escuderia (com que ja l'hem trobat abans,
            // podem dir que està al fitxer
            eliminaEscuderia(this.nom);

            // Afegim la nova escuderia
            // L'afegirà al final del fitxer
            this.afegeixEscuderia();
        }

        /// <summary>
        /// Cerca una escuderia a partir del seu nom
        /// </summary>
        /// <param name="nom_esc">String, nom escuderia</param>
        /// <returns>null si no existeix o l'objecte escuderia si existeix</returns>
        public escuderia CercaEscuderia(String nom_esc)
        {
            escuderia[] esc = new escuderia[100];

            // llegim totes les escuderies
            esc = llegeixEscuderies();

            int i = 0;
            // busquem la escuderia
            do
            {
                if (esc[i].nom.Equals(nom_esc))
                    return esc[i];
                i++;
            } while (esc[i] != null);

            // si no troba res torna null
            return null;

        }

        /// <summary>
        /// Elimina una escuderia a partir del seu nom
        /// </summary>
        /// <param name="nom_esc">String Nom escuderia a eliminar</param>
        public void eliminaEscuderia(String nom_esc)
        {
            escuderia[] esc = new escuderia[100];

            // llegim totes les escuderies
            esc = llegeixEscuderies();

            int i = 0;
            // per comprovar la primera escriptura
            Boolean primer = true;

            // busquem la escuderia
            do
            {
                // quant trobem la que volem borrar no la reescrivim
                if (!esc[i].nom.Equals(nom_esc))
                {
                    if (primer)
                    {
                        // generem fitxer nou
                        esc[i].afegeixEscuderia(false);
                        primer = false;
                    }
                    else
                    {
                        // afegim al fitxer
                        esc[i].afegeixEscuderia(true);
                    }
                }
                i++;
            } while (esc[i] != null);
        }

        /// <summary>
        /// Elimina la escuderia a partir del seu propi objecte
        /// </summary>
        public void eliminaEscuderia()
        {
            escuderia[] esc = new escuderia[100];

            // llegim totes les escuderies
            esc = llegeixEscuderies();

            int i = 0;
            Boolean primer = true;      // per comprovar la primera escriptura

            // busquem la escuderia
            do
            {
                // quant trobem la que volem borrar no la reescrivim
                if (!this.Nom.Equals(esc[i].nom)
                    && !this.motor.Equals(esc[i].motor)
                    && !this.pais.Equals(esc[i].pais)
                    && this.any_fundacio != esc[i].any_fundacio
                    )
                {
                    if (primer)
                    {
                        // generem fitxer nou
                        esc[i].afegeixEscuderia(false);
                        primer = false;
                    }
                    else
                    {
                        // afegim al fitxer
                        esc[i].afegeixEscuderia();
                    }
                }
                i++;
            } while (esc[i] != null);
        }
    }
}
