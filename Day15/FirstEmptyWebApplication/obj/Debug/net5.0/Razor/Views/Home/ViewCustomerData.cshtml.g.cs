#pragma checksum "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\Day15\FirstEmptyWebApplication\Views\Home\ViewCustomerData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4501c436034f1c1bd4eafd52eb661ca83d5a2089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewCustomerData), @"mvc.1.0.view", @"/Views/Home/ViewCustomerData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4501c436034f1c1bd4eafd52eb661ca83d5a2089", @"/Views/Home/ViewCustomerData.cshtml")]
    public class Views_Home_ViewCustomerData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 style=\"background-color:blue\">Hello from ViewCustomerData</h1>\r\n\r\n   \r\n");
            WriteLiteral("\r\n<section>\r\n    Customer\'s Name : ");
#nullable restore
#line 17 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\Day15\FirstEmptyWebApplication\Views\Home\ViewCustomerData.cshtml"
                 Write(ViewData["CustomerName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Customer\'s Age : ");
#nullable restore
#line 19 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\Day15\FirstEmptyWebApplication\Views\Home\ViewCustomerData.cshtml"
                Write(ViewData["CustomerAge"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Customer\'s Salary : ");
#nullable restore
#line 21 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\Day15\FirstEmptyWebApplication\Views\Home\ViewCustomerData.cshtml"
                   Write(ViewData["CustomerSalary"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Customer\'s Pet : ");
#nullable restore
#line 23 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\Day15\FirstEmptyWebApplication\Views\Home\ViewCustomerData.cshtml"
                Write(ViewData["CustomerPet"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n \r\n\r\n");
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
