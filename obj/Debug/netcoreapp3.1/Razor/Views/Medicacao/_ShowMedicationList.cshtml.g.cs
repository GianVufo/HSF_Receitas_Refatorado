#pragma checksum "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3827bde89125114ff01473a8678e3db9f1f74a45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medicacao__ShowMedicationList), @"mvc.1.0.view", @"/Views/Medicacao/_ShowMedicationList.cshtml")]
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
#line 1 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\_ViewImports.cshtml"
using Hsf_Receitas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
using Hsf_Receitas.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
using Hsf_Receitas.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3827bde89125114ff01473a8678e3db9f1f74a45", @"/Views/Medicacao/_ShowMedicationList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489f18548069da5d6cb12941c30987820b77cd47", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Medicacao__ShowMedicationList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Receituario>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("medication-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("medication-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
  
    ViewData["title"] = "Completar Receituário";

    Medicacao medic = new Medicacao();
    HSFContext database = new HSFContext();

    List<Medicacao> medicList = database.Medicamentos.Where(m => m.ReceituarioId == Model.Id).ToList();
    List<Receituario> prescriptionList = database.Receitas.Where(m => m.Id == Model.Id).ToList();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"view-presc\">\r\n \r\n");
#nullable restore
#line 18 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
     if (prescriptionList.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""header-show-prescription"">

            <div class=""header-img mt-2 mb-2"">
                <img src=""../images/logotipo-hospital-sao-francisco.png""alt=""logotipo da vizualização do receituário comum"">
            </div>

            <div class=""show-logo mt-2 mb-2"">

                <h1>RECEITUÁRIO</h1>
                <h2 style=""text-decoration: underline 2px solid #007bff;"">FUNDAÇÃO DE SAÚDE TRÊS MARIAS</h2>
                <h2>HOSPITAL SÃO FRANCISCO</h2>

            </div>

        </div>
");
            WriteLiteral("        <div class=\"show-body mt-4\">\r\n\r\n");
#nullable restore
#line 38 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
             foreach (var item in prescriptionList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"prescription-data\">\r\n\r\n                    <div class=\"inputs\">\r\n                        <p class=\"m-0 p-0\">NOME DO PACIENTE :</p><span class=\"content\">");
#nullable restore
#line 43 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                                                                                  Write(item.PacientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"inputs\">\r\n                        <p class=\"m-0 p-0\">NOME DO MÉDICO :</p><span class=\"content\">");
#nullable restore
#line 46 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                                                                                Write(item.DoctorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"inputs\">\r\n                        <p class=\"m-0 p-0\">DATA DO ATENDIMENTO :</p><span class=\"content\">");
#nullable restore
#line 49 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                                                                                     Write(item.DateOfMedicalAppoiment.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 53 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"medicacoes\">\r\n\r\n                <h3 class=\"text-center mt-2 mb-3 text-primary font-weight-bold\">MEDICAMENTOS :</h3>\r\n\r\n");
#nullable restore
#line 59 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                 if (medicList.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <table class=\"text-primary list-visualization table-responsive\">\r\n");
#nullable restore
#line 62 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                         foreach (var item in medicList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <thead class=""text-center font-weight-normal"">

                                <tr class=""border-table"">

                                    <tr class=""border-table"">
                                        <th class=""font-weight-bold border-line2 p-1""><span> Vias de Administração: ");
#nullable restore
#line 69 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                                                                                                               Write(item.RouteOfAdministration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></th>\r\n                                    </tr>\r\n\r\n");
            WriteLiteral(@"                                    <th class=""p-1 border-line"">Nome</th>
                                    <th class=""p-1 border-line"">Apresentação</th>
                                    <th class=""p-1 border-line"">Posologia</th>
                                    <th class=""p-1 border-line"">Duração do Tto.</th>

                                </tr>

                            </thead>
");
            WriteLiteral("                            <tbody class=\"text-center\">\r\n    \r\n                                <tr class=\"border-table\">\r\n\r\n                                    <td class=\"p-1 border-line\">");
#nullable restore
#line 86 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                                                           Write(item.MedicationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"p-1 border-line\">");
#nullable restore
#line 87 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                                                           Write(item.Presentation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"p-1 border-line\">");
#nullable restore
#line 88 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                                                           Write(item.Posology);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"p-1 border-line\">");
#nullable restore
#line 89 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                                                           Write(item.DurationOfTreatment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                                </tr>

                                <tr class=""border-table""><td style=""border-right: none;"" class=""p-2 ml-0 mt-3""><span style=""font-size: 6pt;"" class=""text-primary""><b>Observações :</b></span></td></tr>

                            </tbody>
");
#nullable restore
#line 96 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"

                            /* Start DeleteMedication Modal */


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 3967, "\"", 4002, 4);
            WriteAttributeValue("", 3975, "modal", 3975, 5, true);
            WriteAttributeValue(" ", 3980, "fade", 3981, 5, true);
            WriteAttributeValue(" ", 3985, "myModal-", 3986, 9, true);
#nullable restore
#line 99 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
WriteAttributeValue("", 3994, item.Id, 3994, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""deleteMedicationTitle"" aria-hidden=""true"">

                                    <div class=""modal-dialog modal-dialog-centered modal-md"" role=""document"">

                                        <div class=""modal-content"">

                                            <div class=""modal-header bg-danger text-light text-center"">

                                                <h3 class=""modal-title text-ligth text-center"" id=""deleteMedicationTitle"">Alerta!</h3>

                                                <button type=""button"" class=""close"" data-dismiss=""modal"" title=""Fechar"">
                                                    <span class=""text-light"" aria-hidden=""true"">&times;</span>
                                                </button>

                                            </div>

                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3827bde89125114ff01473a8678e3db9f1f74a4513734", async() => {
                WriteLiteral(@"

                                                <div class=""modal-body p-3"">

                                                    <div class=""p-3 text-center"">
                                                        <span>Tem certeza que deseja excluir a medicação <b class=""text-danger"">");
#nullable restore
#line 120 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                                                                                                                           Write(item.MedicationName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b> ?</span>
                                                    </div>

                                                </div>

                                                <div class=""modal-footer p-1"">
                                                    <button class=""btn btn-outline-danger btn-sm"" type=""submit"" title=""Excluir""><i style=""font-size: 20px;"" class=""bi bi-person-fill-x""></i></button>  
                                                </div>

                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onsubmit", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4933, "deleteMedication(", 4933, 17, true);
#nullable restore
#line 115 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
AddHtmlAttributeValue("", 4950, item.Id, 4950, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 4958, ")", 4958, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        </div>\r\n\r\n                                    </div>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 136 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"

                            /* Finish DeleteMedication Modal */
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n");
#nullable restore
#line 140 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""show-footer"">
            <P>BR 040 - KM 438 - BRASÍLIA / BELO HORIZONTE - TEL.: (38) 3754-1256</P>
            <p><span>PARQUE DIADORIM</span> - CEP: 39205-000 - TRÊS MARIAS - MINAS GERAIS</p>
            <div class=""line""></div>
        </div>
");
#nullable restore
#line 150 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"

    }else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning w-100 text-center alert-medication\" role=\"alert\">\r\n            Não existe uma receita para mostrar !\r\n        </div>\r\n");
#nullable restore
#line 156 "C:\Users\gianluca.vialli\Desktop\HSF_Receitas_Refatorado\Views\Medicacao\_ShowMedicationList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
