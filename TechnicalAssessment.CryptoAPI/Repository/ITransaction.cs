using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAssessment.Shared.Entities;

namespace TechnicalAssessment.CryptoAPI.Repository
{
   public interface ITransaction
    {

        IEnumerable<Crypto_Transactions> GetTransactions();
        IEnumerable<Crypto_Transactions> GetUpdatedTransaction(int transactionId, string wallentaddress);
        void InsertTransaction(Crypto_Transactions transaction);
        void DeleteTransaction(int transactionsId);
        void UpdateTransaction(Crypto_Transactions transaction);
        void Save();
    }
}
