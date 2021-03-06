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

'    Copyright 2012-2014 Jonathan Heizer jheizer@gmail.com
#End Region


Imports MythService
Imports MythDVR

Partial Class upcoming
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Master.PageTitle = "Upcoming Recordings"

        Dim Recordings As ProgramList = Common.MBE.DvrAPI.GetUpcomingList(0, 500, False)

        Dim List As New HtmlList
        maincontent.Controls.Add(List)
        List.Attributes.Add("data-role", "listview")

        Dim StartDate As String = DateTime.MaxValue.ToLongDateString

        For Each Rec As Program In Recordings.Programs
            If Rec.StartTime.Value.ToLocalTime.ToLongDateString <> StartDate Then
                Dim Divider As New HtmlListItem
                Divider.Attributes.Add("data-role", "list-divider")
                Divider.InnerText = Rec.StartTime.Value.ToLocalTime.ToLongDateString
                List.Controls.Add(Divider)
                StartDate = Rec.StartTime.Value.ToLocalTime.ToLongDateString
            End If

            Dim LI As New UpcomingListItem(Rec)
            List.Controls.Add(LI)
        Next

    End Sub

End Class
