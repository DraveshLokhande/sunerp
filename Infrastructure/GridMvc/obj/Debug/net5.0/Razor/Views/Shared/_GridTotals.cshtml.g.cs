#pragma checksum "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ff62a876866d7003e2399ee420dde08b2189b555bf4a17d4aef8680bdfd645a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GridTotals), @"mvc.1.0.view", @"/Views/Shared/_GridTotals.cshtml")]
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
#line 1 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
using GridCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
using GridCore.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
using GridShared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
using GridShared.Columns;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ff62a876866d7003e2399ee420dde08b2189b555bf4a17d4aef8680bdfd645a3", @"/Views/Shared/_GridTotals.cshtml")]
    #nullable restore
    public class Views_Shared__GridTotals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISGrid>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
 if (Model == null) { return; }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
  
    var firstColumn = (ITotalsColumn)Model.Columns.FirstOrDefault();
    bool hasSubGrid = Model.SubGridKeys != null && Model.SubGridKeys.Length > 0;
    bool requiredTotalsColumn = firstColumn != null
              && (firstColumn.IsSumEnabled || firstColumn.IsAverageEnabled
                  || firstColumn.IsMaxEnabled || firstColumn.IsMinEnabled);
    string cssStyles = "";
    if (Model.Direction == GridDirection.RTL)
        cssStyles = string.Concat(cssStyles, " text-align:right;direction:rtl;").Trim();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
 if (Model.RenderOptions.RenderRowsOnly)
{
    return;
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr class=\"grid-row\"><td class=\"grid-cell\" style=\"height:25px;border:none;background-color:white\"></td></tr>\r\n");
#nullable restore
#line 27 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
    if (Model.IsSumEnabled)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"grid-totals-row\">\r\n");
#nullable restore
#line 30 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             if (hasSubGrid)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"grid-cell\" data-name=\"\"></td>\r\n");
#nullable restore
#line 33 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             if (requiredTotalsColumn)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 1142, "\"", 1160, 1);
#nullable restore
#line 36 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 1150, cssStyles, 1150, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 36 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                       Write(Strings.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 37 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             for (int i = 0; i < Model.Columns.Count(); i++)
            {
                var column = (ITotalsColumn)Model.Columns.ElementAt(i);
                if (i == 0 && !column.IsSumEnabled && !column.IsAverageEnabled
                   && !column.IsMaxEnabled && !column.IsMinEnabled)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 1562, "\"", 1580, 1);
#nullable restore
#line 44 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 1570, cssStyles, 1570, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 44 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                           Write(Strings.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 45 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                }
                else
                {
                    if (column.IsSumEnabled)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"grid-cell purchaseorderamount\" previouscost=\"0\" previousqty=\"0\" title=\"0\" totalamount=\"0\"");
            BeginWriteAttribute("style", " style=\"", 1861, "\"", 1879, 1);
#nullable restore
#line 50 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 1869, cssStyles, 1869, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 50 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                                                                                                              Write(column.SumString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 51 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                    }
                    else
                    {
                        if (((IGridColumn)column).Hidden)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"grid-cell\" style=\"display:none;\"></td>\r\n");
#nullable restore
#line 57 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 2282, "\"", 2300, 1);
#nullable restore
#line 60 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 2290, cssStyles, 2290, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n");
#nullable restore
#line 61 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                        }
                    }
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 67 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
    }
    if (Model.IsAverageEnabled)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"grid-totals-row\">\r\n");
#nullable restore
#line 71 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             if (hasSubGrid)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"grid-cell\" data-name=\"\"></td>\r\n");
#nullable restore
#line 74 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             if (requiredTotalsColumn)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 2705, "\"", 2723, 1);
#nullable restore
#line 77 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 2713, cssStyles, 2713, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 77 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                       Write(Strings.Average);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 78 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             for (int i = 0; i < Model.Columns.Count(); i++)
            {
                var column = (ITotalsColumn)Model.Columns.ElementAt(i);
                if (i == 0 && !column.IsSumEnabled && !column.IsAverageEnabled
                   && !column.IsMaxEnabled && !column.IsMinEnabled)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 3129, "\"", 3147, 1);
