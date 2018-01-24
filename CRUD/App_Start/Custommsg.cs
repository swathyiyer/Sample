using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace CRUD.App_Start
{
    public class Custommsg : IHttpActionResult
    {

        string _value;
        HttpRequestMessage _req;
        HttpStatusCode _code;
        public Custommsg(string value, HttpRequestMessage req, HttpStatusCode code)
        {
            _value = value;
            _req = req;
            _code = code;
        }
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            var response = new HttpResponseMessage()
            {
                Content = new StringContent(_value),
                RequestMessage = _req,
                StatusCode = _code

            };
            return Task.FromResult(response);
        }
    }
}