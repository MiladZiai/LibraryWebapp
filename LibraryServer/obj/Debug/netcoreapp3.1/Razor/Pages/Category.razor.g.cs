#pragma checksum "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "158db7514c2bc2f1449368b6492c016ca06ac8e2"
// <auto-generated/>
#pragma warning disable 1591
namespace LibraryServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\_Imports.razor"
using LibraryServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\_Imports.razor"
using LibraryServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
using LibraryServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category")]
    public partial class Category : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Category</h3>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
 if (category == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 16 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<div>\r\n        <a class=\"btn btn-primary\" href=\'/addCategory\'>Add category</a>\r\n    </div>\r\n    <br>\r\n");
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, @"<thead>
                <tr>
                    <th>Id</th>
                    <th>Category Name</th>
                    <th>Action</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 36 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
                 foreach (var c in category)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                    ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 39 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
__builder.AddContent(18, c.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 40 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
__builder.AddContent(21, c.CategoryName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "class", "btn btn-primary");
            __builder.AddAttribute(26, "href", "/editCategory/" + (
#nullable restore
#line 41 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
                                                                            c.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 41 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
                                                                                  c.CategoryName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Edit category");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddAttribute(32, "href", "/addLibraryItem/" + (
#nullable restore
#line 42 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
                                                                              c.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Add Item");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "btn btn-warning");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
                                                                 () => deleteCategory(c.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Delete category");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 45 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 49 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\Category.razor"
       

    List<CategoryModel> category;

    protected override async Task OnInitializedAsync()
    {
        string sql = "select * from category";

        category = await data.LoadData<CategoryModel, dynamic>(sql, new { }, config.GetConnectionString("DefaultConnection"));
    }

    protected async Task deleteCategory(int id)
    {
        string sql = "delete from category where Id = @id";

        await data.StoreData(sql, new { Id = id }, config.GetConnectionString("DefaultConnection"));

        await OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess data { get; set; }
    }
}
#pragma warning restore 1591
