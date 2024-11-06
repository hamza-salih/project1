using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1_Home_.Models;

namespace project1.Business
{
    internal class UcEtudiantBusiness
    {
        public ObservableCollection<Etudiant> ListOfObject { get; set; }

        public Etudiant SelectedStudent{ get; set; }
        public string BusinessLabel { get; set; }

        public string AddButton { get; set; }
        public string EditButton { get; set; }
        public string DeleteButton { get; set; }
        public object SelectedAbsence { get; internal set; }

        public UcEtudiantBusiness()
        {
            BusinessLabel = "Gestion Etudiant";
            AddButton = "Ajouter Etudiant";
            EditButton = "Editer Etudiant";
            DeleteButton = "Suprimer Etudiant";
            ListOfObject = new ObservableCollection<Etudiant>();

            for (int i = 0; i < 4; i++)
            {
                Etudiant etudiant = new Etudiant();
                etudiant.Nom = "Salih" + i.ToString();
                etudiant.Prenom = "Hamza" + i.ToString();
                etudiant.CIN = "444444" + i.ToString();
                etudiant.CNE = "343432" + i.ToString();
                ListOfObject.Add(etudiant);

            }

        }
    }
}
