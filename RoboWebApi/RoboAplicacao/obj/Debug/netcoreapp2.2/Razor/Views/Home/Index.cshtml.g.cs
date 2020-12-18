#pragma checksum "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc1d5284206e9667336f144da9972f5147f453e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\_ViewImports.cshtml"
using RoboAplicacao;

#line default
#line hidden
#line 2 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\_ViewImports.cshtml"
using RoboAplicacao.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc1d5284206e9667336f144da9972f5147f453e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dfb51fdd42f7c57bc2f09461fb96b186118966d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-12 row align-content-md-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/robo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Robo";

#line default
#line hidden
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
  
    RoboModel robo = ViewBag.robo != null ? ViewBag.robo : new RoboModel();

    string[] inclinacao = new string[] { "btn-primary", "btn-primary", "btn-primary" };
    string[] rotacao = new string[] { "btn-primary", "btn-primary", "btn-primary", "btn-primary", "btn-primary" };
    string[] pulsoDir = new string[] { "btn-primary", "btn-primary", "btn-primary", "btn-primary", "btn-primary", "btn-primary", "btn-primary" };
    string[] pulsoEsq = new string[] { "btn-primary", "btn-primary", "btn-primary", "btn-primary", "btn-primary", "btn-primary", "btn-primary" };
    string[] cotoveloDir = new string[] { "btn-primary", "btn-primary", "btn-primary", "btn-primary" };
    string[] cotoveloEsq = new string[] { "btn-primary", "btn-primary", "btn-primary", "btn-primary" };

    try { inclinacao[robo.Cabeca.Inclinacao.Estado - 1] = "btn-success"; } catch (Exception) { }
    try { rotacao[robo.Cabeca.Rotacao.Estado - 1] = "btn-success"; } catch (Exception) { }
    try { pulsoDir[robo.BracoDireito.Pulso.Estado - 1] = "btn-success"; } catch (Exception) { }
    try { pulsoEsq[robo.BracoEsquerdo.Pulso.Estado - 1] = "btn-success"; } catch (Exception) { }
    try { cotoveloDir[robo.BracoDireito.Cotovelo.Estado - 1] = "btn-success"; } catch (Exception) { }
    try { cotoveloEsq[robo.BracoEsquerdo.Cotovelo.Estado - 1] = "btn-success"; } catch (Exception) { }

