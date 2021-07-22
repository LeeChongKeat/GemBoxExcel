#pragma checksum "C:\Users\chongkle.KEYSIGHT\source\repos\CKNoted\CKNoted\Views\GemBox\SpreadsheetSession\CreateExcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c5730c387203db96982fce0e7090d313df77052"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GemBox_SpreadsheetSession_CreateExcel), @"mvc.1.0.view", @"/Views/GemBox/SpreadsheetSession/CreateExcel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c5730c387203db96982fce0e7090d313df77052", @"/Views/GemBox/SpreadsheetSession/CreateExcel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d990a8903b9775f4ae1e50bfd00e12efec907130", @"/Views/_ViewImports.cshtml")]
    public class Views_GemBox_SpreadsheetSession_CreateExcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GemBox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetDownload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section>
    <div class=""card shadow"">
        <div class=""card-header""><h3>Create Excel File</h3></div>
        <div class=""card-body"">
            <ol>
                <li>
                    <b>Load Excel</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        ExcelFile workbook = ExcelFile.Load(""wwwroot/data/xlsx/SimpleTemplate.xlsx"");
                    </div>
                </li>
                <li>
                    <b>Create empty workbook</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        var workbook = new ExcelFile();
                    </div>
                </li>
                <li>
                    <b>Add Sheet</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        var worksheet = workbook.Worksheets.Add(""Sheet Name"");
                    </div>
                </li>
                <li>
                    <b>Ad");
            WriteLiteral(@"d cell value</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        worksheet.Cells[""A1""].Value = ""Value"";
                    </div>
                </li>
                <li>
                    <b>Set cell width</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        worksheet.Columns[""A""].SetWidth(8, LengthUnit.ZeroCharacterWidth);
                    </div>
                </li>
                <li>
                    <b>Merged cell</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        worksheet.Cells.GetSubrange(""A3:A4"").Merged = true;
                    </div>
                </li>
                <li>
                    <b>Set Style</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        style = new CellStyle();<br />
                        style.HorizontalAlignment = HorizontalAlignme");
            WriteLiteral(@"ntStyle.Center;<br />
                        style.VerticalAlignment = VerticalAlignmentStyle.Center;<br />
                        style.Font.Weight = ExcelFont.BoldWeight;<br />
                        var mergedRange = worksheet.Cells.GetSubrange(""I5:I14"");<br />
                        mergedRange.Merged = true;<br />
                        mergedRange.Value = ""T o p   1 0"";<br />
                        style.Rotation = -90;<br />
                        style.FillPattern.SetSolid(SpreadsheetColor.FromArgb(198, 239, 206));<br />
                        style.Borders.SetBorders(MultipleBorders.Right | MultipleBorders.Top, SpreadsheetColor.FromName(ColorName.Black), LineStyle.Thin);<br />
                        mergedRange.Style = style;<br />
                    </div>
                </li>
                <li>
                    <b>Save Excel</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        workbook.Save(""Writing.xlsx"");
         ");
            WriteLiteral(@"           </div>
                </li>
                <li>
                    <b>Convert to pdf</b> <br />
                    <div class=""alert alert-secondary"" role=""alert"">
                        workbook.Save(""Convert.pdf"", new PdfSaveOptions() { SelectionType = SelectionType.EntireFile });
                    </div>
                </li>
            </ol>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c5730c387203db96982fce0e7090d313df770527777", async() => {
                WriteLiteral("Donwload");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
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
