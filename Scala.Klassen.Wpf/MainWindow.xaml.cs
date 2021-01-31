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

namespace Scala.Klassen.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Persoon student = new Persoon();
            student.Naam = "Janssens";
            student.Voornaam = "Wim";
            student.Geboortedatum = new DateTime(1995, 12, 24);
            student.IsMan = true;

            Persoon docent = new Persoon("Willems", "Jan", new DateTime(1985, 5, 1), true);

            lstPersonen.Items.Add(student);
            lstPersonen.Items.Add(docent);
        }

        private void lstPersonen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Persoon persoon = (Persoon)lstPersonen.SelectedItem;
            lblNaam.Content = persoon.Naam;
            lblVoornaam.Content = persoon.Voornaam;
            lblGeboortedatum.Content = persoon.Geboortedatum.ToString("ddd dd/MM/yyyy");
            if (persoon.IsMan)
                lblGeslacht.Content = "Man";
            else
                lblGeslacht.Content = "Vrouw";
        }
    }
}
