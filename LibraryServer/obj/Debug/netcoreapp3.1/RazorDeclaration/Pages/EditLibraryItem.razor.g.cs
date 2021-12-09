// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LibraryServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
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
#line 3 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\EditLibraryItem.razor"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\EditLibraryItem.razor"
using LibraryServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\EditLibraryItem.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\EditLibraryItem.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\EditLibraryItem.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\EditLibraryItem.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editLibraryItem/{id:int}/{type}")]
    public partial class EditLibraryItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\EditLibraryItem.razor"
       

    List<LibraryItemModel> libraryItem;

    [Parameter]
    public int id { get; set; }

    [Parameter]
    public string type { get; set; }

    protected override async Task OnInitializedAsync()
    {
        string sql = " select l.Id, l.Title, l.Type, l.Author, l.Pages, l.RunTimeMinutes, l.IsBorrowable, l.CategoryId " +
                     " from libraryitem as l " +
                     " where Id = @id ";

        libraryItem = await data.LoadData<LibraryItemModel, dynamic>(sql, new { Id = @id }, config.GetConnectionString("DefaultConnection"));
    }

    //private async Task editLibraryItem()
    //{

    //    string sql = " update libraryitem set (CategoryId, Title, Author, Pages, RunTimeMinutes, Type) " +
    //                 " values (@CategoryId, @Title, @Author, @Pages, @RunTimeMinutes, @Type)  " +
    //                 " where Id = @id ";

    //    await data.StoreData(sql, new
    //    {
    //        CategoryId = @CategoryId,
    //        Title = @Title,
    //        Author = @Author,
    //        Pages = @Pages,
    //        RunTimeMinutes = @RunTimeMinutes,
    //        Type = @Type,
    //        Id = @id,
    //    }, config.GetConnectionString("DefaultConnection"));

    //    navigationManager.NavigateTo("/category");
    //}

    void cancel()
    {
        navigationManager.NavigateTo("/libraryItems");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess data { get; set; }
    }
}
#pragma warning restore 1591
