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
            string requestedBy = Console.ReadLine();
            DateTime inquiryDate = DateTime.Now;
            Inquiry inquiry = new Inquiry(itemName, version, condition, requestedBy, inquiryDate);
            Storage.inquiries.Add(inquiry);
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
                Storage.inquiries.Sort();
                foreach (Inquiry inquiry in Storage.inquiries)
                {
                    Console.WriteLine($"Navn: {inquiry.ItemName}, Version: {inquiry.Version}, Id: {inquiry.InquiryId}, Stand: {inquiry.Condition}, Anmodet af: {inquiry.RequestedBy}, Dato: {inquiry.InquiryDate}");
                }
                Console.WriteLine("Hvilket spil vil du fjerne(1..): ");
                Storage.Games.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
            }
        }        
    }
}
