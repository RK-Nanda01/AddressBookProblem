namespace AddressBookProblem;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program");
        AddressBook addressBook = new AddressBook();
        bool flag = true;
        int option;
        while(flag)
        {
            Console.WriteLine("Menu->");
            Console.WriteLine("1.Create Contact and Add to the AddressBook");
            Console.WriteLine("2.Display AddressBook");
            Console.WriteLine("3.Edit Details");
            Console.WriteLine("0.Exit");
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 0:
                    {
                        flag = false;
                        break;
                    }
                case 1:
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
                        addressBook.AddContact(newContact);
                        Console.WriteLine("Successfully Added the contact");
                        break;
                    }
                case 2:
                    {
                        addressBook.DisplayAddressBook();
                        break;
                    }
                case 3:
                    {
                        string fName;
                        Console.WriteLine("Enter Name to Edit Details");
                        fName = Console.ReadLine();
                        addressBook.FindContactAndEdit(fName);
                        break;

                    }

            }
        }
        
    }
}

