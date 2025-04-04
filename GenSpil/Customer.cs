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
                    Console.WriteLine("Ingen kunder fundet.");
                    return;
                }
                else
                {
                    GetCustomerDetails();
                    Console.WriteLine("Hvilken kunde vil du fjerne: ");
                    Customers.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1); // input 0 crash system
                }
            }
        }
        public static void GetCustomerDetails()
        {
            int index = 0;
            
            foreach (Customer customer in Customers)
            {
                index++;
                Console.WriteLine($"{index}. Navn: {customer.Name}, ID: {customer.CustomerId}, Adresse: {customer.Address}, Postnr.: {customer.PostalCode}, By: {customer.City}, Telefon: {customer.PhoneNumber}, Email: {customer.Email}, Oprettet: {customer.CustomerCreated}");
            }
        }
        public static void SearchCustomers()
        {
            bool subChoice = false;
            if (subChoice == false)
            {
                subChoice = true;
                while (subChoice = true)
                {
                    Console.WriteLine("1. Søg med navn");
                    Console.WriteLine("2. Søg med kundeid");
                    Console.WriteLine("3. Tilbage");
                    int i = Convert.ToInt32(Console.ReadLine());
                    if (i == 1)
                    {
                        Console.WriteLine("Indtast kundens navn: ");
                        string name = Console.ReadLine();
                        var itemFound = Customers.Where(customer => customer.Name == name).ToList();
                        if (itemFound.Count > 0)
                        {
                            foreach (Customer customer in itemFound)
                            {
                                GetCustomerDetails();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingen kunde fundet!");
                        }
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Indtast kundens id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var itemFound = Customers.Where(customer => customer.CustomerId == id).ToList();
                        if (itemFound.Count > 0)
                        {
                            foreach (Customer customer in itemFound)
                            {
                                GetCustomerDetails();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingen kunde fundet!");
                        }
                    }
                    else if (i == 3)
                    {
                        subChoice = false;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
        }
    }
}
