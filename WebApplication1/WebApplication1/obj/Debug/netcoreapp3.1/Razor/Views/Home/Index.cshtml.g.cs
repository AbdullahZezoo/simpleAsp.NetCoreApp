#pragma checksum "C:\Users\AbdullahZezo\Downloads\Az_app-main\Az_app-main\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "945c514f373fac187fb528568c6048d71c36eda5"
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
#line 1 "C:\Users\AbdullahZezo\Downloads\Az_app-main\Az_app-main\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdullahZezo\Downloads\Az_app-main\Az_app-main\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"945c514f373fac187fb528568c6048d71c36eda5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637209e7eeedf13d00f2cccd93a350b795d01eb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\AbdullahZezo\Downloads\Az_app-main\Az_app-main\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>Welcome To MVC Web App.</a>.</p>\n\n");
#nullable restore
#line 7 "C:\Users\AbdullahZezo\Downloads\Az_app-main\Az_app-main\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
     using (Html.BeginForm("LoginPage", "Home"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"submit\" name=\"Login\" value=\"Login\" />");
#nullable restore
#line 9 "C:\Users\AbdullahZezo\Downloads\Az_app-main\Az_app-main\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 12 "C:\Users\AbdullahZezo\Downloads\Az_app-main\Az_app-main\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
     using (Html.BeginForm("RegisterPage", "Home"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"submit\" name=\"Register\" value=\"Register\" />");
#nullable restore
#line 14 "C:\Users\AbdullahZezo\Downloads\Az_app-main\Az_app-main\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n\n");
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