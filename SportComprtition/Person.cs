using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportComprtition
{
    class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (!IsValid(value))
                    throw new ArgumentException("Wrong value string name.", "name");
                //
                name = value;
            }
        }
        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                if (!IsValid(value))
                    throw new ArgumentException("Wrong value string surname.", "surname");
                //
                surname = value;
            }
        }
        private string iD;
        public string ID
        {
            get
            {
                return iD;
            }

            set
            {
                value = GetID(Surname);           
                iD = value;
            }
        }
        public Person() { }

        public Person(string name, string surname)
        {            
            Name = name;
            Surname = surname;            
        }

        private string GetID(string str)
        {
            Random rand = new Random();
            return Surname.ToUpper() + " " + (rand.Next(1, 1000).ToString());
        }
        private bool IsValid(string str)
        {
            List<char> strToChar = str.ToCharArray().ToList();
            List<bool> charInStr = new List<bool>();
            foreach (char el in strToChar)
            {
                if ((((int)el >= 65 && (int)el < 91) || ((int)el >= 96 && (int)el < 123)) || ((int)el >= 1040 && (int)el < 1104))
                {
                    charInStr.Add(true);
                }
                else
                {
                    charInStr.Add(false);
                }
            }
            var qwer = charInStr.All(x => x == true);
            return qwer;
        }
    }
}

