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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Xml.Serialization;

namespace MeineDatenbankÜbung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Person _neuePerson;   
        Mitarbeiter _neuerMitarbeiter;
        Student _neuerStudent;
        public List<Person> listVonPersonen = new List<Person>();
        public MainWindow()
        {           
            InitializeComponent();
            ausgabe_lb.ItemsSource = listVonPersonen;
        }

        private void neuesFenster_bt_Click(object sender, RoutedEventArgs e)
        {

            SecondWindow newWindow = new SecondWindow();
            
            //Zweite form wird aufgerufen
            newWindow.ShowDialog();
            //if (newWindow.DialogResult.HasValue && newWindow.DialogResult.Value)
            //{
                //ausgabe_lb.Items.Add(newWindow._neuePerson);
                if (newWindow._neuerMitarbeiter != null)
                {
                    listVonPersonen.Add(newWindow._neuerMitarbeiter);
                    ausgabe_lb.Items.Refresh();
                }
                else if(newWindow._neuerStudent != null)
                {
                    listVonPersonen.Add(newWindow._neuerStudent);
                    ausgabe_lb.Items.Refresh();
                }
               
            //}
           
        }

        private void ausgabe_lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Person ausgewaehltePerson = (Person)ausgabe_lb.SelectedItem;

            if(ausgewaehltePerson != null)
            {
                personInfo_tb.Text = ausgewaehltePerson.PersonInformationen();
            }

        }
        private void edit_bt_Click(object sender, RoutedEventArgs e)
        {
            if(listVonPersonen.Count > 0)
            {
                if (listVonPersonen[ausgabe_lb.SelectedIndex] is Mitarbeiter)
                {
                    _neuerMitarbeiter = (Mitarbeiter)ausgabe_lb.SelectedItem;
                    int selectedIndex = ausgabe_lb.SelectedIndex;

                    SecondWindow newWindow = new SecondWindow(_neuerMitarbeiter, true);
                    newWindow.ShowDialog();
                    if (newWindow.DialogResult.HasValue && newWindow.DialogResult.Value)
                    {
                        listVonPersonen.RemoveAt(selectedIndex);
                        listVonPersonen.Insert(selectedIndex, newWindow._neuerMitarbeiter);
                        ausgabe_lb.Items.Refresh();
                    }
                }
                else if (listVonPersonen[ausgabe_lb.SelectedIndex] is Student)
                {
                    _neuerStudent = (Student)ausgabe_lb.SelectedItem;
                    int selectedIndex = ausgabe_lb.SelectedIndex;

                    SecondWindow newWindow = new SecondWindow(_neuerStudent, true);
                    newWindow.ShowDialog();
                    if (newWindow.DialogResult.HasValue && newWindow.DialogResult.Value)
                    {
                        listVonPersonen.RemoveAt(selectedIndex);
                        listVonPersonen.Insert(selectedIndex, newWindow._neuerStudent);
                        ausgabe_lb.Items.Refresh();
                    }
                }
            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ausgabe_lb.Items.Count > 0)
            {
                int selectecIndex = ausgabe_lb.SelectedIndex;
                listVonPersonen.RemoveAt(selectecIndex);
                ausgabe_lb.Items.Refresh();
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(listVonPersonen.Count > 0)
            {
                List<Person> sortedList = listVonPersonen.OrderBy(item => item.Vorname).ToList();
                listVonPersonen.Clear();
                listVonPersonen = sortedList;
                ausgabe_lb.ItemsSource = listVonPersonen;
                ausgabe_lb.Items.Refresh();
            }
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(listVonPersonen.Count > 0)
            {
                List<Person> sortedList = listVonPersonen.OrderBy(item => item.Erstellungsdatum).ToList();
                listVonPersonen.Clear();
                listVonPersonen = sortedList;
                ausgabe_lb.ItemsSource = listVonPersonen;
                ausgabe_lb.Items.Refresh();
            }
        }

        private void export_bt_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer mSer = new XmlSerializer(typeof(Mitarbeiter));
            TextWriter mWriter = new StreamWriter("C:\\temp\\mitarbeiter.xml");
            XmlSerializer sSer = new XmlSerializer(typeof(Student));
            TextWriter sWriter = new StreamWriter("C:\\temp\\student.xml");
            
            if (listVonPersonen.Count > 0)
            {
                foreach (Person p in listVonPersonen)
                {
                    if (p is Mitarbeiter)
                    {
                        mSer.Serialize(mWriter, p);
                    }
                    else if (p is Student)
                    {
                        sSer.Serialize(sWriter, p);
                    }
                    //mWriter.Close();
                    //sWriter.Close();
                    MessageBox.Show("Export ist fertig!!");
                }
            }           

        }
    }
}
