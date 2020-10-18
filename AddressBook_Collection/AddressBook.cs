// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kumar Kartikeya"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_Collection
{
    public class AddressBook
    {
        /// <summary>
        /// The contact list is created
        /// </summary>
        private List<Contacts> contactList = new List<Contacts>();
        /// <summary>
        /// The address dictionary is created
        /// </summary>
        private Dictionary<string, Contacts> addressDictionary = new Dictionary<string, Contacts>();
        /// <summary>
        /// Method to add the personal details
        /// </summary>
        public void AddContact()
        {
            bool flag = true;
            while (flag)
            {
                Contacts contacts = new Contacts();
                /// <summary>
                /// UC 7: To check for the name if it is already present in the list
                /// </summary>summary>
                string fullName = contacts.firstName + " " + contacts.lastName;
                /// <summary>
                /// It will check for every name previously present in the list
                /// </summary>
                if(contactList.Count==0)
                {
                    contactList.Add(contacts);
                    addressDictionary.Add(contacts.firstName, contacts);
                }
                else
                {
                    foreach (KeyValuePair<string,Contacts> keyValuePair in addressDictionary)
                    {
                        string fullNameInList = keyValuePair.Value.firstName + " " + keyValuePair.Value.lastName;
                        if(keyValuePair.Key==contacts.firstName)
                        {
                            if(fullNameInList != fullName)
                            {
                                contactList.Add(contacts);
                                addressDictionary.Add(contacts.firstName, contacts);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Contact already present");
                            }
                        }
                        else
                        {
                            try
                            {
                                contactList.Add(contacts);
                                addressDictionary.Add(contacts.firstName, contacts);
                                break;
                            }
                            catch(ArgumentException)
                            {
                                Console.WriteLine("Contact already present");
                            }
                        }
                    }
                }
                Console.WriteLine("\nType 'yes' to enter new user");
                string option = Console.ReadLine();
                if (option != "yes")
                {
                    flag = false;
                }
            }
        }
        /// <summary>
        /// Method to edit the personal details with the help of first name
        /// </summary>
        public void EditContact()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter first name to edit details");
                string name = Console.ReadLine();
                if (addressDictionary.ContainsKey(name))
                {
                    Contacts contacts = addressDictionary[name];
                    Console.WriteLine("Enter First Name");
                    string firstName = Console.ReadLine();
                    contacts.firstName = firstName;
                    Console.WriteLine("Enter Last Name");
                    string lastName = Console.ReadLine();
                    contacts.lastName = lastName;
                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();
                    contacts.address = address;
                    Console.WriteLine("Enter City");
                    string city = Console.ReadLine();
                    contacts.city = city;
                    Console.WriteLine("Enter state");
                    string state = Console.ReadLine();
                    contacts.state = state;
                    Console.WriteLine("Enter email");
                    string email = Console.ReadLine();
                    contacts.email = email;
                    Console.WriteLine("Enter zip");
                    string zip = Console.ReadLine();
                    contacts.zip = zip;
                    Console.WriteLine("Enter phone number");
                    string phnNo = Console.ReadLine();
                    contacts.phnNo = phnNo;
                }
                else
                    Console.WriteLine("Invalid first name");
                Console.WriteLine("\nType 'yes' to edit another user");
                string option = Console.ReadLine();
                if (option != "yes")
                    flag = false;
            }
        }
        /// <summary>
        /// Method to delete the personal details with the help of first name
        /// </summary>
        public void DeleteContact()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter first name to delete contact");
                string name = Console.ReadLine();
                if (addressDictionary.ContainsKey(name))
                {
                    Contacts contacts = addressDictionary[name];
                    var index = contactList.FindIndex(i => i == contacts);
                    if (index >= 0)
                    {  
                        contactList.RemoveAt(index);
                    }
                    addressDictionary.Remove(name);
                }
                else
                    Console.WriteLine("Invalid first name");
                Console.WriteLine("\nType 'yes' to delete more users");
                string option = Console.ReadLine();
                if (option != "yes")
                    flag = false;
            }
        }
        /// <summary>
        /// Method to display all the personal details
        /// </summary>
        public void DisplayContact()
        {
            foreach (Contacts contacts in contactList)
            {
                Console.WriteLine("\nFirst name: " + contacts.firstName + "\nLast name: " + contacts.lastName + "\nAddress: " + contacts.address + "\nCity: " + contacts.city + "\nState: " + contacts.state + "\nEmail: " + contacts.email + "\nZip: " + contacts.zip + "\nPhone number" + contacts.phnNo);
            }
        }
    }
}
