using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy;

namespace HelloMicroservices.Modules
{
    public class CurrentDateTimeModule : NancyModule
    {
        public CurrentDateTimeModule()
        {
            Get("/", _=> DateTime.UtcNow);
        }
    }
}
