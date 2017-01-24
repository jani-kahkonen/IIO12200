<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:FileUpload id="FileUploadControl" runat="server" />
    <asp:Button runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click" />
    <br /><br />
    <asp:Label runat="server" id="StatusLabel" text="Upload status: " />
    <br /><br />
    <h1>Siirrettävä dokumentti</h1>
    <h3>Folder1 Files</h3>
    <asp:DropDownList runat="server" id="ddlmove"></asp:DropDownList>
    <h3>Folder2 Files</h3>
    <asp:DropDownList runat="server" ID="ddlmove2"></asp:DropDownList>
    <h3>From, WhichFile, Where to move</h3>
    <asp:DropDownList runat="server" ID="whichfolder" OnSelectedIndexChanged="whichfolder_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
    <asp:DropDownList runat="server" id="whichfile"></asp:DropDownList>
    <asp:DropDownList runat="server" id="whereto"></asp:DropDownList>
    <asp:Button runat="server" id="moveDocument" text="Move Document" onclick="moveDocument_Click" />
    </form>
</body>
</html>
