using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    /* objective: crate a method which gets an int and returns a message of concatenated string and int.
     * <summary>
     * This code gets an intenger and returns a message.
     * </summary>
     * <example>
     * Post/api/Greeting/3 -> "Greetins to 3 people!"
     * </example>
     */
    // GET api/Greeting

    public class GreetingController : ApiController
    {
        public string Get(int id)
        {
            int amount = id;
            string message = "Greetings to " + amount.ToString() + " people!";
            return message;
        }

    }
}

