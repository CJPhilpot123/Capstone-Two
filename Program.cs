using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Task_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task();
            List<Task> Tasks = new List<Task>();
            Tasks.Add(new Task("Chris", "Clean Classroom", "5/3/2019", false));
            int wave = 1;
            while (wave == 1)
            {
                Console.WriteLine("Welcome to the Task Manager Pro!\n     (1)List Task\n     (2)Add Task\n     (3)Delete Task\n     (4)Mark Task Complete\n     (5)Quit\nWhat would you like to do?");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("LISTING:");
                    foreach (Task t in Tasks)
                    {
                        Task.LISTtask(t);
                    }
                }
                if (choice == 2)
                {
                    Console.WriteLine("ADD TASK:\n");
                    Task.ADDTask(Tasks);
                    Console.WriteLine("Task Entered!");
                }
                if (choice == 3)
                {
                    foreach (Task t in Tasks)
                    {
                        Task.LISTtask(t);
                    }
                    Task.DeleteTask(Tasks);
                }
                if ( choice == 4)
                {
                    foreach (Task t in Tasks)
                    {
                        Task.FalsetoTrue(t);
                    }
                }
                if (choice == 5)
                {
                    Console.WriteLine("Hope You Have A Nice Day!");
                    wave--;
                }
            }


        }

       
    }
}
