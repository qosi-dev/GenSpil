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
            Console.WriteLine("4. Søg spil");
            Console.WriteLine("5. Opret forespørgsel");
            Console.WriteLine("6. Forespørgselsoversigt");
            Console.WriteLine("7. Slet Forespørgsel");
            Console.WriteLine("8. Afslut");

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
                    Storage.SearchGame();
                    break;
                case 5:
                    Inquiry.CreateInquiryIfNeeded();
                    break;
                case 6:
                    Inquiry.ViewInquiry();
                    break;
                case 7:
                    Inquiry.RemoveInquiry();
                    break;
                case 8:
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
