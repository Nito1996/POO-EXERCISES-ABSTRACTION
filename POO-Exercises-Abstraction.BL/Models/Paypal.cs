using System;
using POO_Exercises_Abstraction.DA.Abstractions;

namespace POO_Exercises_Abstraction.BL.Abstractions
{
    public class Paypal : PaymentMethod
    {
        public string Email { get; set; }
        public Paypal(string email)
        {
            Email = email;
        }
        public override void ProcessPayment(double mount)
        {
            Console.WriteLine($"Proccessing Payment of {mount} on Paypal from the account: {Email}");
        }
    }
}
