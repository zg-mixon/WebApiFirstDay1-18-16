using BindingToComplexObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BindingToComplexObject.Controllers
{
    public class CustomersController : ApiController
    {
        public static IList<Customer> _customers = new List<Customer>() {
            new Customer() {
                
            }
        };
        public Customer Get(int id) {
            return _customers.First(x => x.Id == id);
        }

        public IHttpActionResult Post(Customer customer) {
            _customers.Add(customer);
            return Ok();
        }
    }
}
