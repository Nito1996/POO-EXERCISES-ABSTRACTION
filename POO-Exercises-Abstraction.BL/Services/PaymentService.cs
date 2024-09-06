using System.Collections.Generic;
using POO_Exercises_Abstraction.DA.Abstractions;

namespace POO_Exercises_Abstraction.BL.Services
{
    public class PaymentService
    {
        public List<PaymentMethod> GetPaymentList()
        {
            return Data.paymentsList;
        }
    }
}
