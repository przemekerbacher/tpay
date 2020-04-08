using ObslugaTPay.Models;
using System.Threading.Tasks;

namespace ObslugaTPay.Api
{
    public interface ITPayApiAccess
    {
        Task<BlikResponse> BlikPayment(Blik data);
        Task<ChargebackResponse> Chargeback(Chargeback data);
        Task<ChargebackResponse> ChargebackAny(Chargeback data);
        Task<CreateResponse> Create(Create data);
        Task<GetResponse> Get(Get data);
        Task<RefundTransactionRespose> GetChargebackStatus(RefundTransaction data);
    }
}