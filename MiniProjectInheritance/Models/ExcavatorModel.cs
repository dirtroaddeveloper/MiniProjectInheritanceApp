using System;

namespace MiniProjectInheritance
{
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig() => Console.WriteLine("I am digging");

        public void Rent()
        {

            QuantityInStock -= 1;
            Console.WriteLine("This excavater has been rented.");
        }

        public void ReturnRental()
        {
            
            QuantityInStock += 1;
            Console.WriteLine("The excavater has been returned.");
        }
    }
    
}
