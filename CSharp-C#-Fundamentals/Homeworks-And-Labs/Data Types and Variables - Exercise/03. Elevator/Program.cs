using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            int courses = 0;
            if (numOfPeople % capacityOfElevator == 0)
            {
                courses = (numOfPeople / capacityOfElevator);
            }
            else
            {
                courses = (numOfPeople / capacityOfElevator) + 1;
            }
            Console.WriteLine(courses);                                    
        }
    }
}
