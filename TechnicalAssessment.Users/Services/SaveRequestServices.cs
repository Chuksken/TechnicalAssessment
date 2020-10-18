using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalAssessment.Shared.Entities;
using TechnicalAssessment.Shared.Models;

namespace TechnicalAssessment.Users.Services
{
   public class SaveRequestServices : ISaveRequestServices
    {
        private readonly ApplicationDbContext db;

        public SaveRequestServices(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }
        public string AddRequest(RequestData TransferRequest)
        {
            try
            {
                var collection = new Log_Request()
                {
                    WallentAddress = TransferRequest.WallentAddress,
                    ClientID = TransferRequest.ClientID,
                    CurrencyType = TransferRequest.CurrencyType
                };

                db.Log_Requests.Add(collection);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                //LogHelper.Info($"Error from Internal Transfer transaction: {ex} : {JsonConvert.SerializeObject(ex)}");

                //LogHelper.Debug(ex.StackTrace, DateTime.Now);
                if (ex.InnerException != null)
                {
                    //LogHelper.Debug(ex.InnerException.StackTrace, DateTime.Now);
                }
                throw ex;
            }

            return ("Successful");
        }

    }
}
