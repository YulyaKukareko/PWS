#pragma checksum "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fafffe8a4b51dbcffc4dd783c7bb48dff335c51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
#line 1 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\_ViewImports.cshtml"
using Lab_APSNETCORE;

#line default
#line hidden
#line 2 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\_ViewImports.cshtml"
using Lab_APSNETCORE.Models;

#line default
#line hidden
#line 1 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\Users\Index.cshtml"
using Lab_APSNETCORE.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fafffe8a4b51dbcffc4dd783c7bb48dff335c51", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a3637c37b899fdea3ee4c88a58c36b471ab135", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var users = UsersService.Read();

#line default
#line hidden
            BeginContext(146, 350, true);
            WriteLiteral(@"
<h2>Index</h2>

<div style=""margin: 64px; "">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <td>ID</td>
                <td>First name</td>
                <td>Last name</td>
                <td>Birthday</td>
                <td>Gender</td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\Users\Index.cshtml"
             foreach (var obj in users)
            {

#line default
#line hidden
            BeginContext(552, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(599, 6, false);
#line 25 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\Users\Index.cshtml"
                   Write(obj.Id);

#line default
#line hidden
            EndContext();
            BeginContext(605, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(637, 13, false);
#line 26 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\Users\Index.cshtml"
                   Write(obj.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(650, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(682, 12, false);
#line 27 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\Users\Index.cshtml"
                   Write(obj.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(694, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(726, 32, false);
#line 28 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\Users\Index.cshtml"
                   Write(obj.Birthday.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(758, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(790, 10, false);
#line 29 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\Users\Index.cshtml"
                   Write(obj.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(800, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "D:\Univer\3 курс\2 семестр\Программирование интернет-серверов\LAB8\Lab_APSNETCORE\Views\Users\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(845, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UsersService UsersService { get; private set; }
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
