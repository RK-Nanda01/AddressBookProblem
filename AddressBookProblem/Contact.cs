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
    }
}