#nullable restore
#line 85 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 3137, cssStyles, 3137, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 85 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                           Write(Strings.Average);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 86 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                }
                else
                {
                    if (column.IsAverageEnabled)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 3357, "\"", 3375, 1);
#nullable restore
#line 91 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 3365, cssStyles, 3365, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 91 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                               Write(column.AverageString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 92 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                    }
                    else
                    {
                        if (((IGridColumn)column).Hidden)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"grid-cell\" style=\"display:none;\"></td>\r\n");
#nullable restore
#line 98 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 3782, "\"", 3800, 1);
#nullable restore
#line 101 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 3790, cssStyles, 3790, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n");
#nullable restore
#line 102 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                        }
                    }
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 107 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
    }
    if (Model.IsMaxEnabled)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"grid-totals-row\">\r\n");
#nullable restore
#line 111 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             if (hasSubGrid)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"grid-cell\" data-name=\"\"></td>\r\n");
#nullable restore
#line 114 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             if (requiredTotalsColumn)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 4199, "\"", 4217, 1);
#nullable restore
#line 117 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 4207, cssStyles, 4207, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 117 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                       Write(Strings.Max);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 118 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             for (int i = 0; i < Model.Columns.Count(); i++)
            {
                var column = (ITotalsColumn)Model.Columns.ElementAt(i);
                if (i == 0 && !column.IsSumEnabled && !column.IsAverageEnabled
                   && !column.IsMaxEnabled && !column.IsMinEnabled)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 4619, "\"", 4637, 1);
#nullable restore
#line 125 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 4627, cssStyles, 4627, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 125 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                           Write(Strings.Max);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 126 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                }
                else
                {
                    if (column.IsMaxEnabled)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 4839, "\"", 4857, 1);
#nullable restore
#line 131 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 4847, cssStyles, 4847, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 131 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                               Write(column.MaxString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 132 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                    }
                    else
                    {
                        if (((IGridColumn)column).Hidden)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"grid-cell\" style=\"display:none;\"></td>\r\n");
#nullable restore
#line 138 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 5260, "\"", 5278, 1);
#nullable restore
#line 141 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 5268, cssStyles, 5268, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n");
#nullable restore
#line 142 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                        }
                    }
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 147 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
    }
    if (Model.IsMinEnabled)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"grid-totals-row\">\r\n");
#nullable restore
#line 151 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             if (hasSubGrid)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"grid-cell\" data-name=\"\"></td>\r\n");
#nullable restore
#line 154 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             if (requiredTotalsColumn)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 5677, "\"", 5695, 1);
#nullable restore
#line 157 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 5685, cssStyles, 5685, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 157 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                       Write(Strings.Min);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 158 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
             for (int i = 0; i < Model.Columns.Count(); i++)
            {
                var column = (ITotalsColumn)Model.Columns.ElementAt(i);
                if (i == 0 && !column.IsSumEnabled && !column.IsAverageEnabled
                   && !column.IsMaxEnabled && !column.IsMinEnabled)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 6097, "\"", 6115, 1);
#nullable restore
#line 165 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 6105, cssStyles, 6105, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 165 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                           Write(Strings.Min);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 166 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                }
                else
                {
                    if (column.IsMinEnabled)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 6317, "\"", 6335, 1);
#nullable restore
#line 171 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 6325, cssStyles, 6325, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 171 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                                                               Write(column.MinString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 172 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                    }
                    else
                    {
                        if (((IGridColumn)column).Hidden)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"grid-cell\" style=\"display:none;\"></td>\r\n");
#nullable restore
#line 178 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"grid-cell\"");
            BeginWriteAttribute("style", " style=\"", 6738, "\"", 6756, 1);
#nullable restore
#line 181 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
WriteAttributeValue("", 6746, cssStyles, 6746, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n");
#nullable restore
#line 182 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
                        }
                    }
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 187 "D:\AksharItSolution\M2LERP Detail\ERP Backup\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridTotals.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
