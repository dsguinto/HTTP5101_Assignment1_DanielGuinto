﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_DanielGuinto.Controllers
{
    public class SquareController : ApiController
    {

        //Question 2
        //GET api/Square/{id}
        public int Get(int id)
        {
            return id * id;
        }

    }
}
