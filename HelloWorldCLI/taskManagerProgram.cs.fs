using System;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tasks = new string[100];
            bool[] taskStatus = new bool[100];
            int taskCount = 0;
            
            Console.WriteLine("WELCOME TO TASK MANAGER");
            
            while (true)
            {
                Console.WriteLine("\nACTIONS:");
                Console.WriteLine("[1] Add Task");
                Console.WriteLine("[2] View Tasks");
                Console.WriteLine("[3] Mark Task as Completed");
                Console.WriteLine("[4] Delete Task");
                Console.WriteLine("[5] Exit");
                Console.Write("Enter Action: ");
                
                int userAction = Convert.ToInt16(Console.ReadLine());
                
                switch (userAction)
                {
                    case 1:
                        Console.Write("Enter Task: ");
                        tasks[taskCount] = Console.ReadLine();
                        taskStatus[taskCount] = false;
                        taskCount++;
                        Console.WriteLine("Task added successfully!");
                        break;
                    case 2:
                        if (taskCount == 0)
                        {
                            Console.WriteLine("No tasks available.");
                        }
                        else
                        {
                            Console.WriteLine("\nTASK LIST:");
                            for (int i = 0; i < taskCount; i++)
                            {
                                string status = taskStatus[i] ? "[Completed]" : "[Pending]";
                                Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Enter task number to mark as completed: ");
                        int taskNum = Convert.ToInt16(Console.ReadLine());
                        if (taskNum > 0 && taskNum <= taskCount)
                        {
                            taskStatus[taskNum - 1] = true;
                            Console.WriteLine("Task marked as completed!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                        break;
                    case 4:
                        Console.Write("Enter task number to delete: ");
                        taskNum = Convert.ToInt16(Console.ReadLine());
                        if (taskNum > 0 && taskNum <= taskCount)
                        {
                            for (int i = taskNum - 1; i < taskCount - 1; i++)
                            {
                                tasks[i] = tasks[i + 1];
                                taskStatus[i] = taskStatus[i + 1];
                            }
                            taskCount--;
                            Console.WriteLine("Task deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting Task Manager...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
