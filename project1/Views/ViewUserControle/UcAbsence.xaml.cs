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
    /// Logique d'interaction pour UcAbsence.xaml
    /// </summary>
    public partial class UcAbsence : UserControl
    {
        public UcAbsence()
        {
            InitializeComponent();
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Content != null && btn.Content.Equals("Ajouter Absence"))
            {
                Absence absence = new Absence();
                var dataEntry = new Views.DataEntry.AbsenceDataEntry();
                dataEntry.DataContext = absence;

                if (dataEntry.ShowDialog() == true)
                {
                    Business.UcAbsenceBusiness bs = this.DataContext as Business.UcAbsenceBusiness;
                    if (bs != null)
                    {
                        bs.ListOfObject.Add(absence);
                    }
                    else
                    {
                        MessageBox.Show("Error: Business context is not set.");
                    }
                }
            }
        }

        private void BtnEditer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSuprimer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AbsenceGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
