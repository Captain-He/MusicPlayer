<%@ Page Language="C#" Debug="true"  MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" Title="无标题页" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 245px;
        }
        .style4
        {
            width: 221px;
        }
        .style5
        {
            width: 207px;
        }
        .style6
        {
            width: 160px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>  <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
    AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="LinqDataSource1">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="id" HeaderText="编号" InsertVisible="False" 
            ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="name" HeaderText="歌曲名" SortExpression="name" />
        <asp:BoundField DataField="who" HeaderText="演唱者" SortExpression="who" />
        <asp:BoundField DataField="url" HeaderText="播放地址" SortExpression="url" />
    </Columns>
</asp:GridView>
<asp:LinqDataSource ID="LinqDataSource1" runat="server" 
    ContextTypeName="DataDataContext" EnableDelete="True" EnableInsert="True" 
    EnableUpdate="True" TableName="music">
</asp:LinqDataSource>
    <table class="style1" width="300">
        <tr>
            <td align="right" class="style6">
                音乐名：</td>
                                <td>
                                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style6">
                                    演唱者：</td>
                                <td>
                                    <asp:TextBox ID="who" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style6">
                                    文件上传：</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                <asp:Button ID="fbit" runat="server" onclick="fbit_Click" Text="上传" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Cancel" runat="server" CommandName="Cancel" Text="取消" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="Delbt" runat="server" onclick="Delbt_Click" 
    Text="垃圾文件处理" />
                        <cc1:ConfirmButtonExtender ID="Delbt_ConfirmButtonExtender" runat="server" 
                            ConfirmText="你确定要处理垃圾文件吗？" Enabled="True" TargetControlID="Delbt">
                        </cc1:ConfirmButtonExtender>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
    </table>
</asp:Content>

