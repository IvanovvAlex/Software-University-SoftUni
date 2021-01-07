using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split('!')
                .ToList();

            string[] firstCommand = Console.ReadLine()
                .Split()
                .ToArray();

            while (string.Join(' ', firstCommand) != "Go Shopping!")
            {
                string[] command = firstCommand;

                switch (command[0])
                {
                    case "Urgent":
                        bool exist = false;
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            if (shoppingList[i] == command[1])
                            {
                                exist = true;
                            }
                        }
                        if (exist == false)
                        {
                            shoppingList.Insert(0, command[1]);
                        }
                        break;
                    case "Unnecessary":
                        shoppingList.Remove(command[1]);
                        break;
                    case "Correct":
                        int index = -5;
                        for (int i = 0; i < shoppingList.Count; i++)
                        {                            
                            if (shoppingList[i] == command[1])
                            {
                                shoppingList.RemoveAt(i);
                                index = i;
                            }                            
                        }
                        if (index != -5)
                        {
                            shoppingList.Insert(index, command[2]);
                        }
                        break;
                    case "Rearrange":
                        bool exisT = false;
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            if (shoppingList[i] == command[1])
                            {
                                shoppingList.RemoveAt(i);
                                exisT = true;                                
                            }
                        }
                        if (exisT == true)
                        {
                            shoppingList.Add(command[1]);
                        }
                        break;
                }

                firstCommand = Console.ReadLine()
                .Split()
                .ToArray();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
