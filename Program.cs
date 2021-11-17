using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            //prepare a list to save data from file
            List<string> toDoFromFile = new List<string>();
            string toDoFilePath = @"C:\Users\opilane\samples\kt3\toDoList.txt";
            //reading array of values from todo file and converting the array to list
            toDoFromFile = File.ReadAllLines(toDoFilePath).ToList();

            //display data from toDoList file
            foreach(string task in toDoFromFile)
            {
                Console.WriteLine(task);
            }

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a task? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Enter a task:");
                    string userTask = Console.ReadLine();
                    toDoFromFile.Add(userTask);
                    Console.WriteLine($"Task {userTask} added.");
                } else
                {
                    Console.WriteLine("Take care!");
                    loopActive = false;
                }
            }

            File.WriteAllLines(toDoFilePath, toDoFromFile.ToArray());
        }
    }
}
