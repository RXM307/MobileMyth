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

Partial Class tablet_mythweb
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Try

            Dim Url As String = SiteSettings.Setting("MythWebUrl") & HttpUtility.UrlDecode(Request.QueryString("url"))
            Dim Lit As New LiteralControl
            Lit.Text = "<iframe src=""" & Url & """ id=""mythwebframe"" onLoad=""$('#mythwebframe').height($('#mythwebframe').contents().height());"" width=""100%"" height=""300""   frameborder=""0"" allowfullscreen></iframe>"
            maincontent.Controls.Add(Lit)
        Catch ex As Exception
        End Try
    End Sub
End Class
