using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    public class DatabazePojistenych
    {
        /// <summary>
        /// List pojištěných
        /// </summary>
        List<Pojistenec> listPojistenych = new List<Pojistenec>();
        
        /// <summary>
        /// Metoda přidávající do Listu nového pojištěného
        /// </summary>
        /// <param name="pojistenec"></param>
        public void PridejPojisteneho(Pojistenec pojistenec)
        {
            listPojistenych.Add(pojistenec);
        }

        /// <summary>
        /// Metoda vypisující všechny pojištěné
        /// </summary>
        public void VypisVsechnyPojistene()
        {
            foreach (var pojisteny in listPojistenych)
            {
                Console.WriteLine(pojisteny);
            }            
        }

        /// <summary>
        /// Metoda vyhledávající a vracející konkrétního pojištěného
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        public void VyhledejAVratPojisteneho(string jmeno, string prijmeni)
        {
            var dotaz = from pojistenec in listPojistenych
                        where (pojistenec.Jmeno == jmeno && pojistenec.Prijmeni == prijmeni)
                        select pojistenec;
            if (dotaz.Count() > 0)
            {
                foreach (var pojistenec in dotaz)
                {
                    Console.WriteLine(pojistenec.Jmeno + "\t\t" + pojistenec.Prijmeni + "\t\t" + pojistenec.Vek + "\t\t" + pojistenec.TelefonniCislo);
                }
            }
            else
            {
                Console.WriteLine("V databázi se nenachází pojištěný splňující zadaná kritéria");
            }
        }           
    }
}
