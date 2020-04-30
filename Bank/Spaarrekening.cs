using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class Spaarrekening
    {
        /// <summary>
        /// dit moet in IBAN formaat
        /// </summary>
        public string rekeningnummer
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Het bedrag dat op de rekening staat
        /// </summary>
        public decimal Saldo { get; set; }
        

        /// <summary>
        /// De naam van de eigenaar van de rekening
        /// </summary>
        public string houder { get; set; }
        

        /// <summary>
        /// de basis rentevoet in percentage
        /// </summary>
        public float basisrente { get; set; }


        /// <summary>
        /// de getrouwheidsrente
        /// </summary>
        public float getrouwheid { get; set; }


        /// <summary>
        /// bedrag wordt gestort
        /// </summary>
        /// <param name="bedrag">het bedrag dat in totaal op de rekening staat</param>
        /// <returns>het bedrag dat in totoaal op de rekening staat</returns>
        public decimal storten(decimal bedrag)
        {
            // gestorte bedrag bij saldo tellen
            Saldo += bedrag;
            // nieuwe saldo teruggeven
            return Saldo;
        }

       
    }
}