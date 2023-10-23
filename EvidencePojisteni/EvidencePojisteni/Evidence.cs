using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Reprezentuje evidenční systém pro správu záznamů pojištení.
    /// </summary>
    internal class Evidence
    {
        private Databaze databaze;

        public Evidence()
        {
            databaze = new Databaze();
        }
        /// <summary>
        /// Zpracování vstupu uživatele při hledání v databázi
        /// </summary>
        /// <returns>Výstup pro předání funkci VyhledejZaznamy</returns>
        public (string jmeno, string prijmeni) ZjistiJmeno()
        {
            Console.WriteLine("Zadejte křestní jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string prijmeni = Console.ReadLine();
            return (jmeno, prijmeni);
        }
        /// <summary>
        /// Vypíše záznamy z databáze
        /// </summary>
        public void VypisZaznamy()
        {
            List<Zaznam> zaznamy = databaze.VypisZaznamy();
            if (zaznamy.Count > 0)
            {
                Console.WriteLine("Seznam všech pojištěných:\n");
                Console.WriteLine("Jméno         Příjmení      Věk  Telefon");
                Console.WriteLine("------------------------------------------");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z.ToString());

            }
            else
            {
                Console.WriteLine("Tato pojišťovna aktuálně nedisponuje žádnou klientelou.");
            }
            Console.WriteLine("\nPokračujte stisknutím libovolné klávesy...");
            Console.ReadKey();
        }
        /// <summary>
        /// Přidá záznam do databáze na základě vstupu uživatele
        /// </summary>
        public void PridejZaznam()
        {
            (string jmeno, string prijmeni) = ZjistiJmeno();
            /// Validace uživatelského vstupu, ochrana před zadáním pouze prázdných znaků či mezery
            if (string.IsNullOrWhiteSpace(jmeno) || string.IsNullOrWhiteSpace(prijmeni))
            {
                Console.WriteLine("Jméno a příjmení nesmí být prázdné.");
                Console.WriteLine("\nStiskem libovolné klávesy se navraťte k výběru akce...");
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine("Zadejte věk pojištěného: ");
            int vek;
            /// Validace vstupu - akceptuje pouze hodnotu v celých číslech
            while (!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Neplatné zadání. Zadejte znovu pomocí čísel:");
            
            Console.WriteLine("Zadejte telefonní číslo pojištěného: ");
            string telefon = Console.ReadLine();
            databaze.PridejZaznam(jmeno, prijmeni, vek, telefon);
            Console.WriteLine("Nový pojištěnec byl úspěšně přidán.");
            Console.WriteLine("\nPokračujte stiskem libovolné klávesy...");
            Console.ReadKey();
        }
        /// <summary>
        /// Vyhledá záznamy v databázi na základě dříve zpracovaného vstupu uživatele
        /// </summary>
        public void VyhledejZaznamy()
        {
            var (jmeno, prijmeni) = ZjistiJmeno();
            List<Zaznam> zaznamy = databaze.NajdiZaznamy(jmeno, prijmeni);
            if (zaznamy.Count > 0)
            {
                Console.WriteLine("\nJméno         Příjmení      Věk  Telefon");
                Console.WriteLine("------------------------------------------");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z.ToString());

            }

            else
            {
                Console.WriteLine("Pojištěnec nebyl nalezen.");
            }

            Console.WriteLine("\nPokračujte stisknutím libovolné klávesy...");
            Console.ReadKey();
        }
        /// <summary>
        /// Smaže předchozí obsah konzole a vypíše čistou hlavičku
        /// </summary>
        public void VypisHlavickuObrazovky()
        {
            Console.Clear();
            Console.WriteLine("------------------------------\nEvidence pojištěných\n------------------------------");
        }
        /// <summary>
        /// Provede odřádkování pro uživatelské prostředí
        /// </summary>
        public void Odradkuj()
        {
            Console.WriteLine();
        }

    }
}
