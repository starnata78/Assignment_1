using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{/* objective: crate a method which recieves an integer and applies four mathematical operations to it.
 * <summary>
 * This code revieves an int and adds 5, substracts 2, multiply by 2 and divide by 2.
 * <param name -"id"> the input number</param>
 * </summary>
 * <example>
 * Get api/NumberMachine/10 -> 13
 * </example>
 */
 // GET api/NumberMachine
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            return id + 5 - 2 * 2 / 2;
        }

    }

}
