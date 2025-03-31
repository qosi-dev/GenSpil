using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GenSpil
{
    internal class Medarbejder
    {
        // Fields
        private string _name;
        private int _employeeId;
        private string _phoneNumber;
        private string _email;

        // Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
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
        public Medarbejder(string name, int employeeId, string phoneNumber, string email)
        {
            _name = name;
            _employeeId = employeeId;
            _phoneNumber = phoneNumber;
            _email = email;
        }

        public static List<Medarbejder> Employees = new List<Medarbejder>();

        

        
        public static void AddEmployee()
        {
            Console.WriteLine("Indtast navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast medarbejder ID: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast telefonnummer: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Indtast email: ");
            string email = Console.ReadLine();
            Employees.Add(new Medarbejder(name, employeeId, phoneNumber, email));
        }
        public static void EditEmployee()
        {

        }
        public static void RemoveEmployee()
        {

        }




    }
}
