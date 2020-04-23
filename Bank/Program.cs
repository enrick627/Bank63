///Enrick De Munter nr3 5ITN 23/04/2020
/*
 * OPGAVE
 * ======
 * Creëer 2 classes voor een eenvoudig banksysteem:
 * 1. Rekening
 * een bankrekening heeft volgende eigenschappen:
 * rekeningnummer (in IBAN-formaat)
 * saldo (het bedrag dat op de rekening staat)
 * kredietlimiet (het bedrag dat je onder nul mag gaan)
 * houder (de naam van de eigenaar van de rekening)
 * een bankrekening kan volgende acties uitvoeren:
 * storten: bedrag wordt gestort; geeft het nieuwe saldo terug
 * afhalen: bedrag wordt afgehaald indien mogelijk; geeft terug of het gelukt is om af te
 * halen of niet
 * 
 * 2. Client
 * een cliënt heeft volgende eigenschappen:
 * voornaam
 * familienaam
 * adres
 * lijst met rekeningen
 * een cliënt kan volgende acties uitvoeren:
 * rekening openen
 * rekening sluiten
 * rekening opzoeken (a.d.h.v. rekeningnummer)
 * storting uitvoeren (bedrag op een bepaalde rekening)
 * afhaling uitvoeren (bedrag van een bepaalde rekening)
 *
 * 
 * ANALYSE
 * =======
 * 
 * VRAAG alle gegevens aan de gebruiker
 * vraag aan gebruiker of hij een rekenining wilt openen
 * Vraag aan de gebruiker zijn gegevens
 * vraag saldo
 * vraag kredietlimiet
 * vraag rekeningnummer
 * Vraag houder 
 * Vraag of ze willen storten of afhalen
 * Vraag bedrag storten
 * Vraag of ze willen afhalen
 * Vraag of u wilt zoeken naar een rekening of niet
 * 
 * Bereken het stortbedrag(het saldo + storten bedrag)
 * Bereken het afhaalbedrag(het saldo - afhaal bedrag)
 * 
 * TOON
 *          alle antwoorden van de vragen
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {   //declaraties
            rekening Rekening;
            Rekening = new rekening();

            client Client;
            Client = new client();

            decimal Somstortbedrag = 0; 
            string GetalStortAfhaal; 
            decimal totsomkrediet, RekeningNummer;
            string Openen, RekeningNummerOpzoekenVraag, Rekekeningnummerzoek;
            //proccessing
            //vraag aan gebruiker of hij een rekenining wilt openen of niet
            Console.WriteLine("wilt u een rekenening openen?");
            Openen = Console.ReadLine();
            if (Openen == "ja")
            {
                //Vraag aan de gebruiker zijn gegevens
                //Vraag de voornaam
                Console.WriteLine("geef uw voornaam");
                Client.Voornaam = Console.ReadLine();

                //vraag de familienaam
                Console.WriteLine("geef uw familienaam");
                Client.Familienaam = Console.ReadLine();

                //vraag het adres
                Console.WriteLine("geef uw adres");
                Client.Adres = Console.ReadLine();
                
                //vraag kredietlimiet
                Console.WriteLine("kredietlimiet:");
                Rekening.kredietlimiet = decimal.Parse(Console.ReadLine()); 
            }
            if (Openen == "nee")
            {
                //vraag saldo
                Console.WriteLine("saldo:");
                Rekening.saldo = decimal.Parse(Console.ReadLine());

                Console.WriteLine("U wilt geen rekening openen");

                //vraag rekeningnummer
                Console.WriteLine("rekeningnummer:");
                Rekening.rekeningnummer = Console.ReadLine();
                RekeningNummer = decimal.Parse(Rekening.rekeningnummer);
                
                //Vraag houder 
                Console.WriteLine("houder:");
                Rekening.houder = Console.ReadLine();

                //Vraag of ze willen storten of afhalen
                Console.WriteLine("type ja als je wilt storten type nee als je wilt afhalen");
                GetalStortAfhaal = Console.ReadLine();
                if (GetalStortAfhaal == "ja")
                {
                    //Vraag bedrag storten
                    Console.WriteLine("bedrag dat u wil storten?");
                    Rekening.stortBedrag = decimal.Parse(Console.ReadLine());

                    //Bereken het stortbedrag(het saldo + storten bedrag)
                    Somstortbedrag = Rekening.stortBedrag + Rekening.saldo;
                    Console.WriteLine($"totaal bedrag na storten {Somstortbedrag}");
                }
                if (GetalStortAfhaal == "nee")
                {

                    {
                        //Vraag of ze willen afhalen
                        Console.WriteLine("het bedrag dat u wilt afhalen?");
                        Rekening.afhaalBedrag = decimal.Parse(Console.ReadLine());

                        //Bereken het afhaalbedrag(het saldo - afhaal bedrag)
                        Somstortbedrag = Rekening.saldo - Rekening.afhaalBedrag;
                        Console.WriteLine($"totaal bedrag na afhalen {Somstortbedrag}");
                        totsomkrediet = Rekening.kredietlimiet - Rekening.afhaalBedrag;
                        if (totsomkrediet < Rekening.kredietlimiet)
                        {
                            Console.WriteLine("je mag dit niet je gaat onder je ingestelde limiet.");
                        }
                    }

                }
                //Vraag of u wilt zoeken naar een rekening of niet
                Console.WriteLine("als u een rekening wilt zoeken type dan ja anders type je nee");
                RekeningNummerOpzoekenVraag = Console.ReadLine();
                if (RekeningNummerOpzoekenVraag == "ja")
                {
                    Console.WriteLine("wat is het rekeningnummer dat je wilt zoeken");
                    Rekekeningnummerzoek = Console.ReadLine();
                    Console.WriteLine($"rekeningnummer {Rekekeningnummerzoek} is niet te vinden");
                }
            }
            


            //Wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter als u de rekenening wilt sluiten");
            Console.ReadKey();
        }
    }
}
