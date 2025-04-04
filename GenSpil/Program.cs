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
            Console.WriteLine("Vælg undermenu: ");
            Console.WriteLine("1. Administrer spil");
            Console.WriteLine("2. Administrer kunder");
            Console.WriteLine("3. Administrer medarbejdere");
            Console.WriteLine("4. Afslut");

            int choice = Convert.ToInt32(Console.ReadLine());
            int subChoice;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Tilføj spil: ");
                    Console.WriteLine("2. Ændre spil: ");
                    Console.WriteLine("3. Fjern spil: ");
                    Console.WriteLine("4. Spilliste: ");
                    subChoice = Convert.ToInt32(Console.ReadLine());
                    switch (subChoice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Vælg venligt en af de angivet muligheder.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1.");

                    subChoice = Convert.ToInt32(Console.ReadLine());
                    switch (subChoice)
                    {
                        case 1:
                            Customer.CreateCustomer();
                            break;
                        case 2:
                            Customer.RemoveCustomer();
                            break;
                        case 3:
                            break;
                        case 4:
                            Console.WriteLine("Liste over kunder:");
                            foreach (var customer in Customer.Customers)
                            {
                                Console.WriteLine($"Navn: {customer.Name}, Kunde ID: {customer.CustomerId}, Addresse: {customer.Address}, Postnr: {customer.PostalCode}, By: {customer.City} Telefonnummer: {customer.PhoneNumber}, Email: {customer.Email}, Oprettet: {customer.CustomerCreated}");
                            }
                            break;
                        default:
                            Console.WriteLine("Vælg venligt en af de angivet muligheder.");
                            break;
                    }
                    break;
                case 3:
                   break;
                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }

        public static void Games()
        {
        }
        public static void Customers()
        {

        }
        public static void Employees()
        {
        }
    }
}
