using System.Xml.Linq;

namespace AddressBookProblem;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program");
        AddrBookCollection ac = new AddrBookCollection();
        bool flag = true;
        int option;
        while (flag)
        {
            Console.WriteLine("Menu->");
            // Select Option1 to create multiple contacts and save to the address book
            Console.WriteLine("1.Create an AddressBook");
            Console.WriteLine("2.Add Contact");
            Console.WriteLine("3.Display Dictionary of AddressBook");
            Console.WriteLine("4.Display A Particular AddressBook");
            Console.WriteLine("5.Find Contact and Edit Details");
            Console.WriteLine("6.Remove Contact");
            Console.WriteLine("7.Search for a person in a city");
            Console.WriteLine("8.Search for a person in a state");
            Console.WriteLine("9.Get Count of person in a city");
            Console.WriteLine("10.Get Count of person in a state");
            Console.WriteLine("11.Sort the entries of addressbook wrt Name");
            Console.WriteLine("12.Sort the entries of addressbook wrt State");
            Console.WriteLine("13.Sort the entries of addressbook wrt City");
            Console.WriteLine("14.Sort the entries of addressbook wrt ZipCode");
            Console.WriteLine("0.Exit");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    {
                        flag = false;
                        break;
                    }
                case 1:
                    {
                        string nameOfBook;
                        Console.WriteLine("Enter Name of address book ");
                        nameOfBook = Console.ReadLine();
                        AddressBook aBook = new AddressBook(nameOfBook);
                        ac.AddAddressBook(aBook);
                        break;
                    }
                case 2:
                    {
                        string nameOfBook;
                        Console.WriteLine("Enter Name of address book you want to add the contact to");
                        nameOfBook = Console.ReadLine();
                        if(ac.IfExists(nameOfBook))
                        {
                            string firstName, lastName, address, state, city, email;
                            int zipCode;
                            long phoneNumber;
                            Console.WriteLine("Enter First Name");
                            firstName = Console.ReadLine();
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
                            Contact newContact = new Contact(firstName, lastName, address, state, city, email, zipCode, phoneNumber);
                            ac.FindAddressBookAndEdit(nameOfBook, newContact);
                        }
                        else
                        {
                            Console.WriteLine("AddressBook DoesNot exist");
                        }
                        
                        break;
                    }
                case 3:
                    {
                        ac.DisplayAllAddressBook();
                        break;

                    }
                case 4:
                    {
                        string nameOfBook;
                        Console.WriteLine("Enter Name of AddressBook to display");
                        nameOfBook = Console.ReadLine();
                        ac.DisplayAddressBook(nameOfBook);
                        break;
                    }
                case 5:
                    {
                        string fname;
                        Console.WriteLine("Enter Name of contact to edit Details");
                        fname = Console.ReadLine();
                        ac.EditDetails(fname);
                        break;
                    }
                case 6:
                    {
                        string fname;
                        Console.WriteLine("Enter Name of contact to delete");
                        fname = Console.ReadLine();
                        ac.RemoveContact(fname);
                        break;
                    }
                case 7:
                    {
                        string nameOfCity;
                        List<Contact> personInCity = new List<Contact>(); 
                        Console.WriteLine("Enter Name of city");
                        nameOfCity = Console.ReadLine();
                        personInCity = ac.GetPersonInACity(nameOfCity);
                        if(personInCity.Count == 0)
                        {
                            Console.WriteLine($"No person living in the city {nameOfCity}");
                        }
                        else
                        {
                            Console.WriteLine($"Name of person in the city {nameOfCity} are:->");
                            foreach (Contact c in personInCity)
                            {
                                Console.Write($"{c.GetFirstName()} ");
                            }
                            Console.Write("\n");
                        }
                       
                        break;
                    }
                case 8:
                    {
                        string nameOfState;
                        List<Contact> personInState = new List<Contact>();
                        Console.WriteLine("Enter Name of State");
                        nameOfState = Console.ReadLine();
                        personInState = ac.GetPersonInAState(nameOfState);
                        if (personInState.Count == 0)
                        {
                            Console.WriteLine($"No person living in the state {nameOfState}");
                        }
                        else
                        {
                            Console.WriteLine($"Name of person in the state {nameOfState} are:->");
                            foreach (Contact c in personInState)
                            {
                                Console.Write($"{c.GetFirstName()} ");
                            }
                            Console.Write("\n");
                        }

                        break;
                    }
                case 9:
                    {
                        string nameOfCity;
                        List<Contact> personInCity = new List<Contact>();
                        Console.WriteLine("Enter Name of city");
                        nameOfCity = Console.ReadLine();
                        personInCity = ac.GetPersonInACity(nameOfCity);
                       
                        Console.WriteLine($"Number of person living in the city {nameOfCity} is {personInCity.Count}");

                        break;
                    }
                case 10:
                    {
                        string nameOfState;
                        List<Contact> personInState = new List<Contact>();
                        Console.WriteLine("Enter Name of State");
                        nameOfState = Console.ReadLine();
                        personInState = ac.GetPersonInAState(nameOfState);
                        Console.WriteLine($"No person living in the state {nameOfState} is {personInState.Count}");
                        break;
                    }
                case 11:
                    {
                        string nameOfAddBook;
                        Console.WriteLine("Enter Name of AddressBook");
                        nameOfAddBook = Console.ReadLine();
                        if(ac.IfExists(nameOfAddBook))
                        {
                            ac.SortAddressBookWithName(nameOfAddBook);

                        }
                        else
                        {
                            Console.WriteLine("The Address Book DoesNot Exists");
                        }

                        break;
                    }
                case 12:
                    {
                        string nameOfAddBook;
                        Console.WriteLine("Enter Name of AddressBook");
                        nameOfAddBook = Console.ReadLine();
                        if (ac.IfExists(nameOfAddBook))
                        {
                            ac.SortAddressBookWithState(nameOfAddBook);

                        }
                        else
                        {
                            Console.WriteLine("The Address Book DoesNot Exists");
                        }

                        break;
                    }
                case 13:
                    {
                        string nameOfAddBook;
                        Console.WriteLine("Enter Name of AddressBook");
                        nameOfAddBook = Console.ReadLine();
                        if (ac.IfExists(nameOfAddBook))
                        {
                            ac.SortAddressBookWithCity(nameOfAddBook);

                        }
                        else
                        {
                            Console.WriteLine("The Address Book DoesNot Exists");
                        }

                        break;
                    }
                case 14:
                    {
                        string nameOfAddBook;
                        Console.WriteLine("Enter Name of AddressBook");
                        nameOfAddBook = Console.ReadLine();
                        if (ac.IfExists(nameOfAddBook))
                        {
                            ac.SortAddressBookWithZipCode(nameOfAddBook);

                        }
                        else
                        {
                            Console.WriteLine("The Address Book DoesNot Exists");
                        }

                        break;
                    }

            }
        }

    }
}

