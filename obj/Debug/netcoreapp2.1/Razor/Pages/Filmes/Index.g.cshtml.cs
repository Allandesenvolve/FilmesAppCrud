#pragma checksum "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6daa74f88b67955ff1f51bbf82b5a5279d26a93e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FilmesCRUDRazor.Pages.Filmes.Pages_Filmes_Index), @"mvc.1.0.razor-page", @"/Pages/Filmes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Filmes/Index.cshtml", typeof(FilmesCRUDRazor.Pages.Filmes.Pages_Filmes_Index), null)]
namespace FilmesCRUDRazor.Pages.Filmes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\_ViewImports.cshtml"
using FilmesCRUDRazor;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6daa74f88b67955ff1f51bbf82b5a5279d26a93e", @"/Pages/Filmes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f86caf6ad55c75a80e440415e9cf35d8d198c65", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Filmes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(132, 138, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n   <div class=\"row\">\r\n      <div class=\"col-md-12\">\r\n         <h2>Filmes Top +</h2>\r\n         <p>\r\n            ");
            EndContext();
            BeginContext(270, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2e506db9ae4d3f9164c2a2f7f38a0b", async() => {
                BeginContext(315, 90, true);
                WriteLiteral("\r\n            <span class=\"glyphicon glyphicon-plus\"></span> Adicionar Filme\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(409, 26, true);
            WriteLiteral("\r\n         </p>\r\n         ");
            EndContext();
            BeginContext(435, 827, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52db69e104874c1298765a217cde84a8", async() => {
                BeginContext(441, 160, true);
                WriteLiteral("\r\n             <div class=\"row\">\r\n                 <div class=\"col-md-6\">\r\n                     <label class=\"text-left\">Gêneros:</label>\r\n                     ");
                EndContext();
                BeginContext(601, 180, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75d43c57d83f42deb14041e75d6578df", async() => {
                    BeginContext(681, 27, true);
                    WriteLiteral("\r\n                         ");
                    EndContext();
                    BeginContext(708, 41, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c747c770035447e807edf4be3b9285a", async() => {
                        BeginContext(725, 15, true);
                        WriteLiteral("Todos - Gêneros");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(749, 23, true);
                    WriteLiteral("\r\n                     ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 25 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilmePorGenero);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 25 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Generos;

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
                BeginContext(781, 474, true);
                WriteLiteral(@"
                 </div>
             </div>
             <br />
             <div class=""row"">
                 <div class=""col-md-6"">
                     <label class=""text-left"">Título do Filme</label>
                     <input class=""form-control"" type=""text"" name=""BuscaPorGeneroNome"" />
                     <br />
                     <input class=""btn btn-primary"" type=""submit"" value=""Filtrar"" />
                 </div>
             </div>
         ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1262, 211, true);
            WriteLiteral("\r\n         <div class=\"table-responsive\">\r\n            <table class=\"table table-striped\">\r\n               <thead>\r\n                  <tr>\r\n                     <th class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(1474, 51, false);
#line 45 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Filme[0].Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 101, true);
            WriteLiteral("\r\n                     </th>\r\n                     <th class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(1627, 59, false);
#line 48 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Filme[0].DataLancamento));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 101, true);
            WriteLiteral("\r\n                     </th>\r\n                     <th class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(1788, 51, false);
#line 51 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Filme[0].Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 101, true);
            WriteLiteral("\r\n                     </th>\r\n                     <th class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(1941, 50, false);
#line 54 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Filme[0].Preco));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 161, true);
            WriteLiteral("\r\n                     </th>\r\n                     <th class=\"text-center\">Ações</th>\r\n                  </tr>\r\n               </thead>\r\n               <tbody>\r\n");
            EndContext();
#line 60 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                   foreach (var item in Model.Filme) {

#line default
#line hidden
            BeginContext(2208, 95, true);
            WriteLiteral("                  <tr>\r\n                     <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(2304, 41, false);
#line 63 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(2345, 101, true);
            WriteLiteral("\r\n                     </td>\r\n                     <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(2447, 49, false);
#line 66 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DataLancamento));

#line default
#line hidden
            EndContext();
            BeginContext(2496, 101, true);
            WriteLiteral("\r\n                     </td>\r\n                     <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(2598, 41, false);
#line 69 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(2639, 101, true);
            WriteLiteral("\r\n                     </td>\r\n                     <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(2741, 40, false);
#line 72 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(2781, 101, true);
            WriteLiteral("\r\n                     </td>\r\n                     <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(2882, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce2508009acc471aa267305108b53a06", async() => {
                BeginContext(2956, 49, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-pencil\"></span> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                                                                       WriteLiteral(item.FilmeId);

#line default
#line hidden
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
            EndContext();
            BeginContext(3009, 27, true);
            WriteLiteral(" \r\n                        ");
            EndContext();
            BeginContext(3036, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b080e7baee543d6af0987f3242a152f", async() => {
                BeginContext(3110, 52, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-info-sign\"></span> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                                                                       WriteLiteral(item.FilmeId);

#line default
#line hidden
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
            EndContext();
            BeginContext(3166, 27, true);
            WriteLiteral(" \r\n                        ");
            EndContext();
            BeginContext(3193, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fa7894bb84746a7a9d3918286418637", async() => {
                BeginContext(3268, 48, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-trash\"></span> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                                                                        WriteLiteral(item.FilmeId);

#line default
#line hidden
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
            EndContext();
            BeginContext(3320, 55, true);
            WriteLiteral("\r\n                     </td>\r\n                  </tr>\r\n");
            EndContext();
#line 80 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\Filmes\Index.cshtml"
                  }

#line default
#line hidden
            BeginContext(3396, 693, true);
            WriteLiteral(@"               </tbody>
            </table>
            <div class=""clearfix""></div>
            <ul class=""pagination pull-right"">
                <li class=""disabled""><a href=""#""><span class=""glyphicon glyphicon-chevron-left""></span></a></li>
                <li class=""active""><a href=""#"">1</a></li>
                <li class=""#""><a href=""#"">2</a></li>
                <li class=""#""><a href=""#"">3</a></li>
                <li class=""#""><a href=""#"">4</a></li>
                <li class=""#""><a href=""#"">5</a></li>
                <li><a href=""#""><span class=""glyphicon glyphicon-chevron-right""></span></a></li>
            </ul>
         </div>
      </div>
   </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmesCRUDRazor.Pages.Filmes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FilmesCRUDRazor.Pages.Filmes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FilmesCRUDRazor.Pages.Filmes.IndexModel>)PageContext?.ViewData;
        public FilmesCRUDRazor.Pages.Filmes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
