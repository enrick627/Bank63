﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class client
    {

        private List<zichtrekening> rekeningen;

        public client()
        {
            rekeningen = new List<zichtrekening>();
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
        public List<zichtrekening> Rekeningen
        {
            get { return rekeningen; }
            set { rekeningen = value; }
        }

        /// <summary>
        /// Open een rekening voor deze cliënt.
        /// </summary>
        /// <param name="rekening">De rekening voor deze cliënt.</param>
        public void RekeningOpenen(zichtrekening rekening)
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
            zichtrekening teSluitenRekening = RekeningOpzoeken(rekeningnummer);
            // Verwijder de gezochte rekening uit de lijst
            isGelukt = rekeningen.Remove(teSluitenRekening);
            return isGelukt;
        }

        /// <summary>
        /// Zoek een rekening van deze cliënt op.
        /// </summary>
        /// <param name="rekeningnummer">Het rekeningnummer van de te zoeken rekening.</param>
        /// <returns>De rekening indien gevonden; null indien niet gevonden.</returns>
        public zichtrekening RekeningOpzoeken(string rekeningnummer)
        {
            zichtrekening gezochteRekening = null;
            foreach (zichtrekening rekening in rekeningen)
            {
                if (rekening.Rekeningnummer == rekeningnummer)
                    gezochteRekening = rekening;
            }
            return gezochteRekening;
        }



        /// <summary>
        /// bedraga van een bepaalde rekening halen
        /// </summary>
        /// <param name="bedrag">het bedrag dat van de rekening wordt gehaalt</param>
        /// <returns>dat waneer er niet genoeg geld op de rekening staat. het niet gaat</returns>
        public bool afhalingUitvoeren(decimal bedrag = 0)
        {
            bool isGelukt = false;
            zichtrekening Afhaal = new zichtrekening();
            // Geld afhalen mogelijk ALS saldo + kredietlimiet >= bedrag
            if (Afhaal.Saldo >= bedrag)
            {
                // geld afhalen => saldo aanpassen
                Afhaal.Saldo -= bedrag;
                // geld afhalen is gelukt
                isGelukt = true;
                
            }
            return isGelukt;

        }

        /// <summary>
        /// bedrag op een bepaalde rekening plaatsen
        /// </summary>
        /// <param name="bedrag">het bedrag dat gaat worden gestort op de rekening</param>
        /// <returns>of de storting succesvol is gebeurtd</returns>
        public decimal StortingUitvoeren(decimal bedrag)
        {
            zichtrekening Stort = new zichtrekening();
            Stort.Saldo += bedrag ;
            Console.WriteLine("het is succesvol op uw rekening gestort");
            return Stort.Saldo;
        }
        /// <summary>
        /// bedrag van een bepaalde rekening naar een bepaald rekeningnummer
        /// </summary>
        /// <param name="bedrag">het bedrag dat van een bepaalde rekening naar een bepaalde rekeningummer moet</param>
        /// <returns>Of de overschrijving succesvol is gebeurt</returns>
        public bool OverschrijvingUitvoeren(decimal bedrag)
        {
            
            bool IsGelukt = false;
            decimal BedragNaarAnderPers = 0;
            zichtrekening Overschrijven = new zichtrekening();
            //je kan allen geld afhalen als er genoeg geld opstaat
            if (Overschrijven.Saldo > bedrag)
            {
                Overschrijven.Saldo -= bedrag;
                BedragNaarAnderPers += bedrag;

                IsGelukt = true;

            }
            return IsGelukt;

        }

        
    }
}
