using System;
using POO_Exercises_Abstraction.DA.Abstractions;

namespace POO_Exercises_Abstraction.BL.Abstractions
{
    public class BankTransfer : PaymentMethod
    {
        public double AccountNumber { get; set; }
        public BankTransfer(double accountNumber)
        {
            AccountNumber = accountNumber;
        }
        public override void ProcessPayment(double mount)
        {
            Console.WriteLine($"Proccessing Payment of {mount} on this BankAccount: {AccountNumber}");
        }
    }
}
