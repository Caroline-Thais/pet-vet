#pragma checksum "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Segunda Atividade\Views\Home\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0ccf1898672026a829579a417cbf23c262f1fce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listagem), @"mvc.1.0.view", @"/Views/Home/Listagem.cshtml")]
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
#line 1 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Segunda Atividade\Views\_ViewImports.cshtml"
using Segunda_Atividade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Segunda Atividade\Views\_ViewImports.cshtml"
using Segunda_Atividade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0ccf1898672026a829579a417cbf23c262f1fce", @"/Views/Home/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fbb834be686e364c00e0ea6f465e7a6a201453", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Agendamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
    <style>
    body {
        background-color: #f3ecc026;
        line-height: 1.8;
        font-family: sans-serif;
        font-size: medium;
    }
    table {
        text-align: center;
        line-height: 2;
    }

    a:link {
        text-decoration: none;
    }
</style>

    <h2> Consultas pré-agendadas </h2>
<table border=""1"">
   <thead>
       <tr>
           <th>Nome</th>
           <th>Telefone</th>
           <th>Animal</th>
           <th>Data</th>
           <th>Necessidade</th>
       </tr>
   </thead>
   <tbody>
");
#nullable restore
#line 32 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Segunda Atividade\Views\Home\Listagem.cshtml"
        foreach(Agendamento a in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n           <td>");
#nullable restore
#line 35 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Segunda Atividade\Views\Home\Listagem.cshtml"
          Write(a.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 36 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Segunda Atividade\Views\Home\Listagem.cshtml"
          Write(a.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 37 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Segunda Atividade\Views\Home\Listagem.cshtml"
          Write(a.Animal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 38 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Segunda Atividade\Views\Home\Listagem.cshtml"
          Write(a.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 39 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Segunda Atividade\Views\Home\Listagem.cshtml"
          Write(a.Necessidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Segunda Atividade\Views\Home\Listagem.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0ccf1898672026a829579a417cbf23c262f1fce5878", async() => {
                WriteLiteral("Cadastrar nova consulta");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Agendamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
