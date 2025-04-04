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
            Console.WriteLine("Vælg undermenu:");
            Console.WriteLine("1. Tilføj spil");
            Console.WriteLine("2. Spiloversigt");
            Console.WriteLine("3. Fjern spil");
            Console.WriteLine("4. Tilføj Forespørgsel");
            Console.WriteLine("5. Forespørgselsoversigt");
            Console.WriteLine("6. Slet Forespørgsel");
            Console.WriteLine("7. Afslut");

            int choice = Convert.ToInt32(Console.ReadLine());
            int subChoice;
            switch (choice)
            {
                case 1:
                    Storage.AddItem();
                    break;
                case 2:
                    Storage.ViewStorage();
                    break;
                case 3:
                    Storage.RemoveItem();
                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:
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
