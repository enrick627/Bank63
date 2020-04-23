using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class rekening
    {
        public string rekeningnummer { get; set;}
        public decimal saldo { get; set;}
        public decimal kredietlimiet { get; set;}
        public string houder { get; set; }
        public decimal stortBedrag { get; set; }
        public decimal afhaalBedrag { get; set; }


    }
}
