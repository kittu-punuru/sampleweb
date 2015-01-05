<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" OnItemCommand="DataList1_ItemCommand" OnDeleteCommand="DataList1_ItemCommand">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                eno ename salary
            </HeaderTemplate>
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <ItemTemplate>
                <asp:Button ID="btndelete" runat="server" Text="delete" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"eno") %>' />
                <%#DataBinder.Eval(Container.DataItem,"eno") %>
                <%#DataBinder.Eval(Container.DataItem,"ename") %>
                <%#DataBinder.Eval(Container.DataItem,"salary") %>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        </asp:DataList>
    <div>
    
    </div>
    </form>
</body>
</html>
