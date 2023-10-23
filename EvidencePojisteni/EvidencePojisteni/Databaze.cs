using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Databáze uložených evidenčních záznamů.
    /// </summary>
    internal class Databaze
    {
        private List<Zaznam> zaznamy;
        /// <summary>
        /// Vytvoření nového seznamu záznamů
        /// </summary>
        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }
        /// <summary>
        /// Přidání nového záznamu do evidence
        /// </summary>
        /// <param name="jmeno">Jméno pojištence</param>
        /// <param name="prijmeni">Příjmení pojištence</param>
        /// <param name="vek">Věk pojištence</param>
        /// <param name="telefon">Telefonní číslo pojištence v libovolném formátu</param>
        public void PridejZaznam(string jmeno, string prijmeni, int vek, string telefon)
        {
            zaznamy.Add(new Zaznam(jmeno, prijmeni, vek, telefon));
        }
        /// <summary>
        /// Hledání záznamů dle vstupu uživatele
        /// </summary>
        /// <param name="jmeno">Hledané jméno</param>
        /// <param name="prijmeni">Hledané příjmení</param>
        /// <returns>Nalezené shody ignorující zadanou velikost písmen</returns>
        internal List<Zaznam> NajdiZaznamy(string jmeno, string prijmeni)
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                /// Porovná hledané stringy vůči záznamu a vrátí validní výsledek i při nedodržení původní velikosti písmen záznamu
                if (string.Equals(z.Jmeno, jmeno, StringComparison.OrdinalIgnoreCase) && string.Equals(z.Prijmeni, prijmeni, StringComparison.OrdinalIgnoreCase))
                    nalezene.Add(z);
            }
            return nalezene;
        }
        /// <summary>
        /// Výpis všech záznamů.
        /// </summary>
        /// <returns>Vrací vše z listu.</returns>
        internal List<Zaznam> VypisZaznamy()
        {
            return zaznamy;
        }
    }
}
