using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary2;
namespace WebApplication1.ApiControllers
{
    public class FirstController : ApiController
    {
        [HttpGet]
        public int getFirst(int id)
        {
            Class1 class1 = new Class1();
            return class1.FirstSql();
        }
        [HttpPost]
        public string PostFirst(string name,string sex)
        {
            return "姓名："+name+" 性别：" + sex;
        }
    }
}
