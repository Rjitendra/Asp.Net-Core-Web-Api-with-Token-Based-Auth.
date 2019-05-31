

namespace API.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Service.Interface;
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;
        private IRepositoryWrapper _repoWrapper;

        public ValuesController(ILogger<ValuesController> logger,
            IRepositoryWrapper repoWrapper)
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            this._logger.LogInformation("Heloo jitendra.Your method call start now");
            var domesticAccounts = _repoWrapper.Account.FindByCondition(x => x.AccountType.Equals("Domestic"));
            var owners = _repoWrapper.Owner.FindAll();

            return new string[] { "value1", "value2" };
        }

        [HttpPost("GetAllOwners")]
        public IActionResult GetAllOwners()
        {
            try
            {

                this._logger.LogInformation("Heloo jitendra.Your method GetAllOwners call start now");
                var owners = _repoWrapper.Owner.GetAllOwners();


                return Ok(owners);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllOwners action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
