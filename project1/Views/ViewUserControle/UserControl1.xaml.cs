using project1_Home_.Models;
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

namespace project1.Views.ViewUserControle
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void BtnAjouter(object sender, RoutedEventArgs e)
        {
            Etudiant etudiant = new Etudiant();
            Views.DataEntry.StudentDataEntry DataEntry = new DataEntry.StudentDataEntry();
            DataEntry.DataContext = etudiant;

            if (DataEntry.ShowDialog() == true)
            {
                Business.UcEtudiantBusiness bs = this.DataContext as Business.UcEtudiantBusiness;
                if (bs != null)
                {
                    bs.StudentList.Add(etudiant);
                }
                else
                {
                    MessageBox.Show("Error: Business context is not set.");
                }
            }
        }

        private void BtnEditerStudent(object sender, RoutedEventArgs e)
        {
            Business.UcEtudiantBusiness bs = this.DataContext as Business.UcEtudiantBusiness;
            if (bs != null && bs.SelectedStudent != null)
            {
                Views.DataEntry.StudentDataEntry dataEntry = new Views.DataEntry.StudentDataEntry();
                dataEntry.DataContext = bs.SelectedStudent;
                dataEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Please select a student.");
            }
        }


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle the selection change logic here
        }

        private void BtnSuprimer(object sender, RoutedEventArgs e)
        {
            Business.UcEtudiantBusiness bs = this.DataContext as Business.UcEtudiantBusiness;
            if (bs.SelectedStudent != null)
            {
                bs.StudentList.Remove(bs.SelectedStudent);
            }
            else {
                MessageBox.Show("Error: Please select a student.");
            }
        }
    }
}