#line default
#line hidden
            BeginContext(1431, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
 if (ViewBag.Exception != null && ViewBag.Exception != "")
{

#line default
#line hidden
            BeginContext(1496, 59, true);
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(1556, 17, false);
#line 26 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
   Write(ViewBag.Exception);

#line default
#line hidden
            EndContext();
            BeginContext(1573, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 28 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
}
else if (ViewBag.Message != null && ViewBag.Message != "")
{

#line default
#line hidden
            BeginContext(1653, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(1714, 15, false);
#line 32 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1729, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 34 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1746, 171, true);
            WriteLiteral("\r\n<div id=\"estado\" class=\"col-12 row\">\r\n    <div class=\"col-12 text-info\">\r\n        <label>Cabeça</label>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <label>Inclinação: ");
            EndContext();
            BeginContext(1918, 38, false);
#line 41 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
                      Write(robo.Cabeca.Inclinacao.EstadoDescricao);

#line default
#line hidden
            EndContext();
            BeginContext(1956, 96, true);
            WriteLiteral("</label>\r\n        <label></label>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <label>Rotação: ");
            EndContext();
            BeginContext(2053, 35, false);
#line 45 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
                   Write(robo.Cabeca.Rotacao.EstadoDescricao);

#line default
#line hidden
            EndContext();
            BeginContext(2088, 233, true);
            WriteLiteral("</label>\r\n        <label></label>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div id=\"estado\" class=\"col-12 row\">\r\n    <div class=\"col-12 text-info\">\r\n        <label>Braço Direito</label>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <label>Cotovelo: ");
            EndContext();
            BeginContext(2322, 42, false);
#line 56 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
                    Write(robo.BracoDireito.Cotovelo.EstadoDescricao);

#line default
#line hidden
            EndContext();
            BeginContext(2364, 94, true);
            WriteLiteral("</label>\r\n        <label></label>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <label>Pulso: ");
            EndContext();
            BeginContext(2459, 39, false);
#line 60 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
                 Write(robo.BracoDireito.Pulso.EstadoDescricao);

#line default
#line hidden
            EndContext();
            BeginContext(2498, 234, true);
            WriteLiteral("</label>\r\n        <label></label>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div id=\"estado\" class=\"col-12 row\">\r\n    <div class=\"col-12 text-info\">\r\n        <label>Braço Esquerdo</label>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <label>Cotovelo: ");
            EndContext();
            BeginContext(2733, 43, false);
#line 71 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
                    Write(robo.BracoEsquerdo.Cotovelo.EstadoDescricao);

#line default
#line hidden
            EndContext();
            BeginContext(2776, 94, true);
            WriteLiteral("</label>\r\n        <label></label>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <label>Pulso: ");
            EndContext();
            BeginContext(2871, 40, false);
#line 75 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
                 Write(robo.BracoEsquerdo.Pulso.EstadoDescricao);

#line default
#line hidden
            EndContext();
            BeginContext(2911, 68, true);
            WriteLiteral(" </label>\r\n        <label></label>\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n\r\n");
            EndContext();
            BeginContext(2979, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fc1d5284206e9667336f144da9972f5147f453e11318", async() => {
                BeginContext(3028, 59, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>Robo</title>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3094, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3096, 5122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fc1d5284206e9667336f144da9972f5147f453e12653", async() => {
                BeginContext(3102, 221, true);
                WriteLiteral("\r\n    <h1><strong>Robo</strong></h1>\r\n    <h2><strong>Cabeça</strong></h2>\r\n    <div>\r\n        <p>Inclinação</p>\r\n        <p>\r\n            <button type=\"button\" id=\"inclinacao1\" onclick=\"alterarEstadoRobo(\'inclinacao\',1)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3323, "\"", 3356, 2);
                WriteAttributeValue("", 3331, "inclinacao", 3331, 10, true);
#line 93 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3341, inclinacao[0], 3342, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3357, 115, true);
                WriteLiteral(">Para Cima</button>\r\n            <button type=\"button\" id=\"inclinacao2\" onclick=\"alterarEstadoRobo(\'inclinacao\',2)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3472, "\"", 3505, 2);
                WriteAttributeValue("", 3480, "inclinacao", 3480, 10, true);
#line 94 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3490, inclinacao[1], 3491, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3506, 116, true);
                WriteLiteral(">Em Repouso</button>\r\n            <button type=\"button\" id=\"inclinacao3\" onclick=\"alterarEstadoRobo(\'inclinacao\',3)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3622, "\"", 3655, 2);
                WriteAttributeValue("", 3630, "inclinacao", 3630, 10, true);
#line 95 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3640, inclinacao[2], 3641, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3656, 184, true);
                WriteLiteral(">Para Baixo</button>\r\n        </p>\r\n    </div>\r\n    <div>\r\n        <p>Rotação</p>\r\n        <p>\r\n            <button type=\"button\" id=\"rotacao1\" onclick=\"alterarEstadoRobo(\'rotacao\',1)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3840, "\"", 3867, 2);
                WriteAttributeValue("", 3848, "rotacao", 3848, 7, true);
#line 101 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3855, rotacao[0], 3856, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3868, 112, true);
                WriteLiteral(">Rotação -90º</button>\r\n            <button type=\"button\" id=\"rotacao2\" onclick=\"alterarEstadoRobo(\'rotacao\',2)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3980, "\"", 4007, 2);
                WriteAttributeValue("", 3988, "rotacao", 3988, 7, true);
#line 102 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3995, rotacao[1], 3996, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4008, 112, true);
                WriteLiteral(">Rotação -45º</button>\r\n            <button type=\"button\" id=\"rotacao3\" onclick=\"alterarEstadoRobo(\'rotacao\',3)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4120, "\"", 4147, 2);
                WriteAttributeValue("", 4128, "rotacao", 4128, 7, true);
#line 103 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4135, rotacao[2], 4136, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4148, 110, true);
                WriteLiteral(">Em Repouso</button>\r\n            <button type=\"button\" id=\"rotacao4\" onclick=\"alterarEstadoRobo(\'rotacao\',4)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4258, "\"", 4285, 2);
                WriteAttributeValue("", 4266, "rotacao", 4266, 7, true);
#line 104 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4273, rotacao[3], 4274, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4286, 111, true);
                WriteLiteral(">Rotação 45º</button>\r\n            <button type=\"button\" id=\"rotacao5\" onclick=\"alterarEstadoRobo(\'rotacao\',5)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4397, "\"", 4424, 2);
                WriteAttributeValue("", 4405, "rotacao", 4405, 7, true);
#line 105 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4412, rotacao[4], 4413, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4425, 215, true);
                WriteLiteral(">Rotação 90º</button>\r\n        </p>\r\n    </div>\r\n    <h2>Braço Direito</h2>\r\n    <div>\r\n        <p>Pulso</p>\r\n        <p>\r\n            <button type=\"button\" id=\"pulso_dir1\" onclick=\"alterarEstadoRobo(\'pulso_dir\',1)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4640, "\"", 4670, 2);
                WriteAttributeValue("", 4648, "pulso_dir", 4648, 9, true);
#line 112 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4657, pulsoDir[0], 4658, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4671, 119, true);
                WriteLiteral(">Rotação em -90º</button>\r\n            <button type=\"button\" id=\"pulso_dir2\" onclick=\"alterarEstadoRobo(\'pulso_dir\',2)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4790, "\"", 4820, 2);
                WriteAttributeValue("", 4798, "pulso_dir", 4798, 9, true);
#line 113 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4807, pulsoDir[1], 4808, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4821, 119, true);
                WriteLiteral(">Rotação em -45º</button>\r\n            <button type=\"button\" id=\"pulso_dir3\" onclick=\"alterarEstadoRobo(\'pulso_dir\',3)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4940, "\"", 4970, 2);
                WriteAttributeValue("", 4948, "pulso_dir", 4948, 9, true);
#line 114 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4957, pulsoDir[2], 4958, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4971, 114, true);
                WriteLiteral(">Em Repouso</button>\r\n            <button type=\"button\" id=\"pulso_dir4\" onclick=\"alterarEstadoRobo(\'pulso_dir\',4)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 5085, "\"", 5115, 2);
                WriteAttributeValue("", 5093, "pulso_dir", 5093, 9, true);
#line 115 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 5102, pulsoDir[3], 5103, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5116, 118, true);
                WriteLiteral(">Rotação em 45º</button>\r\n            <button type=\"button\" id=\"pulso_dir5\" onclick=\"alterarEstadoRobo(\'pulso_dir\',5)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 5234, "\"", 5264, 2);
                WriteAttributeValue("", 5242, "pulso_dir", 5242, 9, true);
#line 116 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 5251, pulsoDir[4], 5252, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5265, 118, true);
                WriteLiteral(">Rotação em 90º</button>\r\n            <button type=\"button\" id=\"pulso_dir6\" onclick=\"alterarEstadoRobo(\'pulso_dir\',6)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 5383, "\"", 5413, 2);
                WriteAttributeValue("", 5391, "pulso_dir", 5391, 9, true);
#line 117 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 5400, pulsoDir[5], 5401, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5414, 121, true);
                WriteLiteral(">Rotação para 135º</button>\r\n            <button type=\"button\" id=\"pulso_dir7\" onclick=\"alterarEstadoRobo(\'pulso_dir\',7)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 5535, "\"", 5565, 2);
                WriteAttributeValue("", 5543, "pulso_dir", 5543, 9, true);
#line 118 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 5552, pulsoDir[6], 5553, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5566, 202, true);
                WriteLiteral(">Rotação para 180º</button>\r\n        </p>\r\n    </div>\r\n    <div>\r\n        <p>Cotovelo</p>\r\n        <p>\r\n            <button type=\"button\" id=\"cotovelo_dir1\" onclick=\"alterarEstadoRobo(\'cotovelo_dir\',1)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 5768, "\"", 5804, 2);
                WriteAttributeValue("", 5776, "cotovelo_dir", 5776, 12, true);
#line 124 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 5788, cotoveloDir[0], 5789, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5805, 120, true);
                WriteLiteral(">Em Repouso</button>\r\n            <button type=\"button\" id=\"cotovelo_dir2\" onclick=\"alterarEstadoRobo(\'cotovelo_dir\',2)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 5925, "\"", 5961, 2);
                WriteAttributeValue("", 5933, "cotovelo_dir", 5933, 12, true);
#line 125 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 5945, cotoveloDir[1], 5946, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5962, 129, true);
                WriteLiteral(">Levemente Contraído</button>\r\n            <button type=\"button\" id=\"cotovelo_dir3\" onclick=\"alterarEstadoRobo(\'cotovelo_dir\',3)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 6091, "\"", 6127, 2);
                WriteAttributeValue("", 6099, "cotovelo_dir", 6099, 12, true);
#line 126 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6111, cotoveloDir[2], 6112, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6128, 119, true);
                WriteLiteral(">Contraído</button>\r\n            <button type=\"button\" id=\"cotovelo_dir4\" onclick=\"alterarEstadoRobo(\'cotovelo_dir\',4)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 6247, "\"", 6283, 2);
                WriteAttributeValue("", 6255, "cotovelo_dir", 6255, 12, true);
#line 127 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6267, cotoveloDir[3], 6268, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6284, 225, true);
                WriteLiteral(">Fortemente Contraído</button>\r\n        </p>\r\n    </div>\r\n    <h2>Braço Esquerdo</h2>\r\n    <div>\r\n        <p>Pulso</p>\r\n        <p>\r\n            <button type=\"button\" id=\"pulso_esq1\" onclick=\"alterarEstadoRobo(\'pulso_esq\',1)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 6509, "\"", 6539, 2);
                WriteAttributeValue("", 6517, "pulso_esq", 6517, 9, true);
#line 134 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6526, pulsoEsq[0], 6527, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6540, 119, true);
                WriteLiteral(">Rotação em -90º</button>\r\n            <button type=\"button\" id=\"pulso_esq2\" onclick=\"alterarEstadoRobo(\'pulso_esq\',2)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 6659, "\"", 6689, 2);
                WriteAttributeValue("", 6667, "pulso_esq", 6667, 9, true);
#line 135 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6676, pulsoEsq[1], 6677, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6690, 119, true);
                WriteLiteral(">Rotação em -45º</button>\r\n            <button type=\"button\" id=\"pulso_esq3\" onclick=\"alterarEstadoRobo(\'pulso_esq\',3)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 6809, "\"", 6839, 2);
                WriteAttributeValue("", 6817, "pulso_esq", 6817, 9, true);
#line 136 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6826, pulsoEsq[2], 6827, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6840, 114, true);
                WriteLiteral(">Em Repouso</button>\r\n            <button type=\"button\" id=\"pulso_esq4\" onclick=\"alterarEstadoRobo(\'pulso_esq\',4)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 6954, "\"", 6984, 2);
                WriteAttributeValue("", 6962, "pulso_esq", 6962, 9, true);
#line 137 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6971, pulsoEsq[3], 6972, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6985, 118, true);
                WriteLiteral(">Rotação em 45º</button>\r\n            <button type=\"button\" id=\"pulso_esq5\" onclick=\"alterarEstadoRobo(\'pulso_esq\',5)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 7103, "\"", 7133, 2);
                WriteAttributeValue("", 7111, "pulso_esq", 7111, 9, true);
#line 138 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7120, pulsoEsq[4], 7121, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7134, 118, true);
                WriteLiteral(">Rotação em 90º</button>\r\n            <button type=\"button\" id=\"pulso_esq6\" onclick=\"alterarEstadoRobo(\'pulso_esq\',6)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 7252, "\"", 7282, 2);
                WriteAttributeValue("", 7260, "pulso_esq", 7260, 9, true);
#line 139 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7269, pulsoEsq[5], 7270, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7283, 121, true);
                WriteLiteral(">Rotação para 135º</button>\r\n            <button type=\"button\" id=\"pulso_esq7\" onclick=\"alterarEstadoRobo(\'pulso_esq\',7)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 7404, "\"", 7434, 2);
                WriteAttributeValue("", 7412, "pulso_esq", 7412, 9, true);
#line 140 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7421, pulsoEsq[6], 7422, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7435, 202, true);
                WriteLiteral(">Rotação para 180º</button>\r\n        </p>\r\n    </div>\r\n    <div>\r\n        <p>Cotovelo</p>\r\n        <p>\r\n            <button type=\"button\" id=\"cotovelo_esq1\" onclick=\"alterarEstadoRobo(\'cotovelo_esq\',1)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 7637, "\"", 7673, 2);
                WriteAttributeValue("", 7645, "cotovelo_esq", 7645, 12, true);
#line 146 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7657, cotoveloEsq[0], 7658, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7674, 120, true);
                WriteLiteral(">Em Repouso</button>\r\n            <button type=\"button\" id=\"cotovelo_esq2\" onclick=\"alterarEstadoRobo(\'cotovelo_esq\',2)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 7794, "\"", 7830, 2);
                WriteAttributeValue("", 7802, "cotovelo_esq", 7802, 12, true);
#line 147 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7814, cotoveloEsq[1], 7815, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7831, 129, true);
                WriteLiteral(">Levemente Contraído</button>\r\n            <button type=\"button\" id=\"cotovelo_esq3\" onclick=\"alterarEstadoRobo(\'cotovelo_esq\',3)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 7960, "\"", 7996, 2);
                WriteAttributeValue("", 7968, "cotovelo_esq", 7968, 12, true);
#line 148 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7980, cotoveloEsq[2], 7981, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7997, 119, true);
                WriteLiteral(">Contraído</button>\r\n            <button type=\"button\" id=\"cotovelo_esq4\" onclick=\"alterarEstadoRobo(\'cotovelo_esq\',4)\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 8116, "\"", 8152, 2);
                WriteAttributeValue("", 8124, "cotovelo_esq", 8124, 12, true);
#line 149 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 8136, cotoveloEsq[3], 8137, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8153, 58, true);
                WriteLiteral(">Fortemente Contraído</button>\r\n        </p>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8218, 32, true);
            WriteLiteral("\r\n\r\n<div style=\"display:none\">\r\n");
            EndContext();
#line 155 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(8320, 62, true);
            WriteLiteral("        <input type=\"hidden\" id=\"inclinacao\" name=\"inclinacao\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8382, "\"", 8420, 1);
#line 157 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue("", 8390, robo.Cabeca.Inclinacao.Estado, 8390, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8421, 61, true);
            WriteLiteral(" />\r\n        <input type=\"hidden\" id=\"rotacao\" name=\"rotacao\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8482, "\"", 8517, 1);
#line 158 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue("", 8490, robo.Cabeca.Rotacao.Estado, 8490, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8518, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(8525, 66, true);
            WriteLiteral("        <input type=\"hidden\" id=\"cotovelo_dir\" name=\"cotovelo_dir\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8591, "\"", 8633, 1);
#line 160 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue("", 8599, robo.BracoDireito.Cotovelo.Estado, 8599, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8634, 71, true);
            WriteLiteral(" />\r\n        <input type=\"hidden\" id=\"cotovelo_esq\" name=\"cotovelo_esq\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8705, "\"", 8748, 1);
#line 161 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue("", 8713, robo.BracoEsquerdo.Cotovelo.Estado, 8713, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8749, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(8756, 60, true);
            WriteLiteral("        <input type=\"hidden\" id=\"pulso_dir\" name=\"pulso_dir\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8816, "\"", 8855, 1);
#line 163 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue("", 8824, robo.BracoDireito.Pulso.Estado, 8824, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8856, 65, true);
            WriteLiteral(" />\r\n        <input type=\"hidden\" id=\"pulso_esq\" name=\"pulso_esq\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8921, "\"", 8961, 1);
#line 164 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
WriteAttributeValue("", 8929, robo.BracoEsquerdo.Pulso.Estado, 8929, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8962, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(8969, 49, true);
            WriteLiteral("        <input type=\"submit\" id=\"submitRobo\" />\r\n");
            EndContext();
#line 167 "C:\Users\Rafae\Desktop\Projeto NDD\RoboWebApi\RoboAplicacao\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(9025, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9053, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9059, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fc1d5284206e9667336f144da9972f5147f453e37488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9118, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591