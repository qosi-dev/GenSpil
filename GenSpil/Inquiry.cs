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
    }
}
