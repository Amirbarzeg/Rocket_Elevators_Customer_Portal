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

        public async Task<IActionResult> Elevators(string elevId, string elevColId)
        {
            // Console.WriteLine("!!!!!!!!!!!!!");
            // Console.WriteLine(elevBatId);
            // Console.WriteLine("!!!!!!!!!!!!");

            var name = User.Identity.Name;
            ViewBag.name=name;
            var column= elevColId;
            var elevator= elevId;
            ViewBag.column=column;
            ViewBag.elevator= elevator;

            var httpClient = new HttpClient();
               
                var response = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/columns/" + column +"/get");
                
                    string apiResponse = await response.Content.ReadAsStringAsync(); 
                    Console.WriteLine("============");
                    Console.WriteLine(apiResponse);
                    Console.WriteLine("============");
                    Console.WriteLine("!!!!!!!!!!!!!");
                    Console.WriteLine(elevId);
                    Console.WriteLine("!!!!!!!!!!!!");
                    dynamic data = JObject.Parse(apiResponse);
                    Console.WriteLine(data.batteryId);
                    var battery=data.batteryId;
                    var building=data.batteryId;
                    ViewBag.battery=battery;
                    ViewBag.building=building;
             
                    Console.WriteLine(name);
                    Console.WriteLine(column);
                    Console.WriteLine(elevator);
                    Console.WriteLine(battery);
                    Console.WriteLine(building);
            return View("~/Views/Interventio.cshtml");
        }
        public async Task<IActionResult> Columns(string colId, string colBatId)
        {
            var name = User.Identity.Name;
            ViewBag.name=name;
            var column= colId;
            var battery= colBatId;
            ViewBag.column=column;
            ViewBag.battery= battery;
            ViewBag.building= battery;

            return View("~/Views/Intervention/Intervention2.cshtml");
        }
        public async Task<IActionResult> Batteries(string batId)
        {
            var name = User.Identity.Name;
            ViewBag.name=name;
            var battery= batId;
            ViewBag.battery= battery;
            //No need fot a viewbag for building because the value is the same as battery
            return View("~/Views/Intervention/Intervention3.cshtml");
        }
        public async Task<IActionResult> Buildings(string builId)
        {
            var name = User.Identity.Name;
            ViewBag.name=name;
            var building= builId;
            ViewBag.building= building;
            //No need fot a viewbag for building because the value is the same as battery
            return View("~/Views/Intervention/Intervention4.cshtml");
        }
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

            Console.WriteLine(company);
            Console.WriteLine(contact);
            Console.WriteLine(contactPhone);
            Console.WriteLine(contactEmail);
            Console.WriteLine(desc);
            Console.WriteLine(techCo);
            Console.WriteLine(techPh);
            Console.WriteLine(techEm);
            
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