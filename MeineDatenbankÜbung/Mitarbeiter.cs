using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeineDatenbankÜbung
{
    public class Mitarbeiter : Person
    {
        private string _Anrede;
        public string Anrede
        {
            get { return _Anrede; }
            set { _Anrede = value; }
        }
        public Mitarbeiter(string geschlecht, string vorname, string nachname, string anrede, string telefonnummer, string email, string plz, string strasse, string hausnummer, DateTime erstellungsdatum)
        {
            Geschlecht = geschlecht;
            Vorname = vorname;
            Nachname = nachname;
            Anrede = anrede;
            Telefonnummer = telefonnummer;
            Email = email;
            Plz = plz;
            Strasse = strasse;
            Hausnummer = hausnummer;
            Erstellungsdatum = erstellungsdatum;          
        }
        public Mitarbeiter(string geschlecht, string vorname, string nachname, string anrede, string telefonnummer, string email, string plz, string strasse, string hausnummer)
        {
            Geschlecht = geschlecht;
            Vorname = vorname;
            Nachname = nachname;
            Anrede = anrede;
            Telefonnummer = telefonnummer;
            Email = email;
            Plz = plz;
            Strasse = strasse;
            Hausnummer = hausnummer;
            //Erstellungsdatum = erstellungsdatum;
        }
        public Mitarbeiter()
        {

        }
        public override string PersonInformationen()
        {
            return base.PersonInformationen() + ", Anrede: " + Anrede + ", Erstellungsdatum: " + Erstellungsdatum;
        }

    }
}

