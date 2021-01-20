using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireWebAPIv2.Helpers
{
    public class EmailHelperDb
    {
        private readonly DbContext _context;

        public EmailHelperDb(DbContext context)
        {
            _context = context;
        }

        public bool SendEmail(string email)
        {
            var username = _context.GetUserName(email);

            return true;
        }
    }
}
