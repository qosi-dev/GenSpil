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
            Console.Write("Indtast spillets navn: ");
            string name = Console.ReadLine();
            Console.Write("Indtast spillets version: ");
            string version = Console.ReadLine();
            //Automatisk tildeling af itemId
            int itemId = 0;
            if (Games.Count == 0)
            {
                itemId = 1;
            }
            else
            {
                itemId = Games.Max(item => item.ItemId) + 1;
            }
            //
            Console.Write("Vælg spillets stand (1-5): " + "\n");
            Console.WriteLine("1. Meget god" + "\n" + "2. God" + "\n" + "3. Middel" + "\n" + "4. Dårlig" + "\n" + "5. Meget dårlig");
            int conditionInput = Convert.ToInt32(Console.ReadLine());
            string condition = conditionInput switch
            {
                1 => "Meget god",
                2 => "God",
                3 => "Middel",
                4 => "Dårlig",
                5 => "Meget dårlig",
                _ => "Ugyldig valg"
            };
            Console.Write("Indtast antal spillere: ");
            int players = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast udgivelsesår: ");
            int yearReleased = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast pris: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast status: "); // ??? Hvad var meningen igen ???
            string itemStatus = Console.ReadLine();
            Storage.Games.Add(new Item(name, version, itemId, condition, players, yearReleased, price, itemStatus));
            //itemID++;
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
                SearchGame();
                Console.WriteLine("Hvilket spil vil du fjerne: "); // Spillet bør søges frem før mulighed for at slette
                Storage.Games.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
            }
        }
        public static void SearchGame()  
        {
            Console.WriteLine("Indtast spillets navn: ");
            string name = Console.ReadLine();
            var itemFound = Games.Where(game => game.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            if (itemFound.Count > 0)
            {
                Console.WriteLine("Spil fundet!");
                foreach (Item game in itemFound)
                {
                    Item.ViewItem(game.Name);
                }
            }
            else
            {
                Console.WriteLine("Ingen spil fundet!");
            }
        }

        public static void ViewStorage() // Kriterier??
        {
            Console.WriteLine("Vælg sortering:");
            Console.WriteLine("1. Alfabetisk" + "\n" + "2. Tilstand" + "\n" + "3. Pris");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Games = Games.OrderBy(item => item.Name).ToList();
                    break;
                case 2:
                    Games = Games.OrderBy(item => item.Condition).ToList();
                    break;
                case 3:
                    Games = Games.OrderBy(item => item.Price).ToList();
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Viser spil uden sortering.");
                    break;
            }

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
                    Console.WriteLine($"Spil: {game.Name}, Version: {game.Version}, Id: {game.ItemId}, Tilstand: {game.Condition}, På lager: {game.InStock}, Antal Spillere: {game.Players}, Udgivelsesår: {game.YearReleased}, Pris: {game.Price}");
                }
            }
        }
    }
}
