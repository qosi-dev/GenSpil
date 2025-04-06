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
        private int _inquiryId;
        private string _itemName;
        private string _version;
        private string _condition;
        private string _requestedBy;
        private DateTime _inquiryDate;

        // Properties
        public int InquiryId
        {
            get { return _inquiryId; }
            set { _inquiryId = value; }
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
        public string RequestedBy
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
        public Inquiry(string itemName, string version, string condition, string requestedBy, DateTime inquiryDate)
        {
            _itemName = itemName;
            _version = version;
            _condition = condition;
            _inquiryDate = inquiryDate;
            _requestedBy = requestedBy;
        }

        // Methods
        public static void CreateInquiryIfNeeded()
        {
            Console.WriteLine("Indtast navn på spillet: ");
            string itemName = Console.ReadLine();
            Console.WriteLine("Indtast version: ");
            string version = Console.ReadLine();
            Console.WriteLine("Hvad er spillets tilstand: ");
            string condition = Console.ReadLine();
            Console.WriteLine("Hvem anmoder om det: ");
            string requestedBy = Console.ReadLine();
            DateTime inquiryDate = DateTime.Now;
            Inquiry inquiry = new Inquiry(itemName, version, condition, requestedBy, inquiryDate);
            Storage.inquiries.Add(inquiry);
            var highestId = Storage.inquiries.Count > 0 ? Storage.inquiries.Max(i => i.InquiryId) : 0;
            inquiry.InquiryId = highestId + 1;
            Console.WriteLine($"Forespørgsel oprettet med ID: {inquiry.InquiryId}");
        }

        public static void ViewInquiry()
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
                    Console.WriteLine($"Forespørgsel ID: {inquiry.InquiryId}, Spilnavn: {inquiry.ItemName}, Version: {inquiry.Version}, Tilstand: {inquiry.Condition}, Anmodet af: {inquiry.RequestedBy}, Dato: {inquiry.InquiryDate}");
                }
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
                    Console.WriteLine($"Forespørgsel ID: {inquiry.InquiryId}, Spilnavn: {inquiry.ItemName}, Version: {inquiry.Version}, Tilstand: {inquiry.Condition}, Anmodet af: {inquiry.RequestedBy}, Dato: {inquiry.InquiryDate}");
                }
                Console.WriteLine("Hvilken forespørgsel vil du fjerne (angiv ID): ");
                int id = Convert.ToInt32(Console.ReadLine());
                var inquiryToRemove = Storage.inquiries.FirstOrDefault(i => i.InquiryId == id);
                if (inquiryToRemove != null)
                {
                    Storage.inquiries.Remove(inquiryToRemove);
                    Console.WriteLine($"Forespørgsel med ID {id} er fjernet.");
                }
                else
                {
                    Console.WriteLine("Ingen forespørgsel fundet med det angivne ID.");
                }
            }
        }

    }
}
