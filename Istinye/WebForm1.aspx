<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Istinye.WebForm1" %>
<!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
<!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
   
      <asp:TextBox ID="admintxt" runat="server" class="form-control"  aria-describedby="emailHelp" Width="200px" ></asp:TextBox>
     </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
    
      <asp:TextBox ID="sifretxt" runat="server"  class="form-control" type="password" Width="200px"></asp:TextBox>
  </div>

  <div class="mb-3 form-check">
    </div>

 
        <asp:Button ID="Button1" runat="server"  Text="Giriş Yap" type="submit" class="btn btn-primary" OnClick="Button1_Click"/>
      
        
        
        
        
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
       <div class="mb-3">
  <label for="exampleFormControlInput1" class="form-label" >Email address</label>
           <asp:TextBox ID="mailtxt" runat="server" type="email" class="form-control" placeholder="name@example.com" TextMode="Email"></asp:TextBox>
</div>
<div class="mb-3">
  <label for="exampleFormControlTextarea1" class="form-label">Example textarea</label>
    <asp:TextBox ID="mesajtxt" runat="server" class="form-control" rows="3" TextMode="MultiLine" OnTextChanged="mesajtxt_TextChanged"></asp:TextBox>
   
    <asp:Button ID="Button4" runat="server"  Text="Gönder" type="submit" class="btn btn-primary" OnClick="Button4_Click" />

</div>

    </form>
</body>
</html>
