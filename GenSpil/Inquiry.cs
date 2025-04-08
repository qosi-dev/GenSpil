using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpil
{
    internal class Inquiry
    {
        // Statisk felt til automatisk ID-tildeling
        private static int _nextInquiryId = 1;

        // Felter
        private int _inquiryId;
        private string _itemName;
        private string _version;
        private string _condition;
        private Customer _requestedBy;
        private DateTime _inquiryDate;

        // Egenskaber
        public int InquiryId
        {
            get { return _inquiryId; }
            private set { _inquiryId = value; }
        }
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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
        public Customer RequestedBy
        {
            get { return _requestedBy; }
            set { _requestedBy = value; }
        }
        public DateTime InquiryDate
        {
            get { return _inquiryDate; }
            set { _inquiryDate = value; }
        }

        // Constructor
        public Inquiry(string itemName, string version, string condition, Customer requestedBy, DateTime inquiryDate)
        {
            this.InquiryId = _nextInquiryId++;
            this.ItemName = itemName;
            this.Version = version;
            this.Condition = condition;
            this.RequestedBy = requestedBy;
            this.InquiryDate = inquiryDate;
        }

        // Metode til oprettelse af en ny Inquiry
        public static void CreateInquiryIfNeeded()
        {
            Console.WriteLine("Indtast navn på spillet: ");
            string itemName = Console.ReadLine();

            Console.WriteLine("Indtast version: ");
            string version = Console.ReadLine();

            Console.WriteLine("Hvad er spillets tilstand: ");
            string condition = Console.ReadLine();

            // Vælg eller opret kunde
            Customer selectedCustomer = SelectOrCreateCustomer();

            DateTime inquiryDate = DateTime.Now;
            Inquiry inquiry = new Inquiry(itemName, version, condition, selectedCustomer, inquiryDate);
            Storage.inquiries.Add(inquiry);

            Console.WriteLine("Inquiry oprettet med ID: " + inquiry.InquiryId);
        }

        // Privat metode, der lader brugeren vælge en eksisterende kunde eller oprette en ny
        private static Customer SelectOrCreateCustomer()
        {
            Console.WriteLine("Vælg kunde:");
            Console.WriteLine("1. Vælg eksisterende kunde");
            Console.WriteLine("2. Opret ny kunde");

            int choice;
            bool validChoice = int.TryParse(Console.ReadLine(), out choice);
            if (!validChoice)
            {
                Console.WriteLine("Ugyldigt input. Opretter ny kunde som standard.");
                choice = 2;
            }

            if (choice == 1)
            {
                if (Customer.Customers.Count == 0)
                {
                    Console.WriteLine("Ingen eksisterende kunder. Opretter ny kunde.");
                    Customer.CreateCustomer();
                    return Customer.Customers.Last();
                }
                else
                {
                    Console.WriteLine("Eksisterende kunder:");
                    for (int i = 0; i < Customer.Customers.Count; i++)
                    {
                        Customer cust = Customer.Customers[i];
                        Console.WriteLine($"{i + 1}. Navn: {cust.Name}, Telefon: {cust.PhoneNumber}, KundeID: {cust.CustomerId}");
                    }
                    Console.WriteLine("Vælg kunde ved nummer:");
                    int selected;
                    if (int.TryParse(Console.ReadLine(), out selected) && selected > 0 && selected <= Customer.Customers.Count)
                    {
                        return Customer.Customers[selected - 1];
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt valg. Opretter ny kunde.");
                        Customer.CreateCustomer();
                        return Customer.Customers.Last();
                    }
                }
            }
            else if (choice == 2)
            {
                Customer.CreateCustomer();
                return Customer.Customers.Last();
            }
            else
            {
                Console.WriteLine("Ugyldigt valg. Opretter ny kunde som standard.");
                Customer.CreateCustomer();
                return Customer.Customers.Last();
            }
        }
        public static void RemoveInquiry()
        {
            if (Storage.inquiries.Count == 0)
            {
                Console.WriteLine("Ingen forespørgsler tilgængelige.");
                return;
            }
            else
            {
                foreach (Inquiry inquiry in Storage.inquiries)
                {
                    ViewInquiries();
                }
                Console.WriteLine("Hvilket spil vil du fjerne(1..): ");
                Storage.Games.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
            }
        }
        public static void ViewInquiries()
        {
            foreach (Inquiry inquiry in Storage.inquiries)
            {
                Console.WriteLine($"Navn: {inquiry.ItemName}, Version: {inquiry.Version}, Id: {inquiry.InquiryId}, Stand: {inquiry.Condition}, Anmodet af: {inquiry.RequestedBy}, Dato: {inquiry.InquiryDate}");
            }
        }
    }
}