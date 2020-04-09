﻿using ObslugaTPay.Models;
using System.Threading.Tasks;

namespace ObslugaTPay.Api
{
    public interface ITransactionsApi
    {
        Task<BlikResponse> BlikPayment(Blik data);
        Task<ChargebackResponse> Chargeback(Chargeback data);
        Task<ChargebackResponse> ChargebackAny(ChargebackAny data);
        Task<CreateResponse> Create(Create data);
        Task<GetResponse> Get(Get data);
        Task<RefundTransactionRespose> GetChargebackStatus(RefundTransaction data);
    }
}