<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductDatail.aspx.cs" Inherits="ProductDatail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
   <h4>查看明细</h4>
    <p>
        商品编号：<asp:Label ID="lblSN" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        商品名称：<asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        商品说明：<asp:Label ID="lblDSCN" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="http://www.pptbz.com/pptpic/UploadFiles_6909/201211/2012111719294197.jpg" Width="400px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-primary" NavigateUrl="~/ProductList.aspx">返回</asp:HyperLink>
    </p>
</asp:Content>

