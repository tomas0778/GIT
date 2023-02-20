/*
 *  EVIDENCE POJIŠTĚNÝCH
 *  ZÁVĚREČNÝ PROJEKT PRO ITNETWORK.CZ
 */
using EvidencePojistenych;

// Volba zvolená uživatelem aplikace
char volbaUzivatele = '0';
string jmeno;
string prijmeni;
uint vek;
uint telefonniCislo;

// Instance databáze pojištěných
DatabazePojistenych databazePojistenych = new();

// Instance vlastních metod konzole
MetodyKonzole konzole = new();

// Vypíše název aplikace
konzole.VypisNazevAplikace();

//Hlavní cyklus, reakce na volbu
while (volbaUzivatele != 4)
{
    // Vypíše menu, respketive možné volby
    konzole.VypisMenu();
    //Uloží volbu uživatele do proměnné
    volbaUzivatele = Console.ReadKey().KeyChar;
    
    switch (volbaUzivatele)
    {
        case '1':
            // Načtení jména pojištěného
            Console.Write("\n\nZadejte jméno pojištěného: ");
            jmeno = Console.ReadLine().Trim();

            // Načtení přijmení pojištěného
            Console.Write("Zadejte příjmení pojištěného: ");
            prijmeni = Console.ReadLine().Trim();

            // Načtení věku pojištěného
            Console.Write("Zadejte věk pojištěného: ");            
            while (!uint.TryParse(Console.ReadLine(), out vek))
            {                
                Console.Write("Zadejte věk pojištěného (věk musí být vyjádřen číslem větším jak 0): ");                
            }

            // Načtení telefonního čísla  
            Console.Write("Zadejte telefonní číslo pojištěného: +420 ");
            while (!uint.TryParse(Console.ReadLine(), out telefonniCislo))
            {
                Console.Write("Zadejte telefonní číslo pojištěného (telefonní číslo musí být větší jak 0): ");
            }

            // Uloži nového pojištěného do databáze
            databazePojistenych.PridejPojisteneho(new Pojistenec(jmeno, prijmeni, vek, telefonniCislo));   
            
            // Oznámí úspěšné uložení
            konzole.VypisHlaseni("Data byla úspěšně uložena.");
            break;

        case '2':            
            konzole.VypisHlaseni("Seznam všech pojištěných:");
            databazePojistenych.VypisVsechnyPojistene();
            break;

        case '3':
            // Načte jméno hledaného pojištěného
            Console.Write("\n\nZadejte jméno pojištěného: ");
            jmeno = Console.ReadLine().Trim();

            //Načte přijimeni hledaného pojištěného
            Console.Write("Zadejte příjmení pojištěného: ");
            prijmeni = Console.ReadLine().Trim();

            // Vypíše seznam hledaných pojištěných
            konzole.VypisHlaseni("Seznam hledaných pojištěných:");
            databazePojistenych.VyhledejAVratPojisteneho(jmeno, prijmeni);            
            break;

        case '4':
            // Oznámí ukončení aplikace a ukončí ji
            konzole.VypisHlaseni("Děkuji za použití programu. Aplikace bude ukončena...");
            konzole.UkonciAplikaci();
            break;

        default:
            // Vypíše oznámení o neplatné volbě
            konzole.VypisHlaseni("Byla zadána neplatná volba, zadejte prosím znovu.");
            break;
    }
    
}




