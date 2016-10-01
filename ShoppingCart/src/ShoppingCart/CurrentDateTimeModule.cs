using System;
using Nancy;

namespace ShoppingCart
{
    public class CurrentDateTimeModule:NancyModule
    {
        public CurrentDateTimeModule():base("/datetime")
        {
            Get("/", _ =>DateTime.UtcNow);
        }
    }
}