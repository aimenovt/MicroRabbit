using MicroRabbit.Banking.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : Controller
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        //GET api/banking
        [HttpGet]
        public IActionResult Index()
        {
            var accounts = _accountService.GetAccounts();
            return Ok(accounts);
        }
    }
}
