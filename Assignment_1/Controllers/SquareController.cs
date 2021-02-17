using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    /* objective: crate a method which revieve an return its square.
     * <summary>
     * This code revieves an int and returns the square of the number.
     * <param name -"id"> the input number</param>
     * </summary>
     * <example>
     * Get api/Square/-2 -> 4
     * </example>
     */

public class SquareController : ApiController
    {
        public int Get(int id)
        {
            return (id);
        }
    }
}