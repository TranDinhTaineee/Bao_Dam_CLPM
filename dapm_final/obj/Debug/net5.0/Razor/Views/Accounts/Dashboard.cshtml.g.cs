#pragma checksum "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51473135f4f05b265ef5cadc412d8265e9c887d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Dashboard), @"mvc.1.0.view", @"/Views/Accounts/Dashboard.cshtml")]
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
#line 1 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\_ViewImports.cshtml"
using dapm_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\_ViewImports.cshtml"
using dapm_final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51473135f4f05b265ef5cadc412d8265e9c887d6", @"/Views/Accounts/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de7bca1180a586702ce5be81b08789727cd7be9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dapm_final.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Order> DanhSachDonHang = ViewBag.DonHang;
    dapm_final.ModelViews.ChangePasswordViewModel changePassword = new dapm_final.ModelViews.ChangePasswordViewModel();
    dapm_final.ModelViews.EditProfileViewModel editProfile = new dapm_final.ModelViews.EditProfileViewModel();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""account-page-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""account-dashboard-tab"" data-bs-toggle=""tab"" href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard"" aria-selected=""true"">Thông Tin Tài Khoản</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab"" href=""#account-orders"" role=""tab"" aria-controls=""account-orders"" aria-selected=""false"">Danh Sách Đơn Hàng</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-details-tab"" data-bs-toggle=""tab"" href=""#ac");
            WriteLiteral(@"count-details"" role=""tab"" aria-controls=""account-details"" aria-selected=""false"">Thay Đổi Mật Khẩu</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-profile-tab"" data-bs-toggle=""tab"" href=""#account-profile"" role=""tab"" aria-controls=""account-profile"" aria-selected=""false"">Thay Đổi Thông Tin</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-logout-tab"" href=""dang-xuat.html"" role=""tab"" aria-selected=""false"">Đăng Xuất</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-9"">
                    <div class=""tab-content myaccount-tab-content"" id=""account-page-tab-content"">
                        <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel"" aria-labelledby=""account-dashboard-tab"">
                            <div class=""myaccount-d");
            WriteLiteral("ashboard\">\r\n                                <p>\r\n                                    Xin Chào, <b>");
#nullable restore
#line 39 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                            Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                </p>\r\n                                <p>Email: ");
#nullable restore
#line 41 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Số Điện Thoại: ");
#nullable restore
#line 42 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Địa Chỉ: ");
#nullable restore
#line 43 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-orders-tab"">
                            <div class=""myaccount-orders"">
                                <h4 class=""small-title"">DANH SÁCH ĐƠN HÀNG</h4>
");
#nullable restore
#line 49 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                 if (DanhSachDonHang != null && DanhSachDonHang.Count() > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""table-responsive"">
                                        <table class=""table table-bordered table-hover"">
                                            <tbody>
                                                <tr>
                                                    <th>ID</th>
                                                    <th>Ngày Mua Hàng</th>
                                                    <th>Ngày Ship Hàng</th>
                                                    <th>Trạng Thái</th>
                                                </tr>
");
#nullable restore
#line 60 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                                 foreach (var item in DanhSachDonHang)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td><a class=\"account-order-id\" href=\"javascript:void(0)\">#");
#nullable restore
#line 63 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                                                                                              Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                        <td>");
#nullable restore
#line 64 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 65 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 66 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            <a href=\"javascript:void(0)\" class=\"xemdonhang\" data-madonhang=\"");
#nullable restore
#line 68 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                                                                                                       Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xem Đơn Hàng</a>\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 71 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </tbody>
                                        </table>
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <hr />
                                        <div id=""records_table_oder"">
                                        </div>
                                    </div>
");
#nullable restore
#line 83 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Chưa Có Đơn Hàng!</p>\r\n");
#nullable restore
#line 87 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-address"" role=""tabpanel"" aria-labelledby=""account-address-tab"">
                            <div class=""myaccount-address"">
                                <p>The following addresses will be used on the checkout page by default.</p>
                                <div class=""row"">
                                    <div class=""col"">
                                        <h4 class=""small-title"">BILLING ADDRESS</h4>
                                        <address>
                                            ");
#nullable restore
#line 97 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </address>
                                    </div>
                                    <div class=""col"">
                                        <h4 class=""small-title"">SHIPPING ADDRESS</h4>
                                        <address>
                                            ");
#nullable restore
#line 103 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </address>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-details"" role=""tabpanel"" aria-labelledby=""account-details-tab"">
                            ");
#nullable restore
#line 110 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                       Write(await Html.PartialAsync("_ChangePasswordPartialView", changePassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"tab-pane fade\" id=\"account-profile\" role=\"tabpanel\" aria-labelledby=\"account-profile-tab\">\r\n                             ");
#nullable restore
#line 113 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Accounts\Dashboard.cshtml"
                        Write(await Html.PartialAsync("_EditProfilePartialView", editProfile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".xemdonhang"").click(function () {
                var madonhang = $(this).attr(""data-madonhang"")
                $.ajax({
                    url: '/DonHang/Details',
                    datatype: ""json"",
                    type: ""POST"",
                    data: { id: madonhang },
                    async: true,
                    success: function (results) {
                        $(""#records_table_oder"").html("""");
                        $(""#records_table_oder"").html(results);
                    },
                    error: function (xhr) {
                        alert('error');
                    }
                });
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dapm_final.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
