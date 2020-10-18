using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using TechnicalAssessment.CryptoAPI.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechnicalAssessment.CryptoAPI.Controllers
{
    [Route("api/[controller]")]
    public class CryptoAPIController : ControllerBase
    {

        private readonly ITransaction _crptoRepository;

        public CryptoAPIController(ITransaction cryptoRepository)
        {
            _crptoRepository = cryptoRepository;
        }
        // GET: api/<controller>
        [HttpGet]
        [Route("getalltransactions")]
        public IActionResult Get()
        {
            var products = _crptoRepository.GetTransactions();
            return Ok(products);
        }

        // GET api/ <controller>/5
        [HttpGet]
        [Route("getupdatedtransactions")]
        public IActionResult Get( int clientId, string wallentAddress)
        {
            var transactions = _crptoRepository.GetUpdatedTransaction( clientId, wallentAddress);
            return Ok(transactions);
        }

        //// POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
