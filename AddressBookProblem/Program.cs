using System.Xml.Linq;

namespace AddressBookProblem;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program");
        AddrBookCollection ac = new AddrBookCollection();
        //AddressBook addressBook = new AddressBook();
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

            }
        }

    }
}

