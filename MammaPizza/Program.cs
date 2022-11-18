// See https://aka.ms/new-console-template for more information
using MammaPizza;

Console.WriteLine("Hello, World!");

Customer Cus1 = new Customer(0001, "Mike", "ms@email.dk", "gade 123");
Pizza Pizza1 = new Pizza("Vesuvio", 75.0, 01, 28);
Order Order1 = new Order(Pizza1, Cus1);

Order1.PrintAllInfo();