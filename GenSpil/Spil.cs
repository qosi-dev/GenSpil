using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpil
{
    internal class Spil
    {
        // Fields
        private string _name;
        private string _version;
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
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        // Constructor
        public Spil(string name, string version, string condition, int inStock, int players, int yearReleased, double price)
        {
            _name = name;
            _version = version;
            _condition = condition;
            _inStock = inStock;
            _players = players;
            _yearReleased = yearReleased;
            _price = price;
        }

        public static List<Spil> Games = new List<Spil>();

        public static void AddGame()
        {
            Console.WriteLine("Indtast spilnavn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast version: ");
            string version = Console.ReadLine();
            Console.WriteLine("Indtast stand: ");
            string condition = Console.ReadLine();
            Console.WriteLine("Indtast antal på lager: ");
            int inStock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast antal spillere: ");
            int players = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast udgivelsesår: ");
            int yearReleased = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast pris: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Games.Add(new Spil(name, version, condition, inStock, players, yearReleased, price));
        }
        public static void EditGame()
        {
        }
        public static void RemoveGame()
        {
        }

    }
}
