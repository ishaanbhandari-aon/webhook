using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Receiver.Receiver
{
    [Authorize]
    public class NotifyApiController : ApiController
    {
        public async Task Post()
        {
            // Create an event with 'event2' and additional data
            await this.NotifyAsync("event2", new { P1 = "p1" });
        }
    }
}