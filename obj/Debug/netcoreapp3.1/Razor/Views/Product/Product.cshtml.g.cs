#pragma checksum "/home/amir/Rocket_Elevators_Customer_Portal/Views/Product/Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a60821f9610cec461d37820051ba15ec3d042093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Product), @"mvc.1.0.view", @"/Views/Product/Product.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/amir/Rocket_Elevators_Customer_Portal/Views/_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/amir/Rocket_Elevators_Customer_Portal/Views/_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/amir/Rocket_Elevators_Customer_Portal/Views/Product/Product.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a60821f9610cec461d37820051ba15ec3d042093", @"/Views/Product/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25f6d5fda41f36129904dab2a2a0a3fc6a06f30", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/amir/Rocket_Elevators_Customer_Portal/Views/Product/Product.cshtml"
  
    ViewData["Title"] = "Product";
    var cu= ViewBag.customers;
    var bi = ViewBag.buildings;
    var ba = ViewBag.batteries;
    var col = ViewBag.columns;
    var el = ViewBag.elevators;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<main class=""col-md-9 ms-sm-auto col-lg-10 px-md-4"">
    <div class=""d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom"">
        <h1 class=""h2"">Products</h1>
    </div>
    
    <h3>Account Info</h3>
    <div class=""table-responsive"">
    <table class=""table table-striped table-sm"">
        <thead>
        <tr>
            
            <th scope=""col"">ID</th>
            <th scope=""col"">Company</th>
            <th scope=""col"">Contact</th>
            <th scope=""col"">Phone</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">About</th>
            <th scope=""col"">Tech Contact</th>
            <th scope=""col"">Tech Phone</th>
            <th scope=""col"">Tech Email</th>
        </tr>
        </thead>
        <tbody>
            <tr id=""customerInfo"">
            </tr>
        </tbody>
    </table>
    </div>
    <h3>Buildings</h3>
            <div class=""table-responsive"">
                <table class=""ta");
            WriteLiteral(@"ble table-striped table-sm"">
                    <thead>
                        <tr>
                            <th scope=""col"">ID</th>
                            <th scope=""col"">Admin</th>
                            <th scope=""col"">Email</th>
                            <th scope=""col"">Phone #</th>
                            <th scope=""col"">Tech Contact</th>
                            <th scope=""col"">Tech Email</th>
                            <th scope=""col"">Tech Phone</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr id=""buildingInfo"">
                        </tr>
                    </tbody>
                </table>
    
            </div>

    <h3>Batteries</h3>
        <div class=""table-responsive"">
              <table class=""table table-striped"">
                        <thead>
                            <tr>
                                <th>Battery Id</th>
                                <th>Sta");
            WriteLiteral("tus</th>\r\n                                <th>Belongs to Building</th>\r\n                            </tr>\r\n                        </thead>\r\n");
            WriteLiteral(@"            </table>
        </div>

        <h3>Columns</h3>
        <div class=""table-responsive"">
            <table class=""table table-striped table-sm"">
                <thead>
                    <tr>
                        <th scope=""col"">ID</th>
                        <th scope=""col"">Type</th>
                        <th scope=""col"">Floors</th>
                        <th scope=""col"">Status</th>
                        <th scope=""col"">Info</th>
                        <th scope=""col"">Notes</th>
                    </tr>
                </thead>
            </table>
        </div>

        <h3>Elevators</h3>
        <div class=""table-responsive"">
            <table class=""table table-striped table-sm"">
                <thead>
                    <tr>
                        <th scope=""col"">ID</th>
                        <th scope=""col"">Serial #</th>
                        <th scope=""col"">Model</th>
                        <th scope=""col"">Type</th>
                       ");
            WriteLiteral(@" <th scope=""col"">Status</th>
                        <th scope=""col"">Commission</th>
                        <th scope=""col"">Inspected</th>
                        <th scope=""col"">Certified by</th>
                        <th scope=""col"">Info</th>
                        <th scope=""col"">Notes</th>
                    </tr>
                </thead>
                <tbody>    
                </tbody>
            </table>
        </div>

</main>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
