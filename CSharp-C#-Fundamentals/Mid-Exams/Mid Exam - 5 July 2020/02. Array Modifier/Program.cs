using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] firstCommand = Console.ReadLine()
                .Split()
                .ToArray();

            while (firstCommand[0] != "end")
            {
                string[] command = firstCommand;

                switch (command[0])
                {
                    case "swap":
                        int firstNum = arr[int.Parse(command[1])];
                        int secondNum = arr[int.Parse(command[2])];

                        arr[int.Parse(command[1])] = secondNum;
                        arr[int.Parse(command[2])] = firstNum;
                        break;
                    case "multiply":
                        int multiply = arr[int.Parse(command[1])] * arr[int.Parse(command[2])];
                        arr[int.Parse(command[1])] = multiply;
                        break;
                    case "decrease":
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] -= 1;
                        }
                        break;
                }

                firstCommand = Console.ReadLine()
                .Split()
                .ToArray();
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
