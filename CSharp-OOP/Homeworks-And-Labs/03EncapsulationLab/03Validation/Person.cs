using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {        
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName 
        {
            get {return firstName; }
            private set 
            {
                if (value.Length >= 3)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            } 
        }
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value.Length >= 3)
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }
        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value >= 460m)
                {
                    salary = value;
                }
                else
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                Salary += (Salary * ((percentage*0.01m)/2));
            }
            else
            {
                Salary += (Salary * (percentage*0.01m));
            }            
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
    }
}
