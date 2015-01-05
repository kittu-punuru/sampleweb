<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <HeaderTemplate>
                eno ename salary
            </HeaderTemplate>
            <ItemTemplate>
                <%#DataBinder.Eval(Container.DataItem,"eno") %>
                <%#DataBinder.Eval(Container.DataItem,"ename") %>
                <%#DataBinder.Eval(Container.DataItem,"salary") %>
            </ItemTemplate>
        </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
