#pragma checksum "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30b2a8fd8b5c6289c5dc20e2f4db00a438c8f02f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Create_ShowPaper), @"mvc.1.0.view", @"/Views/Create/ShowPaper.cshtml")]
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
#line 1 "G:\Online Quiz\Online Quiz\Views\_ViewImports.cshtml"
using Online_Quiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Online Quiz\Online Quiz\Views\_ViewImports.cshtml"
using Online_Quiz.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30b2a8fd8b5c6289c5dc20e2f4db00a438c8f02f", @"/Views/Create/ShowPaper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff5f3ec98f2921fa5562436b4e2fd795d51f75e", @"/Views/_ViewImports.cshtml")]
    public class Views_Create_ShowPaper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Online_Quiz.Models.Paper>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowPaperDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
  
    ViewData["Title"] = "ShowPaper";
    var paper = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
 if (TempData["Success"].ToString() == "success")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-success alert-dismissible"" role=""alert"">
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
        New Quiz created Check out mail..
    </div>
");
#nullable restore
#line 14 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
   TempData["Success"] = "";

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
 if (TempData["Delete"].ToString() == "delete")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissible\" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        paper is deleted..\r\n    </div>\r\n");
#nullable restore
#line 23 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
    TempData["Delete"] = "";

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
 foreach (var item in Model)
{
    paper++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            Paper ");
#nullable restore
#line 32 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
             Write(paper);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\"");
            BeginWriteAttribute("id", " id=\"", 974, "\"", 992, 1);
#nullable restore
#line 33 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
WriteAttributeValue("", 979, item.PaperId, 979, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 40 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
               Write(Html.DisplayNameFor(item => item.PaperCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 43 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
               Write(item.PaperCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 47 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
               Write(Html.DisplayNameFor(item => item.PaperName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 50 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
               Write(item.PaperName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 53 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
               Write(Html.DisplayNameFor(item => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 56 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
               Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 59 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
               Write(Html.DisplayNameFor(item => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 62 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
               Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 65 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
               Write(Html.DisplayNameFor(item => item.Pmarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 68 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
               Write(item.Pmarks);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </dd>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b2a8fd8b5c6289c5dc20e2f4db00a438c8f02f9521", async() => {
                WriteLiteral("Show paper Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
                                                                       WriteLiteral(item.PaperId);

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
            WriteLiteral("\r\n            </dl>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 75 "G:\Online Quiz\Online Quiz\Views\Create\ShowPaper.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            console.log($('.card').find('.close'))
            $('.card').find('.close').each(function () {
                console.log($(this))
                $(this).click(function () {
                    var paperId = $(this).attr('id')
                    console.log(paperId)
                    var ans = window.confirm(""Do you want to delete??"")
                    if (ans) {
                        window.location.href = ""/Create/DeletePaper/"" + paperId;
                    }
                })

            })






        })
    </script>






");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Online_Quiz.Models.Paper>> Html { get; private set; }
    }
}
#pragma warning restore 1591
