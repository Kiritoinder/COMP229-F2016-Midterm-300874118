<%@ Page Title="Todo List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TodoList.aspx.cs" Inherits="COMP229_F2016_MidTerm_300874118.TodoList" %>
<%--Name: Inderjeet Singh --%>
<%--Student ID: 300874118 --%>
<%-- Date Modofied: 19-oct-2016 --%>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:GridView ID="TodoListGridView" runat="server" AutoGenerateColumns="false" 
                    CssClass="table table-bordered table-striped table-hover" DataKeyNames="TodoID" OnRowDeleting="TodoListGridView_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="TodoID" HeaderText="ToDo ID" Visible="true" />
                        <asp:BoundField DataField="ToDoDescription" HeaderText="Notes" Visible="true" />
                        <asp:BoundField  DataField="Compleated" HeaderText="Compleated" Visible="true" />
                        <asp:CommandField HeaderText="Edit" EditText="<i class='fa fa-pencil-square-o fa-lg '></i> Edit"
                            ShowEditButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm"  />
                    
                        
                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
     
</asp:Content>
