<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
            <HeaderTemplate>
                eno ename salary
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Button ID="btndelete" runat="server" Text="delete" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"eno")%>' />
                <%#DataBinder.Eval(Container.DataItem,"eno" %>
                <%#DataBinder.Eval(Container.DataItem,"ename" %>
                <%#DataBinder.Eval(Container.DataItem,"salary" %>
            </ItemTemplate>
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
