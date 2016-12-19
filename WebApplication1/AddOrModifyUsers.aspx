<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOrModifyUsers.aspx.cs" Inherits="WebApplication1.AddOrModifyUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add or Modify Users</title>
    <style type="text/css">  
        .style1  
        {  
        width: 139px;  
        }  
        .style2  
        {  
        width: 158px;  
        }  
        .style3  
        {  
        width: 139px;  
        height: 23px;  
        }  
        .style4  
        {  
        width: 158px;  
        height: 23px;  
        }  
        .style5  
        {  
        height: 23px;  
        }  
        .style6  
        {  
        font-size: large;  
        text-decoration: underline;  
        }  
</style>
</head>
<body>
    <form id="form1" runat="server">
       <div>  
                <strong>  
                    <span class="style6">Add/Modify User</span>  
                </strong>  
                <br />  
                <table style="width:100%;">  
                    <tr>  
                        <td class="style1">  
 </td>  
                        <td class="style2">  
 </td>  
                        <td>  
 </td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            Full Name</td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>  
                        </td>  
                        <td>  
 </td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            Education</td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtEducation" runat="server"></asp:TextBox>  
                        </td>  
                        <td>  
 </td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            Email</td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>  
                        </td>  
                        <td>  
 </td>  
                    </tr>  
                    <tr>  
                        <td class="style3">  
                        &nbsp;UserName</td>  
                        <td class="style4">  
                            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>  
                        </td>  
                        <td class="style5"></td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            Password</td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>  
                        </td>  
                        <td>  
                        </td>  
                    </tr>
                    <tr>  
                        <td class="style1">  
                            Confirm Password</td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>  
                        </td>  
                        <td>  
                        </td>  
                    </tr>   
                    <tr>  
                        <td class="style1">  
 </td>  
                        <td class="style2">  
 </td>  
                        <td>  
 </td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
 </td>  
                        <td class="style2">  
                            <asp:Button ID="Button1" runat="server" BorderColor="#CCFF66"   
ForeColor="#0066FF" onclick="Button1_Click" Text="Save" />  
                        </td>  
                        <td>  
                            <asp:Label ID="lblMessage" runat="server" Text="Label" ForeColor ="Red"></asp:Label>  
                        </td>  
                    </tr>  
                </table>  
            </div> 
        <div>
           <asp:LinkButton ID ="lnkWeatherpage" Text ="Return to Login page" runat ="server" OnClick="lnkWeatherpage_Click" ></asp:LinkButton>  
        </div>
    </form>
</body>
</html>
