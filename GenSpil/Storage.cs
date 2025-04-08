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
            Console.WriteLine("Vælg status: ");
            Console.WriteLine("1. På lager" + "\n" + "2. Ikke på lager" + "\n" + "3. Forespurgt" + "\n" + "4. Reserveret" + "\n" + "5. Til reperation");
            int statusInput = Convert.ToInt32(Console.ReadLine());
            string itemStatus = statusInput switch
            {
                1 => "På lager",
                2 => "Ikke på lager",
                3 => "Forespurgt",
                4 => "Reserveret",
                5 => "Til reperation",
                _ => "Ugyldig valg"
            };
            Storage.Games.Add(new Item(name, version, itemId, condition, players, yearReleased, price, itemStatus));
            Console.WriteLine("Spil oprettet!");
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
                Console.WriteLine("Hvilket spil vil du fjerne: ");
                Storage.Games.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
                Console.WriteLine("Spil Fjernet!");
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

        public static void ViewStorage()
        {
            Console.WriteLine("Vælg sortering:");
            Console.WriteLine("1. Alfabetisk" + "\n" + "2. Tilstand" + "\n" + "3. Pris" + "\n" + "4. Status");
            int choice = Convert.ToInt32(Console.ReadLine());
            int i = 1;
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
                case 4:
                    Games = Games.OrderBy(item => item.ItemStatus).ToList();
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg.");
                        break;
            }
            if (Games.Count == 0)
            {
                Console.WriteLine("Ingen spil tilgængelige.");
                return;
            }
            else
            {
                foreach (Item game in Storage.Games)
                {
                    Console.WriteLine($"{i}. Spil: {game.Name}, Version: {game.Version}, ID: {game.ItemId}, Tilstand: {game.Condition}, Antal Spillere: {game.Players}, Udgivelsesår: {game.YearReleased}, Pris: {game.Price}, Status: {game.ItemStatus}");
                    i++;
                }
            }
        }
    }
}
