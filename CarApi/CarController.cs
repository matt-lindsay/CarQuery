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

    /*
     * RESTful APIs
     * REST - REpresentational State Transfer
     * 
     * Client server communications that are stateless.
     * Resouce based vs. traditional procedure call approach.
     * Uses HTTP methods.
     * 
     * HATEOAS - HypermediaEngineOfApplicationState
     * Return information as to what can be done with high level datasets.
     * 
     * http://www.odata.org/ - Open Data standard end points.
     */

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
