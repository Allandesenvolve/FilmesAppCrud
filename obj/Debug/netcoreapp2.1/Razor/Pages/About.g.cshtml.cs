#pragma checksum "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa3db9938dfb142c735a920c691d1cd53cfb3036"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FilmesCRUDRazor.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(FilmesCRUDRazor.Pages.Pages_About), null)]
namespace FilmesCRUDRazor.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3db9938dfb142c735a920c691d1cd53cfb3036", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f86caf6ad55c75a80e440415e9cf35d8d198c65", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\About.cshtml"
  
    ViewData["Title"] = "Sobre mim";

#line default
#line hidden
            BeginContext(66, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(71, 17, false);
#line 6 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(88, 10, true);
            WriteLiteral("</h2>\n<h3>");
            EndContext();
            BeginContext(99, 13, false);
#line 7 "C:\Users\allan.alencar\Documents\PROJETOCRUD\workshop-net-core-iniciantes-master\src\FilmesCRUDRazor\Pages\About.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(112, 953, true);
            WriteLiteral(@"</h3>

<div class=""container"">
    <div class=""row"">
        <h2 class=""text-center"">Allan de Almeida Alencar</h2>
        <p align=""center"">
            <img src=""https://i.imgsafe.org/1c/1c7fcef027.png"" />
        </p>
        <br />

        <h3 class=""text-justify"">Bio</h3>
        <hr />
        <p class=""text-justify"">
            Estudante de Sistemas e aprendiz de Desenvolvimento Web.
    

        <h3 class=""text-justify"">Informações Pessoais:</h3>
        <hr />
        <dl>
            <dt>Nome: Allan Alencar</dt>
        </dl>
        <dl>
            <dt>Empresa: <a href=""https://www.institutoeldorado.org.br/"">Eldorado</a></dt>
        </dl>
        <dl>
            <dt>Profissão: Auxiliar de Suporte </dt>
        </dl>
       
        <dl>
            <dt>e-mail: allan.alencar@eldorado.org.br </dt>
        </dl>
        <dl>
            <dt>Localização: Brasília, Brasil</dt>
        </dl>              
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
