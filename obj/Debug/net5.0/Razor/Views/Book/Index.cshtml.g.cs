#pragma checksum "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e07235cce1be178ab663c3acc8d5fab2863786ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
#line 1 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\_ViewImports.cshtml"
using UnitTestExc;

#line default
#line hidden
#line 2 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\_ViewImports.cshtml"
using UnitTestExc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e07235cce1be178ab663c3acc8d5fab2863786ea", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552983b97e1636d6efe9d872cc7c83211e3de7ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Book\Index.cshtml"
  
    ViewBag.Title = "Get Book By ID Result";

#line default
#line hidden
            BeginContext(79, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(84, 13, false);
#line 5 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Book\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(97, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
            BeginContext(262, 226, true);
            WriteLiteral("<div><b>Book By ID Result</b><br /></div>  \r\n<table class=\"table table-bordered table-responsive table-hover\">  \r\n    <tr>  \r\n        <th>Book Id </th>  \r\n        <th>Title </th>  \r\n        <th>Author Id </th>  \r\n    </tr>  \r\n");
            EndContext();
#line 21 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Book\Index.cshtml"
     foreach (var d in Model)  
    {  

#line default
#line hidden
            BeginContext(530, 32, true);
            WriteLiteral("        <tr>  \r\n            <td>");
            EndContext();
            BeginContext(563, 8, false);
#line 24 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Book\Index.cshtml"
           Write(d.BookId);

#line default
#line hidden
            EndContext();
            BeginContext(571, 25, true);
            WriteLiteral("</td>  \r\n            <td>");
            EndContext();
            BeginContext(597, 7, false);
#line 25 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Book\Index.cshtml"
           Write(d.Title);

#line default
#line hidden
            EndContext();
            BeginContext(604, 25, true);
            WriteLiteral("</td>  \r\n            <td>");
            EndContext();
            BeginContext(630, 10, false);
#line 26 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Book\Index.cshtml"
           Write(d.AuthorId);

#line default
#line hidden
            EndContext();
            BeginContext(640, 26, true);
            WriteLiteral("</td>  \r\n        </tr>  \r\n");
            EndContext();
#line 28 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Book\Index.cshtml"
    }  

#line default
#line hidden
            BeginContext(675, 15, true);
            WriteLiteral("</table>\r\n<div>");
            EndContext();
            BeginContext(691, 32, false);
#line 30 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Book\Index.cshtml"
Write(Html.ActionLink("New", "create"));

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
