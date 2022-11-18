using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammaPizza
{
    public class Order
    {
        private static int _orderCounter = 0;
        private int _orderId;
        const int tax = 40;
        private Pizza _pizza;
        private DateTime _dato;
        private Customer _customer;


        public Order(Pizza pizza, Customer customer)
        {
            _orderCounter++;
            _orderId = _orderCounter;
            _pizza = pizza;
            _dato = DateTime.Now;
            _customer = customer;
        }
        public DateTime Dato
        {
            get { return _dato; }
        }

        public Pizza Pizza
        {
            get { return _pizza; }
            set { _pizza = value; }
        }


        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public void PrintAllInfo()
        {
            Console.WriteLine($"ID: {Customer.Cid}, Name: {Customer.Name}, Address: {Customer.Address}, Email: {Customer.Email}  " +
                $"\n\t Pizza: a number {Pizza.ID} '{Pizza.Name}', {Pizza.Size} cm, costing {Pizza.Price} ");
        }

        public override string ToString()
        {
            return $"ID: {Customer.Cid}, Name: {Customer.Name}, Address: {Customer.Address}, Email: {Customer.Email}";
        }



    }
}
