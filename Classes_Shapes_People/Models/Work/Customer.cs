using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Shapes_People.Models.Work
{// Customer = Child, Person = Parent
    public class Customer : Person
    {
        string[] purchaseHistory;
        string DeliveryAdress { get; set; }
        public Customer(
            string name, string phone, 
            string adress, string deliveryAress
            ) : base(name, phone, adress)
        {
            this.DeliveryAdress = deliveryAress;
            this.purchaseHistory = new string[0];
        }

        public new string Info()
        {
            return base.Info() + $"\nDelivery Aress: {DeliveryAdress}";
        }
    }
}
