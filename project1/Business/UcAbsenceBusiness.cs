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
        public List<Absence> ListAbsence { get; set; }
        public UcAbsenceBusiness() 
        {
           ListAbsence = new List<Absence>();

            for (int i = 0; i < 10; i++) {
                ListAbsence = new List<Absence>();
                Absence absence = new Absence();
                absence.id_Absence = i;
                ListAbsence.Add(absence);
            }
        }
    }
}
