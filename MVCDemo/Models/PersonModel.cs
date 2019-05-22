using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class PersonModel
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; } = 0;
        public bool IsAlive { get; set; } = true; 
    }
}