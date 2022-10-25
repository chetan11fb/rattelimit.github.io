using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AnnonymousURL()
        {
            return View();
        }


        public ActionResult AnnonymousURL(FormCollection form)
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Responces = string.Empty; ;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> About(FormCollection form)
        {
            //ContactInfo contactInfo = Myrequest();
            List<string> list = new List<string>();
            var APIUrl = form["UrlData"].ToString();

            List<ContactInfo> lstContactInfo = Contactlist();

            //var dataAsString = JsonConvert.SerializeObject(contactInfo);
            //var dataContent = new StringContent(dataAsString);
            for (int i = 0; i < 30; i++)
            {
                var itemlist = lstContactInfo[i];
                string accessToken = "Bearer " + form["TokenData"].ToString();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", accessToken);

                HttpResponseMessage response = await client.PostAsync(APIUrl, new StringContent(
       new JavaScriptSerializer().Serialize(itemlist), Encoding.UTF8, "application/json"));
                if (response != null)
                {
                    list.Add(response.ToString());
                    //Console.WriteLine(response.ToString());
                }
            }


            ViewBag.Responces = list;
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private List<ContactInfo> Contactlist()
        {

            City city1 = new City();
            city1.name = "ATCO";
            city1.abbreviation = "string";
            State state1 = new State();
            state1.abbreviation = "NJ";
            state1.name = "string";
            Country country1 = new Country();
            country1.name = "string";
            country1.abbreviation = "USA";

            var lstContactInfo = new List<ContactInfo>() {
                new ContactInfo(){  address="2437 RICHARDS AVE",suiteAddress ="",city = city1,state=state1, zipCode="08004-1264",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                 new ContactInfo(){  address="2437 RICHARDS AVE",suiteAddress ="",city = city1,state=state1, zipCode="08004-1264",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                  new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},


                    new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                      new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                        new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},

                          new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                            new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                              new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},


                                new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                  new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                    new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},

                                      new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                        new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                          new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},

                                            new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                              new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                                new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},

                                                  new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                                    new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                                      new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},

                                                        new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                                          new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                                            new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},


                                                                new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                                                  new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
                                                                    new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},


  new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
    new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},
      new ContactInfo(){  address="942 CAMELOT CT",suiteAddress ="",city = city1,state=state1, zipCode="8077",country=country1
                  ,phone= "+1 123-546-0134",email= "23455@n.com"},

            };




            return lstContactInfo;
        }
    }
}