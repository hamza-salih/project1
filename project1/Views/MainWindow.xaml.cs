using project1.Business;
using project1_Home_.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using project1_Home_.Models;

namespace project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Business.MainWindowBusiness mainWindowBusiness = new Business.MainWindowBusiness();
            InitializeComponent();
            this.DataContext = mainWindowBusiness;  
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            //List<Etudiant> list = new List<Etudiant>();
            //Etudiant etudiant = new Etudiant();

            //project1_Home_.Models.Etudiant etudiant = new project1_Home_.Models.Etudiant();
            //etudiant.Nom = "Salih";
            //etudiant.Prenom = "Hamza";
            //etudiant.CIN = "444444";
            //etudiant.CNE = "343432";
            //list.Add(etudiant);
            //GridGestionEtudiant.ItemsSource = list;

        }
    }
}