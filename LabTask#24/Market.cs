using LabTask_24;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_24
{
    internal class Market
    {
        public Product[] Products { get; set; }

        public Market(Product[] products)
        {
            Products = products;
        }

        //public void Shopping(Product[] products, Customer customer)
        //{
        //    head:
        //    Console.WriteLine("Alis veris edirsizse 1 ve  imtina etmek isteyirsize 2 yazin");
        //    string input = Console.ReadLine();
        //    bool checkInput=int.TryParse(input, out int id);
        //    if (!checkInput) goto head;
        //    switch (id)
        //    {
        //        case 1:
        //            foreach (var item in products)
        //            {

        //                if (item.AvailableCount > 0)
        //                {
        //                pay:

        //                    Console.WriteLine("Nagd alis veris edirsizse 1, kartla edirsize 2 yazin");
        //                    string inputPay = Console.ReadLine();
        //                    bool checkInputPay = int.TryParse(inputPay, out int idPay);
        //                    if (!checkInputPay) goto pay;
        //                    double sum = 0;
        //                    foreach (var item1 in products)
        //                    {
        //                        sum += item1.Price;
        //                    }
        //                    switch (idPay)
        //                        {
        //                            case (int)Payment.Cash:
        //                            if (customer.CashBalance > sum)
        //                            {
        //                                customer.CashBalance -= sum;
        //                                Console.WriteLine("Alis veris ugurla bas verdi: Qalig nagd pulunuz " + customer.CashBalance);
        //                                break;
        //                            }
        //                            else
        //                            {
        //                            halfPay:
        //                                Console.WriteLine("Nagd pulunuz catmir yarisini kart yarisini nag etmek isteyirsiniz beli-1, xeyr-2");
        //                                string inputHalfPay = Console.ReadLine();
        //                                bool checkInputHalfPay = int.TryParse(inputHalfPay, out int idHalfPay);
        //                                if (!checkInputHalfPay) goto halfPay;
        //                                switch (idHalfPay)
        //                                {
        //                                    case 1:
        //                                        double rest = 0;
        //                                        rest = sum - customer.CashBalance;
        //                                        customer.CashBalance = 0;
        //                                        customer.CardBalance -= rest;
        //                                        Console.WriteLine("Alis veris ugurla bas verdi: Qaliq nagd ve card balansiniz " + customer.CashBalance + " " + customer.CardBalance);
        //                                        break;
        //                                    case 2:
        //                                        Console.WriteLine("Alis veris bitdi");
        //                                        break;
        //                                }
        //                            }
        //                            break;
        //                        case (int)Payment.CreditCard:
        //                            if (customer.CardBalance > sum)
        //                            {
        //                                customer.CardBalance -= sum;
        //                                Console.WriteLine("Alis veris ugurla bas verdi: Qalig card pulunuz " + customer.CardBalance);
        //                                break;
        //                            }
        //                            else
        //                            {
        //                            halfPay:
        //                                Console.WriteLine("Card pulunuz catmir yarisini nagd yarisini kart etmek isteyirsiniz beli-1, xeyr-2");
        //                                string inputHalfPay = Console.ReadLine();
        //                                bool checkInputHalfPay = int.TryParse(inputHalfPay, out int idHalfPay);
        //                                if (!checkInputHalfPay) goto halfPay;
        //                                switch (idHalfPay)
        //                                {
        //                                    case 1:
        //                                        double rest;
        //                                        rest = sum - customer.CardBalance;
        //                                        customer.CardBalance = 0;
        //                                        customer.CashBalance -= rest;
        //                                        Console.WriteLine("Alis veris ugurla bas verdi: Qaliq nagd ve card balansiniz " + customer.CashBalance + " " + customer.CardBalance);
        //                                        break;
        //                                    case 2:
        //                                        Console.WriteLine("Alis veris bitdi");
        //                                        break;
        //                                }
        //                            }
        //                            break;   
        //                        }
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Mehsul Marketde bitib stoku yoxlayaq");
        //                    if (item.InStockCount > 0)
        //                    {
        //                    pay:

        //                        Console.WriteLine("Nagd alis veris edirsizse 1, kartla edirsize 2 yazin");
        //                        string inputPay = Console.ReadLine();
        //                        bool checkInputPay = int.TryParse(inputPay, out int idPay);
        //                        if (!checkInputPay) goto pay;
        //                        double sum = 0;
        //                        foreach (var item1 in products)
        //                        {
        //                            sum += item1.Price;
        //                        }
        //                        switch (idPay)
        //                        {
        //                            case (int)Payment.Cash:
        //                                if (customer.CashBalance > sum)
        //                                {
        //                                    customer.CashBalance -= sum;
        //                                    Console.WriteLine("Alis veris ugurla bas verdi: Qalig nagd pulunuz " + customer.CashBalance);
        //                                    break;
        //                                }
        //                                else
        //                                {
        //                                halfPay:
        //                                    Console.WriteLine("Nagd pulunuz catmir yarisini kart yarisini nag etmek isteyirsiniz beli-1, xeyr-2");
        //                                    string inputHalfPay = Console.ReadLine();
        //                                    bool checkInputHalfPay = int.TryParse(inputHalfPay, out int idHalfPay);
        //                                    if (!checkInputHalfPay) goto halfPay;
        //                                    switch (idHalfPay)
        //                                    {
        //                                        case 1:
        //                                            double rest;
        //                                            rest = sum - customer.CashBalance;
        //                                            customer.CashBalance = 0;
        //                                            customer.CardBalance -= rest;
        //                                            break;
        //                                        case 2:
        //                                            break;
        //                                    }
        //                                }
        //                                break;
        //                            case (int)Payment.CreditCard:
        //                                if (customer.CardBalance > sum)
        //                                {
        //                                    customer.CardBalance -= sum;
        //                                    Console.WriteLine("Alis veris ugurla bas verdi: Qalig card pulunuz " + customer.CardBalance);
        //                                    break;
        //                                }
        //                                else
        //                                {
        //                                halfPay:
        //                                    Console.WriteLine("Card pulunuz catmir yarisini nagd yarisini kart etmek isteyirsiniz beli-1, xeyr-2");
        //                                    string inputHalfPay = Console.ReadLine();
        //                                    bool checkInputHalfPay = int.TryParse(inputHalfPay, out int idHalfPay);
        //                                    if (!checkInputHalfPay) goto halfPay;
        //                                    switch (idHalfPay)
        //                                    {
        //                                        case 1:
        //                                            double rest;
        //                                            rest = sum - customer.CardBalance;
        //                                            customer.CardBalance = 0;
        //                                            customer.CashBalance -= rest;
        //                                            Console.WriteLine("Alis veris ugurla bas verdi: Qaliq nagd ve card balansiniz " + customer.CashBalance + " " + customer.CardBalance);
        //                                            break;
        //                                        case 2:
        //                                            Console.WriteLine("Alis veris bitdi");
        //                                            break;
        //                                    }
        //                                }
        //                                break;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Mehsul stokda bitib yeni mehsul elave edin zehmet olmasa");
        //                        break;
        //                    }
        //                }

        //            }
        //            break;
        //            case 2:
        //            Console.WriteLine("Alis-verisiniz bitdi");
        //            break;
        //    }


        //}


        //public void Shop(Product[] products, Customer customer)
        //{
        //head:
        //    Console.WriteLine("Alis veris edirsizse 1 ve  imtina etmek isteyirsize 2 yazin");
        //    string input = Console.ReadLine();
        //    bool checkInput = int.TryParse(input, out int id);
        //    if (!checkInput) goto head;
        //    switch (id)
        //    {
        //        case 1:
        //            break;
        //        case 2:
        //            Console.WriteLine("Alis-verisiniz bitmisdir");
        //            break;
        //    }








        //}
    }
}



