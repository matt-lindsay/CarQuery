using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarApi
{
    public class Car
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
 
    public class CarController : ApiController
    {
        public IEnumerable<Car> Get()
        {
            return new List<Car>
            {
                new Car { ID = 0, Make = "Ford", Model = "Kuga" },
                new Car { ID = 1, Make = "BMW", Model = "325i" },
                new Car { ID = 2, Make = "Audi", Model = "A6" }
            };
        }
    }
}
