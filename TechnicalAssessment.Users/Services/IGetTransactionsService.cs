using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAssessment.Shared.Models;

namespace TechnicalAssessment.Users.Services
{
   public interface IGetTransactionsService
    {
      Task< List<TransactionModel>> GetTransactions(RequestData _request);
    }
}
