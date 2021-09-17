using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rocket_Elevators_Customer_Portal.Models;
using System.Net.Http;
using System.Net;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Encodings.Web;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Identity;


namespace RocketElevatorsCustomerPortal.Controllers
{
    public class InterventionController : Controller
    {
       [HttpPost]
       public ActionResult AddIntervention(IEnumerable<InterventionController> interfaces)
       {
           return View();
       }

public async Task<IActionResult> InterventionAsync()
        {


            dynamic mymodel = new ExpandoObject();
            return View(mymodel);
        }
        

        //CALLED IN PRODUCT.CSHTML
        public async Task<IActionResult> Elevators(string elevId, string elevColId)
        {
            
            var name = User.Identity.Name; //GET THE USER EMAIL
            ViewBag.name=name;
            var column= elevColId;
            var elevator= elevId;
            ViewBag.column=column;
            ViewBag.elevator= elevator;

            
            //TO GET THE BATTERY ID OF THE COLUMN TO SHOW IT IN INTERVENTION FORM
            var httpClients = new HttpClient();
            var response = await httpClients.GetAsync("https://rocketrestapi.azurewebsites.net/api/columns/" + column +"/get");
            
            string apiResponse = await response.Content.ReadAsStringAsync(); 
            dynamic data = JObject.Parse(apiResponse);
            Console.WriteLine(data.batteryId);
            var bu= data.batteryId;  //BATTERY ID OF THE COLUMN

            //TO GET THE CUSTOMER ID TO BE ABLE TO SEND IT IN AJAX CALL INSIDE THE INTERVENTION FORM
            var httpClient = new HttpClient();
            var responses = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/buildings/" + bu +"/get");
        
            string apiResponses = await responses.Content.ReadAsStringAsync(); 
            dynamic data1 = JObject.Parse(apiResponses);
            var customerId= data1.customerId;
            var battery=data.batteryId;
            var building=data.batteryId;
            ViewBag.battery=battery;
            ViewBag.building=building;
            ViewBag.customer=customerId;

            return View("~/Views/Intervention/Intervention.cshtml");
            
        }
        //CALLED IN PRODUCT.CSHTML
        public async Task<IActionResult> Columns(string colId, string colBatId)
        {
            //TO GET THE CUSTOMER ID TO BE ABLE TO SEND IT IN AJAX CALL INSIDE THE INTERVENTION FORM
            var httpClient = new HttpClient();
            var responses = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/buildings/" + colBatId +"/get");
            string apiResponses = await responses.Content.ReadAsStringAsync(); 
            dynamic data1 = JObject.Parse(apiResponses);
            var customerId= data1.customerId;
            ViewBag.customer=customerId;   //THE CUSTOMER ID
            
            var name = User.Identity.Name; //GET THE USER EMAIL
            ViewBag.name=name;
            var column= colId;
            var battery= colBatId;
            ViewBag.column=column;
            ViewBag.battery= battery;
            ViewBag.building= battery;

            return View("~/Views/Intervention/Intervention2.cshtml");
        }

        //CALLED IN PRODUCT.CSHTML
        public async Task<IActionResult> Batteries(string batId)
        {
            //TO GET THE CUSTOMER ID TO BE ABLE TO SEND IT IN AJAX CALL INSIDE THE INTERVENTION FORM
            var httpClient = new HttpClient();
            var responses = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/buildings/" + batId +"/get");
            string apiResponses = await responses.Content.ReadAsStringAsync(); 
            dynamic data1 = JObject.Parse(apiResponses);
            var customerId= data1.customerId;
            ViewBag.customer=customerId;
            var name = User.Identity.Name; //GET THE USER EMAIL
            ViewBag.name=name;
            var battery= batId;
            ViewBag.battery= battery;
            //No need fot a viewbag for building because the value is the same as battery
            return View("~/Views/Intervention/Intervention3.cshtml");
        }
        //CALLED IN PRODUCT.CSHTML
        public async Task<IActionResult> Buildings(string builId)
        {
            //TO GET THE CUSTOMER ID TO BE ABLE TO SEND IT IN AJAX CALL INSIDE THE INTERVENTION FORM
            var httpClient = new HttpClient();
            var responses = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/buildings/" + builId +"/get");
            string apiResponses = await responses.Content.ReadAsStringAsync(); 
            dynamic data1 = JObject.Parse(apiResponses);
            var customerId= data1.customerId;
            ViewBag.customer=customerId;
            var name = User.Identity.Name; //GET THE USER EMAIL
            ViewBag.name=name;
            var building= builId;
            ViewBag.building= building;
            //No need fot a viewbag for building because the value is the same as battery
            return View("~/Views/Intervention/Intervention4.cshtml");
        }
        //CALLED IN PRODUCT.CSHTML
        public async Task<IActionResult> info( string com,string cont, string contph, string contem, string des, string teco, string tecoph, string tecoem)
        {
            var company = com;
            var contact = cont;
            var contactPhone = contph;
            var contactEmail = contem;
            var desc = des;
            var techCo = teco;
            var techPh = tecoph;
            var techEm = tecoem;
            ViewBag.company=company;
            ViewBag.contact=contact;
            ViewBag.contactPhone=contactPhone;
            ViewBag.contactEmail=contactEmail;
            ViewBag.desc= desc;
            ViewBag.techCo=techCo;
            ViewBag.techPh=techPh;
            ViewBag.techEm=techEm;

            //No need fot a viewbag for building because the value is the same as battery
            return View("~/Views/UpdateInfo/CustomerInfoUpdate.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}