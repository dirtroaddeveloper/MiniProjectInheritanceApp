namespace MiniProjectInheritance
{
    public interface IRentable: IInventoryItem 
    {

        void Rent();
        void ReturnRental();

    }
    
}
