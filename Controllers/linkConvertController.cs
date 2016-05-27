using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using convertLink.Models;

namespace convertLink.Controllers
{
    public class linkConvertController : ApiController
    {
        public bool post(converter lessonData)
        {

            bool result=lessonData.creatNameListJsFile();

            return result;

        }
    }
}
