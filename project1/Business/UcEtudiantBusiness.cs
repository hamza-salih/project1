using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1_Home_.Models;

namespace project1.Business
{
    internal class UcEtudiantBusiness
    {
        public List<Etudiant> StudentList { get; set; }
        public UcEtudiantBusiness()
        {
            StudentList = new List<Etudiant>();

            for (int i = 0; i < 4; i++)
            {
                Etudiant etudiant = new Etudiant();
                etudiant.Nom = "Salih" + i.ToString();
                etudiant.Prenom = "Hamza" + i.ToString();
                etudiant.CIN = "444444" + i.ToString();
                etudiant.CNE = "343432" + i.ToString();
                StudentList.Add(etudiant);

            }

        }
    }
}
