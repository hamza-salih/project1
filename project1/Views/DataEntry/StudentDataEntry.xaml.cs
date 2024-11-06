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

namespace project1.Views.DataEntry
{
    /// <summary>
    /// Logique d'interaction pour StudentDataEntry.xaml
    /// </summary>
    public partial class StudentDataEntry : Window
    {
        public StudentDataEntry()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();

        //}

        private void BtnEnregistrer(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void BtnAnnuler(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
