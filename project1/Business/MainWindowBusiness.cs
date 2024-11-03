using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using project1_Home_.Models;

namespace project1.Business
{
    public class MainWindowBusiness
    {
        public string MainWindowTitle { get; set; }
        public List<Etudiant> EtdList { get; set; }
        public MainWindowBusiness()
        {

            EtdList = new List<Etudiant>();


            MainWindowTitle = "Hello World";
            
            for (int i = 0; i < 4; i++)
            {
                Etudiant etudiant = new Etudiant();
                etudiant.Nom = "Salih" + i.ToString();
                etudiant.Prenom = "Hamza" + i.ToString();
                etudiant.CIN = "444444" + i.ToString();
                etudiant.CNE = "343432" + i.ToString();
                EtdList.Add(etudiant);

            }


        }
    }
}
