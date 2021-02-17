using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
/* objective: crate a method which revieve an int and adds a value to it.
 * <summary>
 * This code revieves an int and adds 10 to it.
 * <param name -"id"> the input number</param>
 * </summary>
 * <example>
 * Get api/AddTen/21 -> 31
 * </example>
 */
// // GET api/AddTen
{
    public class AddTenController : ApiController
    {
        public int Get(int id)
        {
            return id+10;
        }
    }
}
