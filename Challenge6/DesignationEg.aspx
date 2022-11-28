<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DesignationEg.aspx.cs" Inherits="Challenge6.DesignationEg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table align="center" class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddldepartment" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Designation</td>
                    <td>
                        <asp:TextBox ID="txtdesignation" runat="server"></asp:TextBox>
                    </td>  
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click"  />
                    </td> 
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="desigId" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="Gridview1_RowDeleting" OnRowCancelingEdit="Gridview1_RowCancelEdit">
                            <columns>
                                <asp:BoundField DataField="deptName" HeaderText="Department" />
                                <asp:BoundField DataField="desigId" HeaderText="Designation ID" />
                                <asp:BoundField DataField="desigName" HeaderText="Designation"/>
                                <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                                 <asp:HyperLinkField DataNavigateUrlFields="desigId" DataNavigateUrlFormatString="test.aspx?desigId={0}" HeaderText="Viewmore" Text="Go" />
                            </columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
