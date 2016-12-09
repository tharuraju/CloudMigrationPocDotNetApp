<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
form {
    border: 3px solid #f1f1f1;
}

input[type=text], input[type=password] {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    box-sizing: border-box;
}

button {
    background-color: #4CAF50;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    cursor: pointer;
    width: 100%;
}
.submitbutton
{
    background-color: #4CAF50;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    cursor: pointer;
    width: 100%;
}
.cancelbtn {
    width: auto;
    padding: 10px 18px;
    background-color: #f44336;
}

.imgcontainer {
    text-align: center;
    margin: 24px 0 12px 0;
}

img.avatar {
    width: 40%;
    border-radius: 50%;
}

.container {
    padding: 16px;
}

span.psw {
    float: right;
    padding-top: 16px;
}

/* Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
    span.psw {
       display: block;
       float: none;
    }
    .cancelbtn {
       width: 100%;
    }
}
</style>
    <title>Login Form</title>
</head>
<body>
    <form id="form1" runat="server">
       <h2>Login Form</h2>
    <div class="imgcontainer">
    <img src="Images/img_avatar2.png" alt="Avatar" class="avatar" ">
  </div>

  <div class="container">
    <label><b>Username</b></label>    
    
     <asp:TextBox ID ="txtUserName" placeholder ="Enter Username" runat ="server"></asp:TextBox>
       <label><b>Password</b></label>   
     
      <asp:TextBox ID ="txtPassword" placeholder ="Enter Password" runat ="server" TextMode="Password" ></asp:TextBox>   
  
     <asp:Button ID ="btnSubmit" runat ="server" Text="Login" CssClass ="submitbutton" OnClick="btnSubmit_Click" />
    <input type="checkbox" checked="checked"> Remember me
  </div>

      <div class="container" style="background-color:#f1f1f1">
           <asp:Label ID ="lblMessage" runat ="server" ForeColor ="Red"></asp:Label>
      </div>
    </form>
</body>
</html>
