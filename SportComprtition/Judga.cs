using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportComprtition
{
    class Judga : Person
    {
        public string KindOfSports { get; set; }
        public string Qualification { get; set; }

        public Judga(string name, string surname, string kindOfSport, string qualification)
            :base(name, surname)
        {
            KindOfSports = kindOfSport;
            Qualification = qualification;
        }
    }
}
