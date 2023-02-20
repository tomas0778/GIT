using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    public class MetodyKonzole
    {
        /// <summary>
        /// Metoda vypisující název aplikace
        /// </summary>
        public void VypisNazevAplikace()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" EVIDENCE POJIŠTĚNÝCH");
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// Metoda vypisující menu
        /// </summary>
        public void VypisMenu()
        {
            Console.WriteLine("\nVyberte si akci:\n");
            Console.WriteLine("1 - Přidat nového pojištěného\n" +
                "2 - Vypsat všechny pojištěné\n" +
                "3 - Vyhledat pojištěného\n" +
                "4 - Ukončit aplikaci");
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nZvolená volba: ");
            Console.ResetColor();
        }

        /// <summary>
        /// Metoda ukončující aplikaci
        /// </summary>
        public void UkonciAplikaci()
        {
            Thread.Sleep(2000);
            Environment.Exit(0);
        }

        /// <summary>
        /// Vymaže konzolu a znovu vypíše název aplikace a menu - pouze pro přehlednost
        /// </summary>
        /// <param name="textNovehoZadani"></param>
        public void VypisHlaseni(string textNovehoZadani)
        {
            Console.Clear();
            VypisNazevAplikace();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(textNovehoZadani);
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();
        }       
    }
}
