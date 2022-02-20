using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeineDatenbankÜbung
{
    public class Person
    {
        private string _Geschlecht;
        public string Geschlecht
        {
            get { return _Geschlecht; }
            set { _Geschlecht = value; }
        }
        private string _Vorname;
        public string Vorname
        {
            get { return _Vorname; }
            set { _Vorname = value; }
        }
        private string _Nachname;
        public string Nachname
        {
            get { return _Nachname; }
            set { _Nachname = value; }
        }
        private string _Telefonnummer;
        public string Telefonnummer
        {
            get { return _Telefonnummer; }
            set { _Telefonnummer = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _Plz;
        public string Plz
        {
            get { return _Plz; }
            set { _Plz = value; }
        }
        private string _Strasse;
        public string Strasse
        {
            get { return _Strasse; }
            set { _Strasse = value; }
        }
        private string _Hausnummer;
        public string Hausnummer
        {
            get { return _Hausnummer; }
            set { _Hausnummer = value; }
        }
        private DateTime _Erstellungsdatum;
        public DateTime Erstellungsdatum 
        { 
            get {return _Erstellungsdatum; } set { _Erstellungsdatum = value; }
        }
       public Person()
       {

       }
        public virtual string PersonInformationen()
        {
            return "Geschlecht: " + Geschlecht + ", Vorname: " + Vorname + ", Nachname: " + Nachname + ", Telefonnummer: " + Telefonnummer + ", Email: " + Email
                   + ", Plz: " + Plz + ", Strasse: " + Strasse + ", Hausnummer: " + Hausnummer + ", Datum: " + Erstellungsdatum;
        }
    }
}

