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
            mymodel.building = await GetBuildings();
            mymodel.battery = await GetBatteries();
            mymodel.column= await GetColumns();
            mymodel.elevator= await GetElevators();
            return View(mymodel);
        }

        public async Task<IEnumerable<Buildings>> GetBuildings(){
         List<Buildings> buildingList = new List<Buildings>();
         using (var httpClient= new HttpClient()){
            using (var response= await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/buildings"))
            {
                string apiResponse= await response.Content.ReadAsStringAsync();
                buildingList= JsonConvert.DeserializeObject<List<Buildings>>(apiResponse);

            }
         }
                    return buildingList;
         }
          public async Task<IEnumerable<Batteries>> GetBatteries(){
         List<Batteries> buildingList = new List<Batteries>();
         using (var httpClient= new HttpClient()){
            using (var response= await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/batteries"))
            {
                string apiResponse= await response.Content.ReadAsStringAsync();
                buildingList= JsonConvert.DeserializeObject<List<Batteries>>(apiResponse);

            }
         }
                    return buildingList;
         }
          public async Task<IEnumerable<Columns>> GetColumns(){
         List<Columns> buildingList = new List<Columns>();
         using (var httpClient= new HttpClient()){
            using (var response= await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/columns"))
            {
                string apiResponse= await response.Content.ReadAsStringAsync();
                buildingList= JsonConvert.DeserializeObject<List<Columns>>(apiResponse);

            }
         }
                    return buildingList;
         }
        
        public async Task<IEnumerable<Elevators>> GetElevators(){
         List<Elevators> buildingList = new List<Elevators>();
         using (var httpClient= new HttpClient()){
            using (var response= await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/elevators"))
            {
                string apiResponse= await response.Content.ReadAsStringAsync();
                buildingList= JsonConvert.DeserializeObject<List<Elevators>>(apiResponse);

            }
         }
                    return buildingList;
         }




         public IActionResult Product()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}