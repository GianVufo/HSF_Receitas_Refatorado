#pragma checksum "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f3009f749b15407e3687e9393c54a26ee92dc21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AtestadoMedico_ATMCompletePrescription), @"mvc.1.0.view", @"/Views/AtestadoMedico/ATMCompletePrescription.cshtml")]
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
#line 2 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
using Hsf_Receitas.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
using Hsf_Receitas.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3009f749b15407e3687e9393c54a26ee92dc21", @"/Views/AtestadoMedico/ATMCompletePrescription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489f18548069da5d6cb12941c30987820b77cd47", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AtestadoMedico_ATMCompletePrescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Receituario>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("atm-up-prescriptionId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control mb-3 addRec-prescriptionId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("atm-up-pacientName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control line-inputs border-primary mt-0 mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("atm-up-doctorName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("atm-up-dataAppoiment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control line-inputs border-primary mt-0 mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("atm-up-receita-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("prescription-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
  
    ViewData["title"] = "Completar Receituário";

    Medicacao medic = new Medicacao();
    AtestadoMedico atm = new AtestadoMedico();
    HSFContext database = new HSFContext();

    List<Medicacao> medicList = database.Medicamentos.Where(m => m.ReceituarioId ==
    Model.Id).ToList();

    List<Receituario> prescriptionList = database.Receitas.Where(m => m.Id ==
    Model.Id).ToList();

    List<AtestadoMedico> atmList = database.AtestadosMedico.Where(m => m.ReceituarioId ==
    Model.Id).ToList();

    var atmData = @Model.DateOfMedicalAppoiment.ToString("dd");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""prescription container-fluid"">

    <div class=""card border-primary col-md-5 mb-4 p-0"">

        <div class=""card-header text-light"">

            <h1 class=""text-center"">Receituário</h1>

        </div>

        <div class=""card-body"">

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3009f749b15407e3687e9393c54a26ee92dc219051", async() => {
                WriteLiteral(@"

                <span class=""mt-3 mb-3 alerta""></span>

                <div class=""card text-light border-primary"">

                    <h5 class=""card-header font-weight-bold"">Informações básicas :</h5>

                    <div class=""card-body prescription-card-body"">

                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f3009f749b15407e3687e9393c54a26ee92dc219625", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                        <label class=\"text-primary\" for=\"atm-up-pacientName\">Nome do Paciente: </label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f3009f749b15407e3687e9393c54a26ee92dc2111986", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 51 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PacientName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                        <label class=\"text-primary\" for=\"atm-up-doctorName\">Nome do Médico: </label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f3009f749b15407e3687e9393c54a26ee92dc2114354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 55 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DoctorName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                        <label class=\"text-primary\" for=\"atm-up-dataAppoiment\">Data da consulta: </label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f3009f749b15407e3687e9393c54a26ee92dc2116726", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#nullable restore
#line 59 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateOfMedicalAppoiment);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                        <p class=""text-danger ml-5"">Salve as alterações antes de imprimir.</p>

                        <div class=""edit-button col-md-3"">
                            <button type=""submit"" class=""btn btn-sm btn-primary btn-printer mt-3""> <span class=""material-symbols-outlined""> save </span> Salvar</button>
                        </div>

                    </div>

                </div>

                <div class=""card text-light border-primary"">

                    <h5 class=""card-header font-weight-bold"">Medicações :</h5>

                    <div class=""card-body"">

                        <p class=""text-info ml-3"">Agora você pode adicionar medicamentos!</p>

                        <div class=""col-md-12 mt-3 mb-3"">
                            ");
#nullable restore
#line 80 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                       Write(await Html.PartialAsync("/Views/Medicacao/_ListaDeMedicacao.cshtml", @medicList));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"row button-prescription\">\r\n\r\n                            <button type=\"button\" data-toggle=\"modal\" data-target=\"#atm-medication-modal-");
#nullable restore
#line 85 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                                                                                                    Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                                onclick=\"inserirRemedios()\" class=\"btn btn-sm btn-info btn-printer\"> <span\r\n                                    class=\"material-symbols-outlined\"> syringe </span> Adicionar Medicamentos</button>\r\n\r\n");
#nullable restore
#line 89 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                             if (medicList.Count() <= 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <button title=""Insira medicamentos para imprimir!""
                                class=""btn btn-sm btn-secondary btn-printer medic-btn"" disabled><span
                                    class=""material-symbols-outlined mr-2""> print </span> Imprimir </button>
");
#nullable restore
#line 94 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"

                            }
                            else if (atmList.Count() <= 0)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <button title=""Gere um atestado médico para imprimir!""
                                class=""btn btn-sm btn-secondary btn-printer medic-btn"" disabled><span
                                    class=""material-symbols-outlined mr-2""> print </span> Imprimir </button>
");
#nullable restore
#line 102 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"

                            }
                            else
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a");
                BeginWriteAttribute("href", " href=\"", 4632, "\"", 4693, 2);
                WriteAttributeValue("", 4639, "/AtestadoMedico/ATMPrescriptionPrintToPDF?id=", 4639, 45, true);
#nullable restore
#line 107 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
WriteAttributeValue("", 4684, Model.Id, 4684, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\"\r\n                                title=\"Imprimir receituário\" class=\"btn btn-sm btn-secondary btn-printer\"><span\r\n                                    class=\"material-symbols-outlined mr-2\"> print </span> Imprimir </a>\r\n");
#nullable restore
#line 110 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>

                    </div>

                </div>

                <div class=""card text-light border-primary"">

                    <h5 class=""card-header font-weight-bold"">Atestado Médico :</h5>

                    <div class=""card-body"">

");
#nullable restore
#line 125 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                         if (atmList.Count() <= 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p class=\"text-info ml-3\">Agora você pode adicionar um atestado médico!</p>\r\n");
                WriteLiteral("                            <button type=\"button\" data-toggle=\"modal\" data-target=\"#atm-modal-");
#nullable restore
#line 129 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                                                                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                            title=""Adicionar Atestado Médico"" onclick="" ATM()""
                            class=""btn btn-sm btn-info btn-printer ml-3""> <span class=""material-symbols-outlined"">
                                    clinical_notes </span> Atestado Médico</button>
");
                WriteLiteral("                            <p class=\"text-danger ml-3 mt-3 mb-0\" role=\"alert\"> Nenhum atestado médico cadastrado ! </p>\r\n");
#nullable restore
#line 135 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"

                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                             foreach (var item in atmList)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <button target type=""button"" title=""Atestado médico já cadastrado""
                            class=""btn btn-sm btn-info btn-printer medic-btn ml-3"" disabled> <span
                                class=""material-symbols-outlined""> clinical_notes </span> Atestado Médico </button>
");
                WriteLiteral("                                <p class=\"text-info ml-3 mt-3 mb-0\"> Atestado médico cadastrado para: <span\r\n                                class=\"text-info font-weight-bold mt-3\">");
#nullable restore
#line 146 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                                                                   Write(item.PacientName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> </p>\r\n");
#nullable restore
#line 147 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"card border-primary col-md-5 mb-4 p-0\">\r\n        ");
#nullable restore
#line 161 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
   Write(await Html.PartialAsync("/Views/Medicacao/_ShowMedicationList.cshtml", @Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <!-- Vizualização do Atestado médico -->\r\n");
#nullable restore
#line 165 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
     if (atmList.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card border-primary col-md-5 mb-4 p-0"">

            <div class=""header-show-prescription mt-2 ml-2"">

                <div class=""header-img mt-2 mb-2"">

                    <img src=""../images/logotipo-hospital-sao-francisco.png""
                    alt=""logotipo da vizualização do receituário comum"">

                </div>

                <div class=""show-logo mt-2 mb-2"">

                    <h2 style=""text-decoration: underline 2px solid #007bff;"">FUNDAÇÃO DE SAÚDE TRÊS MARIAS</h2>
                    <h2>HOSPITAL SÃO FRANCISCO</h2>

                </div>

            </div>

            <div class=""show-body-atm"">

                <div class=""atm-title"">
                    <h1 class=""text-center"">ATESTADO MÉDICO</h1>
                </div>

                <div class=""prescription-data mt-4"">

");
#nullable restore
#line 195 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                     foreach (var item in atmList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <article class=""text-primary mt-5 "">

                            <p class=""p1"">Atesto para os devido fins que o(a) Sr.(a)</p>

                            <div class=""atm-pacient"">
                                <span class=""text-center ml-2"">");
#nullable restore
#line 202 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                                                          Write(item.PacientName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>

                            <div class=""row"">

                                <p class=""p2"">foi atendido(a) na unidade de</p>

                                <div class=""atm-MedicUnity"">

                                    <span");
            BeginWriteAttribute("class", " class=\"", 8586, "\"", 8594, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 211 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                                              Write(item.MedicUnity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                                </div>

                            </div>

                            <div class=""row"">

                                <p class=""p3"">do</p>

                                <div class=""atm-Local"">
                                    <span");
            BeginWriteAttribute("class", " class=\"", 8906, "\"", 8914, 0);
            EndWriteAttribute();
            WriteLiteral(">Hospital Municipal de Três Marias</span>\r\n                                </div>\r\n\r\n                                <p class=\"p3 ml-2\">no dia</p>\r\n\r\n                                <div class=\"atm-Data\">\r\n                                    <span");
            BeginWriteAttribute("class", " class=\"", 9162, "\"", 9170, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 228 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                                              Write(atmData);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>

                            </div>

                            <div class=""row"">

                                <p class=""p4"">às</p>

                                <div class=""atm-Time"">

                                    <span");
            BeginWriteAttribute("class", " class=\"", 9473, "\"", 9481, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n\r\n                                </div>\r\n\r\n                                <p class=\"p4 ml-2\">horas. Necessitando de</p>\r\n\r\n                                <div class=\"atm-RestDays\">\r\n\r\n                                    <span");
            BeginWriteAttribute("class", " class=\"", 9720, "\"", 9728, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 247 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                                              Write(item.RestDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                </div>\r\n\r\n                                <p class=\"p5 ml-2\">dias de repouso.</p>\r\n\r\n                            </div>\r\n\r\n                        </article>\r\n");
#nullable restore
#line 256 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

            </div>

            <div class=""show-footer"">
                <P>BR 040 - KM 438 - BRASÍLIA / BELO HORIZONTE - TEL.: (38) 3754-1256</P>
                <p><span>PARQUE DIADORIM</span> - CEP: 39205-000 - TRÊS MARIAS - MINAS GERAIS</p>
                <div class=""line""></div>
            </div>

        </div>
");
#nullable restore
#line 269 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning w-50 text-center alert-medication\" role=\"alert\">\r\n            Ainda não existe um atestado médico para ser exibido !\r\n        </div>\r\n");
#nullable restore
#line 276 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<!--Start Medication Modal-->\r\n\r\n<div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 10603, "\"", 10638, 2);
            WriteAttributeValue("", 10608, "atm-medication-modal-", 10608, 21, true);
#nullable restore
#line 282 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
WriteAttributeValue("", 10629, Model.Id, 10629, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog""
    aria-labelledby=""registerUserTitle"" aria-hidden=""true"">

    <div class=""modal-dialog modal-dialog-centered modal-md"" role=""document"">

        <div class=""modal-content"">

            <div class=""modal-header bg-primary text-light text-center"">

                <h2 class=""text-center mb-0""> Inserir Medicamento</h2>

                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">

                    <span class=""text-light"" aria-hidden=""true"">&times;</span>

                </button>

            </div>

            <div class=""modal-body p-3"">
                ");
#nullable restore
#line 302 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
           Write(await Html.PartialAsync("/Views/Medicacao/_MedicationRegister.cshtml", @medic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<!--Finish Medication Modal-->\r\n\r\n<!--Start ATM Modal-->\r\n\r\n<div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 11517, "\"", 11541, 2);
            WriteAttributeValue("", 11522, "atm-modal-", 11522, 10, true);
#nullable restore
#line 315 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
WriteAttributeValue("", 11532, Model.Id, 11532, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""registerUserTitle""
    aria-hidden=""true"">

    <div class=""modal-dialog modal-dialog-centered modal-md"" role=""document"">

        <div class=""modal-content"">

            <div class=""modal-header text-center"">

                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">

                    <span aria-hidden=""true"">&times;</span>

                </button>

            </div>

            <div class=""modal-body p-2"">
                ");
#nullable restore
#line 333 "C:\Users\Administrador\Desktop\HSF_Receitas_Refatorado\Views\AtestadoMedico\ATMCompletePrescription.cshtml"
           Write(await Html.PartialAsync("/Views/AtestadoMedico/_ATMRegister.cshtml", @atm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<!--Finish ATM Modal-->");
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
