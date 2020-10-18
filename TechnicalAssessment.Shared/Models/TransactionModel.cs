using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalAssessment.Shared.Models
{
   public class TransactionModel
    {
        //public int Id { get; set; }

        public string TransactionID { get; set; }
        public int ClientID { get; set; }
        public DateTime TrDate { get; set; }
        public string WallentAddress { get; set; }

        public string CurrencyType { get; set; }

        public decimal Amount { get; set; }
    }
}
