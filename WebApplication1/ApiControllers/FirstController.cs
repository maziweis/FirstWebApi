using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.ApiControllers
{
    public class FirstController : ApiController
    {
        [HttpGet]
        public int getFirst(int id)
        {
            return id;
        }
        [HttpPost]
        public string PostFirst(string name,string sex)
        {
            return "姓名："+name+" 性别：" + sex;
        }
    }
}
