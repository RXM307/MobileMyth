﻿<%@ Page Title="" Language="VB" MasterPageFile="dialog.master" AutoEventWireup="false" CodeFile="startstream.aspx.vb" Inherits="startstream" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="DialogHeader" Runat="Server">
    <h1>Loading</h1>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="DialogContent" Runat="Server">
    <div style="text-align: center;">
        <img src="http://jquerymobile.com/test/css/themes/default/images/ajax-loader.gif" /><p>Creating Video Stream...</p>
    </div>

    <script type="text/javascript" >
        window.setTimeout(function () {
            window.location.href = window.location.href + '&done=t';
        }, 5000);
    </script>
</asp:Content>

