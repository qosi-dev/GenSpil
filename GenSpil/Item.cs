using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

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
        private string _itemStatus;

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
        public string ItemStatus
        {
            get { return _itemStatus; }
            set { _itemStatus = value; }
        }

        // Constructor
        public Item(string name, string version, int itemId, string condition, int inStock, int players, int yearReleased, int price, string itemStatus)
        {
            _name = name;
            _version = version;
            _itemId = itemId;
            _condition = condition;
            _inStock = inStock;
            _players = players;
            _yearReleased = yearReleased;
            _price = price;
            _itemStatus = itemStatus;
        }

        // Methods
        public static void AddItem()
        {
            Console.WriteLine("Indtast spillets navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast spillets version: ");
            string version = Console.ReadLine();
            Console.WriteLine("Indtast spillets id: ");
            int itemId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast spillets stand: ");
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
            Console.WriteLine("Indtast status: ");
            string itemStatus = Console.ReadLine();
            Storage.Games.Add(new Item(name, version, itemId, condition, inStock, players, yearReleased, price, itemStatus));
        }

        public static void RemoveItem()
        {
            if (Storage.Games.Count == 0)
            {
                Console.WriteLine("Ingen spil tilgængelige.");
                return;
            }
            else
            {
                foreach (Item game in Storage.Games)
                {
                    ViewItem(game.ItemId);
                }
                Console.WriteLine("Hvilket spil vil du fjerne: ");
                Storage.Games.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
            }
        }
        public static void ViewItem(int id)
        {
            Console.WriteLine("Indtast spillets id: ");
            id = Convert.ToInt32(Console.ReadLine());
            var itemFound = Storage.Games.Where(game => game.ItemId == id).ToList();
            if (itemFound.Count > 0)
            {
                Console.WriteLine("Spil fundet!");
                foreach (Item game in itemFound)
                {
                    Console.WriteLine($"Spil: {game.Name}, Version: {game.Version}, ID: {game.ItemId}, Tilstand: {game.Condition}, På lager: {game.InStock}, Antal Spillere: {game.Players}, Udgivelsesår: {game.YearReleased}, Pris: {game.Price}");
                }
            }
            else
            {
                Console.WriteLine("Spillet kunne ikke findes.");
            }
        }

        
    }
}
