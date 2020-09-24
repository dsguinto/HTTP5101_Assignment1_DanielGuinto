using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_DanielGuinto.Controllers
{
    public class HostingCostController : ApiController
    {

        public IEnumerable<string> Get(double id)
        {
            //Bonus Question

            //Sets variable for fortnights
            double fn = 1;

            //Sets conditions to check how many fortnights have passed (only up until 28 days, not sure how to do it for an infinite range!)
            if (id < 14) 
            {
                fn = fn;
            }
            
            else if (id >= 14 & id < 28)
            {
                fn = fn + 1;
            }
            
            else
            {
                fn = fn + 2;
            }

            //Sets variables for charges, hst, and total cost
            //Also rounds values to nearst 2 decimal places and displays 2 decimal places at all times (even if number is a whole number)
            double charge = Math.Round(fn * 5.50, 2);
            string rcharge = charge.ToString("N2");


            double hst = Math.Round(charge * 0.13, 2);
            string rhst = hst.ToString("N2");

            double total = Math.Round(charge + hst, 2);
            string rtotal = total.ToString("N2");

            //Outputs 3 strings describing costs
            return new string[] 
            {
                (fn-1) + " fornights at $5.50/FN = $" + rcharge + " CAD", 
                "HST 13% = $" + rhst + " CAD", 
                "Total = $" + rtotal + " CAD"
            };
        }
    }
}
