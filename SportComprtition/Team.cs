using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportComprtition
{
    class Team
    {        
        public string Country { get; set; }   
        public int TeamScore { get; set; }
        //это поле, по сути для дальнейшего развития программки, по заданию не нужно     
        public List<Competitor> CompetitorList { get; set; }
        public List<Result> ResultList { get; set; }

        public Team(string country, List<Competitor> competitorList)            
        {
            Country = country;
            CompetitorList = competitorList;
        }        
    }
}
