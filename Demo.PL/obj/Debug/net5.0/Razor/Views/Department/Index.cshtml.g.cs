#pragma checksum "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dae076ce44e9b4991076a2e1a0c7aa20dad9a0bbe7930e1c8521f21fbf6a8a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.BLL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"dae076ce44e9b4991076a2e1a0c7aa20dad9a0bbe7930e1c8521f21fbf6a8a03", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"59f5fe8c36e9bb7d073cbe439b138aa7a8ef2e9f9980e975dd6f9bfa3d72802a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DepartmentViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Department", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SearchPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";
    string VDataMessage = ViewData["Message"] as string; // It is strongly typed so it needs casting
    string VBagMessage = ViewBag.Message; //Can't enforce type Safety , it does not need casting as it run in the run time. Weakly typed


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
#nullable restore
#line 19 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 21 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>All Departments</h1>\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dae076ce44e9b4991076a2e1a0c7aa20dad9a0bbe7930e1c8521f21fbf6a8a037143", async() => {
                WriteLiteral("Create New Department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dae076ce44e9b4991076a2e1a0c7aa20dad9a0bbe7930e1c8521f21fbf6a8a038626", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 31 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"mt-3 table table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 36 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(D => D.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 37 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(D => D.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 38 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(D => D.DateOfCreation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 45 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
             foreach (var department in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 48 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
                   Write(department.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
                   Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
                   Write(department.DateOfCreation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dae076ce44e9b4991076a2e1a0c7aa20dad9a0bbe7930e1c8521f21fbf6a8a0312561", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 51 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = department.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 53 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 56 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-5 alert alert-warning\">\r\n        <h3>There is no departments</h3>\r\n    </div>\r\n");
#nullable restore
#line 62 "E:\TAAZZ\ASP.NET\Eng Ahmed Nasr\07 ASP.NET MVC\Session 02\ThreeTierLayerSolution\Demo.PL\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DepartmentViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
