#pragma checksum "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a00d2683e6872275f873b4864bd0e9af3ce7abf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Edit), @"mvc.1.0.view", @"/Views/Pizza/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a00d2683e6872275f873b4864bd0e9af3ce7abf", @"/Views/Pizza/Edit.cshtml")]
    public class Views_Pizza_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyPizzaStoreApplication.Models.Pizza>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a00d2683e6872275f873b4864bd0e9af3ce7abf3013", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Edit</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a00d2683e6872275f873b4864bd0e9af3ce7abf4071", async() => {
                WriteLiteral("\r\n\r\n<h4>Pizza</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 20 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
         using (Html.BeginForm("Edit", "Pizza", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
       Write(Html.LabelFor(m => m.Name, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
       Write(Html.EditorFor(m => m.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
       Write(Html.LabelFor(m => m.IsVeg, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
       Write(Html.CheckBoxFor(m => m.IsVeg));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
       Write(Html.LabelFor(m => m.Crust, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
       Write(Html.EditorFor(m => m.Crust, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
       Write(Html.LabelFor(m => m.Price, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
       Write(Html.EditorFor(m => m.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
       Write(Html.LabelFor(m => m.Pic, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
       Write(Html.EditorFor(m => m.Pic, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"submit\" value=\"Update Pizza\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 33 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\Data\d drive\Corp\Srushti\Collabra\May31\Participants\MyPizzaStoreApplication\Views\Pizza\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                }
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyPizzaStoreApplication.Models.Pizza> Html { get; private set; }
    }
}
#pragma warning restore 1591