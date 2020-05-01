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
 *       aan gebruiker of hij een rekenining wilt openen
 *       aan de gebruiker zijn gegevens
 *       saldo
 *       kredietlimiet
 *       rekeningnummer
 *       houder 
 *       of ze willen storten of afhalen
 *       bedrag storten
 *       of ze willen afhalen
 *       of u wilt zoeken naar een rekening of niet
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
        {
            client clientnr1 = new client();


            clientnr1.Voornaam = "marie";
            clientnr1.Familienaam = "jeanne";
            clientnr1.Adres = "willebroek";

            zichtrekening ClientRek = new zichtrekening();
            ClientRek.Rekeningnummer = "BE55 55 66 77 88 99";
            ClientRek.Saldo = 500;
            Spaarrekening SprRekening = new Spaarrekening();
            SprRekening.basisrente = 2;
            SprRekening.getrouwheidsrente = 5;
            Console.WriteLine($"basisrente: {SprRekening.basisrente}%");
            Console.WriteLine($"getrouwheid: {SprRekening.getrouwheidsrente}%");
            Console.WriteLine($"rekeningnummer: {ClientRek.Rekeningnummer}");
            Console.ReadLine();
        }
    }
}
