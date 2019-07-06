#pragma checksum "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\Cep\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68324de377d784a62b3d9caa1826f195aa5b56d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cep_Index), @"mvc.1.0.view", @"/Views/Cep/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cep/Index.cshtml", typeof(AspNetCore.Views_Cep_Index))]
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
#line 1 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\_ViewImports.cshtml"
using AppCep;

#line default
#line hidden
#line 2 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\_ViewImports.cshtml"
using AppCep.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68324de377d784a62b3d9caa1826f195aa5b56d0", @"/Views/Cep/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c3e10b8583e31b55c3b66705159d3f541472e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Cep_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppCep.Models.Endereco>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscaCep", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\Cep\Index.cshtml"
  
    ViewData["Title"] = "Busca CEP";

#line default
#line hidden
            BeginContext(82, 103, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-xs-12\">\r\n            <h1>Busca de CEP</h1>\r\n            ");
            EndContext();
            BeginContext(185, 542, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80077411ea234605a58f2159ab31050a", async() => {
                BeginContext(226, 494, true);
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-xs-12 col-md-6"">
                        <div class=""form-group"">
                            <input type=""text"" name=""cep"" class=""form-control"" />
                        </div>
                    </div>
                </div>
                <div class=""form-group"">
                    <button type=""submit"" value=""Buscar"" class=""btn btn-md btn-success"">Pesquisar</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(727, 480, true);
            WriteLiteral(@"
            <h2>Endereços</h2>
            <table class=""table table-striped table-condensed"">
                <thead>
                    <tr>
                        <th>CEP</th>
                        <th>Logradouro</th>
                        <th>Complemento</th>
                        <th>Bairro</th>
                        <th>Localidade</th>
                        <th>UF</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 33 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\Cep\Index.cshtml"
                     foreach (var endereco in Model){

#line default
#line hidden
            BeginContext(1262, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1347, 12, false);
#line 36 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\Cep\Index.cshtml"
                       Write(endereco.Cep);

#line default
#line hidden
            EndContext();
            BeginContext(1359, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1451, 19, false);
#line 39 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\Cep\Index.cshtml"
                       Write(endereco.Logradouro);

#line default
#line hidden
            EndContext();
            BeginContext(1470, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1562, 20, false);
#line 42 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\Cep\Index.cshtml"
                       Write(endereco.Complemento);

#line default
#line hidden
            EndContext();
            BeginContext(1582, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1674, 15, false);
#line 45 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\Cep\Index.cshtml"
                       Write(endereco.Bairro);

#line default
#line hidden
            EndContext();
            BeginContext(1689, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1781, 19, false);
#line 48 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\Cep\Index.cshtml"
                       Write(endereco.Localidade);

#line default
#line hidden
            EndContext();
            BeginContext(1800, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1892, 11, false);
#line 51 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\Cep\Index.cshtml"
                       Write(endereco.Uf);

#line default
#line hidden
            EndContext();
            BeginContext(1903, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 54 "C:\Users\Aluno\source\repos\AppCep\AppCep\Views\Cep\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1982, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppCep.Models.Endereco>> Html { get; private set; }
    }
}
#pragma warning restore 1591
