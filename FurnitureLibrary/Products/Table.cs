namespace FurnitureLibrary
{
    public class Table : Furniture
    {
        public override void ShowCharacteristics()
        {
            Console.WriteLine("Стіл");
            Console.WriteLine("  Матеріал: дуб");
            Console.WriteLine("  Розміри: 140 x 80 x 75 см");
            Console.WriteLine("  Кількість ніжок: 4");
        }
    }
}
