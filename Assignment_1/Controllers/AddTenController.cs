using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
        public class AddTenController : ApiController
    {/*objective: create a method which recieves a value and adds a certain value;
      <summary> This code recieves a value and adds ten.
        <param name-"id">the input number</param>
        <returns>the number plus 10</returns>
        </summary>
        <example> 
        Get api/AddTen/21 -> 31
        </example>
        */
        // GET api/AddTen/
        public int Get(int id)
        {
            return id+10;
        }
    }
    
}
