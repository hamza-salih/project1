using project1.Business;
using System.Windows;

namespace project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Business.MainWindowBusiness mainWindowBusiness = new Business.MainWindowBusiness();
            //Business.UcEtudiantBusiness ucEtudiantBusiness = new Business.UcEtudiantBusiness();
            //this.DataContext = ucEtudiantBusiness;
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

        Views.ViewUserControle.UserControl1 gestion_user;
        private void BtnGestionEtd(object sender, RoutedEventArgs e)
        {
            gestion_user = new();
            Business.UcEtudiantBusiness ucEtudiantBusiness = new();
            gestion_user.DataContext = ucEtudiantBusiness;
            UserGrid.Children.Clear();
            UserGrid.Children.Add(gestion_user);

        }

        private void BtnAbsence_Click(object sender, RoutedEventArgs e)
        {
            gestion_user.DataContext = new UcAbsenceBusiness();
            //Views.ViewUserControle.UcAbsence gestion_absence = new Views.ViewUserControle.UcAbsence();
            //Business.UcAbsenceBusiness ucAbsenceBusiness = new Business.UcAbsenceBusiness();
            //gestion_absence.DataContext = ucAbsenceBusiness;
            //UserGrid.Children.Clear();
            //UserGrid.Children.Add(gestion_absence);


        }
    }
}