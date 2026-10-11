namespace FurnitureLibrary
{
    public class WardrobeFactory : FurnitureFactory
    {
        public override Furniture CreateFurniture()
        {
            return new Wardrobe();
        }
    }
}
