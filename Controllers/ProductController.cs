using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Net.Http;
using Newtonsoft.Json;
using Rocket_Elevators_Customer_Portal.Models;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Rocket_Elevators_Customer_Portal.Controllers
{
    [Authorize]
    
    public class ProductController : Controller
    {
        public async Task<IActionResult> ProductAsync()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.Batteries = await GetBatteries();
            mymodel.Columns = await GetColumns();
            mymodel.Elevators = await GetElevators();
            mymodel.Customers = await GetCustomer();
            mymodel.Building = await GetBuildings();
            return View(mymodel);
        }
        
        // Customers
        public async Task<IEnumerable<Customers>> GetCustomer()
        {
            var name = User.Identity.Name;
            List<Customers> customerList = new List<Customers>();
            using (var httpClient = new HttpClient())
            {
                //HTTP GET request to the API
                using (var response = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/customers/"+name))
                {
                    //data returned by the API is fetched from the code
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //Deserialize the JSON to a List type object
                    customerList = JsonConvert.DeserializeObject<List<Customers>>(apiResponse);
                }
            }
            ViewBag.customers = customerList;
            return customerList;
        }
        
        // BUILDINGS
        public async Task<IEnumerable<Buildings>> GetBuildings()
        {
            var name = User.Identity.Name;
            List<Buildings> buildingList = new List<Buildings>();
            using (var httpClient = new HttpClient())
            {
                //HTTP GET request to the API
                using (var response = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/buildings/"+name))
                {
                    //data returned by the API is fetched from the code
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //Deserialize the JSON to a List type object
                    buildingList = JsonConvert.DeserializeObject<List<Buildings>>(apiResponse);
                }
            }
            ViewBag.buildings = buildingList;
            return buildingList;
        }

        // BATTERIES
        public async Task<IEnumerable<Batteries>> GetBatteries()
        {
            var name = User.Identity.Name;
            Console.WriteLine(name);
            List<Batteries> batteryList = new List<Batteries>();
            using (var httpClient = new HttpClient())
            {
                //HTTP GET request to the API
                using (var response = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/batteries/"+name))
                {
                    //data returned by the API is fetched from the code
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //Deserialize the JSON to a List type object
                    batteryList = JsonConvert.DeserializeObject<List<Batteries>>(apiResponse);
                    
                    
                }
            }
            ViewBag.batteries = batteryList;
            // Console.WriteLine(batteryList);
            return batteryList;
        }

        // COLUMNS
        public async Task<IEnumerable<Columns>> GetColumns()
        {
            var name = User.Identity.Name;
            List<Columns> columnList = new List<Columns>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/columns/"+name))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    columnList = JsonConvert.DeserializeObject<List<Columns>>(apiResponse);
                    
                }
            }
            ViewBag.columns = columnList;
            return columnList;
        }

        // ELEVATORS
        public async Task<IEnumerable<Elevators>> GetElevators()
        {
            var name = User.Identity.Name;
            List<Elevators> elevatorList = new List<Elevators>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/elevators/"+name))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    elevatorList = JsonConvert.DeserializeObject<List<Elevators>>(apiResponse);
                }
            }
            // Console.WriteLine(elevatorList);
            ViewBag.elevators = elevatorList;
            return elevatorList;
        }

        //Update Contact Info
         // public async Task<Customers> ModifyContactInfo(int id)
        //  public async Task<IActionResult> ModifyContactInfo(int id)
        // {
        //     Customers customer = new Customers();
        //     using (var httpClient = new HttpClient())
        //     {
        //         using (var response = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/customers/" + id))
        //         {
        //             string apiResponse = await response.Content.ReadAsStringAsync();
        //             customer = JsonConvert.DeserializeObject<Customers>(apiResponse);
        //         }
        //     }
        //     return View(customer);
        // }
        
        
        //   public async Task<IActionResult> ModifyAddressInfo(int id)
        // {
        //     Addresses address = new Addresses();
        //     using (var httpClient = new HttpClient())
        //     {
        //         using (var response = await httpClient.GetAsync("https://rocketrestapi.azurewebsites.net/api/addresses/" + id))
        //         {
        //             string apiResponse = await response.Content.ReadAsStringAsync();
        //             address = JsonConvert.DeserializeObject<Addresses>(apiResponse);
        //         }
        //     }
        //     return View(address);
        // }
          
        
    }
}