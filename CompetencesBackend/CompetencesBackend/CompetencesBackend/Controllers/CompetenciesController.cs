using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Cors;

namespace CompetencesBackend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CompetenciesController : ApiController
    {
        [HttpGet]
        [ResponseType(typeof(List<object>))]
        public IHttpActionResult List() {
            return Ok(new List<object>()
            {
                new { Id= 1, Name= "Boootstrap", Level= 4, Picture= "bootstrap.svg", Description= "Wersja 3" },
                new{ Id= 2, Name= "AngularJS", Level= 0, Picture= "angularjs.png", Description= "" },
                new{ Id= 3, Name= "Angular", Level= 4, Picture= "angular.png", Description= "" },
                new{ Id= 4, Name= "Ionic", Level= 4, Picture= "ionic.png", Description= "Wersja 2" },
                new{ Id= 5, Name= "PhoneGap", Level= 1, Picture= "phonegap.png", Description= "Tylko absolutne podstawy" },
                new{ Id= 6, Name= "ReactJS", Level= 1, Picture= "react.png", Description= "Tylko absolutne podstawy" },
                new{ Id= 7, Name= "Xamarin", Level= 2, Picture= "xamarin.png", Description= "Bez API dla IOS" },
                new{ Id= 8, Name= "HTML5", Level= 5, Picture= "html5.png", Description= "Bez WebSockets i Database API" },
                new{ Id= 9, Name= "CSS3", Level= 4, Picture= "css3.png", Description= "" },
                new{ Id= 10, Name= "WebAPI", Level= 5, Picture= "webapi.png", Description= "" }
            });
        }
    }
}
