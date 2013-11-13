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

namespace Piranha.Areas.Manager.Views.Settings
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
    
    #line 2 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
    using Piranha.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Settings/UserList.cshtml")]
    public partial class UserList : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.SettingModels.UserListModel>
    {
        public UserList()
        {
        }
        public override void Execute()
        {



DefineSection("Head", () => {

WriteLiteral(@"
    <style type=""text/css"">
        .content .tabs {
            float: left;
            margin-left: 10px;
        }
        .content .tabs .selected {
            border: 0 none;
            padding: 10px 20px 6px;
        }
    </style>
    <script type=""text/javascript"">
        $(document).ready(function () {
            var options = {
                listClass: 'list-js',
                searchId: 'search',
                valueNames: ['login', 'name', 'group', 'updated', 'created']
            };
            var list = new List('list', options);
        });
    </script>
");


});

WriteLiteral("\r\n");


DefineSection("Toolbar", () => {

WriteLiteral("\r\n");


            
            #line 26 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"toolbar\">\r\n    <div class=\"inner\">\r\n        <ul>\r\n            <li i" +
"d=\"add\">\r\n                <a href=\"");


            
            #line 31 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    Write(Url.Action("user"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"add\">");


            
            #line 31 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                     Write(Piranha.Resources.Global.ToolbarAdd);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n            <li><a href=\"");


            
            #line 33 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    Write(Url.Action("userlist"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"refresh\">");


            
            #line 33 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                             Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <button class=\"search\"></button>");


            
            #line 35 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                   Write(Html.TextBox("search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</div>\r\n");


});

WriteLiteral("\r\n\r\n<div class=\"grid_12\">\r\n");


            
            #line 42 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
     if (Model.Groups.Count > 1) {

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n        <ul class=\"tabs\">\r\n            <li><a href=\"");


            
            #line 45 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    Write(Url.Action("userlist", "settings"));

            
            #line default
            #line hidden
WriteLiteral("\" ");


            
            #line 45 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                          Write(Model.ActiveGroup == Guid.Empty ? "class=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">All</a></li>\r\n");


            
            #line 46 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
             foreach (var group in Model.Groups) {

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n                <a href=\"");


            
            #line 48 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    Write(Url.Action("usergroup", "settings", new { @id = group.Id }));

            
            #line default
            #line hidden
WriteLiteral("\" ");


            
            #line 48 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                                                   Write(group.Id == Model.ActiveGroup ? "class=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");


            
            #line 48 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                                                                                                           Write(group.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n");


            
            #line 50 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n");


            
            #line 54 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <table id=\"list\" class=\"list\">\r\n        <thead>\r\n            <tr>\r\n          " +
"      <th></th>\r\n                <th><span class=\"sort asc\" data-sort=\"login\">");


            
            #line 59 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                        Write(Piranha.Resources.Global.Username);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span class=\"sort\" data-sort=\"name\">");


            
            #line 60 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                   Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span class=\"sort\" data-sort=\"group\">");


            
            #line 61 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                    Write(Piranha.Resources.Global.Group);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th class=\"date\"><span class=\"sort\" data-sort=\"upda" +
"ted\">");


            
            #line 62 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                                   Write(Piranha.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th class=\"date\"><span class=\"sort\" data-sort=\"crea" +
"ted\">");


            
            #line 63 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                                   Write(Piranha.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th class=\"one\"></th>\r\n            </tr>\r\n        <" +
"/thead>\r\n        <tbody class=\"list-js\">\r\n");


            
            #line 68 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
             foreach (var user in Model.Users) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td class=\"gravatar\">\r\n");


            
            #line 71 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                     if (!String.IsNullOrEmpty(user.Email)) {

            
            #line default
            #line hidden
WriteLiteral("                        <img src=\"");


            
            #line 72 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                             Write(Url.GetGravatarUrl(user.Email, 30));

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Gravatar for ");


            
            #line 72 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                                                    Write(user.Email);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");


            
            #line 73 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td class=\"login\">\r\n");


            
            #line 76 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                     if (User.IsMember(user.GroupId)) {

            
            #line default
            #line hidden
WriteLiteral("                    <a href=\"");


            
            #line 77 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                         Write(Model.ActiveGroup == Guid.Empty ? 
                        Url.Action("user", new { id = user.Id }) :
                        Url.Action("user", new { id = user.Id, returl = Url.Action("usergroup", new { id = Model.ActiveGroup }) }));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 79 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                                                                                                Write(user.Login);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");


            
            #line 80 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    } else {
                    
            
            #line default
            #line hidden
            
            #line 81 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
               Write(user.Login);

            
            #line default
            #line hidden
            
            #line 81 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                               
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>        \r\n                <td class=\"name\">");


            
            #line 84 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                            Write(user.Firstname);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 84 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                            Write(user.Surname);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"group\">");


            
            #line 85 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                             Write(user.GroupName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"updated\">");


            
            #line 86 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                               Write(user.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"created\">");


            
            #line 87 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                               Write(user.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"buttons\">\r\n");


            
            #line 89 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                     if (User.IsMember(user.GroupId)) {

            
            #line default
            #line hidden
WriteLiteral("                    <a class=\"icon delete\" href=\"");


            
            #line 90 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                            Write(Url.Action("deleteuser", new { id = user.Id }));

            
            #line default
            #line hidden
WriteLiteral("\"></a>\r\n");


            
            #line 91 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");


            
            #line 94 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=" +
"\"6\"></td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
