#pragma checksum "C:\Users\stari\OneDrive\Documents\GitHub\C-Sharp_Projects\myFirstAzureWebApp\myFirstAzureWebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c694cffcab5faa001d9545beae013833d045905e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(myFirstAzureWebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace myFirstAzureWebApp.Pages
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
#line 1 "C:\Users\stari\OneDrive\Documents\GitHub\C-Sharp_Projects\myFirstAzureWebApp\myFirstAzureWebApp\Pages\_ViewImports.cshtml"
using myFirstAzureWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c694cffcab5faa001d9545beae013833d045905e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c08e124d4786ae33dbe014b105d9bf55c64e4dba", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\stari\OneDrive\Documents\GitHub\C-Sharp_Projects\myFirstAzureWebApp\myFirstAzureWebApp\Pages\Index.cshtml"
  
  ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n  <h2 class=\"display-4\">Welcome to The Tech Academy</h2>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\stari\OneDrive\Documents\GitHub\C-Sharp_Projects\myFirstAzureWebApp\myFirstAzureWebApp\Pages\Index.cshtml"
  
  var todaysDate = DateTime.Now;
  var greetingMessage = " Today is: " + todaysDate;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p><center> ");
#nullable restore
#line 16 "C:\Users\stari\OneDrive\Documents\GitHub\C-Sharp_Projects\myFirstAzureWebApp\myFirstAzureWebApp\Pages\Index.cshtml"
       Write(greetingMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></center>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591