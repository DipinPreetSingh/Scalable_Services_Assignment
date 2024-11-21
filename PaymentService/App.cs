using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using payment_service.config;
using payment_service.services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("PaymentDB"));
builder.Services.AddControllers();


var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
