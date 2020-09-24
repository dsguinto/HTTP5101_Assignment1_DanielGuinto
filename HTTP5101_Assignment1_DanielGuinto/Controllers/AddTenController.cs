using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_DanielGuinto.Controllers
{
    public class AddTenController : ApiController
    {

        //Question 1
        //GET api/AddTen/{id}
        public int Get(int id)
        {
            return id + 10;
        }

    }
}
