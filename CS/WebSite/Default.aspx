<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!--region #Markup-->        
        <dx:ASPxTreeView ID="ASPxTreeView1" runat="server" AllowSelectNode="True">
        </dx:ASPxTreeView>
        <br />
        <dx:ASPxTextBox ID="ASPxTextBox1" runat="server">
        </dx:ASPxTextBox>
        <br />
        <dx:ASPxButton ID="ASPxButton1" runat="server" OnClick="ASPxButton1_Click" Text="Add Node">
        </dx:ASPxButton>
        <!--endregion #Markup-->    
    </div>
    </form>
</body>
</html>
