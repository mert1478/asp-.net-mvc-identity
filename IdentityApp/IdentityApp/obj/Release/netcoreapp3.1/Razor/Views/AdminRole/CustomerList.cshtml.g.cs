#pragma checksum "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\CustomerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142d763e6374f74f7353babc3f91fbdfb69c2d6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminRole_CustomerList), @"mvc.1.0.view", @"/Views/AdminRole/CustomerList.cshtml")]
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
#line 1 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\CustomerList.cshtml"
using IdentityApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"142d763e6374f74f7353babc3f91fbdfb69c2d6c", @"/Views/AdminRole/CustomerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a79e07979cc264206d8f33978c0db4b98bb04f4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminRole_CustomerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AspNetCustomers>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\CustomerList.cshtml"
  
    ViewData["Title"] = "CustomerList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>CustomerList</h1>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "142d763e6374f74f7353babc3f91fbdfb69c2d6c3436", async() => {
                WriteLiteral(@"
    <div class=""wrapper wrapper-content progress-bar-animated fadeInRight"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""ibox"">
                    <div class=""ibox-title"">
                        <h5>Roles</h5>
                        <div class=""ibox-tools"">
                            <a class=""collapse-link"">
                                <i class=""fade fa-chevron-up""></i>
                            </a>
                            <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                                <i class=""fa-chevron-up fa-wrench""></i>
                            </a>
                            <ul class=""dropdown-menu dropdown-user"">
                                <li>
                                    <a href=""#"" class=""dropdown-item"">Config option 1</a>
                                </li>
                                <li>
                                    <a href=""#"" class=""dropdown-item"">Config opt");
                WriteLiteral(@"ion 2</a>
                                </li>
                            </ul>
                            <a class=""close-link"">
                                <i class=""fa fa-times""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""ibox-content"">
                        <table class=""table table-hover"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Name</th>
                                    <th>Delete</th>
                                    <th>Update</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 50 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\CustomerList.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <th>");
#nullable restore
#line 53 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\CustomerList.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 54 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\CustomerList.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <td><a");
                BeginWriteAttribute("href", " href=\"", 2318, "\"", 2359, 2);
                WriteAttributeValue("", 2325, "/AdminRole/DeleteCustomer/", 2325, 26, true);
#nullable restore
#line 55 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\CustomerList.cshtml"
WriteAttributeValue("", 2351, item.Id, 2351, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a></td>\r\n                                        <td><a");
                BeginWriteAttribute("href", " href=\"", 2455, "\"", 2496, 2);
                WriteAttributeValue("", 2462, "/AdminRole/UpdateCustomer/", 2462, 26, true);
#nullable restore
#line 56 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\CustomerList.cshtml"
WriteAttributeValue("", 2488, item.Id, 2488, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-success\">Update</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 58 "C:\webapi\backend\files\IdentityApp\IdentityApp\Views\AdminRole\CustomerList.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tbody>
                        </table>
                        <a href=""/AdminRole/Index/"" class=""btn btn-primary"">Go Back to Rol List</a>
                        <a href=""/AdminRole/AddCustomer/"" class=""btn btn-primary"">Add New Customer</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AspNetCustomers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
