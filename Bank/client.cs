using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class client
    {

        private List<rekening> rekeningen;

        public client()
        {
            rekeningen = new List<rekening>();
        }

        /// <summary>
        /// De voornaam van de cliënt.
        /// </summary>
        public string Voornaam { get; set; }
        /// <summary>
        /// De familienaam van de cliënt.
        /// </summary>
        public string Familienaam { get; set; }
        /// <summary>
        /// Het adres van de cliënt (vereenvoudigd als string)
        /// </summary>
        public string Adres { get; set; }

        /// <summary>
        /// De rekeningen van deze cliënt
        /// </summary>
        public List<rekening> Rekeningen
        {
            get { return rekeningen; }
            set { rekeningen = value; }
        }

        /// <summary>
        /// Open een rekening voor deze cliënt.
        /// </summary>
        /// <param name="rekening">De rekening voor deze cliënt.</param>
        public void RekeningOpenen(rekening rekening)
        {
            // Deze cliënt als houder van de rekening instellen
            rekening.Houder = $"{Voornaam} {Familienaam}";
            // De rekening toevoegen aan de rekeningen van de cliënt
            rekeningen.Add(rekening);
        }

        /// <summary>
        /// sluit de rekening alleen als er geen geld meer op staat
        /// </summary>
        /// <param name="rekeningnummer">Het rekeningnummer van de te sluiten rekening.</param>
        /// <returns>true indien sluiting gelukt is; false indien niet.</returns>
        public bool RekeningSluiten(string rekeningnummer)
        {
            bool isGelukt;
            // zoek de te sluiten rekening
            rekening teSluitenRekening = RekeningOpzoeken(rekeningnummer);
            // Verwijder de gezochte rekening uit de lijst
            isGelukt = rekeningen.Remove(teSluitenRekening);
            return isGelukt;
        }

        /// <summary>
        /// Zoek een rekening van deze cliënt op.
        /// </summary>
        /// <param name="rekeningnummer">Het rekeningnummer van de te zoeken rekening.</param>
        /// <returns>De rekening indien gevonden; null indien niet gevonden.</returns>
        public rekening RekeningOpzoeken(string rekeningnummer)
        {
            rekening gezochteRekening = null;
            foreach (rekening rekening in rekeningen)
            {
                if (rekening.Rekeningnummer == rekeningnummer)
                    gezochteRekening = rekening;
            }
            return gezochteRekening;
        }

        /// <summary>
        /// bedrag op een bepaalde rekening zetten
        /// </summary>
        public decimal stortingUitvoeren()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// bedraga van een bepaalde rekening halen
        /// </summary>
        public decimal afhalingUitvoeren()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// bedrag van een bepaalde rekening naar een bepaald rekeningnummer
        /// </summary>
        public decimal OverschrijvingUitvoeren()
        {
            throw new System.NotImplementedException();
        }
    }
}
