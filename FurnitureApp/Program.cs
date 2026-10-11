using System.Text;
using FurnitureLibrary;

namespace FurnitureApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("=== Меблева фабрика ===");
                Console.WriteLine("1 - Стіл");
                Console.WriteLine("2 - Стілець");
                Console.WriteLine("3 - Шафа");
                Console.WriteLine("4 - Диван");
                Console.WriteLine("0 - Вихід");
                Console.Write("Що виготовити: ");

                string? choice = Console.ReadLine();
                if (choice == null || choice == "0")
                {
                    break;
                }

                FurnitureFactory? factory = null;
                switch (choice)
                {
                    case "1":
                        factory = new TableFactory();
                        break;
                    case "2":
                        factory = new ChairFactory();
                        break;
                    case "3":
                        factory = new WardrobeFactory();
                        break;
                    case "4":
                        factory = new SofaFactory();
                        break;
                }

                Console.WriteLine();
                if (factory == null)
                {
                    Console.WriteLine("Невідомий пункт меню, спробуйте ще раз.");
                }
                else
                {
                    Furniture furniture = factory.CreateFurniture();
                    furniture.ShowCharacteristics();
                }
                Console.WriteLine();
            }
        }
    }
}
