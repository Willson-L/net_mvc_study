#pragma checksum "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86a78e91139fd7cd27617487b9d4c95a459ae738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BMS_Module_Index), @"mvc.1.0.view", @"/Views/BMS_Module/Index.cshtml")]
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
#line 1 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\_ViewImports.cshtml"
using BmsWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\_ViewImports.cshtml"
using BmsWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a78e91139fd7cd27617487b9d4c95a459ae738", @"/Views/BMS_Module/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"930af88a41bd15cd762991f79efff8b247b99d1e", @"/Views/_ViewImports.cshtml")]
    public class Views_BMS_Module_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BmsWeb.Models.BMS_module>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n    var chdatas = [];\r\n    function getdata() {\r\n            $.ajax({\r\n                url: \'");
#nullable restore
#line 9 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                 Write(Url.Action("GetData", "BMS_Module"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: ""GET"",
                dataType: 'json',
                async: true,
                data:'',
                success: function (data) {
                    chdatas = data;
                    console.log(chdatas);
                    console.log(chdatas[1]);

                    google.charts.load('current', { 'packages': ['corechart'] });
                    google.charts.setOnLoadCallback(drawChart);
                }
            });
        }
    function drawChart() {
        data1 = 'V1(v)';
        data2 = 'V2(v)';
        data3 = 'V3(v)';
        data4 = 'V4(v)';
        data5 = 'V5(v)';
        data6 = 'V6(v)';
        data7 = 'V7(v)';
        data8 = 'V8(v)';
      
        dataTable = new google.visualization.DataTable();
        dataTable.addColumn('string', 'Time');
        dataTable.addColumn('number', data1);
        dataTable.addColumn('number', data2);
        dataTable.addColumn('number', data3);
        dataTable.addColumn('number', da");
            WriteLiteral(@"ta4);
        dataTable.addColumn('number', data5);
        dataTable.addColumn('number', data6);
        dataTable.addColumn('number', data7);
        dataTable.addColumn('number', data8);

        for (i in chdatas) {
            console.log(chdatas[i].V1)
            dataTable.addRows([[i + '', chdatas[i].V1, chdatas[i].V2, chdatas[i].V3, chdatas[i].V4, chdatas[i].V5, chdatas[i].V6, chdatas[i].V7, chdatas[i].V8]]);
        }
        options = {
            title: '趨勢圖',
            pointSize: 2,
            height: 280,
            legend: { position: 'bottom' },
            hAxis: {
                title: 'Time(max15min)',
                maxValue: 600,

            },
            vAxis: {
                title: 'value',

            }
        };
        chart = new google.visualization.LineChart(document.getElementById('mainchart'));

        chart.draw(dataTable, options);
        dataTable = null;
        chart = null;
    }
function chartnow() {
    getdata();
}
</scr");
            WriteLiteral(@"ipt>
<script type=""text/javascript"">
    $(document).ready(function () {
        getdata();
        var myVar2 = setInterval(function () {
                chartnow();
                //re();
            }, 3000);
    });   
</script>
<div id=""somediv""></div>
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""panel panel-info table-responsive scroll"" style=""border-width:3px;border-style:dashed;border-color:#A9A9A9;padding:5px;"">
                <div class=""panel-heading  text-center"" style=""background-color:mediumseagreen""><span style=""font-size:24px"">BMS</span></div>
                <table class=""table"" style=""text-align:center;"">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 92 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 95 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 98 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 101 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 104 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 107 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 110 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 113 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 118 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                         foreach (var item in Model)
                        {
                            var V1 = @Html.DisplayFor(modelItem => item.V1);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 123 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                                Write(V1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 126 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 129 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 132 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 135 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 138 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 141 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 144 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 147 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 155 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 158 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 161 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 164 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 167 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 170 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 173 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 176 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 181 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 185 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 188 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 191 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 194 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 197 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 200 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 203 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 206 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 209 "d:\Users\youhao\Desktop\新增資料夾 (2)\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
        <div class=""col-md-6"">

            <div id=""mainchart"" style=""width: 800px; height: 300px;border-width:3px;border-style:dashed;border-color:#A9A9A9;padding:5px;""></div>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BmsWeb.Models.BMS_module>> Html { get; private set; }
    }
}
#pragma warning restore 1591
