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
    public class persona
    {


        //variable privadas
        String nacionalitat;
        String nom;
        escuderia esc;

        public persona()
        {
        }

        public persona(string nacionalitat, string nom, escuderia esc)
        {
            this.Nacionalitat = nacionalitat;
            this.Nom = nom;
            this.Esc = esc;
        }

        public string Nacionalitat { get => nacionalitat; set => nacionalitat = value; }
        public string Nom { get => nom; set => nom = value; }
        public escuderia Esc { get => esc; set => esc = value; }


        //RESTA METODES

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
        public void afegeixPersonaArxiu(String arxiu = "fitxers/persones.dat", bool afegir = true)
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
       

        public int contaPersones(Object []obj)
        {
            int total = 0;

            // busquem el pilot
            while (obj[total] != null)
            {
                total++;
            }
            return total;
        }


    }
}
