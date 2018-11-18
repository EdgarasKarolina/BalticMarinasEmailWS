using BalticMarinasEmailWS.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BalticMarinasEmailWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        // GET api/email/
        [HttpGet("{emailBody}/{receiver}")]
        public void Send(string emailBody, string receiver)
        {
            Email.sendEmail(emailBody, receiver);
        }
    }
}