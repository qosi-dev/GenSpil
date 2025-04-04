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
            Item.AddItem();
        }
        public static void RemoveItem()
        {
            Item.RemoveItem();
        }
        public void GetItemStatus()
        {

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
