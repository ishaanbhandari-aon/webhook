﻿using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Receiver.Receiver
{
    public class TestHandler : WebHookHandler
    {
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            return Task.FromResult(true);
        }
    }
}