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
        public override string ToString()
        {
            return $"First Name: {this.firstName} \n" + 
                   $"LastName => {this.lastName} \n" +
                   $"Address => {this.address}\n" +
                   $"State => {this.state} \n" +
                   $"City => {this.city} \n" +
                   $"EmailId => {this.emailId} \n" +
                   $"ZipCode => {this.zipCode} \n" +
                   $"PhoneNumber => {this.phoneNumber} \n";
        }
    }
}

