#pragma checksum "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ceafdd720f90d179e8c998664d885a2fa7132acf1a22f311ae4e49d448e4d936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_RequestType_Index), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/RequestType/Index.cshtml")]
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
#line 1 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
using Business.SQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
using GridCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ceafdd720f90d179e8c998664d885a2fa7132acf1a22f311ae4e49d448e4d936", @"/Areas/SuperAdmin/Views/RequestType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"66ca4ed4d968d0cb63ad96b0820d0f1f680273fdde74e92383c120d6a96a5604", @"/Areas/SuperAdmin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_SuperAdmin_Views_RequestType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISGrid>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MasterEntity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::GridMvc.TagHelpers.GridTagHelper __GridMvc_TagHelpers_GridTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
  
      ViewData["Title"] = "Request Type";
    Layout = "~/Views/Shared/_LayoutMaster.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-breadcrumb d-none d-sm-flex align-items-center pb-3 border-bottom"">
    <div class=""ps-3 col-md-6"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb mb-0 p-0"">
                <li class=""breadcrumb-item"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceafdd720f90d179e8c998664d885a2fa7132acf1a22f311ae4e49d448e4d9367274", async() => {
                WriteLiteral("<i class=\"bx bx-home-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 17 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
                 if (Model.CommonSettings != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"breadcrumb-item active\" aria-current=\"page\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceafdd720f90d179e8c998664d885a2fa7132acf1a22f311ae4e49d448e4d9369289", async() => {
                WriteLiteral("Master Entity");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
            WriteLiteral("                    <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 21 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
                                                                      Write(Model.CommonSettings.QueryString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 22 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"breadcrumb-item active\" aria-current=\"page\">Request Type</li>\r\n");
#nullable restore
#line 26 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ol>\r\n        </nav>\r\n    </div>\r\n    <div class=\"col-md-6 text-align-right\">\r\n");
#nullable restore
#line 31 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
         if (Model.CommonSettings != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"btn btn-primary px-5\" onclick=\"fnMasterEntity(this)\"\r\n           href=\"javascript:void(0)\"\r\n           data-key=\"");
#nullable restore
#line 35 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
                Write(Model.CommonSettings.QueryString);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n           data-bs-toggle=\"offcanvas\"\r\n           data-bs-target=\"#canvas_masterentity\"\r\n           aria-controls=\"canvas_masterentity\">\r\n                Add Request Type\r\n            </a>\r\n");
#nullable restore
#line 41 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a class=""btn btn-primary px-5"" onclick=""fnMasterEntity(this)""
           href=""javascript:void(0)""
           data-key=""0""
           data-bs-toggle=""offcanvas""
           data-bs-target=""#canvas_masterentity""
           aria-controls=""canvas_masterentity"">
                Add Request Type
            </a>
");
#nullable restore
#line 52 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"row pt-1\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ceafdd720f90d179e8c998664d885a2fa7132acf1a22f311ae4e49d448e4d93613956", async() => {
            }
            );
            __GridMvc_TagHelpers_GridTagHelper = CreateTagHelper<global::GridMvc.TagHelpers.GridTagHelper>();
            __tagHelperExecutionContext.Add(__GridMvc_TagHelpers_GridTagHelper);
#nullable restore
#line 57 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
__GridMvc_TagHelpers_GridTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __GridMvc_TagHelpers_GridTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""canvas_masterentity"">
    <div class=""offcanvas-header"">
        <h5 class=""offcanvas-title"">Request Type</h5>
        <button type=""button"" class=""btn-close te  xt-reset"" data-bs-dismiss=""offcanvas"" aria-l abel=""Close""></button>
    </div>
    <div class=""offcanvas-body pt-3 pb-5"">
        <div id=""dvInfo"">
        </div>
    </div>
</div>
<script type=""text/javascript"">
    var urladd = '");
#nullable restore
#line 71 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
             Write(Url.Action("Get", "RequestType"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var urldeletebyid = \'");
#nullable restore
#line 72 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
                    Write(Url.Action("DeleteRequestType", "RequestType"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';    
    function fnMasterEntity(obj) {        
        var _id = $(obj).data('id');
        var _parameters = { id: _id };
        $.ajax({
            url: urladd,
            type: ""POST"",
            data: _parameters,
            success: function (data, textStatus, jqXHR) {
                $('#dvInfo').html(data);
                $(""#canvas_masterentity"").show();//('hide');
            }
        });
    }

    function fnDelete(obj) {
        var _id = $(obj).data('id');
        var _parameters = { id: _id };
        $.ajax({
            url: urldeletebyid,
            type: ""POST"",
            data: _parameters,
            success: function (data, textStatus, jqXHR) {

                if (data.status) {
                    //notification
                    Lobibox.notify('success', {
                        pauseDelayOnHover: true,
                        size: 'mini',
                        icon: 'bx bx-check-circle',
                        continueDelayOnInactiveTa");
            WriteLiteral(@"b: false,
                        position: 'bottom right',
                        msg: data.message
                    });
                    window.location.reload().delay(3000);
                }
                else {
                    Lobibox.notify('error', {
                        pauseDelayOnHover: true,
                        size: 'mini',
                        icon: 'bx bx-check-circle',
                        continueDelayOnInactiveTab: false,
                        position: 'bottom right',
                        msg: data.message
                    });
                }
            }
            , error: function (error) {
                laddaStop(l);
                Lobibox.notify('error', {
                    pauseDelayOnHover: true,
                    size: 'mini',
                    icon: 'bx bx-check-circle',
                    continueDelayOnInactiveTab: false,
                    position: 'bottom right',
                    msg: """);
#nullable restore
#line 127 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Areas\SuperAdmin\Views\RequestType\Index.cshtml"
                     Write(MessageHelper.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                });\r\n            }\r\n        });\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISGrid> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
