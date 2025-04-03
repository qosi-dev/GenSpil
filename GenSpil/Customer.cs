using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace GenSpil
{
    internal class Kunde
    {
        // Fields
        private string _name;
        private int _customerId;
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
        public Kunde(string name, int customerId, string phoneNumber, string email)
        {
            _name = name;
            _customerId = customerId;
            _phoneNumber = phoneNumber;
            _email = email;
        }
        public static List<Kunde> Customers = new List<Kunde>();

        public static void AddCustomer()
        {
            Console.WriteLine("Indtast navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast kunde ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast telefonnummer: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Indtast email: ");
            string email = Console.ReadLine();
            Customers.Add(new Kunde(name, customerId, phoneNumber, email));
            Console.WriteLine("Kunde tilføjet!");
        }
        public static void EditCustomer()
        {
        }
        public static void RemoveCustomer()
        {
        }
    }
}
