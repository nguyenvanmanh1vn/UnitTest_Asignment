#pragma checksum "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Author\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "855b871b11585b3a580a47d237ae43b8e673b9de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Create), @"mvc.1.0.view", @"/Views/Author/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/Create.cshtml", typeof(AspNetCore.Views_Author_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"855b871b11585b3a580a47d237ae43b8e673b9de", @"/Views/Author/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552983b97e1636d6efe9d872cc7c83211e3de7ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Author\Create.cshtml"
  
    ViewBag.Title = "New Author";

#line default
#line hidden
            BeginContext(57, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(62, 13, false);
#line 5 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Author\Create.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(75, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 6 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Author\Create.cshtml"
 using(Html.BeginForm()){

#line default
#line hidden
            BeginContext(109, 32, true);
            WriteLiteral("  <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(142, 39, false);
#line 8 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Author\Create.cshtml"
Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(181, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(188, 71, false);
#line 9 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Author\Create.cshtml"
Write(Html.TextBoxFor(model => model.FirstName, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(259, 45, true);
            WriteLiteral(" \r\n  </div>\r\n  <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(305, 38, false);
#line 12 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Author\Create.cshtml"
Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(343, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(350, 70, false);
#line 13 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Author\Create.cshtml"
Write(Html.TextBoxFor(model => model.LastName, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(420, 78, true);
            WriteLiteral(" \r\n  </div>\r\n  <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
            EndContext();
#line 16 "D:\Jobs\Nash_Tech\MS_Rookies\Offline_Course\Day_15_(2021-04-02)\Session_1_Unit_Testing_With_NUnit_Mentor\Practices\UnitTestExc\Views\Author\Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Author> Html { get; private set; }
    }
}
#pragma warning restore 1591