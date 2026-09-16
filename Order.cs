using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsAssignment
{
    internal class Order
    {
        //filds 

        public int OrderId;
        public string CustomerName;
        public int Quantity;
        public decimal UnitPrice;
        public decimal TotalPrice;
        public bool IsPaid;
        public double DiscountPercent;
        public string ShippingCity;
        public char Priority;
        public long ItemCode;
        private int userID;

        public Order(int orderId, string customerName, int quantity, decimal unitPrice, decimal totalPrice, bool isPaid, double discountPercent, string shippingCity, char priority, long itemCode,int userId)
        {
            OrderId = orderId;
            CustomerName = customerName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
            IsPaid = isPaid;
            DiscountPercent = discountPercent;
            ShippingCity = shippingCity;
            Priority = priority;
            ItemCode = itemCode;
            userID = userId;
        }

         //methods 
         //here if i want to acccess userid 
         //as propery in class scope block menaly 
         //so if you want to acccess it through class you can easly but in private value you might to define method to access it
         public int  getUserID()
        {
            return this.userID;
        }
        public decimal CalculateTotal()
        {
           this.TotalPrice = this.Quantity * this.UnitPrice * (1 - ((decimal)this.DiscountPercent / 100));
            return this.TotalPrice;
        }
        public void PrintSummary()
        {
            Console.WriteLine("=========== summmary of your order ===========");
            Console.WriteLine($"1- OrderId {this.OrderId}");
            Console.WriteLine($"2- CustomerName {this.CustomerName}");
            Console.WriteLine($"3- TotalPrice {this.CalculateTotal()}");
            Console.WriteLine($"4- IsPaid {this.IsPaid}");
            Console.WriteLine($"5- userId {this.userID}");
        }
    }
}


