using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodingChallengeApiTemplate.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserAccountController : ControllerBase
    {
        private readonly ILogger<UserAccountController> _logger;

        public UserAccountController(ILogger<UserAccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void Create(UserAccount user)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public void Update(UserAccount user)
        {
            throw new NotImplementedException();
        }
    }
}
