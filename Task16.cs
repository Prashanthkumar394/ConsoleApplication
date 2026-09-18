using System;

namespace Task16
{
    interface IHR
    {
        void AccessHR();
    }

    interface IInventory
    {
        void AccessInventory();
    }

    interface ISales
    {
        void AccessSales();
    }

    class Client1 : IHR
    {
        public void AccessHR()
        {
            Console.WriteLine("Client1 can access HR");
        }   
    }   

    class Client2 : IHR, IInventory
    {
        public void AccessHR()
        {
            Console.WriteLine("Client2 can access HR");
        }

        public void AccessInventory()
        {
            Console.WriteLine("Client2 can access Inventory");
        }
    }

    class Client3 : IHR, IInventory, ISales
    {
        public void AccessHR()
        {
            Console.WriteLine("Client3 can access HR");
        }

        public void AccessInventory()
        {
            Console.WriteLine("Client3 can access Inventory");
        }

        public void AccessSales()
        {
            Console.WriteLine("Client3 can access Sales");
        }
    }

    class Program
    {
        static void Main()
        {
            Client1 c1 = new Client1();
            c1.AccessHR();

            Console.WriteLine();

            Client2 c2 = new Client2();
            c2.AccessHR();
            c2.AccessInventory();

            Console.WriteLine();

            Client3 c3 = new Client3();
            c3.AccessHR();
            c3.AccessInventory();
            c3.AccessSales();
        }
    }
}

