using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_DanielGuinto.Controllers
{
    public class GreetingController : ApiController
    {

        //Question 3
        //POST api/Greeting
        //Return value viewable throuh terminal
        public string Post()
        {
            return "Hello World!";
        }


        //Question 4
        //GET api/Greeting/{id}
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
