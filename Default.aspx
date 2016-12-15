<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>  <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataKeyNames="id" 
        DataSourceID="LinqDataSource1" >
        <Columns>
            <asp:BoundField DataField="id" HeaderText="编码" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="name" HeaderText="歌曲" SortExpression="name" />
            <asp:BoundField DataField="who" HeaderText="演唱者" SortExpression="who" />
            <asp:BoundField DataField="date" DataFormatString="{0:yyyy年MM月dd日}" 
                HeaderText="发布日期" SortExpression="date" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                       <asp:CheckBox ID="CheckBox2"  runat="server"
                         />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="DataDataContext" TableName="music">
    </asp:LinqDataSource>
   
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="Play" runat="server" Text="播放" onclick="Play_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>
   
    </asp:Content>

