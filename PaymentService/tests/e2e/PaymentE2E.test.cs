using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

public class PaymentE2ETests
{
    private readonly HttpClient _client;

    public PaymentE2ETests()
    {
        
        _client = new HttpClient { BaseAddress = new Uri("http://localhost:5000") };
    }

    [Fact]
    public async Task ProcessPayment_E2ETest()
    {
     
        var paymentRequest = new
        {
            UserId = Guid.NewGuid(),
            Amount = 150,
            Currency = "USD"
        };
        var content = new StringContent(JsonSerializer.Serialize(paymentRequest), Encoding.UTF8, "application/json");

      
        var response = await _client.PostAsync("/api/payments/process", content);

        
        response.EnsureSuccessStatusCode(); 
        var responseContent = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<PaymentModel>(responseContent);

        Assert.NotNull(result);
        Assert.Equal("USD", result.Currency);
        Assert.Equal(150, result.Amount);
        Assert.Equal("Completed", result.Status);
    }
}
