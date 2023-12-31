#pragma checksum "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c3b1359113eca2b189a34683bf6255e093d5f63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medicacao__ShowMedication), @"mvc.1.0.view", @"/Views/Medicacao/_ShowMedication.cshtml")]
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
#line 1 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\_ViewImports.cshtml"
using Hsf_Receitas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedication.cshtml"
using Hsf_Receitas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c3b1359113eca2b189a34683bf6255e093d5f63", @"/Views/Medicacao/_ShowMedication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489f18548069da5d6cb12941c30987820b77cd47", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Medicacao__ShowMedication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Receituario>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedication.cshtml"
  
    ViewData["title"] = "Vizualização de Receituário";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""view-presc"">

    <div class=""header-show-prescription"">

        <div class=""header-img mt-2 mb-2"">
            <img src=""../images/logotipo-hospital-sao-francisco.png"" alt=""logotipo da vizualização do receituário comum"">
        </div>

        <div class=""show-logo mt-2 mb-2"">
            <h1>RECEITUÁRIO</h1>
            <h2 style=""text-decoration: underline 2px solid #007bff;"">FUNDAÇÃO DE SAÚDE TRÊS MARIAS</h2>
            <h2>HOSPITAL SÃO FRANCISCO</h2>
        </div>

    </div>

    <div class=""show-body mt-4"">

        <div class=""prescription-data"">

            <div class=""inputs""><p class=""m-0 p-0"">NOME DO PACIENTE :</p><span class=""content"" id=""nameP""></span></div>
            <div class=""inputs""><p class=""m-0 p-0"">NOME DO MÉDICO :</p><span class=""content"" id=""nameM""></span></div>
            <div class=""inputs""><p class=""m-0 p-0"">DATA DO ATENDIMENTO :</p><span class=""content"" id=""dataA""></span></div>

        </div>

        <div class=""medicacoes"">
      ");
            WriteLiteral(@"      <h3 class=""text-center text-primary font-weight-bold mt-2 mb-3"">MEDICAMENTOS :</h3>
        </div>

    </div>

    <div class=""show-footer"">
        <P>BR 040 - KM 438 - BRASÍLIA / BELO HORIZONTE - TEL.: (38) 3754-1256</P>
        <p><span>PARQUE DIADORIM</span> - CEP: 39205-000 - TRÊS MARIAS - MINAS GERAIS</p>
        <div class=""line""></div>
    </div>

</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Receituario> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
