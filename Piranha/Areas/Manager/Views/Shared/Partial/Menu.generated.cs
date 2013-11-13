﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Shared.Partial
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
    using Piranha.Web;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
    using Piranha.WebPages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Shared/Partial/Menu.cshtml")]
    public partial class Menu : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Menu()
        {
        }
        public override void Execute()
        {


WriteLiteral("<ul class=\"menu\">\r\n");


            
            #line 4 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
     foreach (var group in Manager.Menu) {
        if (group.HasAccess()) {
            var items = group.ItemsForUser() ;

            
            #line default
            #line hidden
WriteLiteral("            <li class=\"");


            
            #line 7 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
                   Write(group.IsActive() ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 7 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
                                                         Write(!String.IsNullOrEmpty(group.CssClass) ? "icon " + group.CssClass : "");

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                <a href=\"");


            
            #line 8 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
                    Write(Url.Action(items[0].Action, items[0].Controller));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 8 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
                                                                       Write(group.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 9 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("    <li class=\"icon logout\"><a href=\"");


            
            #line 11 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
                                Write(Url.Action("logout", "account"));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 11 "..\..\Areas\Manager\Views\Shared\Partial\Menu.cshtml"
                                                                  Write(Piranha.Resources.Global.MenuLogout);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n</ul>\r\n");


        }
    }
}
#pragma warning restore 1591
