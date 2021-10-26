<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AIletisim.aspx.cs" Inherits="CvProject.AIletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="table table-bordered"; style="text-align:center">
        <tr>
            <th style="text-align:center">ID</th>
            <th style="text-align:center">AD SOYAD</th>
            <th style="text-align:center">MAİL</th>
            <th style="text-align:center">KONU</th>
            <th style="text-align:center">DETAY</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("ADSOYAD") %></td>
                    <td><%#Eval("MAIL") %></td>
                    <td><%#Eval("KONU") %></td>
                    <td><a href="AIletisimDetay.aspx?id=<%#Eval("ID") %>" class="btn btn-success">Detay</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
