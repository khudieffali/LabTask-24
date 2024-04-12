using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_24
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Payment Payment {  get; set; } 
        public double CashBalance { get; set; }
        public double CardBalance { get; set; }
        public Customer(string name,string surname,double cashBalance,double cardBalance)
        {
            Name = name;
            Surname = surname;
            CashBalance = cashBalance;
            CardBalance = cardBalance;
        }
        
        public Product[] InBasket(Product[] products)
        {
          Product[] basketProduct = products;
          return basketProduct;
            //Console.WriteLine($"{basketProduct.Name} {item.Price}-azn {item.AvailableCount} {item.InStockCount} ");
        }

    }
}
