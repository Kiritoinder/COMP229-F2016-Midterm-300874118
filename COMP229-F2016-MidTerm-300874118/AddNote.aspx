<%@ Page Title="Add Note" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNote.aspx.cs" Inherits="COMP229_F2016_MidTerm_300874118.AddNote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <div class="col-md-offset-4 col-md-6" style="width:400px; height:400px" >
        <div class="form-group">
            <label for="Notes">Notes:</label>
            <input type="text" class="form-control" id="Note" maxlength="30">
        </div>
        <div class="form-group">
            <label for="Compleated">Compleated:</label>
            <input type="text" class="form-control" id="comp" maxlength="30">
        </div>


        <button type="submit" class="btn btn-default">Submit</button>
    
    </div>
</asp:Content>
