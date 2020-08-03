using MVC.M3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC.M3.API
{
    public class GraphicDesignController : ApiController
    {
        // GET: api/GraphicDesign
        List<GraphicDesign> design = new List<GraphicDesign>();
        public GraphicDesignController()
        {
            design.Add(new GraphicDesign { DesignType = "Web Design, Publication Design, Illustration Design", FrontEnd = "HTML5, CSS,JavaScript", Type = "Advanced Typography", AdobeCloud = "Illustrator, Indesign, Photoshop, AfterEffects" });
        }
        public List<GraphicDesign> Get()
        {

            return design;
        }

        // GET: api/GraphicDesign/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GraphicDesign
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GraphicDesign/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GraphicDesign/5
        public void Delete(int id)
        {
        }
    }
}
