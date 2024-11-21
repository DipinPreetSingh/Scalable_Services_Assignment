using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using payment_service.config;
using payment_service.controllers;
using payment_service.models;
using payment_service.services;

public class PaymentIntegrationTests
{
    [Fact]
    public async Task ProcessPayment_IntegrationTest()
    {
       
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "IntegrationTestDb")
            .Options;

        using (var context = new AppDbContext(options))
        {
         
            context.Payments.Add(new PaymentModel
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Amount = 50,
                Currency = "USD",
                Status = "Completed",
                CreatedAt = DateTime.UtcNow
            });
            context.SaveChanges();

            
            var paymentService = new PaymentService();
            var controller = new PaymentController(paymentService);

           
            var paymentRequest = new PaymentRequest
            {
                UserId = Guid.NewGuid(),
                Amount = 100,
                Currency = "USD"
            };

        
            var result = await controller.ProcessPayment(paymentRequest) as OkObjectResult;

            
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }
    }
}
