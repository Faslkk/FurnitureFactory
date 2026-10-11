namespace FurnitureLibrary
{
    public class TableFactory : FurnitureFactory
    {
        public override Furniture CreateFurniture()
        {
            return new Table();
        }
    }
}
