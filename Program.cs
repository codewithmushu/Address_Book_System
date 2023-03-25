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
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. View all contacts");
                Console.WriteLine("3. Edit a contact");
                Console.WriteLine("4. Exit");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Contact contact = CreateContact();
                        contacts.Add(contact);
                        Console.WriteLine("Contact added!");
                        break;
                    case "2":
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
                    case "3":
                        if (contacts.Count == 0)
                        {
                            Console.WriteLine("No contacts found.");
                        }
                        else
                        {
                            Console.Write("Enter the first name of the contact you want to edit: ");
                            string firstName = Console.ReadLine();
                            Console.Write("Enter the last name of the contact you want to edit: ");
                            string lastName = Console.ReadLine();

                            Contact editContact = contacts.Find(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName));
                            if (editContact == null)
                            {
                                Console.WriteLine($"Contact {firstName} {lastName} not found.");
                            }
                            else
                            {
                                Console.WriteLine("Enter new details (leave blank for no change):");
                                Console.Write($"First Name [{editContact.FirstName}]: ");
                                string newFirstName = Console.ReadLine();
                                if (!string.IsNullOrEmpty(newFirstName))
                                {
                                    editContact.FirstName = newFirstName;
                                }

                                Console.Write($"Last Name [{editContact.LastName}]: ");
                                string newLastName = Console.ReadLine();
                                if (!string.IsNullOrEmpty(newLastName))
                                {
                                    editContact.LastName = newLastName;
                                }

                                Console.Write($"Address [{editContact.Address}]: ");
                                string newAddress = Console.ReadLine();
                                if (!string.IsNullOrEmpty(newAddress))
                                {
                                    editContact.Address = newAddress;
                                }

                                Console.Write($"City [{editContact.City}]: ");
                                string newCity = Console.ReadLine();
                                if (!string.IsNullOrEmpty(newCity))
                                {
                                    editContact.City = newCity;
                                }

                                Console.Write($"State [{editContact.State}]: ");
                                string newState = Console.ReadLine();
                                if (!string.IsNullOrEmpty(newState))
                                {
                                    editContact.State = newState;
                                }

                                Console.Write($"Zip [{editContact.Zip}]: ");
                                string newZip = Console.ReadLine();
                                if (!string.IsNullOrEmpty(newZip))
                                {
                                    editContact.Zip = newZip;
                                }

                                Console.Write($"Phone Number [{editContact.PhoneNumber}]: ");
                                string newPhoneNumber = Console.ReadLine();
                                if (!string.IsNullOrEmpty(newPhoneNumber))
                                {
                                    editContact.PhoneNumber = newPhoneNumber;
                                }

                                Console.Write($"Email [{editContact.Email}]: ");
                                string newEmail = Console.ReadLine();
                                if (!string.IsNullOrEmpty(newEmail))
                                {
                                    editContact.Email = newEmail;
                                }

                                Console.WriteLine("Contact updated!");
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }

        static Contact CreateContact()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter state: ");
            string state = Console.ReadLine();
            Console.Write("Enter zip: ");
            string zip = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            return contact;
        }





    }
}

