using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalAssessment.Shared.Entities;
using TechnicalAssessment.Shared.Models;
using TechnicalAssessment.Users;

namespace TechnicalAssessment.Users.Services
{
   public class SaveTransactionsService : ISaveTransactionsService
    {
        private readonly ApplicationDbContext db;

        public SaveTransactionsService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }


        public string AddTransactions(List<TransactionModel>TransferRequest)
        {

            try
            {

                foreach (var item in TransferRequest)
                {
                    var collection = new Transactions()
                    {
                        WallentAddress = item.WallentAddress,
                        ClientID = item.ClientID,
                        CurrencyType = item.CurrencyType,
                        Amount = item.Amount,
                        //Id = item.Id,
                        TransactionID = item.TransactionID,
                        TrDate = item.TrDate
                    };

                    db.Transactions.Add(collection);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //LogHelper.Info($"Error from Internal Transfer transaction: {ex} : {JsonConvert.SerializeObject(ex)}");

                //LogHelper.Debug(ex.StackTrace, DateTime.Now);
                if (ex.InnerException != null)
                {
                    //LogHelper.Debug(ex.InnerException.StackTrace, DateTime.Now);
                }
                throw ex;
            }

            return("Successfully Updated Transactions");
        }

        //public string AddTransactions(TransactionModel _request)
        //{
        //    throw new NotImplementedException();
        //}
    }
    
}
