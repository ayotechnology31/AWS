using System;

namespace Enums
{
	class Program
	{
        /// <summary>
        /// Magic Number 
        /// A magic number is a value that is hard-coded into your code but which does not have a clear meaning. 
        /// </summary>
        /// <param name="o"></param>
        public void ShipOrder(Order o)
        {
            if (o.Status == 2) // purchased
            {
                // ship it

                // move to shipped status
                o.Status = 3;
            }
        }

        /// <summary>
        /// Declaring Enums
        //To declare an enum, simply use the enum keyword in a similar manner as declaring a class:
        /// </summary>
        public enum OrderStatus
        {
            Quoted = 1,
            Purchased = 2,
            Shipped,
            Delivered
            }
        }


    ////An enum declaration is simply a list of labels with an optional integer value assigned to it. As you can see above, we only provided values for the first two labels. 
    ///If you omit a value, it will simply count up from the last known label. 
    ///In this case, we stopped numbering at 2, so Shipped would be assigned a value 3, Delivered 4, etc. 
    ///It is not common, but you can start numbering then restart numbering later:
    ///
    public enum SampleCounting
    {
        Apple = 5,
        Pear, // 6
        Peach = 2,
        Watermelon, // 3
        Pineapple = 5
    }
    //Using Enums
    //Enums are types, so you can declare variables and class members that are of any enum type that you have defined.
    //    Continuing with our order status example, the Order class could have a member of type 
    //    OrderStatus.If we had a method to advance the status, it could look something like this:
    public class Order
    {
        public OrderStatus Status { get; private set; }

        public void AdvanceStatus()
        {
            switch (Status)
            {
                case OrderStatus.Quoted:
                    Status = OrderStatus.Purchased;
                    break;
                case OrderStatus.Purchased:
                    Status = OrderStatus.Shipped;
                    break;
                case OrderStatus.Shipped:
                    Status = OrderStatus.Delivered;
                    break;
            }
        }
    }

    //Comparing Enums
    //To compare an integer to an enum type you must cast the integer as the type, like the following:

    int status = 3;
        if((OrderStatus) status == OrderStatus.Shipped)
        {
            // do stuff
        }
        //This is true even if we are comparing two enums. In C# if you want to compare two different enum types you still must cast them even if they happen to have the same numerical values:

        public enum FruitA
        {
            Apple = 1
        }

        public enum FruitB
        {
            Apple = 1
        }

        FruitA a = FruitA.Apple;
        FruitB b = FruitB.Apple;
 
        // compile error, not the same type
        if(a == b)
        {
 
        }
 
        // valid, now we are comparing integer values
        if((int) a == (int) b)
        {
 
        }

}
