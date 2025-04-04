using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace GenSpil
{
    internal class Customer
    {
        // Fields
        private string _name;
        private int _customerId;
        private string _address;
        private string _postalCode;
        private string _city;
        private string _phoneNumber;
        private string _email;

        // Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Constructor
        public Customer(string name, int customerId, string phoneNumber, string email)
        {
            _name = name;
            _customerId = customerId;
            _phoneNumber = phoneNumber;
            _email = email;
        }
        public static List<Customer> Customers = new List<Customer>();

        public static void GetCustomerId()
        {
            
        }
    }
}
