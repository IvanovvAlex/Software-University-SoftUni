using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        public Team(string name)
        {
            Name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }        

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }       
        public List<Person> FirstTeam
        {
            get { return firstTeam; }
            private set { firstTeam = value; }
        }
        public List<Person> ReserveTeam
        {
            get { return reserveTeam; }
            private set { reserveTeam = value; }
        }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                FirstTeam.Add(person);
            }
            else
            {
                ReserveTeam.Add(person);
            }
        }

    }
}
