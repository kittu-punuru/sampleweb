<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 151px;
        }
        .auto-style2 {
            width: 151px;
            height: 26px;
            font-weight: bold;
            font-size: large;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            font-weight: bold;
            font-size: large;
        }
        .auto-style5 {
            width: 151px;
            font-weight: bold;
            font-size: large;
            height: 31px;
        }
        .auto-style6 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 49%;">
            <tr>
                <td class="auto-style5">enter a num</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style4" OnTextChanged="TextBox1_TextChanged" Width="143px"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">enter b num</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Width="142px"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style4" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>+</asp:ListItem>
                        <asp:ListItem>-</asp:ListItem>
                        <asp:ListItem>*</asp:ListItem>
                        <asp:ListItem>/</asp:ListItem>
                        <asp:ListItem>%</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
