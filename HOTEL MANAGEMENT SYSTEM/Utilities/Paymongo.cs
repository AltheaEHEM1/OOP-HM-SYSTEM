using Paymongo.Sharp;
using System;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public class PaymentProcessor
    {
        private PayMongoClient payMongoClient;

        public PaymentProcessor(string secretKey)
        {
            payMongoClient = new PayMongoClient(secretKey);
        }

        public async Task<string> CreatePaymentIntent(decimal amount, string currency, string paymentMethod)
        {
            try
            {
                var paymentIntent = await payMongoClient.PaymentIntents.CreateAsync(amount, currency, paymentMethod);
                return paymentIntent.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating payment intent: " + ex.Message);
                return null;
            }
        }
    }
}   