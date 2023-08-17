using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace AddressBookProblem
{
	public class AddrBookCollection
	{
		Dictionary<string, AddressBook> setOfAddressBook;
		public AddrBookCollection()
		{
			setOfAddressBook = new Dictionary<string, AddressBook>();
		}

		public void AddAddressBook(AddressBook a)
		{
            if (!setOfAddressBook.ContainsKey(a.nameOfAddressBook))
            {
                setOfAddressBook[a.nameOfAddressBook] = a;
            }
			else
			{
				Console.WriteLine("Address Book With this name already Exists");
			}
            
		}
		public void FindAddressBookAndEdit(string name, Contact c)
		{
            if (setOfAddressBook.ContainsKey(name))
            {
				setOfAddressBook[name].AddContact(c);
                
            }
            else
            {
                Console.WriteLine("Address Book With this name does not exists");
            }


        }
		public bool IfExists(string name)
		{
			if (setOfAddressBook.ContainsKey(name))
			{
				return true;

			}
			else
			{
				return false;
			}

		}
		public void EditDetails(string fname)
		{
			if(this.setOfAddressBook.Count == 0)
			{
				Console.WriteLine("No Address Book Present");
			}
			else
			{
				foreach(var temp in this.setOfAddressBook)
				{
					temp.Value.FindContactAndEdit(fname);
					
				}
			}
		}

		public void RemoveContact(string fname)
		{
            if (this.setOfAddressBook.Count == 0)
            {
                Console.WriteLine("No Address Book Present");
            }
            else
            {
                foreach (var temp in this.setOfAddressBook)
                {
                    temp.Value.RemoveContact(fname);
                   
                }
            }

        }
		public void DisplayAddressBook(string nameOfBook)
		{
			if(this.setOfAddressBook.Count == 0)
			{
				Console.WriteLine("The Dictionary is Empty");
			}
			else
			{
				foreach(var temp in this.setOfAddressBook)
				{
					if(temp.Key == nameOfBook)
					{
						temp.Value.DisplayAddressBook();
						return;
					}
				}

				Console.WriteLine("The AddressBook Doesnot Exist");
				return;
				
			}


		}
		public void DisplayAllAddressBook()
		{
			if(setOfAddressBook.Count == 0)
			{
				Console.WriteLine("No Address Book present");

			}
			else
			{
				
				foreach(var temp in setOfAddressBook)
				{
					Console.WriteLine($"AddressBook Name-> {temp.Key}");
					temp.Value.DisplayAddressBook();

				}
			}
		}

        public List<Contact> GetPersonInACity(string cityName)
        {
            List<Contact> listOfPersonInCity = new List<Contact>();
            
			listOfPersonInCity	= setOfAddressBook.SelectMany(pair => pair.Value.savedContacts)
								  .Where(c => c.GetCityName() == cityName)
								  .ToList();
            return listOfPersonInCity;
        }
        public List<Contact> GetPersonInAState(string stateName)
        {
            List<Contact> listOfPersonInState = new List<Contact>();

            listOfPersonInState = setOfAddressBook.SelectMany(pair => pair.Value.savedContacts)
                                  .Where(c => c.GetStateName() == stateName)
                                  .ToList();
            return listOfPersonInState;
        }
		public void SortAddressBookWithName(string nameOfAddBook)
		{
            this.setOfAddressBook[nameOfAddBook].savedContacts = this.setOfAddressBook[nameOfAddBook].savedContacts.OrderBy(contact => contact.GetFirstName()).ToList();
        }
        public void SortAddressBookWithState(string nameOfAddBook)
        {

            this.setOfAddressBook[nameOfAddBook].savedContacts = this.setOfAddressBook[nameOfAddBook].savedContacts.OrderBy(contact => contact.GetStateName()).ToList();
        }
        public void SortAddressBookWithCity(string nameOfAddBook)
        {

            this.setOfAddressBook[nameOfAddBook].savedContacts = this.setOfAddressBook[nameOfAddBook].savedContacts.OrderBy(contact => contact.GetCityName()).ToList();
        }
        public void SortAddressBookWithZipCode(string nameOfAddBook)
        {

            this.setOfAddressBook[nameOfAddBook].savedContacts = this.setOfAddressBook[nameOfAddBook].savedContacts.OrderBy(contact => contact.GetZipCode()).ToList();
        }

		public void WriteToAFile(string nameOfBook, string path)
		{
            List < Contact > contactToWrite = this.setOfAddressBook[nameOfBook].savedContacts;
			if(File.Exists(path))
			{
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (var contact in contactToWrite)
                    {
                        writer.WriteLine(contact.GetFirstName() + "," + contact.GetCityName() + "," + contact.GetStateName() + "," + contact.GetZipCode());
                    }
                }
				Console.WriteLine("Contact Written to the file");
			}
			else
			{
                Console.WriteLine("File Path DoesNot Exist");
            }
		}
        public void ReadAndSaveContact(string nameOfBook, string path)
        {
			
            List<Contact> contactToWrite = this.setOfAddressBook[nameOfBook].savedContacts;
            if (File.Exists(path))
            {
				string[] contactDetails = File.ReadAllLines(path);
				string firstName = contactDetails[0];
                string lastName = contactDetails[1];
				string address = contactDetails[2];
                string state = contactDetails[3];
                string city = contactDetails[4];
                string emailId = contactDetails[5];
                int zipCode = Convert.ToInt32(contactDetails[6]);
                long phoneNumber = Convert.ToInt64(contactDetails[7]);
				Contact newContact = new Contact(firstName, lastName, address, state, city, emailId, zipCode, phoneNumber);
				this.setOfAddressBook[nameOfBook].AddContact(newContact);
                Console.WriteLine("Added Contact from file to address book");

            }
            else
            {
                Console.WriteLine("File Path DoesNot Exist");
            }
        }
		public void ReadAndSaveContactCSVHelper(string nameOfBook, string path)
		{
            using (var reader = new StreamReader(path))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
				var newContact = csvReader.GetRecords<Contact>().ToList();
				foreach(Contact c in newContact)
				{
					this.setOfAddressBook[nameOfBook].AddContact(c);
					
				}
			}

		}

	}
}

