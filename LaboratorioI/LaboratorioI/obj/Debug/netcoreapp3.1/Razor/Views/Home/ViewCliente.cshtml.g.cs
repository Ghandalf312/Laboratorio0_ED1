#pragma checksum "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6727f8078147484fb48055b366f4f76d3e2c87c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewCliente), @"mvc.1.0.view", @"/Views/Home/ViewCliente.cshtml")]
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
#line 1 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\_ViewImports.cshtml"
using LaboratorioI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\_ViewImports.cshtml"
using LaboratorioI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6727f8078147484fb48055b366f4f76d3e2c87c9", @"/Views/Home/ViewCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d6ab747fd34f1eec69a65c121ba68e9f04f5f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LaboratorioI.Models.ClienteModelo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
  
    ViewData["Title"] = "ViewCliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>ViewCliente</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6727f8078147484fb48055b366f4f76d3e2c87c93949", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.nombreC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.apellidoC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.telefonoC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.descripcionC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 31 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 34 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombreC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.apellidoC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 40 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.telefonoC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 43 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.descripcionC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 46 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 47 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 48 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 51 "C:\Users\ZeroJChang\Desktop\U 1er ciclo 2021\Estructura de datos\Laboratorio0_ED1-master\LaboratorioI\LaboratorioI\Views\Home\ViewCliente.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LaboratorioI.Models.ClienteModelo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
