
using System;
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
		public void DisplayAddressBook()
		{
			foreach(Contact contact in savedContacts)
			{
				contact.DisplayContact();
			}
		}
	}
}

