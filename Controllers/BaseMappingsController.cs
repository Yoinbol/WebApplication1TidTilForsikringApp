using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1TidTilForsikringApp.Models;
using WebApplication1TidTilForsikringApp.Services;

namespace WebApplication1TidTilForsikringApp.Controllers
{
    [AllowAnonymous]
    public class BaseMappingsController : ApiController
    {
        [HttpGet]
        public Outputs Get(bool a, bool b, bool c, int d, int e, int f)
        {
            return new BaseMappingsService().ResolveOutputs(a, b, c, d, e, f);
        }
    }
}
