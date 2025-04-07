using System.Security.Cryptography.X509Certificates;

namespace GenSpil
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool displayMenu = true;
            while (displayMenu)
            {
                MainMenu();
            }
        }
        public static void MainMenu()
        {
            Console.WriteLine("Vælg:");
            Console.WriteLine("1. Spil");
            Console.WriteLine("2. Søg spil");
            Console.WriteLine("3. Forespørgsler");
            Console.WriteLine("4. Kunder");
            Console.WriteLine("5. Afslut");

            int choice = Convert.ToInt32(Console.ReadLine());
            bool subChoice = false;
            switch (choice)
            {
                case 1:
                if(subChoice == false)
                    {
                        subChoice = true;
                        while (subChoice = true)
                        {
                            Console.WriteLine("1. Tilføj spil");
                            Console.WriteLine("2. Fjern spil");
                            Console.WriteLine("3. Spiloversigt");
                            Console.WriteLine("4. Tilbage");
                            int i = Convert.ToInt32(Console.ReadLine());
                            if (i == 1)
                            {
                                Storage.AddItem();
                            }
                            else if (i == 2)
                            {
                                Storage.RemoveItem();
                            }
                            else if (i == 3)
                            {
                                foreach (Item game in Storage.Games)
                                {
                                    Console.WriteLine($"Navn: {game.Name}, Version: {game.Version}, Id: {game.ItemId}, Stand: {game.Condition}, Antal på lager: {game.InStock}, Spillere: {game.Players}, Udgivelsesår: {game.YearReleased}, Pris: {game.Price}, Status: {game.ItemStatus} ");
                                }
                            }
                            else if (i == 4)
                            {
                                subChoice = false;
                                break;
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                    break;
                case 2:
                    Storage.SearchGame();
                    break;
                case 3:
                    if (subChoice == false)
                    {
                        subChoice = true;
                        while (subChoice = true)
                        {
                            Console.WriteLine("1. Opret forespørgsel");
                            Console.WriteLine("2. Slet forespørgsel");
                            Console.WriteLine("3. Forespørgselsoversigt");
                            Console.WriteLine("4. Tilbage");
                            int i = Convert.ToInt32(Console.ReadLine());
                            if (i == 1)
                            {
                                Inquiry.CreateInquiryIfNeeded();
                            }
                            else if (i == 2)
                            {
                                Inquiry.RemoveInquiry();
                            }
                            else if (i == 3)
                            {
                                Inquiry.ViewInquiries();
                            }
                            else if (i == 4)
                            {
                                subChoice = false;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    break;
                case 4:
                    if (subChoice == false)
                    {
                        subChoice = true;
                        while (subChoice = true)
                        {
                            Console.WriteLine("1. Opret kunde");
                            Console.WriteLine("2. Slet kunde");
                            Console.WriteLine("3. Kundeoversigt");
                            Console.WriteLine("4. Søg kunde");
                            Console.WriteLine("5. Tilbage");
                            int i = Convert.ToInt32(Console.ReadLine());
                            if (i == 1)
                            {
                                Customer.CreateCustomer();
                            }
                            else if (i == 2)
                            {
                                Customer.RemoveCustomer();
                            }
                            else if (i == 3)
                            {
                                Customer.GetCustomerDetails();
                            }
                            else if (i == 4)
                            {
                                Customer.SearchCustomers();
                                
                            }
                            else if (i == 5)
                            {
                                subChoice = false;
                                break;
                            }
                        }
                    }
                    break;
                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }
    }
}
