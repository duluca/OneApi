namespace OneApi.Controllers
{
    using System.Net;
    using System.Net.Http;
    using System.Collections.Generic;
    using System.Web.Http;

    [Authorize]
    [RoutePrefix("reservation")]
    public class ReservationController : ApiController
    {
        [HttpGet, Route("")]
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        [HttpGet, Route("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost, Route("")]
        public HttpResponseMessage Post([FromBody]string value)
        {
            return Request.CreateResponse(HttpStatusCode.Created, value);
        }

        [HttpPut, Route("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete, Route("{id}")]
        public void Delete(int id)
        {
        }
    }
}