#pragma checksum "C:\Users\chongkle.KEYSIGHT\source\repos\CKNoted\CKNoted\Views\GemBox\SpreadsheetSession\ReadExcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f9f58176de99eef45b86cd6edb0fdeff5d1b0a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GemBox_SpreadsheetSession_ReadExcel), @"mvc.1.0.view", @"/Views/GemBox/SpreadsheetSession/ReadExcel.cshtml")]
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
#line 1 "C:\Users\chongkle.KEYSIGHT\source\repos\CKNoted\CKNoted\Views\_ViewImports.cshtml"
using CKNoted;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chongkle.KEYSIGHT\source\repos\CKNoted\CKNoted\Views\_ViewImports.cshtml"
using CKNoted.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f9f58176de99eef45b86cd6edb0fdeff5d1b0a0", @"/Views/GemBox/SpreadsheetSession/ReadExcel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d990a8903b9775f4ae1e50bfd00e12efec907130", @"/Views/_ViewImports.cshtml")]
    public class Views_GemBox_SpreadsheetSession_ReadExcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section>
    <div class=""card shadow"">
        <div class=""card-header""><h3>Read Excel File</h3></div>
        <div class=""card-body"">
            <ol>
                <li>
                    <b>Load Excel</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        ExcelFile workbook = ExcelFile.Load(""wwwroot/data/xlsx/SimpleTemplate.xlsx"");
                    </div>
                </li>
                <li>
                    <b>Code</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        foreach (ExcelWorksheet worksheet in workbook.Worksheets) <br />
                        { <br />
                        &emsp;Console.WriteLine(""{1} {0} {1}\n"", worksheet.Name, new string('#', 30));<br />
                        &emsp;foreach (ExcelRow row in worksheet.Rows)<br />
                        &emsp;{<br />
                        &emsp;&emsp;foreach (ExcelCell cell in row.AllocatedCells)<br />
 ");
            WriteLiteral(@"                       &emsp;&emsp;{<br />
                        &emsp;&emsp;&emsp;string value = cell.Value?.ToString() ?? ""EMPTY"";<br />
                        &emsp;&emsp;&emsp;value = value.Length > 15 ? value.Remove(15) + ""???"" : value;<br />
                        &emsp;&emsp;&emsp;Console.Write($""{value} [{cell.ValueType}]"".PadRight(30));<br />
                        &emsp;&emsp;}<br />
                        &emsp;}<br />
                        }<br />
                    </div>
                </li>
                <li>
                    <b>Remark</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        <ul>
                            <li>
                                <b><span class=""keyword-code"">worksheet</span>.Name</b> - read sheet name <br />
                            </li>
                            <li>
                                <b><span class=""keyword-code"">worksheet</span>.Rows</b> - read Row
               ");
            WriteLiteral(@"             </li>
                            <li>
                                <b><span class=""keyword-code"">row</span>.AllocatedCells</b> - read Cell
                            </li>
                        </ul>
                    </div>
                </li>
            </ol>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
