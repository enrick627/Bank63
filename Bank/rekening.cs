using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class rekening
    {
        /// <summary>
        /// Het rekeningnummer in IBAN-formaat.
        /// </summary>
        public string Rekeningnummer { get; set; }

        /// <summary>
        /// Het bedrag dat op de rekening staat.
        /// </summary>
        public decimal Saldo { get; set; }

        /// <summary>
        /// Het bedrag dat je onder nul mag gaan (€ 100 krediet wordt als +100 ingesteld).
        /// </summary>
        public decimal Kredietlimiet { get; set; }

        /// <summary>
        /// De naam van de eigenaar van de rekening.
        /// </summary>
        public string Houder { get; set; }

        /// <summary>
        /// het adres van de eigenaar van de rekening.
        /// </summary>
        public string adress { get; set; }

    }
}