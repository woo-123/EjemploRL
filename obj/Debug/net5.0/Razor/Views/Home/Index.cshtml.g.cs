#pragma checksum "C:\Users\diego\Desktop\Fia 9\Programacion1\EjemploRL\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a643b07b2e40fbb459a83c878597d1404d5a345"
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
#line 1 "C:\Users\diego\Desktop\Fia 9\Programacion1\EjemploRL\Views\_ViewImports.cshtml"
using EjemploRL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diego\Desktop\Fia 9\Programacion1\EjemploRL\Views\_ViewImports.cshtml"
using EjemploRL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a643b07b2e40fbb459a83c878597d1404d5a345", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e3dc6190c5796130996ff87d1918060da2e5884", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\diego\Desktop\Fia 9\Programacion1\EjemploRL\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""carousel"">
    <div class='carousel__contenedor'>
        <button arial-label='Anterior' class='carousel__anterior'>
            <i class=""fas fa-chevron-left""></i>
        </button>
        <div class='carousel__lista' id='glider'>
            <div class='carousel__elemento'>
                <img src=""/images/carousel1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 392, "\"", 398, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\'carousel__elemento\'>\r\n                <img src=\"/images/carousel2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 516, "\"", 522, 0);
            EndWriteAttribute();
            WriteLiteral(">  \r\n            </div>\r\n            <div class=\'carousel__elemento\'>\r\n                <img src=\"/images/carousel3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 642, "\"", 648, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
        </div>
        <button arial-label='Siguiente' class='carousel__siguiente'>
            <i class=""fas fa-chevron-right""></i>
        </button>
        <div role='tablist' class='carousel__indicadores'></div>
    </div>
    
</div>

<div class='nosotros' id='nosotros'>
    <div class='nosotros-text'>
        <h1>Nosotros</h1>
        <p>Somos una compañia de correcio electronico  Lorem ipsum dolor, sit amet consectetur adipisicing elit. Libero, natus nobis dolore atque placeat, saepe illum eius delectus nisi fugiat adipisci? Minus non distinctio quam vel necessitatibus, nostrum ipsa sit?</p>
        <p>Somos una compañia de correcio electronico  Lorem ipsum dolor, sit amet consectetur adipisicing elit. Libero, natus nobis dolore atque placeat, saepe illum eius delectus nisi fugiat adipisci? Minus non distinctio quam vel necessitatibus, nostrum ipsa sit?</p>
        
    </div>
      <div class='nosotros-img'>
          <img src=""/images/nosotros1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1661, "\"", 1667, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n      </div> \r\n</div>\r\n<div class=\'card-contenido\'>\r\n    <div class=\'card\' > \r\n       <div class=\'card-img\'><img src=\"/images/pc1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1805, "\"", 1811, 0);
            EndWriteAttribute();
            WriteLiteral(@"> </div>
        <div class='card-text'>
            <h1>Pc Escritorio && componentes</h1>
            <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eos hic explicabo, eum voluptates sequi magnam? Inventore numquam voluptatem, ipsam culpa voluptates nisi voluptatibus deserunt perferendis iure repudiandae dicta ab placeat?</p>
        </div>
    </div>
    <div class='card'>
        <div class='card-img'> <img src=""/images/portatil1.png""");
            BeginWriteAttribute("alt", " alt=\"", 2274, "\"", 2280, 0);
            EndWriteAttribute();
            WriteLiteral(@"> </div>
        <div class='card-text'> 
            <h1>Portatil</h1>
            <p> Lorem ipsum dolor sit amet consectetur adipisicing elit. Corporis numquam libero dolorem ad vero ipsum itaque. Totam asperiores voluptate hic, atque rerum, blanditiis ad quaerat inventore, aperiam possimus perferendis delectus.</p>
        </div>
    </div>
    <div class='card'>
        <div class='card-img'> <img src=""/images/raton1.png""");
            BeginWriteAttribute("alt", " alt=\"", 2717, "\"", 2723, 0);
            EndWriteAttribute();
            WriteLiteral(@"> </div>
        <div class='card-text'>
            <h1>Periféricos</h1>
            <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Modi, impedit! Alias quo a voluptatum iusto at soluta eum odio. Recusandae ratione repellendus deleniti ullam, quibusdam nulla nemo incidunt assumenda magni!</p>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
