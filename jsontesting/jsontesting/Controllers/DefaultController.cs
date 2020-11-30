using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jsontesting.Controllers
{
    public class DefaultController : ApiController
    {
        final_pEntities p_db = new final_pEntities();
        // GET: api/Default
        //public IEnumerable<string> Get()
        public JObject Get()
        {
            var ans = new
            {
                fname = from f in p_db.pProductdb
                        select f.Product_name
            };

            string strjson = JsonConvert.SerializeObject(ans, Formatting.Indented);
            JObject o = JObject.Parse(strjson);
            return o;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
