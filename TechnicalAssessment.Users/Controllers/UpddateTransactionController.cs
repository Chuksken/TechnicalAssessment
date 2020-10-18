using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalAssessment.Shared.Entities;
using TechnicalAssessment.Shared.Models;
using TechnicalAssessment.Users.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechnicalAssessment.Users.Controllers
{
    [Route("api/[controller]")]
    public class UpddateTransactionController : ControllerBase
    {
        private readonly IGetTransactionsService _gettransactions;
        private readonly ISaveRequestServices _saverequest;
        private readonly ISaveTransactionsService _savetransaction;
        public UpddateTransactionController(IGetTransactionsService gettransaction, ISaveRequestServices saverequest, ISaveTransactionsService savetransaction)
        {
            _gettransactions = gettransaction;
            _saverequest = saverequest;
            _savetransaction = savetransaction;
        }

        [HttpPost]
        [Route("updatetransaction")]
        public async Task<IActionResult> IntraBulkPayment(RequestData request)
        {
             List<TransactionModel> result = null;
            var respons = "";

            // Save the request data to the database
            try
            {
               
                var response = _saverequest.AddRequest(request);
                
                //return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            // get transaction from cryptoAPI
            try
            {
               
               
                
                result = await _gettransactions.GetTransactions(request);
               
            }
            catch (Exception ex)
            {
                throw ex;
            }



            // save transaction to database
            try
            {

               
              respons = _savetransaction.AddTransactions(result);

              

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return Ok(respons);
        }

     
    }
}


