#pragma checksum "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e735587984d6b879ee6c86ae185b7eb02bc21278"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\_ViewImports.cshtml"
using Todo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\_ViewImports.cshtml"
using Todo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\_ViewImports.cshtml"
using Todo.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e735587984d6b879ee6c86ae185b7eb02bc21278", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac63615b47ed8d024a32e2483176adce9f7077fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row justify-content-left"">
    <div class=""col-xl-6 col-lg-8 col-md-8 col-sm-10"">
        <table class=""table"">
            <thead>
                <tr class=""table-primary"">
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Completed</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 15 "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\Home\Index.cshtml"
                 foreach (var t in Model.TodoList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <th class=\"todos-column\" scope=\"row\">");
#nullable restore
#line 18 "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\Home\Index.cshtml"
                                                        Write(t.intID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <td class=\"todos-column\">");
#nullable restore
#line 19 "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\Home\Index.cshtml"
                                            Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"todos-column\">");
#nullable restore
#line 20 "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\Home\Index.cshtml"
                                            Write(t.isComplete);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"buttons-column\">\n                            <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\"");
            BeginWriteAttribute("onClick", " onClick=\"", 892, "\"", 922, 3);
            WriteAttributeValue("", 902, "deleteTodo(", 902, 11, true);
#nullable restore
#line 22 "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\Home\Index.cshtml"
WriteAttributeValue("", 913, t.intID, 913, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 921, ")", 921, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n");
            WriteLiteral("                            <input type=\"submit\" id=\"ShowButton\" class=\"btn btn-primary\" value=\"Complete\"");
            BeginWriteAttribute("onClick", " onClick=\"", 1160, "\"", 1192, 3);
            WriteAttributeValue("", 1170, "completeTodo(", 1170, 13, true);
#nullable restore
#line 24 "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\Home\Index.cshtml"
WriteAttributeValue("", 1183, t.intID, 1183, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1191, ")", 1191, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                        </td>\n\n                    </tr>\n");
#nullable restore
#line 28 "C:\Users\John_\Downloads\Compressed\Todo-20220804T221058Z-001\Todo\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
