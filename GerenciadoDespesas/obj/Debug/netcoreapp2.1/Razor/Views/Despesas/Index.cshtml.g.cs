#pragma checksum "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b44f605a6237016c1d9bef0f413bed9cec3692a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Despesas_Index), @"mvc.1.0.view", @"/Views/Despesas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Despesas/Index.cshtml", typeof(AspNetCore.Views_Despesas_Index))]
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
#line 1 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\_ViewImports.cshtml"
using GerenciadoDespesas;

#line default
#line hidden
#line 2 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\_ViewImports.cshtml"
using GerenciadoDespesas.Models;

#line default
#line hidden
#line 2 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 3 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b44f605a6237016c1d9bef0f413bed9cec3692a", @"/Views/Despesas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668d4ba52970b678fbd18df48610e22182889a1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Despesas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<GerenciadoDespesas.Models.Entities.Despesas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control escolhaMes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_GastoTotalMes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/GraficoTotalMes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
  
    ViewData["Title"] = "Despesas";

#line default
#line hidden
            BeginContext(182, 94, true);
            WriteLiteral("\r\n<div class=\"tabela\">\r\n    <div class=\"container\">\r\n        <p class=\"btnNovo\">\r\n            ");
            EndContext();
            BeginContext(276, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3efdb3f0e2ff4d2da9482769bf23e20b", async() => {
                BeginContext(338, 12, true);
                WriteLiteral("Nova Despesa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 18, true);
            WriteLiteral("\r\n        </p>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
         if (TempData["Confirmacao"] != null)
        {

#line default
#line hidden
            BeginContext(430, 45, true);
            WriteLiteral("            <h6 class=\"alert alert-success \">");
            EndContext();
            BeginContext(476, 23, false);
#line 17 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
                                        Write(TempData["Confirmacao"]);

#line default
#line hidden
            EndContext();
            BeginContext(499, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 18 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(517, 242, true);
            WriteLiteral("\r\n        <div class=\"row justify-content-md-center\">\r\n            <div class=\"form-group row\">\r\n                <label class=\"col-sm-3 col-form-label\"><strong>Mês</strong></label>\r\n                <div class=\"col-sm-9\">\r\n                    ");
            EndContext();
            BeginContext(759, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93fdb48b7fe344529dee6534ae147b55", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 24 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Meses;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(834, 138, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
            EndContext();
            BeginContext(972, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6ec17f420e1f45cc85d827969b6c93b0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1005, 648, true);
            WriteLiteral(@"
            </div>
        </div>

        <div class=""tabelaPrincipal"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>
                            Meses
                        </th>
                        <th>
                            Tipo da Despesa
                        </th>
                        <th>
                            Valor
                        </th>
                        <th>
                            Ação
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 54 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1726, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1823, 45, false);
#line 58 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Meses.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1972, 52, false);
#line 61 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TipoDespesas.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2128, 40, false);
#line 64 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(2168, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2271, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29c8d73dde334a63a37e78a3f053995f", async() => {
                BeginContext(2359, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
                                                       WriteLiteral(item.DepesasId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2372, 38, true);
            WriteLiteral(" |\r\n                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2410, "\"", 2448, 3);
            WriteAttributeValue("", 2420, "ExibirModal(", 2420, 12, true);
#line 68 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
WriteAttributeValue("", 2432, item.DepesasId, 2432, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2447, ")", 2447, 1, true);
            EndWriteAttribute();
            BeginContext(2449, 118, true);
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">Excluir</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 71 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2590, 86, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2677, 227, false);
#line 78 "C:\Users\GABRIEL-WORK\Source\Repos\Gastos\GerenciadoDespesas\Views\Despesas\Index.cshtml"
Write(Html.PagedListPager(Model, pagina => Url.Action("Index", "Despesas", new { pagina }), new PagedListRenderOptionsBase
{
    LiElementClasses = new string[] { "page-item" },
    PageClasses = new string[] { "page-link" }

}));

#line default
#line hidden
            EndContext();
            BeginContext(2904, 847, true);
            WriteLiteral(@"


<div class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Excluir</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Deseja prosseguir com a exclusão desta despesa?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-primary btnExcluir"">Sim</button>
                <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Não</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3768, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3774, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e8cad35257f4a83a177530270e4e397", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3821, 571, true);
                WriteLiteral(@"
    <script>

        CarregarDadosGastosTotaisMes();

        function ExibirModal(id) {

            $("".modal"").modal();
            $("".btnExcluir"").on('click', function () {
                $.ajax({
                    url: ""Despesas/Delete"",
                    method: ""POST"",
                    data: { id: id },
                    success: function (data) {
                        $("".modal"").modal('hide');
                        location.reload(true);
                    }
                });
            });
        }
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<GerenciadoDespesas.Models.Entities.Despesas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
