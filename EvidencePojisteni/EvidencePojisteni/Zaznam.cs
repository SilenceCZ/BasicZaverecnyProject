using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Reprezentuje záznam uchovávající data o pojištené osobě.
    /// </summary>
    internal class Zaznam
    {
        /// <summary>
        /// Jméno - vlastnost třídy
        /// </summary>
        public string Jmeno {  get; set; }
        /// <summary>
        /// Příjmení - vlastnost třídy
        /// </summary>
        public string Prijmeni { get; set; }
        /// <summary>
        /// Věk - vlastnost třídy
        /// </summary>
        public int Vek { get; set; }
        /// <summary>
        /// Telefon - vlastnost třídy
        /// </summary>
        public string Telefon { get; set; }

        /// <summary>
        /// Inicializace nové instance - Záznamu - s parametry:
        /// </summary>
        /// <param name="jmeno">Křestní jméno pojištěnce</param>
        /// <param name="prijmeni">Příjmení pojištěnce</param>
        /// <param name="vek">Věk pojištěnce</param>
        /// <param name="telefon">Telefonní číslo pojištěnce v libovolném formátu</param>
        public Zaznam(string jmeno, string prijmeni, int vek, string telefon) 
        { 
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }
        /// <summary>
        /// Stanovení konkrétní podoby výpisu objektů třídy
        /// </summary>
        /// <returns>Vrací všechny parametry třídy s definovaným odsazením v řádku pro lepší čitelnost.</returns>
        public override string ToString()
        {
            return $"{Jmeno, -14}{Prijmeni, -14}{Vek, -5}{Telefon}";
        }
    }
}
