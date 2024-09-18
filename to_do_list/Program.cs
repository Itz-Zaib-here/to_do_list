using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. List Tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        RemoveTask();
                        break;
                    case 3:
                        ListTasks();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        static void RemoveTask()
        {
            Console.Write("Enter task number to remove: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            if (taskNumber >= 0 && taskNumber < tasks.Count)
            {
                tasks.RemoveAt(taskNumber);
                Console.WriteLine("Task removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        static void ListTasks()
        {
            Console.WriteLine("Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}