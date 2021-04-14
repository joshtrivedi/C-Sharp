<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RegisterForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <asp:Label ID="Label" runat="server" Text="Register Form" BorderStyle="Dotted"></asp:Label>
    </div>
    <br />
    <br />
    <form id="form1" runat="server">
        <table style="width=100%">
            <tr>
                <td>Name :
                     <input id="Name" type="text" runat="server"/><br />
                </td>
            </tr>
            <tr>
                <td>Phone :
                    <input id="Phone" type="number" runat="server"/><br />
                </td>
            </tr>
            <tr>
                <td>
                   Gender : 
                    <input id="RadioMale" type="radio" runat="server" name="Gender"/>
                    <label>Male</label>
                    <input id="RadioFemale" type="radio" runat="server" name="Gender"/>
                    <label>Female</label>
                </td>
            </tr>
            <tr>
                <td>Branch :
                    <asp:DropDownList ID="BranchDropDown" runat="server">
                        <asp:ListItem>ICT</asp:ListItem>
                        <asp:ListItem>EC</asp:ListItem>
                        <asp:ListItem>CS</asp:ListItem>
                        <asp:ListItem>IT</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Selected Subjects :
                    <input id="dotNet" type="checkbox" runat="server"/>
                    <label>.NET</label>
                    <input id="ML" type="checkbox" runat="server"/>
                    <label>ML</label>
                    <input id="CC" type="checkbox" runat="server"/>
                    <label>CC</label>
                    <input id="VLSI" type="checkbox" runat="server"/>
                    <label>VLSI</label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" />
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Result" runat="server" />
                    </div>
                </td>
            </tr>
        </table>   
    </form>
</body>
</html>
