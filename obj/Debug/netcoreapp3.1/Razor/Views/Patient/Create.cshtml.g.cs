#pragma checksum "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aad2f73d7d6f76a699874d053e23f7a97ddf43ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Create), @"mvc.1.0.view", @"/Views/Patient/Create.cshtml")]
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
#line 1 "C:\Users\armel\Documents\current_project\HealthRecord\Views\_ViewImports.cshtml"
using HealthRecord;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armel\Documents\current_project\HealthRecord\Views\_ViewImports.cshtml"
using HealthRecord.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad2f73d7d6f76a699874d053e23f7a97ddf43ed", @"/Views/Patient/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40855ec26c63d7ecf724c3ca1d930240053c6455", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthRecord.Models.ViewModels.PatientViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
     using (Html.BeginForm(new { style = "width:70%;" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n");
#nullable restore
#line 14 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <fieldset>\r\n                <legend>Identit&eacute;</legend>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @for = "first" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 21 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control", @id = "first", @required = "required" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 22 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.LabelFor(model => model.Birthdate, htmlAttributes: new { @for = "birth" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 26 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.EditorFor(model => model.Birthdate, new { htmlAttributes = new { @class = "form-control", @id = "birth", @type = "date", @required = "required" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 27 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Birthdate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @for = "last" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 33 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control", @id = "last", @required = "required" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 34 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.LabelFor(model => model.NumCNI, htmlAttributes: new { @for = "cni" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.EditorFor(model => model.NumCNI, new { htmlAttributes = new { @class = "form-control", @id = "cni" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 39 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.NumCNI, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </fieldset>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"row\">\r\n            <fieldset>\r\n                <legend>Residence</legend>\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.LabelFor(model => model.City, htmlAttributes: new { @for = "city" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 52 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.DropDownListFor(model => model.City, new SelectList(new List<string>()), "please select", new { @class = "form-control custom-select", @id = "city", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 53 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.City, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 58 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.LabelFor(model => model.Quater, htmlAttributes: new { @for = "quater" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 59 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.EditorFor(model => model.Quater, new { htmlAttributes = new { @class = "form-control", @id = "quater" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 60 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Quater, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </fieldset>
        </div>
        <div class=""row"">
            <fieldset>
                <legend>Contacts</legend>
                <div class=""col-lg-6"">
                    <div class=""form-group"">
                        ");
#nullable restore
#line 70 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @for = "phone" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 71 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control", @id = "phone", @type = "tel", @required = "required" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 72 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 77 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @for = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 78 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", @id = "email", @type = "email", @required = "required" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 79 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </fieldset>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"row\">\r\n            <fieldset>\r\n                <legend></legend>\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 90 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.LabelFor(model => model.Marital, htmlAttributes: new { @for = "city" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 91 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.DropDownListFor(model => model.Marital, new SelectList(new List<string>() { "Married", "Divorced", "Widower", "Single" }), "please select", new { @class = "form-control custom-select", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 92 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Marital, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 97 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.LabelFor(model => model.Street, htmlAttributes: new { @for = "allergy" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 98 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.TextAreaFor(model => model.Street, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 99 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Street, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </fieldset>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\"");
            BeginWriteAttribute("formaction", " formaction=", 6078, "", 6111, 1);
#nullable restore
#line 109 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"
WriteAttributeValue("", 6090, Url.Action("Create"), 6090, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\" />\r\n        </div>\r\n");
#nullable restore
#line 111 "C:\Users\armel\Documents\current_project\HealthRecord\Views\Patient\Create.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <!--<div class=\"col-8\">\r\n        <div class=\"card card-info\">\r\n            <div class=\"card-header\">\r\n                <h3 class=\"card-title\">Personal Data</h3>\r\n            </div>\r\n             /.card-header\r\n \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aad2f73d7d6f76a699874d053e23f7a97ddf43ed18209", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""card-body"">
            <div class=""form-group row"">
                <label for=""inputEmail3"" class=""col-sm-2 col-form-label"">Email</label>
                <div class=""col-sm-10"">
                    <input type=""email"" class=""form-control"" id=""inputEmail3"" placeholder=""Email"">
                </div>
            </div>
            <div class=""form-group row"">
                <label for=""inputPassword3"" class=""col-sm-2 col-form-label"">Password</label>
                <div class=""col-sm-10"">
                    <input type=""password"" class=""form-control"" id=""inputPassword3"" placeholder=""Password"">
                </div>
            </div>
            <div class=""form-group row"">
                <div class=""offset-sm-2 col-sm-10"">
                    <div class=""form-check"">
                        <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck2"">
                        <label class=""form-check-label"" for=""exampleCheck2"">Remember me</label>
             ");
            WriteLiteral(@"       </div>
                </div>
            </div>
        </div>
        <!-- /.card-body 
    <div class=""card-footer"">
        <button type=""submit"" class=""btn btn-info"">Sign in</button>
        <button type=""submit"" class=""btn btn-default float-right"">Cancel</button>
    </div>
    <!-- /.card-footer
    </form>
</div>
    </div>-->

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthRecord.Models.ViewModels.PatientViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591