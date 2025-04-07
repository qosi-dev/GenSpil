using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace GenSpil
{
    internal class Storage
    {
        public static List<Item> Games = new List<Item>();
        public static List<Inquiry> inquiries = new List<Inquiry>();

        public static void AddItem()
        {
            Console.WriteLine("Indtast spillets navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast spillets version: ");
            string version = Console.ReadLine();
            Console.WriteLine("Indtast spillets id: "); // Skal tildeles automatisk
            int itemId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast spillets stand: ");
            string condition = Console.ReadLine();
            Console.WriteLine("Indtast antal på lager: "); // Skal tildeles automatisk
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
                    Item.ViewItem(game.ItemId);
                }
                Console.WriteLine("Hvilket spil vil du fjerne: "); // Spillet bør søges frem før mulighed for at slette
                Storage.Games.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
            }
        }
        public static void SearchGame() // Mangler at tage højde for dele af det søgte navn
        {
                Console.WriteLine("Indtast spillets navn: ");
                string name = Console.ReadLine();
                var itemFound = Games.Where(game => game.Name == name).ToList();
                if (itemFound.Count > 0)
                {
                     Console.WriteLine("Spil fundet!");
                     foreach (Item game in itemFound)
                     {
                        Item.ViewItem("");
                     }
                    }
                    else
                    {
                        Console.WriteLine("Ingen spil fundet!");
                    }
            // Søgefunktion med flere kriterier udover navn
        }






        public static void ViewStorage()
        {
            if (Storage.Games.Count == 0)
            {
                Console.WriteLine("Ingen spil tilgængelige.");
                return;
            }
            else
            {
                Games = Games.OrderBy(item => item.Name).ToList();
                foreach (Item game in Storage.Games)
                {
                    Console.WriteLine($"Spil: {game.Name}, Version: {game.Version}, ID: {game.ItemId}, Tilstand: {game.Condition}, På lager: {game.InStock}, Antal Spillere: {game.Players}, Udgivelsesår: {game.YearReleased}, Pris: {game.Price}");
                }
            }
        }
    }
}
