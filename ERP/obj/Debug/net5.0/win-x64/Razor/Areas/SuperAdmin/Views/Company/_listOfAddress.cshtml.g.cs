#pragma checksum "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96fa3fabc67a100e9054dd44711aa432d4c54bad0f0fda1f9b00f597aca91ab1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Company__listOfAddress), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Company/_listOfAddress.cshtml")]
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
#line 1 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using Business.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using ERP.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using ERP.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using ERP.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using Business.Entities.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
using Business.SQL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"96fa3fabc67a100e9054dd44711aa432d4c54bad0f0fda1f9b00f597aca91ab1", @"/Areas/SuperAdmin/Views/Company/_listOfAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"66ca4ed4d968d0cb63ad96b0820d0f1f680273fdde74e92383c120d6a96a5604", @"/Areas/SuperAdmin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_SuperAdmin_Views_Company__listOfAddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedDataTable<CompanyAddressTxnMetadata>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/assets/vendors/simple-datatables/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96fa3fabc67a100e9054dd44711aa432d4c54bad0f0fda1f9b00f597aca91ab15938", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div id=""CompanyTable"">
    <div class=""row"">
        <div class=""col-sm-12 text-align-right"">
            <a onclick=""fnAddAddress(0)""
               class=""btn btn-outline-primary px-5 btn-sm""
               href=""javascript:void(0)""
               data-id=""0""
               data-bs-toggle=""offcanvas""
               data-bs-target=""#canvas_address""
               aria-controls=""canvas_address"">
                Add Address
            </a>
        </div>
        <table class=""table table-striped"" id=""tblAddress"" >
            <thead style=""position: sticky; top: 0; background-color:#e9ecf8; color:black; font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: x-small;"">
                <tr>
                    <th>Sr. No.</th>
                    <th>Address Type</th>
                    <th>Address</th>
                    <th>Zipcode</th>
                    <th>City</th>
                    <th>State</th>
                    <th></th>
                </tr>
        ");
            WriteLiteral("    </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 30 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
                 if (Model != null)
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 35 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
                           Write(item.SrNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
                           Write(item.AddressTypeText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
                           Write(string.Format("{0} {1} {2}", item.Address1,item.Address2,item.Address3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                        \r\n                            <td>");
#nullable restore
#line 38 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
                           Write(item.ZIPCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
                           Write(item.DistrictName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
                           Write(item.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a class=\'btn editaddress\'");
            BeginWriteAttribute("onclick", " onclick=\"", 1870, "\"", 1919, 3);
            WriteAttributeValue("", 1880, "fnAddAddress(", 1880, 13, true);
#nullable restore
#line 42 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
WriteAttributeValue("", 1893, item.CompanyAddressTxnID, 1893, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1918, ")", 1918, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" 
                                href=""javascript:void(0)""
                                data-bs-toggle=""offcanvas""
                                data-bs-target=""#canvas_address""
                                aria-controls=""canvas_address""
                                data-id=""");
#nullable restore
#line 47 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
                                    Write(item.CompanyAddressTxnID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("compnayid", " \r\n                                compnayid=\"", 2239, "\"", 2300, 1);
#nullable restore
#line 48 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
WriteAttributeValue("", 2285, item.CompanyID, 2285, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\'bx bx-edit\'></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 51 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
<div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""canvas_address"" >
    <div class=""offcanvas-header"">
        <h5 class=""offcanvas-title"">Address</h5>
        <button type=""button"" class=""btn-close text-reset"" data-bs-dismiss=""offcanvas"" aria-label=""Close""></button>
    </div>
    <div class=""offcanvas-body pt-3 pb-5"">
        <div id=""dvInfo"">
        </div>
    </div>
</div>

<script>
    var urlAddAddress = '");
#nullable restore
#line 69 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\Company\_listOfAddress.cshtml"
                    Write(Url.Action("AddAddress", "Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    function fnAddAddress(id) {
        var _id = id;//$(this).data('id');
        var _cid=$(""#CompanyID"").val();
        var _parameters = { id: _id, compnayid: _cid };
        $.ajax({
            url: urlAddAddress,
            type: ""GET"",
            data: _parameters,
            success: function (data, textStatus, jqXHR) {
                $(""#canvas_address"").show();//('hide');
                $('#dvInfo').html(data);
            }
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedDataTable<CompanyAddressTxnMetadata>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
