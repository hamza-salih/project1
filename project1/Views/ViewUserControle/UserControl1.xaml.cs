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
            Button btn = sender as Button;
            if (btn != null && btn.Content != null && btn.Content.Equals("Ajouter Etudiant"))
            {
                Etudiant etudiant = new Etudiant();
                var dataEntry = new Views.DataEntry.StudentDataEntry();
                dataEntry.DataContext = etudiant;

                if (dataEntry.ShowDialog() == true)
                {
                    Business.UcEtudiantBusiness bs = this.DataContext as Business.UcEtudiantBusiness;
                    if (bs != null)
                    {
                        bs.ListOfObject.Add(etudiant);
                    }
                    else
                    {
                        MessageBox.Show("Error: Business context is not set.");
                    }
                }
            }
            else
            {
                var absenceEntry = new Views.DataEntry.AbsenceDataEntry();
                absenceEntry.ShowDialog();
            }
        }


        private void BtnEditerStudent(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Business.UcEtudiantBusiness bs = this.DataContext as Business.UcEtudiantBusiness;

            if (bs == null)
            {
                MessageBox.Show("Error: Business context is not set.");
                return;
            }

            if (btn != null && btn.Content != null && btn.Content.Equals("Editer Etudiant"))
            {
                if (bs.SelectedStudent == null)
                {
                    MessageBox.Show("Error: Please select a student.");
                    return;
                }

                var dataEntry = new Views.DataEntry.StudentDataEntry();
                dataEntry.DataContext = bs.SelectedStudent;
                dataEntry.ShowDialog();
            }
            else if (btn != null && btn.Content != null && btn.Content.Equals("Editer Absence"))
            {
                if (bs.SelectedAbsence == null)
                {
                    MessageBox.Show("Error: Please select an absence.");
                    return;
                }

                var absenceEntry = new Views.DataEntry.AbsenceDataEntry();
                absenceEntry.DataContext = bs.SelectedAbsence;
                absenceEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Invalid action.");
            }
        }



        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void BtnSuprimer(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Business.UcEtudiantBusiness bs = this.DataContext as Business.UcEtudiantBusiness;

            if (bs == null)
            {
                MessageBox.Show("Error: Business context is not set.");
                return;
            }

            if (btn != null && btn.Content != null && btn.Content.Equals("Supprimer Etudiant"))
            {
                if (bs.SelectedStudent == null)
                {
                    MessageBox.Show("Error: Please select a student.");
                    return;
                }

                bs.ListOfObject.Remove(bs.SelectedStudent);
                MessageBox.Show("Student has been deleted.");
            }
            else if (btn != null && btn.Content != null && btn.Content.Equals("Supprimer Absence"))
            {
                if (bs.SelectedAbsence == null)
                {
                    MessageBox.Show("Error: Please select an absence.");
                    return;
                }

                bs.ListOfObject.Remove((Etudiant)bs.SelectedAbsence);
                MessageBox.Show("Absence has been deleted.");
            }
            else
            {
                MessageBox.Show("Error: Invalid action.");
            }
        }

    }
}



