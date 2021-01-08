using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int peopleOnTheCurrentWagon = 0;
            int peopleonTheLyft = 0;

            bool empty = false;

            for (int i = 0; i < lift.Length; i++)
            {
                while (lift[i] < 4)
                {
                    lift[i]++;
                    peopleOnTheCurrentWagon++;
                    if (peopleonTheLyft + peopleOnTheCurrentWagon == people)
                    {
                        empty = true;
                        break;
                    }
                }
                peopleonTheLyft += peopleOnTheCurrentWagon;
                if (empty)
                {
                    break;
                }
                peopleOnTheCurrentWagon = 0;
            }



            if (people > peopleonTheLyft)
            {
                Console.WriteLine($"There isn't enough space! {people - peopleonTheLyft} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people < lift.Length * 4 && lift.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }            
            else if (lift.All(w => w == 4) && empty == true)
            {
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
