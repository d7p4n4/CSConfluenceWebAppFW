
using CSConfluenceServiceFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CSConfluenceWebAppFW.Controllers
{
    public class ConfluenceController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post(UpdateOrAddPageComposite value)
        {
            UpdateOrAddPageCompositeResponse updateOrAddPageCompositeResponse =
                new ConfluenceServices().UpdateOrAddPageComposite(new CSConfluenceServiceFW.UpdateOrAddPageCompositeRequest()
                {
                    PageTitle = value.PageTitle
                    ,
                    Password = value.Password
                    ,
                    Content = value.Content
                    ,
                    URL = value.URL
                    ,
                    Username = value.Username
                    ,
                    ParentPageTitle = value.ParentPageTitle
                    ,
                    SpaceKey = value.SpaceKey
                });

            if (updateOrAddPageCompositeResponse.Result.Success())
            {
                return "A feltöltés sikeres!";
            }
            else
            {
                return updateOrAddPageCompositeResponse.Result.Message;
            }
        }

            // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
