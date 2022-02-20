using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeineDatenbankÜbung
{
    public class Student : Person
    {
        private string _Matrikelnummer;
        public string Matrikelnummer
        {
            get { return _Matrikelnummer; }
            set { _Matrikelnummer = value; }
        }
        private string _Fachsemester;
        public string Fachsemester
        {
            get { return _Fachsemester; }
            set { _Fachsemester = value; }
        }
        private string _Studiengang;
        public string Studiengang
        {
            get { return _Studiengang; }
            set { _Studiengang = value; }
        }
        public Student(string geschlecht, string vorname, string nachname, string telefonnummer, string email, string plz, string strasse, string hausnummer, string matrikelnummer, DateTime erstellungsdatum, string studiengang, string fachsemester)
        {
            Geschlecht = geschlecht;
            Vorname = vorname;
            Nachname = nachname;
            Telefonnummer = telefonnummer;
            Email = email;
            Plz = plz;
            Strasse = strasse;
            Hausnummer = hausnummer;
            Matrikelnummer = matrikelnummer;
            Erstellungsdatum = erstellungsdatum;
            Studiengang = studiengang;
            Fachsemester = fachsemester;
        }

        public Student(string geschlecht, string vorname, string nachname, string telefonnummer, string email, string plz, string strasse, string hausnummer, string matrikelnummer, string studiengang, string fachsemester)
        {
            Geschlecht = geschlecht;
            Vorname = vorname;
            Nachname = nachname;
            Telefonnummer = telefonnummer;
            Email = email;
            Plz = plz;
            Strasse = strasse;
            Hausnummer = hausnummer;
            Matrikelnummer = matrikelnummer;
            //Erstellungsdatum = erstellungsdatum;
            Studiengang = studiengang;
            Fachsemester = fachsemester;
        }
        public Student()
        {

        }
        public override string PersonInformationen()
        {
            return base.PersonInformationen() + ", Fachsemester: " + Fachsemester + ", Studiengang: " + Studiengang;
        }
    }
}
