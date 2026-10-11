namespace FurnitureLibrary
{
    public class SofaFactory : FurnitureFactory
    {
        public override Furniture CreateFurniture()
        {
            return new Sofa();
        }
    }
}
