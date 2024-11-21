namespace payment_service.routes
{
    public static class PaymentRoutes
    {
        public const string Base = "api/payments";
        public const string ProcessPayment = Base + "/process";
        public const string GetPaymentById = Base + "/{id}";
        public const string GetAllPayments = Base + "/all";
    }
}
