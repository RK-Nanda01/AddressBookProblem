using System;
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
    }
}

