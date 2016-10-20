<%@ Page Title="Add Note" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNote.aspx.cs" Inherits="COMP229_F2016_MidTerm_300874118.AddNote" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form name="form" method="post" >
        <div class="form-group">
            <label for="Notes">Notes:</label>
            <input type="text" class="form-control" id="Note">
        </div>
        <div class="form-group">
            <label for="Compleated">Compleated:</label>
            <input type="text" class="form-control" id="comp">
        </div>


        <button type="submit" class="btn btn-default">Submit</button>
    </form>

</asp:Content>
