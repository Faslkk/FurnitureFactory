namespace FurnitureLibrary
{
    public class Wardrobe : Furniture
    {
        public override void ShowCharacteristics()
        {
            Console.WriteLine("Шафа");
            Console.WriteLine("  Матеріал: ДСП");
            Console.WriteLine("  Розміри: 200 x 60 x 220 см");
            Console.WriteLine("  Кількість дверцят: 3");
        }
    }
}
