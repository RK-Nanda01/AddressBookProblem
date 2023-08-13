﻿
using System;
using System.Net;
using System.Reflection.Emit;

namespace AddressBookProblem
{
	public class AddressBook
	{
		List<Contact> savedContacts;
		public AddressBook()
		{
			this.savedContacts = new List<Contact>();
		}
		public void AddContact(Contact newContact)
		{
			this.savedContacts.Add(newContact);
		}
		public void FindContactAndEdit(string fname)
		{
			if(this.savedContacts.Count == 0)
			{
				Console.WriteLine("Address Book Empty");
			}
			foreach(Contact c in this.savedContacts)
			{
				if(c.GetFirstName() == fname)
				{
                    string lastName, address, state, city, email;
                    int zipCode;
                    long phoneNumber;
                    Console.WriteLine("Enter Last Name");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Enter Address");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter State");
                    state = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    city = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    email = Console.ReadLine();
                    Console.WriteLine("Enter Zip Code");
                    zipCode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number");
                    phoneNumber = Convert.ToInt64(Console.ReadLine());
					c.EditContactDetails(lastName, address, state, city, email, zipCode, phoneNumber);
                    Console.WriteLine("Edit Successful!");
                    return;
				}
				else
				{
					Console.WriteLine("No Such Contact Present");
					return;
				}
			}
		}
		public void RemoveContact(string fname)
		{
			if(this.savedContacts.Count == 0)
			{
				Console.WriteLine("Address Book Already Empty");
				return;
			}
			else
			{
				foreach(Contact c in this.savedContacts)
				{
					if(c.GetFirstName() == fname)
					{
						this.savedContacts.Remove(c);
                        Console.WriteLine("Contact Removed!");
                        return;
					}
				}

				Console.WriteLine("Contact Doesnot Exist");
			}
		}
		public void DisplayAddressBook()
		{
			if(this.savedContacts.Count == 0)
			{
				Console.WriteLine("No saved Contacts");
			}
			foreach(Contact contact in this.savedContacts)
			{
				contact.DisplayContact();
			}
		}
	}
}

