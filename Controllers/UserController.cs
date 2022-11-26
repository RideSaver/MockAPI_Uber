using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UberAPI.Model;

namespace UberAPI.Controllers
{
    [ApiController]
    public class UserController
    {
        [HttpGet]
        [Route("/uber/api/user/me")]
        public Task<IActionResult> GetUser([FromQuery]string userId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/uber/api/user/history")]
        public Task<IActionResult> GetUserHistory([FromQuery(Name = "offset")][Required]int offset, [FromQuery(Name = "limit")][Required]int limit)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/uber/api/user/payment")]
        public Task<IActionResult> GetUserPayment([FromQuery(Name = "startLocation")][Required()]Location startLocation, [FromQuery(Name = "endLocation")][Required()]Location endLocation)
        {
            throw new NotImplementedException();
        }

    }
}
