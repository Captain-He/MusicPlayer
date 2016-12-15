<%@ Page Title="" Language="C#" MasterPageFile="/play/MasterPage.master" AutoEventWireup="true" CodeFile="Play.aspx.cs" Inherits="Play_Play" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 1049px;
            margin-left: 45px;
            margin-right: 113px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;
    <br />
    <br />
    <br />
&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <object align=middle classid="CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95" class=auto-style1 id=MediaPlayer height=500> 
 
   <param name=Filename value="<%=lm()%>"> 
   <embed type=application/x-oleobject codebase="http://activex.microsoft.com/activex/con ... n/nsmp2inf.cab#Version=5,1,52,701" > 
   </embed> 
   </object>  
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

