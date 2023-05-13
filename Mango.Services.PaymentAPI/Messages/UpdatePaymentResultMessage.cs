using Mango.MessageBus;

namespace Mango.Services.PaymentAPI.Messages
{
    public class UpdatePaymentResultMessage : BaseMassage
    {
        public int OrderId { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
