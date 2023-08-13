
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
			savedContacts = new List<Contact>();
		}
		public void AddContact(Contact newContact)
		{
			this.savedContacts.Add(newContact);
		}
		public void FindContactAndEdit(string fname)
		{
			foreach(Contact c in savedContacts)
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
					return;
				}
				else
				{
					Console.WriteLine("No Such Contact Present");
					return;
				}
			}
		}
		public void DisplayAddressBook()
		{
			if(savedContacts.Count == 0)
			{
				Console.WriteLine("No saved Contacts");
			}
			foreach(Contact contact in savedContacts)
			{
				contact.DisplayContact();
			}
		}
	}
}

