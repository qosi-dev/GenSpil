using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpil
{
    internal class Item
    {
        // Fields
        private string _name;
        private string _version;
        private int _itemId;
        private string _condition;
        private int _inStock;
        private int _players;
        private int _yearReleased;
        private double _price;

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
        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        public string Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }
        public int InStock
        {
            get { return _inStock; }
            set { _inStock = value; }
        }
        public int Players
        {
            get { return _players; }
            set { _players = value; }
        }
        public int YearReleased
        {
            get { return _yearReleased; }
            set { _yearReleased = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        // Constructor
        public Item(string name, string version, string condition, int inStock, int players, int yearReleased, double price)
        {
            _name = name;
            _version = version;
            _condition = condition;
            _inStock = inStock;
            _players = players;
            _yearReleased = yearReleased;
            _price = price;
        }

        public static List<Item> Games = new List<Item>();

        public static void AddItem()
        {

        }
        public static void RemoveGame()
        {
        }

    }
}
