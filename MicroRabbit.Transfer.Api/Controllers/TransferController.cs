using MicroRabbit.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : Controller
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        //GET api/transfer
        [HttpGet]
        public IActionResult Get()
        {
            var logs = _transferService.GetTransferLogs();
            return Ok(logs);
        }
    }
}
