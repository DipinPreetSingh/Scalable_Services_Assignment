using Xunit;
using payment_service.services;

public class PaymentServiceTests
{
    [Fact]
    public async Task ProcessPayment_ReturnsValidResponse()
    {
        var service = new PaymentService();
        var result = await service.ProcessPayment(new PaymentRequest
        {
            UserId = Guid.NewGuid(),
            Amount = 100,
            Currency = "USD"
        });

        Assert.NotNull(result);
        Assert.Equal("USD", result.Currency);
    }
}
