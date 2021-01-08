using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Angry_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int startIndex = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string typeOfPriceRatings = Console.ReadLine();
            decimal leftTotal = 0m;
            decimal rightTotal = 0m;

            for (int i = startIndex + 1; i < list.Count; i++)
            {
                switch (typeOfItems)
                {
                    case "cheap":
                        switch (typeOfPriceRatings)
                        {
                            case "positive":
                                if (list[i] > 0 && list[i] < list[startIndex])
                                {
                                    rightTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "negative":
                                if (list[i] < 0 && list[i] < list[startIndex])
                                {
                                    rightTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "all":
                                if (list[i] < list[startIndex])
                                {
                                    rightTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                }
                                break;
                        }
                        break;
                    case "expensive":
                        switch (typeOfPriceRatings)
                        {
                            case "positive":
                                if (list[i] > 0 && list[i] >= list[startIndex])
                                {
                                    rightTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "negative":
                                if (list[i] < 0 && list[i] >= list[startIndex])
                                {
                                    rightTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "all":
                                if (list[i] >= list[startIndex])
                                {
                                    rightTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                }
                                break;
                        }
                        break;
                }
                
            }
            for (int i = 0; i < startIndex; i++)
            {
                switch (typeOfItems)
                {
                    case "cheap":
                        switch (typeOfPriceRatings)
                        {
                            case "positive":
                                if (list[i] > 0 && list[i] < list[startIndex])
                                {
                                    leftTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                    startIndex--;
                                }
                                break;
                            case "negative":
                                if (list[i] < 0 && list[i] < list[startIndex])
                                {
                                    leftTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                    startIndex--;
                                }
                                break;
                            case "all":
                                if (list[i] < list[startIndex])
                                {
                                    leftTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                    startIndex--;
                                }
                                break;
                        }
                        break;
                    case "expensive":
                        switch (typeOfPriceRatings)
                        {
                            case "positive":
                                if (list[i] > 0 && list[i] >= list[startIndex])
                                {
                                    leftTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                    startIndex--;
                                }
                                break;
                            case "negative":
                                if (list[i] < 0 && list[i] >= list[startIndex])
                                {
                                    leftTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                    startIndex--;
                                }
                                break;
                            case "all":
                                if (list[i] >= list[startIndex])
                                {
                                    leftTotal += list[i];
                                    list.RemoveAt(i);
                                    i--;
                                    startIndex--;
                                }
                                break;
                        }
                        break;
                }
            }
            if (leftTotal > rightTotal)
            {
                Console.WriteLine($"Left - {leftTotal}");
            }
            else if (leftTotal == rightTotal)
            {
                Console.WriteLine($"Left - {leftTotal}");
            }
            else
            {
                Console.WriteLine($"Right - {rightTotal}");
            }
        }
    }
}
