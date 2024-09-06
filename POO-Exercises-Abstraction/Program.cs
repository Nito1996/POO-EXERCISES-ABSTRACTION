using System.Collections.Generic;
using POO_Exercises_Abstraction.BL.Abstractions;
using POO_Exercises_Abstraction.BL.Services;
using POO_Exercises_Abstraction.DA.Abstractions;

namespace POO_Exercises_Abstraction
{
    internal class Program
    {
        static void Main()
        {
            var paymentList = new PaymentService().GetPaymentList();

            paymentList.AddRange(new List<PaymentMethod>
            {
                new BankTransfer(434356678907),
                new CreditCard(123456789),
                new Paypal("Randy-1996@live.com")
            });

            foreach (var payment in paymentList)
            {
                payment.ProcessPayment(100.00);
            }
        }
    }
}
