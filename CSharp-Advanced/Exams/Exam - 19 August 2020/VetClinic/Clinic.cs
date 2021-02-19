using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        public List<Pet> data;
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public Clinic(int capacity)
        {
            Capacity = capacity;
            data = new List<Pet>();
        }
        public void Add(Pet pet) 
        {
            if (data.Count < Capacity)
            {
                data.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            Pet pet = data.FirstOrDefault(x => x.Name == name);
            if (pet == null)
            {
                return false;
            }
            data.Remove(pet);
            return true;
        }
        public Pet GetPet(string name, string owner)
        {
            Pet pet = data.FirstOrDefault(x => x.Name == name && x.Owner == owner);
            
            return pet;
        }
        public Pet GetOldestPet()
        {
            return data.OrderByDescending(X => X.Age).FirstOrDefault();
        }
        public string GetStatistics()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("The clinic has the following patients:");
            foreach (var pet in data)
            {
                output.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return output.ToString();
        }
    }
}
