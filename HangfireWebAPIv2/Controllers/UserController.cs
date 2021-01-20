using Hangfire;
using HangfireWebAPIv2.Helpers;
using HangfireWebAPIv2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireWebAPIv2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(UserViewModel viewModel)
        {
            DbContext db = new DbContext();
            db.AddUser(viewModel.UserName, viewModel.Email, viewModel.Password);

            BackgroundJob.Enqueue<EmailHelper>(x => x.SendEmail(viewModel.Email));
            return Ok();
        }
    }
}
