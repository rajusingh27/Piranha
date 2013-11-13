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

namespace Piranha.Areas.Manager.Views.Template
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
    
    #line 2 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
    using Piranha.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Template/PageList.cshtml")]
    public partial class PageList : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.TemplateModels.PageListModel>
    {
        public PageList()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
  
    ViewBag.Title = @Piranha.Resources.Template.ListTitlePage;
    ViewBag.Selected = "Settings";
    ViewBag.SelectedTab = "PageType";


            
            #line default
            #line hidden

DefineSection("Head", () => {

WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function() {\r\n  " +
"          $(\".delete\").click(function() {\r\n                return confirm(\"");


            
            #line 12 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                           Write(Piranha.Resources.Template.MessageDeletePageConfirm);

            
            #line default
            #line hidden
WriteLiteral(@""") ;
            });

            var options = {
                listClass:  'list-js',
                searchId: 'search',
                valueNames: ['name', 'created', 'updated']
            };
            var list = new List('list', options);
        });
    </script>
");


});

WriteLiteral("\r\n");


DefineSection("Toolbar", () => {

WriteLiteral(" \r\n");


            
            #line 25 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"toolbar\">\r\n    <div class=\"inner\">\r\n        <ul>\r\n            <li><" +
"a href=\"");


            
            #line 29 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                    Write(Url.Action("page"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"add\">");


            
            #line 29 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                     Write(Piranha.Resources.Global.ToolbarAdd);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a href=\"\" class=\"refresh\">");


            
            #line 30 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                      Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <button class=\"search\" title=\"");


            
            #line 32 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                 Write(Piranha.Resources.Global.ToolbarSearch);

            
            #line default
            #line hidden
WriteLiteral("\"></button>");


            
            #line 32 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                                                   Write(Html.TextBox("search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</div>\r\n");


});

WriteLiteral("\r\n<div class=\"grid_12\">\r\n    <table id=\"list\" class=\"list\">\r\n        <thead>\r\n   " +
"         <tr>\r\n                <th><span class=\"sort asc\" data-sort=\"name\">");


            
            #line 41 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                       Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span class=\"sort\" data-sort=\"created\">");


            
            #line 42 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                      Write(Piranha.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span class=\"sort\" data-sort=\"updated\">");


            
            #line 43 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                      Write(Piranha.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n   " +
"     <tbody class=\"list-js\">\r\n");


            
            #line 48 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
             foreach (var pt in Model.Templates) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td class=\"name\"><a href=\"");


            
            #line 50 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                     Write(Url.Action("page", new { id = pt.Id }));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 50 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                                              Write(pt.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td class=\"created date\">");


            
            #line 51 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                    Write(pt.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"updated date\">");


            
            #line 52 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                    Write(pt.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"buttons one\">\r\n");


            
            #line 54 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                     if (!pt.IsLocked) {

            
            #line default
            #line hidden
WriteLiteral("                    <a class=\"icon delete\" title=\"");


            
            #line 55 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                             Write(Piranha.Resources.Template.ListDeletePage);

            
            #line default
            #line hidden
WriteLiteral("\" href=\"");


            
            #line 55 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                                                               Write(Url.Action("deletepage", new { id = pt.Id }));

            
            #line default
            #line hidden
WriteLiteral("\"></a>\r\n");


            
            #line 56 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");


            
            #line 59 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=" +
"\"5\"></td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
