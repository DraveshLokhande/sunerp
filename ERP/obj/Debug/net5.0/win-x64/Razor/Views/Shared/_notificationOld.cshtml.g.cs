#pragma checksum "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\Shared\_notificationOld.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a14cbf741a448273bdddbb7c9c837f37b5e3e1e7074dd78ddf3cc2ba9dfae331"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__notificationOld), @"mvc.1.0.view", @"/Views/Shared/_notificationOld.cshtml")]
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
#line 1 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\_ViewImports.cshtml"
using ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\_ViewImports.cshtml"
using Business.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\_ViewImports.cshtml"
using Business.SQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\_ViewImports.cshtml"
using ERP.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\_ViewImports.cshtml"
using ERP.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\_ViewImports.cshtml"
using ERP.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\_ViewImports.cshtml"
using Business.Entities.Dynamic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a14cbf741a448273bdddbb7c9c837f37b5e3e1e7074dd78ddf3cc2ba9dfae331", @"/Views/Shared/_notificationOld.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9af2a5bd844c76fa2170a48777822dbd4537e1a6e69a69cabcf43956cc6762c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__notificationOld : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<a class=\"nav-link dropdown-toggle dropdown-toggle-nocaret position-relative\" href=\"#\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">\r\n    <span class=\"alert-count\" id=\"alertCount\"></span> ");
            WriteLiteral(@"
    <i class='bx bx-bell'></i>
</a>
<div class=""dropdown-menu dropdown-menu-end"">
    <a href=""javascript:;"">
        <div class=""msg-header"">
            <p class=""msg-header-title"">Notifications</p>
            <p class=""msg-header-clear ms-auto"">Marks all as read</p>
        </div>
    </a>
    <div class=""header-notifications-list"">
        <a class=""dropdown-item"" href=""javascript:;"">
            <div class=""d-flex align-items-center"">
                <div class=""notify bg-light-primary text-primary"">
                    <i class=""bx bx-group""></i>
                </div>
                <div class=""flex-grow-1"">
                    <h6 class=""msg-name"">
                        New Customers<span class=""msg-time float-end"">
                            14 Sec
                            ago
                        </span>
                    </h6>
                    <p class=""msg-info"">5 new user registered</p>
                </div>
            </div>
        </a>
        <a c");
            WriteLiteral(@"lass=""dropdown-item"" href=""javascript:;"">
            <div class=""d-flex align-items-center"">
                <div class=""notify bg-light-danger text-danger"">
                    <i class=""bx bx-cart-alt""></i>
                </div>
                <div class=""flex-grow-1"">
                    <h6 class=""msg-name"">
                        New Orders <span class=""msg-time float-end"">
                            2 min
                            ago
                        </span>
                    </h6>
                    <p class=""msg-info"">You have recived new orders</p>
                </div>
            </div>
        </a>
        <a class=""dropdown-item"" href=""javascript:;"">
            <div class=""d-flex align-items-center"">
                <div class=""notify bg-light-success text-success"">
                    <i class=""bx bx-file""></i>
                </div>
                <div class=""flex-grow-1"">
                    <h6 class=""msg-name"">
                        24 PDF File<s");
            WriteLiteral(@"pan class=""msg-time float-end"">
                            19 min
                            ago
                        </span>
                    </h6>
                    <p class=""msg-info"">The pdf files generated</p>
                </div>
            </div>
        </a>
        <a class=""dropdown-item"" href=""javascript:;"">
            <div class=""d-flex align-items-center"">
                <div class=""notify bg-light-warning text-warning"">
                    <i class=""bx bx-send""></i>
                </div>
                <div class=""flex-grow-1"">
                    <h6 class=""msg-name"">
                        Time Response <span class=""msg-time float-end"">
                            28 min
                            ago
                        </span>
                    </h6>
                    <p class=""msg-info"">5.1 min avarage time response</p>
                </div>
            </div>
        </a>
        <a class=""dropdown-item"" href=""javascript:;"">
           ");
            WriteLiteral(@" <div class=""d-flex align-items-center"">
                <div class=""notify bg-light-info text-info"">
                    <i class=""bx bx-home-circle""></i>
                </div>
                <div class=""flex-grow-1"">
                    <h6 class=""msg-name"">
                        New Product Approved <span class=""msg-time float-end"">2 hrs ago</span>
                    </h6>
                    <p class=""msg-info"">Your new product has approved</p>
                </div>
            </div>
        </a>
        <a class=""dropdown-item"" href=""javascript:;"">
            <div class=""d-flex align-items-center"">
                <div class=""notify bg-light-danger text-danger"">
                    <i class=""bx bx-message-detail""></i>
                </div>
                <div class=""flex-grow-1"">
                    <h6 class=""msg-name"">
                        New Comments <span class=""msg-time float-end"">
                            4 hrs
                            ago
                 ");
            WriteLiteral(@"       </span>
                    </h6>
                    <p class=""msg-info"">New customer comments recived</p>
                </div>
            </div>
        </a>
        <a class=""dropdown-item"" href=""javascript:;"">
            <div class=""d-flex align-items-center"">
                <div class=""notify bg-light-success text-success"">
                    <i class='bx bx-check-square'></i>
                </div>
                <div class=""flex-grow-1"">
                    <h6 class=""msg-name"">
                        Your item is shipped <span class=""msg-time float-end"">
                            5 hrs
                            ago
                        </span>
                    </h6>
                    <p class=""msg-info"">Successfully shipped your item</p>
                </div>
            </div>
        </a>
        <a class=""dropdown-item"" href=""javascript:;"">
            <div class=""d-flex align-items-center"">
                <div class=""notify bg-light-primary text");
            WriteLiteral(@"-primary"">
                    <i class='bx bx-user-pin'></i>
                </div>
                <div class=""flex-grow-1"">
                    <h6 class=""msg-name"">
                        New 24 authors<span class=""msg-time float-end"">
                            1 day
                            ago
                        </span>
                    </h6>
                    <p class=""msg-info"">24 new authors joined last week</p>
                </div>
            </div>
        </a>
        <a class=""dropdown-item"" href=""javascript:;"">
            <div class=""d-flex align-items-center"">
                <div class=""notify bg-light-warning text-warning"">
                    <i class='bx bx-door-open'></i>
                </div>
                <div class=""flex-grow-1"">
                    <h6 class=""msg-name"">
                        Defense Alerts <span class=""msg-time float-end"">
                            2 weeks
                            ago
                        </span>");
            WriteLiteral(@"
                    </h6>
                    <p class=""msg-info"">45% less alerts last 4 weeks</p>
                </div>
            </div>
        </a>
    </div>
    <a href=""javascript:;"">
        <div class=""text-center msg-footer"">View All Notifications</div>
    </a>
</div>

<script type=""text/javascript"">
    var urlGetNotification = '");
#nullable restore
#line 161 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharerp\aksharm2l\ERP\Views\Shared\_notificationOld.cshtml"
                         Write(Url.Action("GetNotificationCount", "Notification"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    $(function () {
        // Call the updateNotificationCount function every 30 seconds
        setInterval(function () {
            // code to be executed
            $.ajax({
                url: urlGetNotification,
                type: 'GET',
                dataType: 'json',
                success: function (data, textStatus, jqXHR) {
                    var count = data.count;
                    $('#alertCount').text(count);

                    // Get the element with the class you want to disable
                    var element = document.getElementById('alert-count');

                    // Disable the class by adding a disabled class
                    element.classList.add('disabled');
                    
                    //// Create an Audio object with the path to your sound file
                    //var notificationSound = new Audio('C:/Users/Lenovo/Documents/GitHub/aksharm2l/ERP/wwwroot/audio/notification/Simple-notification.mp3');                    
       ");
            WriteLiteral(@"             
                    //// Call the play() method when you want to play the sound
                    //notificationSound.play();

                    //notificationSound.addEventListener('error', function () {
                    //    alert('Notification sound not paly');
                    //    // Code to be executed if there is an error playing the sound
                    //});
                }
            });
        }, 10000);
    });
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
