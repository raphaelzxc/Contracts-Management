#pragma checksum "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2283cfe3f71e7bf2db68bb21816a984a66ba95aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContractsManagement.Pages.MiningContract.Pages_MiningContract_Details), @"mvc.1.0.razor-page", @"/Pages/MiningContract/Details.cshtml")]
namespace ContractsManagement.Pages.MiningContract
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
#line 1 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\_ViewImports.cshtml"
using ContractsManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\_ViewImports.cshtml"
using ContractsManagement.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2283cfe3f71e7bf2db68bb21816a984a66ba95aa", @"/Pages/MiningContract/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf28d7852ae629e119873b983b315128216e9b42", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MiningContract_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>MiningContracts</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.ContractorsName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.ContractorsName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.ReferenceNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.ReferenceNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Amendment_Supplement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Amendment_Supplement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.TypeofContract));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.TypeofContract));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.DocumentStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.DocumentStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Addresss));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Addresss));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Accreditation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Accreditation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Finish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Finish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.PaymentTerms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.PaymentTerms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Scope));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Scope));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Rates));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Rates));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Provisions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Provisions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.WorkProgress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.WorkProgress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Recommendation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Recommendation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.CreatedByUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.CreatedByUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.ModifiedByUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.ModifiedByUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiningContracts.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiningContracts.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2283cfe3f71e7bf2db68bb21816a984a66ba95aa20937", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "C:\Users\Super Admin\Desktop\DbDesktop\ContractsManagement\ContractsManagement\Pages\MiningContract\Details.cshtml"
                           WriteLiteral(Model.MiningContracts.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2283cfe3f71e7bf2db68bb21816a984a66ba95aa23130", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContractsManagement.Pages.MiningContract.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContractsManagement.Pages.MiningContract.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContractsManagement.Pages.MiningContract.DetailsModel>)PageContext?.ViewData;
        public ContractsManagement.Pages.MiningContract.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
