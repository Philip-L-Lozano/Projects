#pragma checksum "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0576ed58d1983e0dfc58957c7b2a58af5daac8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchAPI), @"mvc.1.0.view", @"/Views/Search/SearchAPI.cshtml")]
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
#line 1 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\_ViewImports.cshtml"
using WebProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\_ViewImports.cshtml"
using WebProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0576ed58d1983e0dfc58957c7b2a58af5daac8e", @"/Views/Search/SearchAPI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d35d2813d6673bb22d8616e0dbf06eada8dc73d", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchAPI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProject.Models.RootObject>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
  
    ViewData["Title"] = "API";
    ViewData["Search"] = "MovieReturn";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n");
#nullable restore
#line 12 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
Write(Html.Partial("_Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<hr />\n<h4\">");
#nullable restore
#line 15 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
Write(ViewBag.SearchString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n<br />\n");
#nullable restore
#line 18 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
  
        if (!(bool)ViewBag.noResults)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class =""table table-hover table-condensed"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">    </th> 
                        <th scope=""col"">ID</th> 
                        <th scope=""col"">Title</th> 
                        <th scope=""col"">Released</th> 
                        <th scope=""col"">Type</th> 
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 32 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
                     foreach(var a in Model.Search)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                                <td><img");
            BeginWriteAttribute("src", " src=\"", 858, "\"", 874, 1);
#nullable restore
#line 35 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
WriteAttributeValue("", 864, a?.Poster, 864, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"float:left;width:70px;height:85px;\"/></td>\n                                <td>");
#nullable restore
#line 36 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
                               Write(a?.imdbID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 37 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
                               Write(a?.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 38 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
                               Write(a?.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 39 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
                               Write(a?.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 41 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n");
#nullable restore
#line 44 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 49 "C:\Users\lozan\MSSA2021\Project\WebProject\WebProject\Views\Search\SearchAPI.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProject.Models.RootObject> Html { get; private set; }
    }
}
#pragma warning restore 1591