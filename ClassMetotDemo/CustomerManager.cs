using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi:"+customer.Name+" "+customer.Surname);
        }
        public void list(Customer[] customers)
        {
            foreach(Customer customer in customers)
            {
                Console.WriteLine("Müşteri Id: "+customer.Id+" Müşterinin Adı: "+customer.Name+" Müşterinin Soyadı:"+customer.Surname+" Müşterinin Yaşı: "+customer.Age);
            }
        }
        public void delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi: "+customer.Name+" "+customer.Surname);
        }
    }
}
