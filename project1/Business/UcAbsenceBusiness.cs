using project1_Home_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.Business
{
    internal class UcAbsenceBusiness
    {
        public List<Absence> ListOfObject { get; set; }
        public Etudiant SelectedAbsence { get; set; }

        public string BusinessLabel { get; set; }
        public string AddButton { get; set; }
        public string EditButton { get; set; }
        public string DeleteButton { get; set; }

        public UcAbsenceBusiness() 
        {
            BusinessLabel = "Gestion Absence";
            AddButton = "Ajouter Absence";
            EditButton = "Editer Absence";
            DeleteButton = "Suprimer Absence";
            ListOfObject = new List<Absence>();

            for (int i = 0; i < 10; i++) {
                ListOfObject = new List<Absence>();
                Absence absence = new Absence();
                absence.id_Absence = 1;
                absence.Name = "Hamza";
                ListOfObject.Add(absence);
            }
        }
    }
}
