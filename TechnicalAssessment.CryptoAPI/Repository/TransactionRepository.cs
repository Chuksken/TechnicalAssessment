using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAssessment.Shared.Entities;
using TechnicalAssessment.Users;

namespace TechnicalAssessment.CryptoAPI.Repository
{
    public class TransactionRepository : ITransaction
    {
        private readonly ApplicationDbContext _dbContext;

        public TransactionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteTransaction(int transactionsId)
        {
            var transaction = _dbContext.Crypto_Transactions.Find(transactionsId);
            _dbContext.Crypto_Transactions.Remove(transaction);
            Save();
        }

        public IEnumerable<Crypto_Transactions> GetUpdatedTransaction(int clientid, string wallentAddress)
        {
            return _dbContext.Crypto_Transactions.Where(x =>x.ClientID == clientid && x.WallentAddress == wallentAddress);
        }

        public IEnumerable<Crypto_Transactions> GetTransactions()
        {
            return _dbContext.Crypto_Transactions.ToList();
        }

        public void InsertTransaction(Crypto_Transactions transaction)
        {
            _dbContext.Add(transaction);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateTransaction(Crypto_Transactions transaction)
        {
            _dbContext.Entry(transaction).State = EntityState.Modified;
            Save();
        }
    }
}
