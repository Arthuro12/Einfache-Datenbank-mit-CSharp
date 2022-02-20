using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MeineDatenbankÜbung
{
    /// <summary>
    /// Interaktionslogik für SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        
        public Person _neuePerson;
        public Mitarbeiter _neuerMitarbeiter;
        public Student _neuerStudent;
        public bool _edit;

        public SecondWindow()
        {
            InitializeComponent();

        }
        public SecondWindow(Mitarbeiter neuerMitarbeiter,  bool edit = false)
        {
            InitializeComponent();
            //Mitarbeiter editieren              

            _neuerMitarbeiter = neuerMitarbeiter;

            if (edit == true)
            {
                mitarbeiter_rb.IsChecked = true;
                _edit = true;
                geschlecht_tb.Text = _neuerMitarbeiter.Geschlecht;
                vorname_tb.Text = _neuerMitarbeiter.Vorname;
                nachname_tb.Text = _neuerMitarbeiter.Nachname;
                anrede_tb.Text = _neuerMitarbeiter.Anrede;
                telNr_tb.Text = _neuerMitarbeiter.Telefonnummer;
                mail_tb.Text = _neuerMitarbeiter.Email;
                plz_tb.Text = _neuerMitarbeiter.Plz;
                strasse_tb.Text = _neuerMitarbeiter.Strasse;
                hausnr_tb.Text = _neuerMitarbeiter.Hausnummer;
            }


        }
        public SecondWindow(Student neuerStudent, bool edit = false)
        {
            InitializeComponent();
            //Student editieren
            _neuerStudent = neuerStudent;
            if (edit == true)
            {
                student_rb.IsChecked = true;
                geschlecht_tb.Text = _neuerStudent.Geschlecht;
                vorname_tb.Text = _neuerStudent.Vorname;
                nachname_tb.Text = _neuerStudent.Nachname;
                telNr_tb.Text = _neuerStudent.Telefonnummer;
                mail_tb.Text = _neuerStudent.Email;
                plz_tb.Text = _neuerStudent.Plz;
                strasse_tb.Text = _neuerStudent.Strasse;
                hausnr_tb.Text = _neuerStudent.Hausnummer;
                matnr_tb.Text = _neuerStudent.Matrikelnummer;
                stg_tb.Text = _neuerStudent.Studiengang;
                fs_tb.Text = _neuerStudent.Fachsemester;
            }
        }

        private void ok_bt_Click(object sender, RoutedEventArgs e)
        {
            //Daten in Eugabemaske eintippen
            if (_edit == true)
            {
                if (mitarbeiter_rb.IsChecked == true)
                {
                    _neuerMitarbeiter = new Mitarbeiter(geschlecht_tb.Text, vorname_tb.Text, nachname_tb.Text, anrede_tb.Text, telNr_tb.Text, mail_tb.Text, plz_tb.Text, strasse_tb.Text, hausnr_tb.Text);

                }
                else if (student_rb.IsChecked == true)
                {
                    _neuerStudent = new Student(geschlecht_tb.Text, vorname_tb.Text, nachname_tb.Text, telNr_tb.Text, mail_tb.Text, plz_tb.Text, strasse_tb.Text, hausnr_tb.Text, matnr_tb.Text, stg_tb.Text, fs_tb.Text);
                }

            }
            else
            {
                if (mitarbeiter_rb.IsChecked == true)
                {
                    _neuerMitarbeiter = new Mitarbeiter(geschlecht_tb.Text, vorname_tb.Text, nachname_tb.Text, anrede_tb.Text, telNr_tb.Text, mail_tb.Text, plz_tb.Text, strasse_tb.Text, hausnr_tb.Text, DateTime.Now);

                }
                else if (student_rb.IsChecked == true)
                {
                    _neuerStudent = new Student(geschlecht_tb.Text, vorname_tb.Text, nachname_tb.Text, telNr_tb.Text, mail_tb.Text, plz_tb.Text, strasse_tb.Text, hausnr_tb.Text, matnr_tb.Text, DateTime.Now, stg_tb.Text, fs_tb.Text);
                }
            }
            
            this.DialogResult = true;
            this.Close();
                
        }

        private void mitarbeiter_rb_Checked(object sender, RoutedEventArgs e)
        {
            anrede_tb.IsEnabled = true;
            fs_tb.IsEnabled = false;
            stg_tb.IsEnabled = false;
            matnr_tb.IsEnabled = false;
        }

        private void student_rb_Checked(object sender, RoutedEventArgs e)
        {
            fs_tb.IsEnabled = true;
            stg_tb.IsEnabled = true;
            matnr_tb.IsEnabled = true;
            anrede_tb.IsEnabled = false;
        }      
    }
}
