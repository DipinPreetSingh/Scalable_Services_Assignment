using payment_service.models;
using System.Threading.Tasks;

namespace payment_service.services
{
    public interface IPaymentService
    {
        Task<PaymentModel> ProcessPayment(PaymentRequest request);
    }

    public class PaymentService : IPaymentService
    {
        public async Task<PaymentModel> ProcessPayment(PaymentRequest request)
        {
            var payment = new PaymentModel
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                Amount = request.Amount,
                Currency = request.Currency,
                Status = "Completed",
                TransactionId = Guid.NewGuid().ToString(),
                CreatedAt = DateTime.UtcNow
            };

            await Task.Delay(500); 
            return payment;
        }
    }
}
