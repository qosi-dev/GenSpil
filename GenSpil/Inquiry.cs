using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpil
{
    internal class Inquiry
    {
        // Fields
        private string _name;
        private string _version;
        private string _condition;

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }
        public string Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        // Constructor
        public Inquiry(string name, string version, string condition)
        {
            _name = name;
            _version = version;
            _condition = condition;
        }

        public static List<Inquiry> Inquiries = new List<Inquiry>();


        public static void AddInquiry()
        {
            Console.WriteLine("Indtast navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast version: ");
            string version = Console.ReadLine();
            Console.WriteLine("Indtast stand: ");
            string condition = Console.ReadLine();
            Inquiry inquiry = new Inquiry(name, version, condition);
            Inquiries.Add(inquiry);
        }
        public static void EditInquiry()
        {
        }
        public static void RemoveEmployee()
        {
        }
    }
}
