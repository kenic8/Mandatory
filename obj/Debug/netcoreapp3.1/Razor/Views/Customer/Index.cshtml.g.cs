#pragma checksum "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fba3cd0b9150ce1c5f7ed80529a066b218cdc37e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba3cd0b9150ce1c5f7ed80529a066b218cdc37e", @"/Views/Customer/Index.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"CustomerContent\">\r\n    <h1> Single viewbag</h1>\r\n    <div style=\"margin-left:10%; margin-top:4%;\" class=\"CustomerContent-container\">\r\n        <h2>");
#nullable restore
#line 11 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
       Write(ViewBag.CostumerTry1.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 11 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
                                        Write(ViewBag.CostumerTry1.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>");
#nullable restore
#line 12 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
       Write(ViewBag.CostumerTry1.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>");
#nullable restore
#line 13 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
       Write(ViewBag.CostumerTry1.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
                                 Write(ViewBag.CostumerTry1.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <hr>\r\n    </div>\r\n</section>\r\n\r\n<h1> ViewBag List</h1>\r\n\r\n\r\n<section class=\"CustomerContent\">\r\n");
#nullable restore
#line 22 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
      
        foreach (var customer in ViewBag.Customers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"margin-left:10%; margin-top:4%;\" class=\"CustomerContent-container\">\r\n                <h2>");
#nullable restore
#line 26 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
                Write(customer.FirstName + " " + customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>");
#nullable restore
#line 27 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
              Write(customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 28 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
               Write(customer.Zip + " " + customer.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Tlf: ");
#nullable restore
#line 29 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
                    Write(String.Join(", ", customer.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 30 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
              Write(customer.age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" years old</p>\r\n                <hr>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\lille\Desktop\PBA - 2021\Code\Mandatory\MbmStore\Views\Customer\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591