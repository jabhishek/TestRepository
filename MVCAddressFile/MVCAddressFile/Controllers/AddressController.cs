using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AddressRepository;

namespace MVCAddressFile.Controllers
{
    public class AddressController : ApiController
    {
        // GET api/address
        [ActionName("SearchByName")]
        public IEnumerable<Address> Get(string search)
        {
            return AddresFileHelper.GetAddresses(search);
        }

        // GET api/address/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/address
        public void Post([FromBody]string value)
        {
        }

        // PUT api/address/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/address/5
        public void Delete(int id)
        {
        }
    }
}
