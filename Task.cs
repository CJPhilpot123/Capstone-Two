using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Task_List
{
    class Task
    {
        private string name;
        private string brief;
        private string date;
        private bool completion;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Brief
        {
            set
            {
                brief = value;
            }
            get
            {
                return brief;
            }
        }
        public string Date
        {
            set
            {
                date = value;
            }
            get
            {
                return date;
            }
        }
        public bool Complete
        {
            set
            {
                completion = value;
            }
            get
            {
                return completion;
            }
        }



        public Task(string TeamName, string Descript, string DueDate, bool Completion)
        {
            name = TeamName;
            brief = Descript;
            date = DueDate;
            completion = Completion;
        }

        public Task() { }

        public static void ADDTask(List<Task> Tasks)
        {
            Task task = new Task();
            Console.WriteLine("Enter Team Member Name:");
            task.name = Console.ReadLine();
            Console.WriteLine("Enter Description of Task:");
            task.brief = Console.ReadLine();
            Console.WriteLine("Enter Due Date of Task:");
            task.date = Console.ReadLine();
            Console.WriteLine("Is it completed? (true/false)");
            task.completion = bool.Parse(Console.ReadLine());
            Tasks.Add(task);
        }


        public static void LISTtask(Task t)
        {
            Console.WriteLine($"\nName:{t.name}  \nTask Descript:{t.brief}  \nDue Date:{t.date} \nIs task completed? {t.completion}");
        }

        public static void DeleteTask(List<Task> Tasks)
        {
            try
            {
                Console.WriteLine("What would you like to delete: ");
                int indexOf = int.Parse(Console.ReadLine());

                indexOf--;

                Tasks.RemoveAt(indexOf);
            }
            catch (Exception)
            {
                Console.WriteLine("Item not found");
                DeleteTask(Tasks);
            }
        }
        public static void FalsetoTrue(Task t)
        {
            try
            {
                Console.WriteLine("Which task have you completed? (Enter Name of Teammember)");
                string answer = Console.ReadLine();
                if (t.name == answer)
                
                    t.completion = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Item not found");
                FalsetoTrue(t);
            }
        }
    }
}
