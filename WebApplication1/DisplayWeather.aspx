<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayWeather.aspx.cs" Inherits="WebApplication1.DisplayWeather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css" >
        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }
        .container 
        {
                padding: 16px;
        }
</style>
    <title>Weather Information</title>
    <link href="Css/WeatherAppCss.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
          
      <div class ="wrapperHeader" style="padding-left:0px;padding-right:0px;padding-top:0px">        
           <img src="Images/Acc_Weather_App_Header_BG.png" />         
      </div> 
      <div class="container" style="background-color:#f1f1f1">
           
      </div>
    <div style="background-color:cyan;width:100%;height:100%">
        <div style= "Width:15%;float:left">
            <asp:Label ID ="lblLocation" runat="server"  Text ="Select your location" Font-Bold="true" ></asp:Label> 
        </div>
        <div style= "Width:40%;float:left">
                <asp:DropDownList id ="ddlLocation" runat ="server" Width ="40%" AutoPostBack ="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged" >
                     <asp:ListItem Selected="True"  value="ALL">ALL</asp:ListItem>
                        <asp:ListItem value="B">Bangalore</asp:ListItem>
                        <asp:ListItem value="M">Mumbai</asp:ListItem>
                        <asp:ListItem value="C">Chennai</asp:ListItem>                     
                        <asp:ListItem value="D">Delhi</asp:ListItem>
                </asp:DropDownList>
        </div> 
        <asp:LinkButton ID ="lnkAddNewUser" runat ="server" Text ="Add New User" OnClick="lnkAddNewUser_Click"></asp:LinkButton>
    </div> 
         
    <div style="clear:both;margin-top:20px">
        <asp:Label ID="lblDisplay" runat ="server" Text="" Font-Bold ="true" ForeColor ="Red"></asp:Label>
    </div>
     <div id="divAllTemp" runat ="server">
               <table>
                  <tr>
                    <th>City Name</th>
                    <th>Temperature</th>
                    <th>Temperature Status</th>
                  </tr>
                  <tr>
                    <td>Bangalore</td>
                    <td>21 C</td>
                    <td>Mild</td>
                  </tr>
                  <tr>
                    <td>Chennai</td>
                    <td>37 C</td>
                    <td>Sunny</td>
                  </tr>
                  <tr>
                    <td>Delhi</td>
                    <td>40 C</td>
                    <td>Hot</td>
                  </tr>
                  <tr>
                    <td>Mumbai</td>
                    <td>15 C</td>
                    <td>Cold</td>
                  </tr>
      
            </table>
     </div>
      <div id="divSingleTemparature" runat ="server">
          <table>
                  <tr>
                    <th>City Name</th>
                    <th>Temperature</th>
                    <th>Temperature Status</th>
                  </tr>
                  <tr>
                    <td><asp:Label ID ="lblCityName" runat ="server" ></asp:Label></td>
                    <td><asp:Label ID ="lblTemperature" runat ="server" ></asp:Label></td>
                    <td><asp:Label ID ="lblTemperatureStatus" runat ="server" ></asp:Label></td>
                  </tr>
           </table>
      </div>
        <div class="container" style="background-color:#f1f1f1">
           
      </div>
    </form>
</body>
</html>
