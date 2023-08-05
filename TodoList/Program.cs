using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Todo list program");

            List<string> taskList = new List<string>();

            var option = "";
            Console.WriteLine("What would you like to do today");

            while (option != "e")
            {
                

                Console.WriteLine("Enter 1 to add a task to the list");
                if(taskList.Count > 0)
                {
                    Console.WriteLine("Enter 2 to view the list");
                    Console.WriteLine("Enter 3 to remove a task from the list");
                }
                Console.WriteLine("Enter e to exist");


                option = Console.ReadLine();

                if(option == "1")
                {
                    Console.WriteLine("Enter the name of the task you want to add");
                    var task = Console.ReadLine();
                    if (task != null && task != "")
                    {
                        taskList.Add(task);
                        Console.WriteLine("You have successfully added the task: {0}", task);
                    }
                    else
                    {
                        Console.WriteLine("You have not added any task");
                    }
                }
                else if (option == "2")
                {
                    if(taskList.Count > 0)
                    {
                        Console.WriteLine("The available tasks");
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine(i + " : " + taskList[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have not added any task yet!");
                    }
                    
                }
                else if(option == "3")
                {
                    if(taskList.Count > 0)
                    {
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine(i + " : " + taskList[i]);
                        }
                        Console.WriteLine("Enter the number of task you would like to remove");

                        int taskNumber = Convert.ToInt32(Console.ReadLine());
                        taskList.RemoveAt(taskNumber);
                    }
                    else
                    {
                        Console.WriteLine("You do not have any task to remove");
                    }
                    

                }else if(option == "e")
                {
                    Console.WriteLine("Exiting the program");
                }
                else
                {
                    Console.WriteLine("Invalid option. Kindly try again");
                }
            }

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Thank you for using Kenny Todo app!");
        }
    }
}



