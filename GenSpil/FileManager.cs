using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GenSpil
{
    public static class FileManager
    {
        private const string GamesFile = "games.json";
        private const string InquiriesFile = "inquiries.json";
        private const string CustomersFile = "customers.json";

        /// <summary>
        /// Gemmer listerne for spil, forespørgsler og kunder til filer i JSON-format.
        /// </summary>
        public static void SaveData()
        {
            // Gem spil
            try
            {
                string gamesJson = JsonSerializer.Serialize(Storage.Games, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(GamesFile, gamesJson);
                Console.WriteLine("Spil gemt til " + GamesFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl ved lagring af spil: " + ex.Message);
            }

            // Gem forespørgsler
            try
            {
                string inquiriesJson = JsonSerializer.Serialize(Storage.inquiries, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(InquiriesFile, inquiriesJson);
                Console.WriteLine("Forespørgsler gemt til " + InquiriesFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl ved lagring af forespørgsler: " + ex.Message);
            }

            // Gem kunder
            try
            {
                string customersJson = JsonSerializer.Serialize(Customer.Customers, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(CustomersFile, customersJson);
                Console.WriteLine("Kunder gemt til " + CustomersFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl ved lagring af kunder: " + ex.Message);
            }
        }

        /// <summary>
        /// Indlæser listerne for spil, forespørgsler og kunder fra filer i JSON-format.
        /// </summary>
        public static void LoadData()
        {
            // Indlæs spil
            if (File.Exists(GamesFile))
            {
                try
                {
                    string gamesJson = File.ReadAllText(GamesFile);
                    Storage.Games = JsonSerializer.Deserialize<List<Item>>(gamesJson);
                    Console.WriteLine("Spil indlæst fra " + GamesFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fejl ved indlæsning af spil: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Filen " + GamesFile + " findes ikke.");
            }

            // Indlæs forespørgsler
            if (File.Exists(InquiriesFile))
            {
                try
                {
                    string inquiriesJson = File.ReadAllText(InquiriesFile);
                    Storage.inquiries = JsonSerializer.Deserialize<List<Inquiry>>(inquiriesJson);
                    Console.WriteLine("Forespørgsler indlæst fra " + InquiriesFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fejl ved indlæsning af forespørgsler: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Filen " + InquiriesFile + " findes ikke.");
            }

            // Indlæs kunder
            if (File.Exists(CustomersFile))
            {
                try
                {
                    string customersJson = File.ReadAllText(CustomersFile);
                    Customer.Customers = JsonSerializer.Deserialize<List<Customer>>(customersJson);
                    Console.WriteLine("Kunder indlæst fra " + CustomersFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fejl ved indlæsning af kunder: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Filen " + CustomersFile + " findes ikke.");
            }
        }
    }
}
