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
        private int _postalCode;
        private string _city;
        private string _phoneNumber;
        private string _email;
        private DateTime _customerCreated;

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
        public int PostalCode
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
        public DateTime CustomerCreated
        {
            get { return _customerCreated; }
            set { _customerCreated = value; }
        }
        
        // Constructor
        public Customer(string name, int customerId, string address, int postalCode, string city, string phoneNumber, string email, DateTime CustomerCreated)
        {
            _name = name;
            _customerId = customerId;
            _address = address;
            _postalCode = postalCode;
            _city = city;
            _phoneNumber = phoneNumber;
            _email = email;
            _customerCreated = CustomerCreated;
        }
                
        //
        public static List<Customer> Customers = new List<Customer>();

        // Methods
        public static void CreateCustomer()
        {
            Console.WriteLine("Indtast kundens navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast kundens ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast kundens addresse: ");
            string address = Console.ReadLine();
            Console.WriteLine("Indtast kundens postnr.: ");
            int postalCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast kundens by: ");
            string city = Console.ReadLine();
            Console.WriteLine("Indtast kundens telefonnummer: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Indtast kundens email: ");
            string email = Console.ReadLine();
            DateTime CustomerCreated = DateTime.Now;

            Customers.Add(new Customer(name, customerId, address, postalCode, city, phoneNumber, email, CustomerCreated));
        }
        public static void RemoveCustomer()
        {
            {
                if (Customers.Count == 0)
                {
                    Console.WriteLine("Ingen kunder tilføjet.");
                    return;
                }
                else
                {
                    foreach (Customer customer in Customers)
                    {
                        Console.WriteLine($"Navn: {customer.Name}, ID: {customer.CustomerId}, Adresse: {customer.Address}, Postnr.: {customer.PostalCode}, By: {customer.City}, Telefon: {customer.PhoneNumber}, Email: {customer.Email}, Oprettet: {customer.CustomerCreated}");
                    }
                    Console.WriteLine("Hvilken kunde vil du fjerne: ");
                    Customers.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
                }
            }
        }
        public static void GetCustomerDetails()
        {

        }
    }
}
