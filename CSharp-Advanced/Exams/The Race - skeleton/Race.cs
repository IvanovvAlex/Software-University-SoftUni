using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }
        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }
        public void Add(Racer racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(racer);
            }
        }
        public bool Remove(string name)
        {
            if (data.Any(x => x.Name == name))
            {
                data.Remove(data.FirstOrDefault(x => x.Name == name));
                return true;
            }
            return false;
        }
        public Racer GetOldestRacer()
        {
            return data.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public Racer GetRacer(string name)
        {
           return data.FirstOrDefault(x => x.Name == name);          
        }

        public Racer GetFastestRacer()
        {
            return data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
        }
       
        public string Report()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in data)
            {
                output.AppendLine(racer.ToString());
            }
            return output.ToString().TrimEnd();
        }
    }
}
