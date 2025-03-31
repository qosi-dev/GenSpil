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
                            Spil.AddGame();
                            break;
                        case 2:
                            Spil.EditGame();
                            break;
                        case 3:
                            Spil.RemoveGame();
                            break;
                        case 4:
                            Console.WriteLine("Liste over spil:");
                            foreach (var game in Spil.Games)
                            {
                                Console.WriteLine($"Spilnavn: {game.Name}, Version: {game.Version}, Stand: {game.Condition}, Antal på lager: {game.InStock}, Antal spillere: {game.Players}, Udgivelsesår: {game.YearReleased}, Pris: {game.Price}");
                            }
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1. Tilføj kunde: ");
                    Console.WriteLine("2. Ændre kunde: ");
                    Console.WriteLine("3. Fjern kunde: ");
                    Console.WriteLine("4. Kundeliste: ");

                    subChoice = Convert.ToInt32(Console.ReadLine());
                    switch (subChoice)
                    {
                        case 1:
                            Kunde.AddCustomer();
                            break;
                        case 2:
                            Kunde.EditCustomer();
                            break;
                        case 3:
                            Kunde.RemoveCustomer();
                            break;
                        case 4:
                            Console.WriteLine("Liste over kunder:");
                            foreach (var customer in Kunde.Customers)
                            {
                                Console.WriteLine($"Navn: {customer.Name}, Kunde ID: {customer.CustomerId}, Telefonnummer: {customer.PhoneNumber}, Email: {customer.Email}");
                            }
                            break;
                        default:
                            break;

                    }
                    break;
                case 3:
                    Console.WriteLine("1. Tilføj medarbejder: ");
                    Console.WriteLine("2. Ændre medarbejder: ");
                    Console.WriteLine("3. Fjern medarbejder: ");
                    Console.WriteLine("4. Medarbejderliste: ");
                    subChoice = Convert.ToInt32(Console.ReadLine());
                    switch (subChoice)
                    {
                        case 1:
                            Medarbejder.AddEmployee();
                            break;
                        case 2:
                            Medarbejder.EditEmployee();
                            break;
                        case 3:
                            Medarbejder.RemoveEmployee();
                            break;
                        case 4:
                            foreach (var employee in Medarbejder.Employees)
                            {
                                Console.WriteLine($"Navn: {employee.Name}, Medarbejder ID: {employee.EmployeeId}, Telefonnummer: {employee.PhoneNumber}, Email: {employee.Email}");
                            }
                            break;
                        default:
                            break;
                    }
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
