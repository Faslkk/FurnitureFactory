namespace FurnitureLibrary
{
    public class ChairFactory : FurnitureFactory
    {
        public override Furniture CreateFurniture()
        {
            return new Chair();
        }
    }
}
