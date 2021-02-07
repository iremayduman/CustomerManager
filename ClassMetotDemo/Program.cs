using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer();
            customer1.Id = 5;
            customer1.Name = "Irem";
            customer1.Surname = "Ayduman";
            customer1.Age = 20;

            Customer customer2 = new Customer();
            customer2.Id = 6;
            customer2.Name = "Azra";
            customer2.Surname = "Ayduman";
            customer2.Age = 9;

            Customer customer3 = new Customer();
            customer3.Id = 7;
            customer3.Name = "Ece";
            customer3.Surname = "Coşkun";
            customer3.Age = 20;

            Customer customer4 = new Customer();
            customer4.Id = 8;
            customer4.Name = "Emre";
            customer4.Surname = "Özyüzücüler";
            customer4.Age = 21;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            Console.WriteLine("*************");

            customerManager.list(customers);

            Console.WriteLine("**************");

            customerManager.delete(customer1);
            customerManager.delete(customer2);
            customerManager.delete(customer3);
            customerManager.delete(customer4);



        }
    }
}
