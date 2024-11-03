using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_Home_.Models
{
    /// <summary>
    /// Class Etudiant
    /// </summary>
    public class Etudiant
    {
        #region Propriété
        /// <summary>
        /// La propriété de l'étudiant
        /// </summary>
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }
        public string CNE { get; set; }
        #endregion

        #region Constructeurs
        public DateTime DateDeNaissance { get; set; }
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Etudiant()
        {

        }
        public Etudiant(string nom, string prenom, string CIN, string CNE)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.CIN = CIN;
            this.CNE = CNE;
        }
        #endregion




    }


    /// <summary>
    /// Class absence
    /// </summary>
    public class Absence
    {
        public int id_Absence { get; set; }
        public Absence()
        {

        }
        public Absence(int id)
        {
            this.id_Absence = id;
        }
    }
    }
