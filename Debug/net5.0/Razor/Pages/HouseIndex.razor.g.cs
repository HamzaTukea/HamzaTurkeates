#pragma checksum "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8e7099a8ff2b82040aa56a768e104bc2ed5784a"
// <auto-generated/>
#pragma warning disable 1591
namespace HamzaTestAPP.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\_Imports.razor"
using HamzaTestAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\_Imports.razor"
using HamzaTestAPP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
using HamzaTestAPP.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/HouseIndex")]
    public partial class HouseIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "<div class=\"col-md-4\"><label> House ID :</label></div>\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-8");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "style", "width:100%");
            __builder.AddAttribute(11, "placeholder", "House ID");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                              house.HouseId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.HouseId = __value, house.HouseId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.AddMarkupContent(16, "<div class=\"col-md-4\"><label> Adress :</label></div>\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-8");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "style", "width:100%");
            __builder.AddAttribute(21, "placeholder", "Adress");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                              house.Adress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Adress = __value, house.Adress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
            __builder.AddMarkupContent(27, "<div class=\"col-md-4\"><label> Type Of Offer :</label></div>\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-md-8");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "style", "width:100%");
            __builder.AddAttribute(32, "placeholder", "Type Of Offer");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                              house.TypeOfOffer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.TypeOfOffer = __value, house.TypeOfOffer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "p");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(37);
            __builder.AddAttribute(38, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                  OnInputFileChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(39, "multiple", true);
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
         if (imageUrls.Count > 0) { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "card");
            __builder.AddAttribute(42, "style", "width:30rem;");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "card-body");
#nullable restore
#line 37 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                 foreach (var imageurl in imageUrls)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "img");
            __builder.AddAttribute(46, "class", "rounded-1 ");
            __builder.AddAttribute(47, "src", 
#nullable restore
#line 39 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                                  imageurl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "style", "width:100%");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                  house.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Image = __value, house.Image));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                    
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "row");
            __builder.AddMarkupContent(55, "<div class=\"col-md-4\"></div>\r\n            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-md-8");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                                            e => Save()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "class", "btn btn-danger");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                                           e => Reset()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "style", "float:right;");
            __builder.AddContent(67, "Reset");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col-md-8");
            __builder.OpenElement(71, "table");
            __builder.AddAttribute(72, "class", "table table-striped table-bordered");
            __builder.AddMarkupContent(73, "<thead><tr><th>House ID</th>\r\n                    <th>Adress</th>\r\n                    <th>Type Of Offer</th>\r\n                    <th>Image</th></tr></thead>\r\n            ");
            __builder.OpenElement(74, "tbody");
#nullable restore
#line 69 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                 if (housess.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                     foreach (var ho in housess)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "tr");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 74 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                 ho.HouseId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 75 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                 ho.Adress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                            ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 76 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                 ho.TypeOfOffer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                            ");
            __builder.OpenElement(85, "td");
            __builder.AddContent(86, 
#nullable restore
#line 77 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                 ho.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                            ");
            __builder.OpenElement(88, "td");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "class", "btn btn-primary");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                                                            e => Edit(@ho.HouseId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(92, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                                ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "class", "btn btn-danger");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                                                                           e => Delete(@ho.HouseId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(97, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\hp\source\repos\HamzaTestAPP\HamzaTestAPP\Pages\HouseIndex.razor"
       

    Houses house = new Houses();
    List<Houses> housess = new List<Houses>();

    private IList<string> imageUrls = new List<string>();

    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        var maxAllowedFiles = 3;
        var format = "image/png";

        foreach (var imageFile in e.GetMultipleFiles(maxAllowedFiles))
        {
            var resizedFile = await imageFile.RequestImageFileAsync(format, 100, 100);
            var buffer = new byte[resizedFile.Size];

            resizedFile.OpenReadStream().ReadAsync(buffer);

            var imageUrl = $"data:{format};base64,{Convert.ToBase64String(buffer)}";
            imageUrls.Add(imageUrl);
        }

    }

    private void GetHouses()
    {
        housess = houseRepository.GetsHouses();
    }

    protected override async Task OnInitializedAsync()
    {
        GetHouses();
    }

    private void Save()

    {
        houseRepository.Save(house);
        Reset();
        GetHouses();
    }
    private void Update()

    {
        houseRepository.Update(house);
        Reset();
        GetHouses();
    }
    private void Reset()
    {
        Houses house = new Houses();
    }
    private void Edit(string houseId)
    {
        house = houseRepository.GetHouse(houseId);
    }
    private void Delete(string houseId)
    {
        houseRepository.Delete(houseId);
        GetHouses();
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HamzaTestAPP.IRepository.IHouseRepository houseRepository { get; set; }
    }
}
#pragma warning restore 1591