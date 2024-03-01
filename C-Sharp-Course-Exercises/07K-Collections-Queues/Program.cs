using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07K_Collections_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring a new integer queue
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());  // will show 1 (LIFO method)
            Console.WriteLine("The size of the queue is now: {0}", queue.Count);

            int firstItem = queue.Dequeue();
            Console.WriteLine("The item removed from the queue is {0}", firstItem);

            Console.WriteLine("After the dequeue, the value at the front of the queue is now: {0}", queue.Peek());  // will show 2 (LIFO method)
            Console.WriteLine("After the item was dequeued, the size of the queue is now: {0}", queue.Count);

            

            // using while loop to remove all items from the queue
            int counter = 0;
            while (queue.Count > 0)
            {
                queue.Dequeue();
                counter++;
                Console.WriteLine("{0} items have been removed from the queue", counter);
            }

            Console.WriteLine("After the while loop, the items remaining in the queue are {0}", queue.Count);


            Console.WriteLine("\n\n");
            Console.WriteLine("==============ORDERS QUEUE SECTION=====================");

            Queue<Order> ordersQueue = new Queue<Order>();

            // add each order from Branch 1 to the queue
            foreach ( Order o in ReceiveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            // add each order from Branch 2 to the queue
            foreach (Order o in ReceiveOrdersFromBranch2())
            {               
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                // remove the order at the front of the queue
                // and store it in a variable called 'currentOrder'
                Order currentOrder = ordersQueue.Dequeue();
                // process the order
                currentOrder.ProcessOrder();
            }

        }


        // this method will create an array of orders and return it - orders from Branch 1

        static Order[] ReceiveOrdersFromBranch1()
        {
            // creating new orders array
            Order[] orders = new Order[]
            {
            new Order(1, 5),
            new Order(2, 4),
            new Order(6, 10),
            };
            return orders;
        }

        // this method will create an array of orders and return it - orders from Branch 2
        static Order[] ReceiveOrdersFromBranch2()
        {
            // creating new orders array
            Order[] orders = new Order[]
            {
            new Order(3, 5),
            new Order(4, 4),
            new Order(5, 10),
            };
            return orders;
        }

        class Order
        {
            // properties
            public int OrderId { get; set; }
            public int OrderQuantity { get; set; }

            // constructor
            public Order(int id, int orderQuantity)
            {
                this.OrderId = id;
                this.OrderQuantity = orderQuantity;
            }

            // print message on the screen that the order was processed
            public void ProcessOrder()
            {
                Console.WriteLine($"Order id: {OrderId} has been processed!");
            }
        }
    }
    
}
