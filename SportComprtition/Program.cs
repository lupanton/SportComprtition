using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportComprtition
{
    class Program
    {        
        static void Main(string[] args)
        {
            Team t1 = new Team("USA", new List<Competitor>
            {
                new Competitor("John", "Smith", "gim"),
                new Competitor("Ann", "Goldy", "gim"),
                new Competitor("Sam", "Brown", "gim"),
                new Competitor("Mary", "Linn", "gim")
            });
            Team t2 = new Team("China", new List<Competitor>
            {
                new Competitor("U", "Li", "gim"),
                new Competitor("Cong", "Fay", "gim"),
                new Competitor("Lung", "Ti", "gim"),
                new Competitor("Si", "Pin", "gim")
            });
            Team t3 = new Team("Russia", new List<Competitor>
            {
                new Competitor("Ivan", "Petrov", "gim"),
                new Competitor("Anna", "Pavlova", "gim"),
                new Competitor("Egor", "Sidorov", "gim"),
                new Competitor("Marina", "Kuznetsova", "gim")
            });
            Team t4 = new Team("Italy", new List<Competitor>
            {
                new Competitor("Anna", "Pirony", "gim"),
                new Competitor("Antuan", "Tano", "gim"),
                new Competitor("Silvia", "Lukatty", "gim"),
                new Competitor("Karlo", "Fanzony", "gim")
            });
            Team t5 = new Team("Canada", new List<Competitor>
            {
                new Competitor("Pol", "Chita", "gim"),
                new Competitor("Elen", "Bakron", "gim"),
                new Competitor("Bazil", "Arta", "gim"),
                new Competitor("Bles", "Arno", "gim")
            });
            Judga j1 = new Judga("Alois", "Bertony", "gim", "high");
            Judga j2 = new Judga("Berta", "Frankony", "gim", "middle");
            Judga j3 = new Judga("Elena", "Smirnova", "gim", "high");
            List<Result> results = new List<Result>();
            Result[,] resultList = new Result[5, 3];
            List<int> reitingListScore = new List<int>();

            Dictionary<string, List<int>> reitingDict = new Dictionary<string, List<int>>();
            List<Team> teams = new List<Team> { t1, t2, t3, t4, t5 };
            List<Judga> judgas = new List<Judga> { j1, j2, j3 };
            Random rnd = new Random();
            
            for (int i = 0; i < teams.Count(); i++)
            {                
                for (int j = 0; j < judgas.Count(); j++)
                {
                    Result r = new Result(rnd.Next(1, 10), teams[i], judgas[j]);
                    resultList[i, j] = r;
                    r.Grib += (s, e) => { Console.WriteLine($"Judge {e.Jud.Name} {e.Jud.Surname} have gave {r.Score} to {e.OneTeam.Country}."); };
                    r.DoIt();   
                                                  
                }
            }

            Dictionary<string, List<int>> reitingDict = new Dictionary<string, List<int>>();
            var lst = new List<int>();
            //for (int i = 0; i < resultList.GetLength(0); i++)
            //{
            //    for (int j = 0; j < resultList.GetLength(1); j++)
            //    {
            //        lst = new int[3];
            //        lst[j] = resultList[i, j].Score;
            //        reitingDict.Add(resultList[i, j].SomeTeam.Country, lst);                    
            //    }
            //}

            for (int i = 0; i < resultList.GetLength(0); i++)
            {
                Console.Write("{0}\t", resultList[i, 1].SomeTeam.Country);
                for (int j = 0; j < resultList.GetLength(1); j++)
                {
                    Console.Write("{0}\t", resultList[i, j].Score);                    
                }
                
                Console.WriteLine("\n");
            }

            Console.WriteLine();
            Console.ReadKey();
        }        
    }
}
