using System;
using System.Collections.Generic;

class Program
{
    //create a list to store my tasks
    static List<string> tasks = new List<string>();

    static void Main()
    {
        //create a loop to ensure that the program runs
        while (true)
        {
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Mark task as completed");
            Console.WriteLine("3. View to-do list");
            Console.WriteLine("4. Exit");

            Console.Write("Please select an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    // Allow james to enter a task
                    Console.Write("Please enter a task: ");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                    Console.WriteLine("Task added successfully!");
                    break;

                case 2:
                    // allow james to mark a task as completed
                    Console.Write("Please enter the task number to mark as completed: ");
                    int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (taskNumber >= 0 && taskNumber < tasks.Count)
                    {
                        tasks[taskNumber] = "[Completed] " + tasks[taskNumber];
                        Console.WriteLine("Task marked as completed successfully!");
                    }
                                       {
                        Console.WriteLine("Invalid task number!");
                    }
                    break;

                case 3:
                    
                    Console.WriteLine("Your to-do list:");
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + tasks[i]);
                    }
                    break;
                
                case 4:
                    // allow James to exit the program
                    Console.WriteLine("Exiting the program...");
                    return;

                default:
                    Console.WriteLine("Invalid option selected!");
                    break;
            }
        }
    }
}



