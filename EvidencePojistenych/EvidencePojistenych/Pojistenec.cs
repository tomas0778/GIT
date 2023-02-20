using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    public class Pojistenec
    {
        /// <summary>
        /// Jméno pojištěného
        /// </summary>
        public string Jmeno { get; private set; }
        /// <summary>
        /// Přijmení pojištěného
        /// </summary>
        public string Prijmeni { get; private set; }
        /// <summary>
        /// Věk pojištěného
        /// </summary>
        public uint Vek { get; private set; }
        /// <summary>        
        /// Telefonní číslo pojištěného
        /// </summary>
        public uint TelefonniCislo { get; private set; }
        /// <summary>
        /// Konstruktor pojištěnce
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefonniCislo"></param>
        public Pojistenec(string jmeno, string prijmeni, uint vek, uint telefonniCislo) 
        { 
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }
        public override string ToString()
        {
            return string.Format(Jmeno + "\t\t" + Prijmeni + "\t\t" + Vek + "\t\t" + TelefonniCislo);            
        }
    }
}
