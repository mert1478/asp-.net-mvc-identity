#pragma checksum "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\UserRoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adad35b4eaf9e2e42f986b48f11239c3d6088f89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminRole_UserRoleList), @"mvc.1.0.view", @"/Views/AdminRole/UserRoleList.cshtml")]
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
#line 1 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\_ViewImports.cshtml"
using IdentityApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\_ViewImports.cshtml"
using IdentityApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\UserRoleList.cshtml"
using IdentityApp.Areas.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adad35b4eaf9e2e42f986b48f11239c3d6088f89", @"/Views/AdminRole/UserRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a79e07979cc264206d8f33978c0db4b98bb04f4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminRole_UserRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CustomUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\UserRoleList.cshtml"
  
    ViewData["Title"] = "UserRoleList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Users Role List</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>User</th>\r\n        <th>Get Role</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\UserRoleList.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 18 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\UserRoleList.cshtml"
                   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 435, "\"", 473, 3);
            WriteAttributeValue("", 442, "/AdminRole/AssignRole/", 442, 22, true);
#nullable restore
#line 19 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\UserRoleList.cshtml"
WriteAttributeValue("", 464, item.Id, 464, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 472, "/", 472, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Get Role</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\UserRoleList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/AdminRole/Index/\" class=\"btn btn-primary\">Go Back to Rol List</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CustomUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
