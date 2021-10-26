<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AYeniyetenek.aspx.cs" Inherits="CvProject.AYeniyetenek" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Yeni Yetenek Ekleme Sayfası</h3>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Eklemek istediğiniz yeteneği yazın!!!"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />
</asp:Content>
