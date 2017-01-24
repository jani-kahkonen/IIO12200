<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Proto_Haku.aspx.cs" Inherits="Proto_Haku" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<title>Proto_Haku</title>
		
		<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.3/jquery.min.js"></script>
		
		<script type="text/javascript">
		
		    $(document).ready(filter);

		    $("#txtSearch").live("keyup", filter);

		    $("#ddlSearch").live("change", filter);

		    function filter(event){
		        $("#output").empty();

		        $.ajax({
		            type: "POST",
		            url: "Proto_Haku.aspx/GetDocuments",
		            data: '{arg: "' + $("#txtSearch").val() + '", num: "' + $("#ddlSearch").val() + '" }',
		            contentType: "application/json; charset=utf-8",
		            dataType: "json",
		            success: function (response) {
		                var documents = response.d;

		                $.each(documents, function (index, document) {
		                    $("#output").append('<div>' + document.name + '</div>');
		                });
		            },
		            failure: function (response) {
		                alert(response.d);
		            }
		        });
		    }
		
		</script>
	</head>
	
	<body>
		<form id="form" runat="server">
			<asp:TextBox ID="txtSearch" runat="server" autocomplete="off" />

            <asp:DropDownList ID="ddlSearch" runat="server">
                <asp:ListItem Text="0" Value="0"></asp:ListItem>
                <asp:ListItem Text="1" Value="2"></asp:ListItem>
                <asp:ListItem Text="2" Value="1"></asp:ListItem>
            </asp:DropDownList>
			
			<br />
			
			<div id="output">
			
			</div>
		</form>
	</body>
</html>