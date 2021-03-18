#pragma checksum "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13bec609e5e6efa1ff2df024c92bc056dfd045e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\_ViewImports.cshtml"
using Project1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\_ViewImports.cshtml"
using Project1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13bec609e5e6efa1ff2df024c92bc056dfd045e2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f8a1206ad760d99a32967ca6cf008da4df4ac8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Trip>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Trip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
   
    ViewBag.Title = "My Trip Log";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
 if (TempData.Peek("message") != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"jumbotron\">");
#nullable restore
#line 7 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                     Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 8 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13bec609e5e6efa1ff2df024c92bc056dfd045e24592", async() => {
                WriteLiteral("Add Trip");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Destination</th>
            <th>Start Date</th>
            <th>End Date</th>
            <th>Accommodations</th>
            <th>Things To Do</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
         foreach(var trip in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                   Write(trip.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                   Write(trip.StartDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                   Write(trip.EndDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                         if (@trip.Accommodation != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                            ");
#nullable restore
#line 30 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                       Write(trip.Accommodation);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            Phone: ");
#nullable restore
#line 31 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                              Write(trip.AccommodationPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Email: ");
#nullable restore
#line 31 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                                                                Write(trip.AccommodationEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 33 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                        }
                        else {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <td></td> ");
#nullable restore
#line 34 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 35 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                   Write(trip.ThingToDo1);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 36 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                   Write(trip.ThingToDo2);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 37 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
                   Write(trip.ThingToDo3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\thevi\Documents\repos\IT2030\assignments\Project1\Project1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Trip>> Html { get; private set; }
    }
}
#pragma warning restore 1591
