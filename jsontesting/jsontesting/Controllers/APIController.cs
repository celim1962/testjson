using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
namespace jsontesting.Controllers
{
   
    public class APIController : ApiController
    {
        final_pEntities p_db = new final_pEntities();
        // GET: api/API
        [EnableCors("*", "*", "*")]

        public JObject Get()
        {
            var ans = new
            {
                product = from f in p_db.pProductdb
                              select new
                              {
                                  fname = f.Product_name,
                                  fprice = f.Product_Price
                              }
                
        };
            string strjson = JsonConvert.SerializeObject(ans, Formatting.Indented);
            JObject o = JObject.Parse(strjson);
            return o;
        }
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/API/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/API
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/API/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/API/5
        public void Delete(int id)
        {
        }
    }
}
