using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpil
{
    internal class Storage
    {
        public static List<Item> items = new List<Item>();
        public static List<Inquiry> inquiries = new List<Inquiry>();

        public void AddItem()
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
            int price = Convert.ToInt32(Console.ReadLine());
            items.Add(new Item(name, version, condition, inStock, players, yearReleased, price));

        }
        public void RemoveItem()
        {

        }
        public void ViewItem()
        {

        }
        public void SearchItem()
        {
            
        }
        public void GetItemStatus()
        {

        }
    }
}
