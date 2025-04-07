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
        public Item(string name, string version, int itemId, string condition, int players, int yearReleased, int price, string itemStatus)
        {
            _name = name;
            _version = version;
            _itemId = itemId;
            _condition = condition;
            //_inStock = inStock;
            _players = players;
            _yearReleased = yearReleased;
            _price = price;
            _itemStatus = itemStatus;
        }

        // Methods
        public static void ViewItem(string name)
        {
            Console.WriteLine("Spil fundet!");
            int i = 1;
            foreach (Item game in Storage.Games)
            {
                Console.WriteLine($"{i}. Spil: {game.Name}, Version: {game.Version}, ID: {game.ItemId}, Tilstand: {game.Condition}, På lager: {game.InStock}, Antal Spillere: {game.Players}, Udgivelsesår: {game.YearReleased}, Pris: {game.Price}");
            }
        }


    }
}
