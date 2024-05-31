using System;

namespace MiniProjectInheritance
{
    public class  BookModel : InventoryItemModel, IPurchasable
    { 
        public int NumberOfPages { get; set; }

        public void Purchase()
        {

            QuantityInStock -= 1;
            Console.WriteLine("This been has been purchased.");
        }
    }
    
}
