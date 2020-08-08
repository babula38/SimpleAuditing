using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleAuditing;
using SimpleAuditingApi;

namespace SimpleAuditingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get() => "Hello";

        [Auditing(field: "Name.ID")]
        [HttpPost]
        public void Post(MyClass name) { }
    }

    public class MyClass
    {
        public int ID { get; set; }
        public Inner MyProperty { get; set; }
    }
    public class Inner
    {
        public string MyInner { get; set; }
    }
}
