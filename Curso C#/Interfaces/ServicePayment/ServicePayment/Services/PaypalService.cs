using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePayment.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private double FeePercentage = 0.02;
        private double MonthlyInterest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}
