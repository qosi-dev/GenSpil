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
        private int _price;

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
        public Item(string name, string version, string condition, int inStock, int players, int yearReleased, int price)
        {
            _name = name;
            _version = version;
            _condition = condition;
            _inStock = inStock;
            _players = players;
            _yearReleased = yearReleased;
            _price = price;
        }

        //
        public static List<Item> Games = new List<Item>();

        // Methods
        public static void AddItem()
        {
            Console.WriteLine("Indtast spillets navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast spillets version: ");
            string version = Console.ReadLine();
            Console.WriteLine("Indtast spillets stand: ");
            string condition = Console.ReadLine();
            Console.WriteLine("Indtast antal på lager: ");
            int inStock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast antal spillere: ");
            int players = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast udgivelsesår: ");
            int yearReleased = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast pris: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Games.Add(new Item(name, version, condition, inStock, players, yearReleased, price));
        }

        public static void RemoveItem()
        {
        }

    }
}
