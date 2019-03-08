using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportComprtition
{
    /*класс, который резюмирует данные - в нем структура мартрицы турнирной
     таблицы - матрицы, ради которой все и замышлялось. Это класс - издатель.*/
    class Result
    {
        /*событие, Grib которое извещает подписчика о простановке определенным
        судьей (имя, фамилия) определенного количества баллов по 10-ти бальной
        шкале определенной команде. название события плохое*/
        public event EventHandler<MyEventArgs> Grib;
        private int score;
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }
        public Team SomeTeam { get; set; }
        public Judga SomeJudga { get; set; }

        public Result(int score, Team someTeam, Judga someJudga)
        {
            Score = score;
            SomeTeam = someTeam;
            SomeJudga = someJudga;
        }
        //дурацкий вообще метод, который нужен только для того, чтобы вызвать событие Grib
        public void DoIt()
        {
            if(Score > 0)
                OnGrib(SomeTeam, SomeJudga);
        }

        //метод для определения призеров - у нас все 5 команд будут в рейтинге
        public void decideWinner()
        {
            
        }

        //метод, который обрабатывает инфраструктуру cобытия Grib
        public void OnGrib(Team oneTeam, Judga jud)
        {
            EventHandler<MyEventArgs> handler = Grib;
            if (handler != null)
                handler(this, new MyEventArgs(oneTeam, jud));
        }

    }
}
