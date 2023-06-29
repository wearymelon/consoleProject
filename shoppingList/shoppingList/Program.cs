namespace shoppingList
{
    internal class Program
    {
        static string[] items = new string[2];

        static int count = 0;

        static void addItem(int itemSlot, string itemAdded)
        {
            if (items.Length > itemSlot)
            {
                items[itemSlot] = itemAdded;

                
            }

            else
            {
                string[] tempItems = new string[items.Length * 2];

                for (int i = 0; i < items.Length; i++)
                {
                    tempItems[i] = items[i];
                }

                items = tempItems;

                items[itemSlot] = itemAdded;

                
            }
            count++;
        }

        static void removeItem(string value)
        {
            for(int i = contains(value); i < items.Length - 1; i ++)
            {
                items[i] = items[i + 1];
            }

            items[items.Length - 1] = "";

            if (count <= items.Length / 2)
            {
                string[] tempArray = new string[items.Length / 2];

                for(int i = 0; i < count; i ++)
                {
                    tempArray[i] = items[i];
                }

                items = tempArray;
            }

            count--;
        }

        static void viewItems()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        static int contains(string value)
        {
            for(int i = 0; i < items.Length; i ++)
            {
                if (items[i] == value)
                {
                    return i;
                }
                 
            }
            return -1;
        }

        static void Main(string[] args)
        {
            /*
             * Shopping List:
             * Have an array that store itms in the shopping list
             * Allow the user to add items (with prices) to the list, remove items, view all the items in the list, and checkout (print items w/ prices and total) the items
             * List automatically changes size according to how many items you add to it
             */

            


            

            //give items array individual names (therefore, do not use a for loop and give each index its own item name individually).


            int itemSlot = 0;


            Console.WriteLine("Hello, Customer. Would you like to add items, remove items, view your list, or checkout?");
    
            
            while (true)
            {
                string response = Console.ReadLine();

                if(response == "add")
                {
                    Console.WriteLine("What would you like to add?");
                    string itemAdded = Console.ReadLine();

                        addItem(itemSlot, itemAdded);

                        Console.WriteLine("Your item has been successfully added. What would you like to do next");

                    itemSlot++;
                }

                if (response == "view")
                {
                    viewItems();

                    Console.WriteLine();
                }

                if (response == "remove")
                {
                    Console.WriteLine("What would you like to remove?");

                    string itemRemoved = Console.ReadLine();

                    if (-1 == contains(itemRemoved))
                    {

                        Console.WriteLine("item is not in your list. Please try again.");

                    }

                    else
                    {

                        removeItem(itemRemoved);

                        Console.WriteLine("Your item has been successfully removed. What would you like to do next");
                    }
                }
            }
            
        }
    }
}