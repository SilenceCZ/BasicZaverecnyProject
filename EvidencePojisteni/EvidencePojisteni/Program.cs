// Projekt ke zkoušce (BASIC) - Evidence Pojištění
using EvidencePojisteni;
// Instance systému evidence
Evidence evidence = new Evidence();
char volba = '0';
// Hlavní cyklus
while (volba != '4')
{
    evidence.VypisHlavickuObrazovky();
    Console.WriteLine();
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Ukončit aplikaci");
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch (volba)
    {
        case '1':
            evidence.Odradkuj();
            evidence.PridejZaznam();
            break;
        case '2':
            evidence.Odradkuj();
            evidence.VypisZaznamy();
            break;
        case '3':
            evidence.Odradkuj();
            evidence.VyhledejZaznamy();
            break;
        case '4':
            Console.WriteLine("\nLibovolnou klávesou potvrdíte ukončení programu...");
            break;
        default:
            Console.WriteLine("Neplatná volba, pokračujte stisknutím libovolné klávesy...");
            Console.ReadKey();
            break;
    }
}
Console.ReadKey();