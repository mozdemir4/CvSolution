<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AYetenekler.aspx.cs" Inherits="CvProject.AHakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered"; style="text-align:center">
        <tr>
            <th style="text-align:center">ID</th>
            <th style="text-align:center">YETENEK</th>
            <th style="text-align:center">GÜNCELLE</th>
            <th style="text-align:center">SİL</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("YETENEK") %></td>
                    <td><a href="AYetenekGuncelle.aspx?id=<%#Eval("ID") %>" class="btn btn-success">Güncelle</a></td>
                    <td><a href="AYeteneksil.aspx?id=<%#Eval("ID") %>" class="btn btn-danger">Sil</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="AYeniyetenek.aspx" class="btn btn-primary">Yeni Yetenek Ekle</a>
</asp:Content>
