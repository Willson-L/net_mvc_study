#pragma checksum "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9324e2c7db2c772e7c44116b7db189ffe7e3364f"
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
#line 1 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\_ViewImports.cshtml"
using BmsWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\_ViewImports.cshtml"
using BmsWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9324e2c7db2c772e7c44116b7db189ffe7e3364f", @"/Views/BMS_Module/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"930af88a41bd15cd762991f79efff8b247b99d1e", @"/Views/_ViewImports.cshtml")]
    public class Views_BMS_Module_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BmsWeb.Models.BMS_module>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Vall", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Tall", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("serch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n    var chdatas = [];\r\n    var chdatas2 = [];\r\n    function getdata() {\r\n            $.ajax({\r\n                url: \'");
#nullable restore
#line 10 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
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
                    google.charts.load('current', { 'packages': ['corechart'] });
                    google.charts.setOnLoadCallback(drawChart);
                }
            });
    }
    function putdata(date1,date2,value) {
        $.ajax({
            url: '");
#nullable restore
#line 25 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
             Write(Url.Action("PostData", "BMS_Module"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'post',
            async: true,
            dataType: 'json',
            data: { date1: date1, date2: date2,value:value},
            success: function (data) {
                chdatas2 = data;
                console.log(chdatas2);
                console.log(value);
                console.log(date1);
                console.log(date2);
                google.charts.load('current', { 'packages': ['corechart'] });
                if (value === ""Vall"") {
                    google.charts.setOnLoadCallback(drawhistoryChart(1));
                }
                else if(value === ""Tall"") {
                    google.charts.setOnLoadCallback(drawhistoryChart(2));
                }
            }           
            });
    }
    function drawChart(status) {
        data1 = 'V1(v)';
        data2 = 'V2(v)';
        data3 = 'V3(v)';
        data4 = 'V4(v)';
        data5 = 'V5(v)';
        data6 = 'V6(v)';
        data7 = 'V7(v)';
        data8 = 'V8(v)';
    ");
            WriteLiteral(@"    dataTable = new google.visualization.DataTable();
        dataTable.addColumn('string', 'Time');
        dataTable.addColumn('number', data1);
        dataTable.addColumn('number', data2);
        dataTable.addColumn('number', data3);
        dataTable.addColumn('number', data4);
        dataTable.addColumn('number', data5);
        dataTable.addColumn('number', data6);
        dataTable.addColumn('number', data7);
        dataTable.addColumn('number', data8);
        for (i in chdatas) {
            dataTable.addRows([[i + '', chdatas[i].V1, chdatas[i].V2, chdatas[i].V3, chdatas[i].V4, chdatas[i].V5, chdatas[i].V6, chdatas[i].V7, chdatas[i].V8]]);
        }       
        options = {
            title: '即時趨勢圖',
            pointSize: 2,
            height: 280,
            legend: { position: 'bottom' },
            hAxis: {
                title: 'Time(max15min)',
                maxValue: 600,

            },
            vAxis: {
                title: 'value',

            }");
            WriteLiteral(@"
        };
        chart = new google.visualization.LineChart(document.getElementById('mainchart')); 
        chart.draw(dataTable, options);
        dataTable = null;
        chart = null;
        chdatas = [];
    }    
    function drawhistoryChart(status) {
        if (status ===1) {
            data1 = 'V1(v)';
            data2 = 'V2(v)';
            data3 = 'V3(v)';
            data4 = 'V4(v)';
            data5 = 'V5(v)';
            data6 = 'V6(v)';
            data7 = 'V7(v)';
            data8 = 'V8(v)';
        }
        else if (status ===2) {
            data1 = 'T1';
            data2 = 'T2';
            data3 = 'T3';
            data4 = 'T4';
            data5 = 'T5';
            data6 = 'T6';
            data7 = 'T7';
            data8 = 'T8';
        }      
        dataTable = new google.visualization.DataTable();
        dataTable.addColumn('string', 'Time');
        dataTable.addColumn('number', data1);
        dataTable.addColumn('number', data2);
       ");
            WriteLiteral(@" dataTable.addColumn('number', data3);
        dataTable.addColumn('number', data4);
        dataTable.addColumn('number', data5);
        dataTable.addColumn('number', data6);
        dataTable.addColumn('number', data7);
        dataTable.addColumn('number', data8);


        if (status ===1) {
            for (i in chdatas2) {
                dataTable.addRows([[i + '', chdatas2[i].V1, chdatas2[i].V2, chdatas2[i].V3, chdatas2[i].V4, chdatas2[i].V5, chdatas2[i].V6, chdatas2[i].V7, chdatas2[i].V8]]);
            }
        }
        else if (status ===2) {
            for (i in chdatas2) {
                dataTable.addRows([[i + '', chdatas2[i].T1, chdatas2[i].T2, chdatas2[i].T3, chdatas2[i].T4, chdatas2[i].T5, chdatas2[i].T6, chdatas2[i].T7, chdatas2[i].T8]]);
            }
        }
        options = {
            title: '即時趨勢圖',
            pointSize: 2,
            height: 280,
            legend: { position: 'bottom' },
            hAxis: {
                title: 'Time(max15min)',");
            WriteLiteral(@"
                maxValue: 600,

            },
            vAxis: {
                title: 'value',

            }
        };
        chart = new google.visualization.LineChart(document.getElementById('curve_chart')); 
        chart.draw(dataTable, options);
        dataTable = null;
        chart = null;
        chdatas = [];
    }    
    function spinnerList(selector) {
    $(selector).empty();
    if (selector === '#hh' || selector === '#hh2') {
        for (var i = 0; i <= 23; i++) {
            $(selector).append('<option value=' + '""' + i + '""' + 'selected=""selected""  >' + i + '</option>');
        }
    }
    else if (selector === '#mm' || selector === '#mm2') {
        for (i = 0; i <= 59; i++) {
            $(selector).append('<option value=' + '""' + i + '""' + 'selected=""selected""  >' + i + '</option>');
        }
    }
    }
    function selectsetting() {
    var search = document.getElementById(""search"");
    var searchselect = search.searchselect.value;
    console");
            WriteLiteral(@".log(searchselect);   
}
    function searchdata() {
        var search = document.getElementById(""search"");
        var searchselect = search.searchselect.value;
        var y = search.idYear.value;
        var m = search.idMonth.value;
        var d = search.idDay.value;
        var y2 = search.idYear2.value;
        var m2 = search.idMonth2.value;
        var d2 = search.idDay2.value;
        var hh = search.hh.value;
        var mm = search.mm.value;
        var hh2 = search.hh2.value;
        var mm2 = search.mm2.value;
        var date1 = y + ""-"" + m + ""-"" + d + "" "" + hh+"":""+mm+"":""+""00.000"";
        var date2 = y2 + ""-"" + m2 + ""-"" + d2 + "" "" + hh2 + "":"" + mm2 + "":"" + ""00.000"";
        putdata(date1, date2, searchselect);
}
</script>
<script type=""text/javascript"">
    $(document).ready(function () {
        getdata();
        spinnerList('#hh');
        spinnerList('#hh2');
        spinnerList('#mm');
        spinnerList('#mm2');
        var myVar2 = setInterval(function () {");
            WriteLiteral(@"
                getdata();
                //re();
            }, 3000);
    });   
</script>
<div id=""somediv""></div>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""col-md-6"">
            <div class=""panel panel-info table-responsive scroll"" style=""border-width:3px;border-style:dashed;border-color:#A9A9A9;padding:5px;"">
                <div class=""panel-heading  text-center"" style=""background-color:mediumseagreen""><span style=""font-size:24px"">BMS</span></div>
                <table class=""table"" style=""text-align:center;"">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 212 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 215 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 218 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 221 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 224 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 227 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 230 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 233 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.V8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 238 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                         foreach (var item in Model)
                        {
                            var V1 = @Html.DisplayFor(modelItem => item.V1);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 243 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                                Write(V1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 246 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 249 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 252 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 255 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 258 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 261 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 264 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.V8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 267 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 275 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 278 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 281 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 284 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 287 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 290 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 293 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 296 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.T8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 301 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 305 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 308 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 311 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 314 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 317 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 320 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 323 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 326 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.T8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 329 "D:\Users\user\Desktop\net_mvc_study\net_core\BmsWeb\BmsWeb\BmsWeb\Views\BMS_Module\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
        <div class="" col-md-6""></div><br />
    </div>
    <div class=""col-md-12"">
        <div id=""mainchart"" class=""panel panel-info "" style=""border-width:3px;border-style:dashed;border-color:#A9A9A9;padding:5px;""></div>
        <br />
    </div>
    <div class=""row"">
        <div class=""col-md-4"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9324e2c7db2c772e7c44116b7db189ffe7e3364f28009", async() => {
                WriteLiteral(@"
                <div class="" card"" style="" border-width:3px;border-style:dashed;border-color:#A9A9A9;padding:5px;background-color:white;"">
                    <div class=""card-header text-center"" style=""font-size: 18px;"">搜尋條件</div>
                    <div class=""card-body"">
                        <div class=""col-md-12text-center"">
                            <select class=""form-control"" id=""searchselect"" onclick=""selectsetting()"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9324e2c7db2c772e7c44116b7db189ffe7e3364f28759", async() => {
                    WriteLiteral("Vall");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9324e2c7db2c772e7c44116b7db189ffe7e3364f30013", async() => {
                    WriteLiteral("Tall");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"                                
                            </select>
                            <br />
                        </div>
                        <div class=""row text-center"">
                            <div class=""col-12"">起始時間</div>
                            <div class=""col-4"">
                                <span style=""font-size: 15px; font-family: Microsoft JhengHei;"">年</span>
                                <select class=""form-control"" id=""idYear""></select>
                            </div>
                            <div class=""col-4"">
                                <span style=""font-size: 15px; font-family: Microsoft JhengHei;"">月</span>
                                <select class=""form-control"" id=""idMonth""></select>
                            </div>
                            <div class=""col-4 "">
                                <span style=""font-size: 15px; font-family: Microsoft JhengHei;"">日</span>
                                <select class=""form-control"" ");
                WriteLiteral(@"id=""idDay""></select>
                            </div>
                            <div class=""col-12"">時間</div>
                            <div class=""form-group col-md-4"">
                                <select class=""form-control"" id=""hh""></select>
                            </div>
                            <div class=""form-group col-md-2""><label>點</label></div>
                            <div class=""form-group col-md-4"">
                                <select class=""form-control"" id=""mm""></select>
                            </div>
                            <div class=""form-group col-md-2""><label>分</label></div>
                            <script>
                                var ds = new DateSelector(""idYear"", ""idMonth"", ""idDay"", {
                                    MaxYear: new Date().getFullYear() + 12,
                                    onChange: function () { $$(""idShow"").innerHTML = this.Year + ""/"" + this.Month + ""/"" + this.Day; }
                                }).onlo");
                WriteLiteral(@"ad; ds.onChange();</script>

                            <div class=""col-12"">結束時間</div>
                            <div class=""col-4"">
                                <span style=""font-size: 15px; font-family: Microsoft JhengHei;"">年</span>
                                <select class=""form-control"" id=""idYear2""></select>
                            </div>
                            <div class=""col-4"">
                                <span style=""font-size: 15px; font-family: Microsoft JhengHei;"">月</span>
                                <select class=""form-control"" id=""idMonth2""></select>
                            </div>
                            <div class=""col-4 "">
                                <span style=""font-size: 15px; font-family: Microsoft JhengHei;"">日</span>
                                <select class=""form-control"" id=""idDay2""></select>
                            </div>
                            <div class=""col-12"">時間</div>
                            <div class=""form-g");
                WriteLiteral(@"roup col-md-4"">
                                <select class=""form-control"" id=""hh2""></select>
                            </div>
                            <div class=""form-group col-md-2""><label>點</label></div>
                            <div class=""form-group col-md-4"">
                                <select class=""form-control"" id=""mm2""></select>
                            </div>
                            <div class=""form-group col-md-2""><label>分</label></div>
                            <script>
                                var ds2 = new DateSelector(""idYear2"", ""idMonth2"", ""idDay2"", {
                                    MaxYear: new Date().getFullYear() + 12,
                                    onChange: function () { $$(""idShow"").innerHTML = this.Year + ""/"" + this.Month + ""/"" + this.Day; }
                                }).onload; ds2.onChange();</script>
                            <div class=""col-12 text-center"">
                                <button id=""btPause"" type=""butto");
                WriteLiteral(@"n"" class=""btn btn-info "" onclick=""searchdata()""><span class=""glyphicon glyphicon-search"" aria-hidden=""true""></span>搜尋</button>
                            </div>
                        </div>
            
                    </div>
                </div>            
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class="" col-md-8 text-center"">
            <div class=""card"" style="" border-width:3px;border-style:dashed;border-color:#A9A9A9;padding:5px;background-color:white;"">
                <div class=""card-header"" style=""font-size: 18px;"">歷史趨勢圖</div>
                <div class=""card-body"">
                    <div id=""curve_chart""></div>
                </div>
            </div>
        </div>
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
