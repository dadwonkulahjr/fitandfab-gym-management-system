#pragma checksum "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3e3e91f43ab90717a100a3c9af953fda56de476"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FitAndFabulous.WebUI.Pages.Gyms.Pages_Gyms_SelectGym), @"mvc.1.0.razor-page", @"/Pages/Gyms/SelectGym.cshtml")]
namespace FitAndFabulous.WebUI.Pages.Gyms
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
#line 1 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\_ViewImports.cshtml"
using FitAndFabulous.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\_ViewImports.cshtml"
using FitAndFabulous.DataAccess.Services.Repository.IRepository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e3e91f43ab90717a100a3c9af953fda56de476", @"/Pages/Gyms/SelectGym.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac71b775cd4f7e52f356e0a0eddb3cde16ea3f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Gyms_SelectGym : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .customImage {
        overflow: hidden;
    }

        .customImage img {
            transition: all 1.5s ease;
        }

        .customImage:hover img {
            transform: scale(1.5);
        }
</style>

<div class=""border backgroundWhite container shadow mb-5"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <h5 class=""text-success"">
                <i class=""fas fa-dumbbell""></i>&nbsp;SELECT GYM
            </h5>

        </div>
    </div>
    <hr />
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 32 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml"
             if (Model.Gyms.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml"
                 for (int i = 0; i < Model.Gyms.Count(); i++)
                {
                    string phonePath = "~/images/" + (Model.Gyms[i].Image ?? "no-image.png");

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card mb-2 shadow\" style=\"min-width: 18rem; max-width: 30.5%;margin:5px;\">\r\n                        <div class=\"customImage\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3e3e91f43ab90717a100a3c9af953fda56de4765861", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml"
                          WriteLiteral(phonePath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 39 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"card-body text-center\">\r\n                            <h2 class=\"text-success\">");
#nullable restore
#line 42 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml"
                                                Write(Model.Gyms[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 43 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml"
                                            Write(Model.Gyms[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3e3e91f43ab90717a100a3c9af953fda56de4768872", async() => {
                WriteLiteral("\r\n                                <i class=\"far fa-check-circle\"></i>&nbsp;Select gym\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml"
                                                      WriteLiteral(Model.Gyms[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 49 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml"
                 
            }
            else
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("No gym has been added yet.");
#nullable restore
#line 53 "C:\Users\Dad S. Wonkulah Jr\source\repos\FitAndFabulousSol\FitAndFabulous.WebUI\Pages\Gyms\SelectGym.cshtml"
                                                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FitAndFabulous.WebUI.Pages.Gyms.SelectGymModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FitAndFabulous.WebUI.Pages.Gyms.SelectGymModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FitAndFabulous.WebUI.Pages.Gyms.SelectGymModel>)PageContext?.ViewData;
        public FitAndFabulous.WebUI.Pages.Gyms.SelectGymModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591