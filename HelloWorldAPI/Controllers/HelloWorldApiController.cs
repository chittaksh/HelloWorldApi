using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;
using HelloWorldBusiness.Service;
using HelloWorldBusiness.Interface;

namespace HelloWorldAPI.Controllers
{
    public class HelloWorldApiController : ApiController
    {
        private IDataSource dataSource;

        //Default Constructor..
        public HelloWorldApiController()
        {
            dataSource = new DataSource();
        }

        //Constructor..
        public HelloWorldApiController(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        // GET api/values
        public string Get()
        {
            return dataSource.getDataString();
        }

    }
}
