using System;
using POO_Exercises_Abstraction.DA.Abstractions;

namespace POO_Exercises_Abstraction.BL.Abstractions
{
    public class CreditCard : PaymentMethod
    {
        public double CreditCardNumber { get; set; }

        public CreditCard(double creditCardNumber)
        {
            CreditCardNumber = creditCardNumber;
        }

        public override void ProcessPayment(double mount)
        {
            Console.WriteLine($"Proccessing Payment of {mount} on this CreditCardNumber: {CreditCardNumber}");
        }

    }
}
