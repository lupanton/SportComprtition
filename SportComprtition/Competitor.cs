using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportComprtition
{
    class Competitor : Person        
    {
        public string KindOfSports { get; set; }

        public Competitor(string name, string surname, string kindOfSport)
            :base(name, surname)
        {
            KindOfSports = kindOfSport;
        }
    }
}
