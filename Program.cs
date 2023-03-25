using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program.");


            List<Contact> contacts = new List<Contact>();

            while (true)
            {
                Console.WriteLine("Select an option:");
               
                Console.WriteLine("1. View all contacts");
                Console.WriteLine("2. Exit");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (contacts.Count == 0)
                        {
                            Console.WriteLine("No contacts found.");
                        }
                        else
                        {
                            foreach (Contact c in contacts)
                            {
                                Console.WriteLine(c.ToString());
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }

       



    }
}

