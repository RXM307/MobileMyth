﻿#Region "GPL"
'    This file is part of MobileMyth.

'    MobileMyth is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.

'    MobileMyth is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.

'    You should have received a copy of the GNU General Public License
'    along with MobileMyth.  If not, see <http://www.gnu.org/licenses/>.

'    Copyright 2012, 2013 Jonathan Heizer jheizer@gmail.com
#End Region

Partial Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        If String.IsNullOrEmpty(SiteSettings.Setting("MythServiceAPIAddress")) Then
            Response.Redirect("~/admin/default.aspx", False)

        ElseIf String.IsNullOrEmpty(SiteSettings.FrontendSetting("UIType")) Then
            Response.Redirect("~/admin/frontendsettings.aspx", False)

        Else
            Response.Redirect("~/tablet/default.aspx", False)

        End If

    End Sub
End Class
