<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sayfa3.aspx.cs" Inherits="Istinye.sayfa3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

           <P> &nbsp;</P>
        </div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="273px" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="609px">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:TextBox ID="TextBox1" runat="server" ErrorMessage="Bu alan boş geçilemez" ForeColor="Red" MaximumValue="100" MinimumValue="10"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
        <asp:TextBox ID="TextBox2" runat="server"  ErrorMessage="Bu alan boş geçilemez" ForeColor="Red" MaximumValue="100" MinimumValue="10"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="EKLE" Height="57px" Width="102px" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Height="58px" OnClick="Button2_Click" Text="SİL" Width="99px" />
            <asp:Label ID="Label2" runat="server" Text="Bu kodu 50 farklı şekilde yazmama rağmen çalışmıyor"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Height="65px" Text="Geri dön" Width="97px" />
        </p>
    </form>
</body>
</html>
