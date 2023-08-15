using System;
namespace AddressBookProblem
{
	public class Contact
	{
        private string firstName;
        private string lastName;
        private string address;
        private string state;
        private string city;
        private int zipCode;
        private long phoneNumber;
        private string emailId;

        public Contact(string firstName, string lastName, string address, string state, string city, string email, int zipCode, long phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.state = state;
            this.city = city;
            this.emailId = email;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
        }
        public string GetFirstName()
        {
            return this.firstName;
        }
        public string GetCityName()
        {
            return this.city;
        }
        public string GetStateName()
        {
            return this.state;
        }
        public void EditContactDetails(string lastName, string address, string state, string city, string email, int zipCode, long phoneNumber)
        {
            this.lastName = lastName;
            this.address = address;
            this.state = state;
            this.city = city;
            this.emailId = email;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
        }
        public void DisplayContact()
        {
            Console.WriteLine($"FirstName => {this.firstName}");
            Console.WriteLine($"LastName => {this.lastName}");
            Console.WriteLine($"Address => {this.address}");
            Console.WriteLine($"State => {this.state}");
            Console.WriteLine($"City => {this.city}");
            Console.WriteLine($"EmailId => {this.emailId}");
            Console.WriteLine($"ZipCode => {this.zipCode}");
            Console.WriteLine($"PhoneNumber => {this.phoneNumber}");
            
        }
    }
}

