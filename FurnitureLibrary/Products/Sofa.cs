namespace FurnitureLibrary
{
    public class Sofa : Furniture
    {
        public override void ShowCharacteristics()
        {
            Console.WriteLine("Диван");
            Console.WriteLine("  Оббивка: тканина");
            Console.WriteLine("  Кількість місць: 3");
            Console.WriteLine("  Розкладний: так");
        }
    }
}
