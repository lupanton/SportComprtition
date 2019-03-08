using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportComprtition
{
    class MyEventArgs : EventArgs
    {
        public Judga Jud { get; set; }
        public Team OneTeam { get; set; }
        public MyEventArgs(Team oneTeam, Judga jud)
        {
            OneTeam = oneTeam;
            Jud = jud;
        }
    }
}
