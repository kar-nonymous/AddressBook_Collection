// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kumar Kartikeya"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_Collection
{
    class Program
    {
        public static Dictionary<string, AddressBook> addressBookDictionary = new Dictionary<string, AddressBook>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");
            bool flag = true;
            while (flag)
            {
                
                Console.WriteLine("1: Add New Address Book \n2: Add Contacts \n3: Edit Contacts \n4: Delete Contacts \n5: Display Contacts \n6: Search contact using city or state name");
                string options = Console.ReadLine();
                AddressBook addressBook = new AddressBook();
                /// <summary>
                /// To select from different options available
                /// </summary>
                switch (options)
                {
                    case "1":
                        AddAdressBook();
                        break;
                    case "2":
                        AddContactToAddressBook();
                        break;
                    case "3":
                        EditContactInAdressBook();
                        break;
                    case "4":
                        DeleteContactFromAddressBook();
                        break;
                    case "5":
                        DisplayContactsFromAddressBook();
                        break;
                    case "6":
                        addressBook.GetPersonFromCityOrState();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
        /// <summary>
        /// Adds the address book
        /// </summary>
        static void AddAdressBook()
        {
            Console.WriteLine("\nEnter address book name");
            string name = Console.ReadLine();
            if (addressBookDictionary.ContainsKey(name))
            {
                Console.WriteLine("Address Book Already exists ");
            }
            else
            {
                AddressBook addressBook = new AddressBook();
                addressBookDictionary.Add(name, addressBook);
            }
        }
        /// <summary>
        /// Adds the contact to address book.
        /// </summary>
        static void AddContactToAddressBook()
        {
            Console.WriteLine("\nEnter address book name");
            string name = Console.ReadLine();
            if (!addressBookDictionary.ContainsKey(name))
            {
                Console.WriteLine("Address book name not found");
            }
            else
            {
                AddressBook addressBook = addressBookDictionary[name];
                addressBook.AddContact();
            }
        }
        /// <summary>
        /// Edits the contact in address book.
        /// </summary>
        static void EditContactInAdressBook()
        {
            Console.WriteLine("\nEnter address book name");
            string name = Console.ReadLine();
            if (!addressBookDictionary.ContainsKey(name))
            {
                Console.WriteLine("Address book name not found");
            }
            else
            {
                AddressBook addressBook = addressBookDictionary[name];
                addressBook.EditContact();
            }
        }
        /// <summary>
        /// Deletes the contact from address book.
        /// </summary>
        static void DeleteContactFromAddressBook()
        {
            Console.WriteLine("\nEnter address book name");
            string name = Console.ReadLine();
            if (!addressBookDictionary.ContainsKey(name))
            {
                Console.WriteLine("Address book name not found");
            }
            else
            {
                AddressBook addressBook = addressBookDictionary[name];
                addressBook.DeleteContact();
            }
        }
        /// <summary>
        /// Displays the contacts from address book.
        /// </summary>
        static void DisplayContactsFromAddressBook()
        {
            Console.WriteLine("\nEnter address book name");
            string name = Console.ReadLine();
            if (!addressBookDictionary.ContainsKey(name))
            {
                Console.WriteLine("Address book name not found");
            }
            else
            {
                AddressBook addressBook = addressBookDictionary[name];
                addressBook.DisplayContact();
            }
        }
    }
}