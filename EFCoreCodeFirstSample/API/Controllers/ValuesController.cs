using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        private ILoggerManager _logger;
        private IRepositoryWrapper _repoWrapper;

        public ValuesController(ILoggerManager logger,
            IRepositoryWrapper repoWrapper
            )
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }
       // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is info message from our values controller.");
            _logger.LogDebug("Here is debug message from our values controller.");
            _logger.LogWarn("Here is warn message from our values controller.");
            _logger.LogError("Here is error message from our values controller.");
            var domesticAccounts = _repoWrapper.Account.FindByCondition(x => x.AccountType.Equals("Domestic"));
            var owners = _repoWrapper.Owner.FindAll();

            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public IActionResult GetAllOwners()
        {
            try
            {
                var owners = _repoWrapper.Owner.GetAllOwners();

                _logger.LogInfo($"Returned all owners from database.");

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
