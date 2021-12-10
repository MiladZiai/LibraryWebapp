#pragma checksum "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "836e5a5f5b1632565cfdbf018300b4fd5ecd01eb"
// <auto-generated/>
#pragma warning disable 1591
namespace LibraryServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 3 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
using LibraryServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addLibraryItem/{categoryId:int}")]
    public partial class AddLibraryItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Library Item</h3>\r\n\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                         OnSelect

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "style", "width:170px");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 16 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
     foreach (var type in types)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 18 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                       type

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 18 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
__builder.AddContent(9, type);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 19 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<br>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
 switch (selectedString)
{
    case "Book":

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-4");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "form");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.AddMarkupContent(24, "<label for=\"Name\" class=\"control-label\">Title</label>\r\n                        ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "for", "Name");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Title = __value, Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.AddMarkupContent(35, "<label for=\"Name\" class=\"control-label\">Author</label>\r\n                        ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "for", "Name");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             Author

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Author = __value, Author));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.AddMarkupContent(46, "<label for=\"Name\" class=\"control-label\">Pages</label>\r\n                        ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "for", "Name");
            __builder.AddAttribute(49, "class", "form-control");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             Pages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pages = __value, Pages));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "form-group");
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.AddMarkupContent(57, "<label for=\"Name\" class=\"control-label\">Type</label>\r\n                        ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "for", "Name");
            __builder.AddAttribute(60, "class", "form-control");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Type = __value, Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form-group");
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.AddMarkupContent(68, "<label for=\"Name\" class=\"control-label\">CategoryId</label>\r\n                        ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "for", "Name");
            __builder.AddAttribute(71, "class", "form-control");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             categoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => categoryId = __value, categoryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "form-group");
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.AddMarkupContent(79, "<label for=\"Name\" class=\"control-label\">Is Borrowable: true</label>\r\n                        ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "for", "Name");
            __builder.AddAttribute(82, "class", "form-control");
            __builder.AddAttribute(83, "style", "visibility: hidden;");
            __builder.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                                                                                         IsBorrowable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IsBorrowable = __value, IsBorrowable));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "form-group");
            __builder.AddMarkupContent(90, "\r\n                        ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "type", "button");
            __builder.AddAttribute(93, "class", "btn btn-primary");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                          () => addLibraryItem()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(95, "\r\n                            Add\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                        ");
            __builder.OpenElement(97, "button");
            __builder.AddAttribute(98, "type", "button");
            __builder.AddAttribute(99, "class", "btn btn-warning");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                          () => cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(101, "\r\n                            Cancel\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 71 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
        break;
    case "DVD":
    case "Audio Book":

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "        ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "row");
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-md-4");
            __builder.AddMarkupContent(113, "\r\n                ");
            __builder.OpenElement(114, "form");
            __builder.AddMarkupContent(115, "\r\n                    ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "form-group");
            __builder.AddMarkupContent(118, "\r\n                        ");
            __builder.AddMarkupContent(119, "<label for=\"Name\" class=\"control-label\">Title</label>\r\n                        ");
            __builder.OpenElement(120, "input");
            __builder.AddAttribute(121, "for", "Name");
            __builder.AddAttribute(122, "class", "form-control");
            __builder.AddAttribute(123, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Title = __value, Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "form-group");
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.AddMarkupContent(130, "<label for=\"Name\" class=\"control-label\">Runtime Minutes</label>\r\n                        ");
            __builder.OpenElement(131, "input");
            __builder.AddAttribute(132, "for", "Name");
            __builder.AddAttribute(133, "class", "form-control");
            __builder.AddAttribute(134, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 85 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             RunTimeMinutes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(135, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => RunTimeMinutes = __value, RunTimeMinutes));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                    ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "form-group");
            __builder.AddMarkupContent(140, "\r\n                        ");
            __builder.AddMarkupContent(141, "<label for=\"Name\" class=\"control-label\">Type</label>\r\n                        ");
            __builder.OpenElement(142, "input");
            __builder.AddAttribute(143, "for", "Name");
            __builder.AddAttribute(144, "class", "form-control");
            __builder.AddAttribute(145, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 90 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(146, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Type = __value, Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                    ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "form-group");
            __builder.AddMarkupContent(151, "\r\n                        ");
            __builder.AddMarkupContent(152, "<label for=\"Name\" class=\"control-label\">CategoryId</label>\r\n                        ");
            __builder.OpenElement(153, "input");
            __builder.AddAttribute(154, "for", "Name");
            __builder.AddAttribute(155, "class", "form-control");
            __builder.AddAttribute(156, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 95 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             categoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(157, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => categoryId = __value, categoryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                    ");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "form-group");
            __builder.AddMarkupContent(162, "\r\n                        ");
            __builder.AddMarkupContent(163, "<label for=\"Name\" class=\"control-label\">Is Borrowable: true</label>\r\n                        ");
            __builder.OpenElement(164, "input");
            __builder.AddAttribute(165, "for", "Name");
            __builder.AddAttribute(166, "class", "form-control");
            __builder.AddAttribute(167, "style", "visibility: hidden;");
            __builder.AddAttribute(168, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                                                                                         IsBorrowable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(169, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IsBorrowable = __value, IsBorrowable));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                    ");
            __builder.OpenElement(172, "div");
            __builder.AddAttribute(173, "class", "form-group");
            __builder.AddMarkupContent(174, "\r\n                        ");
            __builder.OpenElement(175, "button");
            __builder.AddAttribute(176, "type", "button");
            __builder.AddAttribute(177, "class", "btn btn-primary");
            __builder.AddAttribute(178, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                          () => addLibraryItem()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(179, "\r\n                            Add\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                        ");
            __builder.OpenElement(181, "button");
            __builder.AddAttribute(182, "type", "button");
            __builder.AddAttribute(183, "class", "btn btn-warning");
            __builder.AddAttribute(184, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                          () => cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(185, "\r\n                            Cancel\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n");
#nullable restore
#line 114 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
        break;
    case "Reference Book":

#line default
#line hidden
#nullable disable
            __builder.AddContent(191, "        ");
            __builder.OpenElement(192, "div");
            __builder.AddAttribute(193, "class", "row");
            __builder.AddMarkupContent(194, "\r\n            ");
            __builder.OpenElement(195, "div");
            __builder.AddAttribute(196, "class", "col-md-4");
            __builder.AddMarkupContent(197, "\r\n                ");
            __builder.OpenElement(198, "form");
            __builder.AddMarkupContent(199, "\r\n                    ");
            __builder.OpenElement(200, "div");
            __builder.AddAttribute(201, "class", "form-group");
            __builder.AddMarkupContent(202, "\r\n                        ");
            __builder.AddMarkupContent(203, "<label for=\"Name\" class=\"control-label\">Title</label>\r\n                        ");
            __builder.OpenElement(204, "input");
            __builder.AddAttribute(205, "for", "Name");
            __builder.AddAttribute(206, "class", "form-control");
            __builder.AddAttribute(207, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 122 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(208, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Title = __value, Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(210, "\r\n                    ");
            __builder.OpenElement(211, "div");
            __builder.AddAttribute(212, "class", "form-group");
            __builder.AddMarkupContent(213, "\r\n                        ");
            __builder.AddMarkupContent(214, "<label for=\"Name\" class=\"control-label\">Author</label>\r\n                        ");
            __builder.OpenElement(215, "input");
            __builder.AddAttribute(216, "for", "Name");
            __builder.AddAttribute(217, "class", "form-control");
            __builder.AddAttribute(218, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 127 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             Author

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(219, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Author = __value, Author));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n                    ");
            __builder.OpenElement(222, "div");
            __builder.AddAttribute(223, "class", "form-group");
            __builder.AddMarkupContent(224, "\r\n                        ");
            __builder.AddMarkupContent(225, "<label for=\"Name\" class=\"control-label\">Pages</label>\r\n                        ");
            __builder.OpenElement(226, "input");
            __builder.AddAttribute(227, "for", "Name");
            __builder.AddAttribute(228, "class", "form-control");
            __builder.AddAttribute(229, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 132 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             Pages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(230, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pages = __value, Pages));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(231, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(232, "\r\n                    ");
            __builder.OpenElement(233, "div");
            __builder.AddAttribute(234, "class", "form-group");
            __builder.AddMarkupContent(235, "\r\n                        ");
            __builder.AddMarkupContent(236, "<label for=\"Name\" class=\"control-label\">Type</label>\r\n                        ");
            __builder.OpenElement(237, "input");
            __builder.AddAttribute(238, "for", "Name");
            __builder.AddAttribute(239, "class", "form-control");
            __builder.AddAttribute(240, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 137 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(241, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Type = __value, Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(242, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(243, "\r\n                    ");
            __builder.OpenElement(244, "div");
            __builder.AddAttribute(245, "class", "form-group");
            __builder.AddMarkupContent(246, "\r\n                        ");
            __builder.AddMarkupContent(247, "<label for=\"Name\" class=\"control-label\">CategoryId</label>\r\n                        ");
            __builder.OpenElement(248, "input");
            __builder.AddAttribute(249, "for", "Name");
            __builder.AddAttribute(250, "class", "form-control");
            __builder.AddAttribute(251, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 142 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                             categoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(252, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => categoryId = __value, categoryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(253, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(254, "\r\n                    ");
            __builder.OpenElement(255, "div");
            __builder.AddAttribute(256, "class", "form-group");
            __builder.AddMarkupContent(257, "\r\n                        ");
            __builder.AddMarkupContent(258, "<label for=\"Name\" class=\"control-label\">Is Borrowable: false</label>\r\n                        ");
            __builder.OpenElement(259, "input");
            __builder.AddAttribute(260, "for", "Name");
            __builder.AddAttribute(261, "class", "form-control");
            __builder.AddAttribute(262, "style", "visibility: hidden");
            __builder.AddAttribute(263, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 146 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                                                                                        IsBorrowable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(264, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IsBorrowable = __value, IsBorrowable));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(265, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(266, "\r\n                    ");
            __builder.OpenElement(267, "div");
            __builder.AddAttribute(268, "class", "form-group");
            __builder.AddMarkupContent(269, "\r\n                        ");
            __builder.OpenElement(270, "button");
            __builder.AddAttribute(271, "type", "button");
            __builder.AddAttribute(272, "class", "btn btn-primary");
            __builder.AddAttribute(273, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 150 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                          () => addLibraryItem()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(274, "\r\n                            Add\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(275, "\r\n                        ");
            __builder.OpenElement(276, "button");
            __builder.AddAttribute(277, "type", "button");
            __builder.AddAttribute(278, "class", "btn btn-warning");
            __builder.AddAttribute(279, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 154 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
                                          () => cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(280, "\r\n                            Cancel\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(281, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(282, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(283, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(284, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(285, "\r\n");
#nullable restore
#line 161 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
        break;
    default:
        break;
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 167 "C:\Users\milad\source\repos\LibraryServer\LibraryServer\Pages\AddLibraryItem.razor"
       

    [Parameter]
    public int categoryId { get; set; }

    string Title;
    string Author;
    int Pages;
    string Type;
    int RunTimeMinutes;
    int IsBorrowable;

    List<string> types = new List<string>() { "Book", "DVD", "Audio Book", "Reference Book" };
    string selectedString = "Book";

    private async Task addLibraryItem()
    {

        string sql = "insert into libraryitem (CategoryId, Title, Author, Pages, RunTimeMinutes, IsBorrowable, Type) " +
                " values (@categoryId, @Title, @Author, @Pages, @RunTimeMinutes, @IsBorrowable, @Type);";

        if(selectedString == "Reference Book")
        {
            await toggleIsBorrowable(sql, 0);
        }
        else
        {
            await toggleIsBorrowable(sql, 1);
        }

        navigationManager.NavigateTo("/libraryItems");
    }

    private async Task toggleIsBorrowable(string sql, int isBorrowable)
    {
        await data.StoreData(sql, new
        {
            CategoryId = @categoryId,
            Title = @Title,
            Author = @Author,
            Pages = @Pages,
            RunTimeMinutes = @RunTimeMinutes,
            IsBorrowable = isBorrowable,
            Type = @Type,
        }, config.GetConnectionString("DefaultConnection"));
    }

    void cancel()
    {
        navigationManager.NavigateTo("/category");
    }

    void OnSelect(ChangeEventArgs e)
    {
        selectedString = e.Value.ToString();
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
