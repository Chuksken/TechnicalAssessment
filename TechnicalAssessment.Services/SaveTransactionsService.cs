using System;
using System.Collections.Generic;
using System.Text;
using TechnicalAssessment.Users;

namespace TechnicalAssessment.Services
{
   public class SaveTransactionsService
    {
        private readonly ApplicationDbContext db;

        public SaveTransactionsService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }


    }
}
