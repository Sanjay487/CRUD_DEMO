<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CRUD_DEMO.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            margin-right: 22px;
            margin-bottom: 0px;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label11" runat="server" ForeColor="#6600FF" Text="Student Details "></asp:Label>
            <br />
&nbsp;<br />
            Enter Student Id:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox13" runat="server" OnTextChanged="TextBox13_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
            &nbsp;<table class="auto-style4">
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="MaleRadioButton" runat="server" GroupName="Gender" OnCheckedChanged="MaleRadioButton_CheckedChanged" Text="Male" ValidationGroup="Gender" />
&nbsp;<asp:RadioButton ID="FemaleRadioButton" runat="server" GroupName="Gender" OnCheckedChanged="FemaleRadioButton_CheckedChanged" Text="Female" ValidationGroup="Gender" />
&nbsp;<asp:RadioButton ID="OthersRadioButton" runat="server" GroupName="Gender" OnCheckedChanged="OthersRadioButton_CheckedChanged" Text="Others" ValidationGroup="Gender" />
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="1" CssClass="auto-style2" GridLines="Vertical" Height="60px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True" Width="1151px" OnRowDeleting="GridView1_RowDeleting">
                <AlternatingRowStyle BackColor="Gainsboro" />
                <Columns>
                    <asp:TemplateField HeaderText="Student Id">
                        <EditItemTemplate>
                            <asp:Label ID="Label9" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Firstname">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"  Text='<%# Eval("Firstname") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <div class="auto-style1">
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Firstname") %>'></asp:Label>
                            </div>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Middlename">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("Middlename") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <div class="auto-style1">
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Middlename") %>'></asp:Label>
                            </div>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Lastname">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("Lastname") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Lastname") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList5" runat="server">
                                 <asp:ListItem>Select Gender</asp:ListItem>
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                                <asp:ListItem>Others</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:DropDownList ID="DropDownList6" runat="server">
                                 <asp:ListItem>Select Gender</asp:ListItem>
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                                <asp:ListItem>Others</asp:ListItem>
                            </asp:DropDownList>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label10" runat="server" Text='<%# Eval("gender") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Address">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Eval("Address") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Class">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Eval("Class") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("Class") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Operations">
                        <EditItemTemplate>
                            <div class="auto-style3">
                                <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Update">Update</asp:LinkButton>
                                &nbsp;
                                <asp:LinkButton ID="LinkButton4" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                            </div>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Insert</asp:LinkButton>
                        </FooterTemplate>
                        <ItemTemplate>
                            <div class="auto-style3">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" OnClick="LinkButton1_Click">Edit</asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CommandName="Delete">Delete</asp:LinkButton>
&nbsp;
                            </div>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </div>
        <div class="auto-style1">
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT * FROM [student] WHERE ([Id] = @Id)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox13" Name="Id" PropertyName="Text" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    <p>
        &nbsp;Show all data&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show" />
&nbsp;&nbsp; </p>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [student]"></asp:SqlDataSource>
    </form>
    </body>
</html>
