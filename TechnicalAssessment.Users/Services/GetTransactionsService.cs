using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalAssessment.Shared.Models;

namespace TechnicalAssessment.Users.Services
{
    public class GetTransactionsService : IGetTransactionsService
    {

        public async Task<List<TransactionModel>> GetTransactions(RequestData TransferRequest)
        {
            List<TransactionModel> result = null;

            try
            {


                var baseurl = "https://localhost:44337/api/CryptoAPI/";

                var client = new RestClient($"{baseurl}getupdatedtransactions?clientId={TransferRequest.ClientID}&wallentAddress={TransferRequest.WallentAddress}");
                //client.Timeout = _config.Timeout * 60000;
                var request = new RestRequest();
                request.Parameters.Clear();

                request.AddHeader("Access-Control-Allow-Origin", "*");
                //request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Content-Type", "application/json; charset=utf-8");
                request.Method = Method.GET;

                var response = await Task.FromResult(client.Get(request));
                var content = response.Content;
                //loggerHeper.Info(content);
                result = JsonConvert.DeserializeObject<List<TransactionModel>>(content);
                return result;

            }
            catch (Exception ex)
            {
                //loggerHeper.Debug(ex.StackTrace, DateTime.Now);
                if (ex.InnerException != null)
                {
                    //loggerHeper.Debug(ex.InnerException.StackTrace, DateTime.Now);
                }
                throw;
            }
        }

        //List<TransactionModel> IGetTransactionsService.GetTransactions(RequestData _request)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
