using System;
using System.Collections.Generic;
using System.Text;

namespace Scala.Klassen.Wpf
{
    class Persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public bool IsMan { get; set; }

        public Persoon()
        {
        }
        public Persoon(string naam, string voornaam, DateTime geboortedatum, bool isman)
        {
            Naam = naam;
            Voornaam = voornaam;
            Geboortedatum = geboortedatum;
            IsMan = isman;
        }

        public override string ToString()
        {
            return $"{Naam} {Voornaam}";
        }
    }
}
