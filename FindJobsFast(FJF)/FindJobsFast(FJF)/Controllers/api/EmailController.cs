using FindJobsFast_FJF_.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FindJobsFast_FJF_.Controllers.api
{
    [RoutePrefix("api/Email")]
    [Authorize(Roles ="ADMIN")]
    public class EmailController : ApiController
    {
        UserRepository repo;
        public EmailController()
        {
            repo = new UserRepository();
        }
        


        [Route("GetUsers")]
       
        public HttpResponseMessage GetUser()
        {
            try
            {
                var users = repo.GetUsers().ToList();
                return this.Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch (Exception ex)
            {

                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}