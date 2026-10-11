namespace FurnitureLibrary
{
    public class Chair : Furniture
    {
        public override void ShowCharacteristics()
        {
            Console.WriteLine("Стілець");
            Console.WriteLine("  Матеріал: бук");
            Console.WriteLine("  Висота сидіння: 45 см");
            Console.WriteLine("  Максимальне навантаження: 120 кг");
        }
    }
}
