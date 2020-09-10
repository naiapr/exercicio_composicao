using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Composicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public void SubTotal (int quantity, double price)
        {
            double st;
            st = quantity * price;
        }
    }
}
