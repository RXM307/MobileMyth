﻿<%@ Page Title="" Language="VB" MasterPageFile="MasterPage.master" AutoEventWireup="false" CodeFile="viewstream.aspx.vb" Inherits="viewstream" EnableViewState="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="HeaderHolder" Runat="Server">
    <a href="recordings.aspx" data-icon="back">Recordings</a>
    <span class="ui-title">&nbsp;</span> 
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" Runat="Server">
    <asp:PlaceHolder runat="server" ID="maincontent"></asp:PlaceHolder>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="FooterHolder" Runat="Server">
</asp:Content>

