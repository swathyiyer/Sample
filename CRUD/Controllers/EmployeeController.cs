using CRUD.App_Start;
using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD.Controllers
{//this is the change
    public class EmployeeController : ApiController
    {
        //[HttpPost]
        //public IHttpActionResult create(int id,string name,int phoneno)
        //{
        //    employeeEntities ob = new employeeEntities();
        //    employeedetail ed = new employeedetail();
        //    ed.id = id;
        //    ed.name = name;
        //    ed.phoneno = phoneno;
        //    ob.employeedetails.Add(ed);
        //    ob.SaveChanges();
        //    return Ok();
        //}
        //[HttpGet]
        //public IHttpActionResult SearchByid(int id)
        //{
        //    employeeEntities ob = new employeeEntities();
        //    employeedetail ed = new employeedetail();
        //    var result = (from e in ob.employeedetails where (e.id == id) select e).FirstOrDefault();
        //    return Ok(result);
        //}
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            employeedetail ed = new employeedetail();
            using (var context = new employeeEntities())
            {
                ed = context.employeedetails.Where(s => s.id == id).FirstOrDefault();
            }
            if (ed == null)
            {
                return new Custommsg("hh", Request, HttpStatusCode.NotFound);
                //  return Request.CreateResponse(HttpStatusCode.NotFound, id);
            }
            return new Custommsg(ed.name, Request, HttpStatusCode.NotFound);
        }

    }
}
