#pragma checksum "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\AdminDashboard\DisplayAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8714531f711d709eb00f935b581aa7e6cdc73d6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminDashboard_DisplayAccount), @"mvc.1.0.view", @"/Views/AdminDashboard/DisplayAccount.cshtml")]
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
#line 1 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\_ViewImports.cshtml"
using BankingInternationalSystemsApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\_ViewImports.cshtml"
using BankingInternationalSystemsApp.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\_ViewImports.cshtml"
using BankingInternationalSystemsApp.Client.ViewModels.LoginRegisterViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\_ViewImports.cshtml"
using BankingInternationalSystemsApp.Model.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\_ViewImports.cshtml"
using BankingInternationalSystemsApp.Client.ViewModels.UserDashboardViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\_ViewImports.cshtml"
using BankingInternationalSystemsApp.Client.ViewModels.WithdrawAccountViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\_ViewImports.cshtml"
using BankingInternationalSystemsApp.Client.ViewModels.AdminDashboardViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8714531f711d709eb00f935b581aa7e6cdc73d6f", @"/Views/AdminDashboard/DisplayAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4526e070c5c072f0e97f0e599d9354fcfebdfecb", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminDashboard_DisplayAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AccountViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AccountDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\AdminDashboard\DisplayAccount.cshtml"
  
    ViewData["Title"] = "Accounts";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h5 class=""text-center"">Display Accounts</h5>
        <hr />
	</div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <table id=""example"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>Full Name</th>
                    <th>Account Number</th>
                    <th>Balence</th>
                    <th>Email</th>
                    <th>Address</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\AdminDashboard\DisplayAccount.cshtml"
                 foreach(AccountViewModel item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\AdminDashboard\DisplayAccount.cshtml"
                       Write(item.GetFullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\AdminDashboard\DisplayAccount.cshtml"
                       Write(item.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\AdminDashboard\DisplayAccount.cshtml"
                       Write(item.InitialBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\AdminDashboard\DisplayAccount.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><address>");
#nullable restore
#line 33 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\AdminDashboard\DisplayAccount.cshtml"
                                Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</address></td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8714531f711d709eb00f935b581aa7e6cdc73d6f8484", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\AdminDashboard\DisplayAccount.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n                    </tr>\r\n");
#nullable restore
#line 38 "D:\BankingInternationalSystems\BankingInternationalSystemsApp\BankingInternationalSystemsApp.Client\Views\AdminDashboard\DisplayAccount.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
            <tfoot>
                <tr>
                    <th>Full Name</th>
                    <th>Account Number</th>
                    <th>Balence</th>
                    <th>Email</th>
                    <th>Address</th>
                    <th>Action</th>
                </tr>
            </tfoot>
        </table>
	</div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AccountViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
