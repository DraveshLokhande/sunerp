#pragma checksum "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cf3d87c624ed09796682bfb0f614414e448d0bfdb6a6178cc1c34275a56ad6d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_OurProduct_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/OurProduct/Index.cshtml")]
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
#line 1 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using Business.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using Business.SQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using ERP.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using ERP.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using ERP.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using Business.Entities.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cf3d87c624ed09796682bfb0f614414e448d0bfdb6a6178cc1c34275a56ad6d7", @"/Areas/Admin/Views/OurProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"66ca4ed4d968d0cb63ad96b0820d0f1f680273fdde74e92383c120d6a96a5604", @"/Areas/Admin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_OurProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Business.Entities.ProductPhotoPath.ProductPhotoPath>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OurProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GoForRFQCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
  
    ViewData["Title"] = "Our Product Images";
    Layout = "~/Views/Shared/_LayoutMaster.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-12 col-md-12 col-lg-12 mx-auto"">
            <div class=""card border-0 shadow rounded-3"">
                <div class=""card-body"">
                    <div class=""row ProductImageUpload"">
                        <div class=""ps-3 col-md-6"">
                            <nav aria-label=""breadcrumb"">
                                <ol class=""breadcrumb mb-0 p-0"">
                                    <li class=""breadcrumb-item"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf3d87c624ed09796682bfb0f614414e448d0bfdb6a6178cc1c34275a56ad6d77626", async() => {
                WriteLiteral("<i class=\"bx bx-home-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </li>
                                    <li class=""breadcrumb-item active"" aria-current=""page"">Our Product</li>
                                </ol>
                            </nav>
                        </div>
                        <div class=""col-md-6 text-align-right"">

");
#nullable restore
#line 26 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
                              
                                string CollectionID = @HttpContextAccessor.HttpContext.Session.GetString("ItemCollectionID");
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
                             if (!string.IsNullOrEmpty(CollectionID))
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf3d87c624ed09796682bfb0f614414e448d0bfdb6a6178cc1c34275a56ad6d710323", async() => {
                WriteLiteral("Go For RFQ Card");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CollectionID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
                                                                                                                      WriteLiteral(CollectionID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CollectionID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CollectionID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CollectionID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 34 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                    <hr />\r\n                    <div class=\"lightbox\">\r\n                        <div class=\"row pt-1\">\r\n                            <div class=\"col-md-12\">\r\n");
            WriteLiteral("\r\n                                <div class=\"row\" id=\"imagesLoop\">\r\n");
#nullable restore
#line 48 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
                                     foreach (var items in Model)
                                    {
                                        var productImageText = @items.ProductImageText.Replace(".jpeg", "").Replace(".jpg", "").Replace(".png", "");
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-sl-12 col-md-4 col-lg-4 col-xl-4 my-2"">
                                            <div class=""card"">
                                                <a href=""#"" class=""pop"">
                                                    <img id=""img01""");
            BeginWriteAttribute("src", " src=\"", 2708, "\"", 2760, 1);
#nullable restore
#line 54 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
WriteAttributeValue("", 2714, Html.DisplayFor(modelItem => items.ImagePath), 2714, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top rounded-circle mx-auto d-block border border-dark mt-3"" alt=""Wire Images"" style=""width:180px; height:180px;"">
                                                </a>
                                                <div class=""card-body text-center"">
                                                    <h5>");
#nullable restore
#line 57 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
                                                   Write(productImageText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n\r\n\r\n\r\n\r\n                                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3176, "\"", 3219, 3);
            WriteAttributeValue("", 3186, "openImages(", 3186, 11, true);
#nullable restore
#line 63 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
WriteAttributeValue("", 3197, items.ProductImageID, 3197, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3218, ")", 3218, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"" class=""btn"">
                                                        <iconify-icon icon=""bi:images"" style=""font-size: 20px;"" title=""Images""></iconify-icon>
                                                    </a>&emsp;


                                                    <a class=""btn""");
            BeginWriteAttribute("onclick", " onclick=\"", 3567, "\"", 3627, 3);
            WriteAttributeValue("", 3577, "fnOurProductImageMoreDetail(", 3577, 28, true);
#nullable restore
#line 68 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
WriteAttributeValue("", 3605, items.ProductImageID, 3605, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3626, ")", 3626, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"
                                                       href=""javascript:void(0)""
                                                       data-key=""0""
                                                       data-bs-toggle=""offcanvas""
                                                       data-bs-target=""#canvas_OurProductImageMoreDetail""
                                                       aria-controls=""canvas_OurProductImageMoreDetail"">
                                                        <iconify-icon icon=""icon-park-solid:view-grid-detail"" style=""font-size: 20px;"" title=""More Detail""></iconify-icon>
                                                    </a>
                                                    &emsp;


                                                    <a class=""btn""");
            BeginWriteAttribute("onclick", " onclick=\"", 4437, "\"", 4487, 3);
            WriteAttributeValue("", 4447, "fnOurProductImage(", 4447, 18, true);
#nullable restore
#line 79 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
WriteAttributeValue("", 4465, items.ProductImageID, 4465, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4486, ")", 4486, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"
                                                       href=""javascript:void(0)""
                                                       data-key=""0""
                                                       data-bs-toggle=""offcanvas""
                                                       data-bs-target=""#canvas_OurProductImage""
                                                       aria-controls=""canvas_OurProductImage"">
                                                        <iconify-icon icon=""uil:file-info-alt"" style=""font-size: 20px;"" title=""Add to RFQ Cart""></iconify-icon>
                                                    </a>


                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 92 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""canvas_OurProductImage"">
    <div class=""offcanvas-header"">
        <h5 class=""offcanvas-title"" id=""canvasHeaderPackage"">Add Product</h5>
        <button type=""button"" class=""btn-close te  xt-reset"" data-bs-dismiss=""offcanvas"" aria-l abel=""Close""></button>
    </div>
    <div class=""offcanvas-body pt-3 pb-5"">
        <div id=""dvInfo"">
        </div>
    </div>
</div>

<div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""canvas_OurProductImageMoreDetail"">
    <div class=""offcanvas-header"">
        <h5 class=""offcanvas-title"" id=""canvasHeaderPackage"">Product Detail</h5>
        <button type=""button"" class=""btn-close te  xt-reset"" data-bs-dismiss=""offcanvas"" aria-l abel=""Close""></button>
    </div>
    <div class=""offcanvas-");
            WriteLiteral(@"body pt-3 pb-5"">
        <div id=""dvInfoMD"">
        </div>
    </div>
</div>


<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-scrollable"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">productImageText</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ...
            </div>
");
            WriteLiteral(@"        </div>
    </div>
</div>


<div class=""modal fade"" id=""imagemodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-body"">
");
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 7696, "\"", 7702, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""imagepreview"" style=""width: 100%;"">
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">



    $(function () {
        $('.pop').on('click', function () {
            $('.imagepreview').attr('src', $(this).find('img').attr('src'));
            $('#imagemodal').modal('show');
        });
    });

    function openImages(ProductImageID) {
        var _id = ProductImageID;
    }

    var urladd = '");
#nullable restore
#line 173 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
             Write(Url.Action("Get", "OurProduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var urlGoForRFQ = \'");
#nullable restore
#line 174 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\ERP\Areas\Admin\Views\OurProduct\Index.cshtml"
                  Write(Url.Action("GoForRFQCard", "OurProduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    function fnOurProductImage(id) {
        // alert(_itemName);
        //var _key = $(obj).data('key');
        var _id = id;
        var _parameters = { id: _id };//, itemName: _itemName
        //if (obj > 0)
        //    document.getElementById(""canvasHeaderPackage"").innerHTML = ""Add Product"";
        //else
        //    document.getElementById(""canvasHeaderPackage"").innerHTML = ""Update Product"";
        $.ajax({
            url: urladd,
            type: ""GET"",
            data: _parameters,
            success: function (data, textStatus, jqXHR) {
                $('#dvInfo').html(data);
                $(""#canvas_OurProductImage"").show();//('hide');
            }
        });
    }

    function fnGoForRFQCard(collectionID) {
        // alert(_itemName);
        //var _key = $(obj).data('key');
        var _parameters = { collactionId: collectionID };//, itemName: _itemName
        //if (obj > 0)
        //    document.getElementById(""canvasHeaderPackage"").innerHTML = ""A");
            WriteLiteral(@"dd Product"";
        //else
        //    document.getElementById(""canvasHeaderPackage"").innerHTML = ""Update Product"";
        $.ajax({
            url: urlGoForRFQ,
            type: ""GET"",
            data: _parameters,
            success: function (data, textStatus, jqXHR) {
                //$('#dvInfo').html(data);
                //$(""#canvas_OurProductImage"").show();//('hide');
            }
        });
    }

    function fnOurProductImageMoreDetail(id) {
        // alert(_itemName);
        //var _key = $(obj).data('key');
        var _id = id;
        var _parameters = { id: _id };//, itemName: _itemName
        if (obj > 0)
            document.getElementById(""canvasHeaderPackage"").innerHTML = ""If Product Detail"";
        else
            document.getElementById(""canvasHeaderPackage"").innerHTML = ""Else Product Detail"";
        $.ajax({
            url: urladd,
            type: ""GET"",
            data: _parameters,
            success: function (data, textStatus, jqXHR) ");
            WriteLiteral(@"{
                $('#dvInfoMD').html(data);
                $(""#canvas_OurProductImageMoreDetail"").show();//('hide');
            }
        });
    }

    $(function () {
        var myModal = document.getElementById('myModal')
        var myInput = document.getElementById('myInput')

        myModal.addEventListener('shown.bs.modal', function () {
            myInput.focus()
        })
    });

                    //function fnOurProductImage(productImageText) {
                    //    debugger;
                    //    var _id = productImageText;//$(this).data('id');
                    //    var _customerId = $(""#ProductImageID"").val();
                    //    debugger;
                    //    if (_id > 0) {
                    //        document.getElementById(""canvasHeaderPackage"").innerHTML = ""Update Customer Contact Person"";
                    //    }
                    //    else {
                    //        document.getElementById(""canvasHeaderPackage"").innerHTML");
            WriteLiteral(@" = ""Add Customer Contact Person"";
                    //    }
                    //    var _parameters = { customerContactID: _id, customerId: _customerId };
                    //    $.ajax({
                    //        url: urladd,
                    //        type: ""GET"",
                    //        data: _parameters,
                    //        success: function (data, textStatus, jqXHR) {
                    //            $(""#canvas_OurProductImage"").show();//('hide');
                    //            $('#dvInfo').html(data);
                    //        }
                    //    });
                    //}


</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Business.Entities.ProductPhotoPath.ProductPhotoPath>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
