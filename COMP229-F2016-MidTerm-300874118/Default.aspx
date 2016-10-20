<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="COMP229_F2016_MidTerm_300874118.Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
    <div class="row">
        <div class="col-md-offset-2 col-md-8">
            <div class="jumbotron" id="content" runat="server">
                <div class="text-center">
                    <h2>Welcome to ToDoList App</h2>
                    <h2>Click here to go to app</h2>
                   <a href="TodoList.aspx"><button type="button" class="btn btn-default">ToDoList</button></a>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
