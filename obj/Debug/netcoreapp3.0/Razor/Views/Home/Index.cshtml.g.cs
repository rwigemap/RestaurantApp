#pragma checksum "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4475081609a3e707bb99524838e56f9d0834851"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4475081609a3e707bb99524838e56f9d0834851", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.ViewsModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Index.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div><br><br>\r\n    <h2 class=\"text-success\">WELCOME TO OUR FOOD SHOP</h2>\r\n    <br><br>\r\n    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Index.cshtml"
             foreach (var resto in Model.Restaurants)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-4 mb-2"">
   
                    <div class=""card"" style=""width: 18rem;"">

                        <!-- Card image -->
                        <div>
                            <img class=""card-img-top"" src=""https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQz2_q9zpZO3y1rZhXNlnUPoR8Q1vkZP1BCiOBgSiuWBCJz_gTj"" alt=""Card image cap"">
                            <div class=""mask rgba-white-slight""></div>
                        </div>

                        <div class=""card-body"">
                            <div class=""card-title""><h4 class=""card-title text-success"">");
#nullable restore
#line 28 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Index.cshtml"
                                                                                   Write(Html.ActionLink(resto.Name, "Details", new {id = resto.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                            <p class=\"card-text\">Some Descriptions about <b>");
#nullable restore
#line 29 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Index.cshtml"
                                                                       Write(resto.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            \r\n                            <button type=\"button\"  class=\"btn btn-outline-info\" >");
#nullable restore
#line 31 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Index.cshtml"
                                                                            Write(Html.ActionLink("Edit","Edit",new {id = resto.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                            <button type=\"button\" class=\"btn btn-outline-danger\">");
#nullable restore
#line 32 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Index.cshtml"
                                                                            Write(Html.ActionLink("Delete","Delete",new {id = resto.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                            \r\n                        </div>\r\n\r\n                    </div>\r\n         \r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.ViewsModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591