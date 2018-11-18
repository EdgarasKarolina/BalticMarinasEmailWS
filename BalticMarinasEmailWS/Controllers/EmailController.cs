using Microsoft.AspNetCore.Mvc;

namespace BalticMarinasEmailWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        // GET api/event/5
        [HttpGet("{id}")]
        public void Send(int id)
        {
            //EventsContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasEventsWS.Models.EventsContext)) as EventsContext;
            //context.DeleteEventById(id);
        }
    }
}