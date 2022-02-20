Imports Sage.Integration.Client
Imports Sage.Integration.Accounts50.SDOAdapter
Imports Sage.Integration.Adapter
Imports Sage.Integration.Diagnostics
Imports Sage.Integration.Messaging
Imports Sage.Integration.ObjectAdapter
Imports Sage.Integration.Presentation
Imports Sage.Integration.Server
Imports Sage.SData.Service.Config
Imports Sage.Utilities
Imports Sage.Common.Syndication
Imports Sage.Integration.Accounts50.SDOAdapter.Feeds


Public Class ArchwaySageUtils

    Public Function GetCommodity(myCommodityGroupId As commodityGroupFeedEntry)


        Console.WriteLine("The Get Product Categories (CommodityGroup) button was clicked")


        'Look up the first commodity (product) record 
        Dim commodityGroupUri As SDataUri = New Sage.Common.Syndication.SDataUri()
        commodityGroupUri.BuildLocalPath("Accounts50", "GCRM", "-", "commodityGroups")
        commodityGroupUri.Where = "Id eq '" & myCommodityGroupId.Id & "'"
        Console.WriteLine("URI: " & commodityGroupUri.ToString)

        Dim commodityGroupRequest As SDataRequest = New SDataRequest(commodityGroupUri.Uri)
        commodityGroupRequest.Username = "MANAGER"
        commodityGroupRequest.Password = "water"
        commodityGroupRequest.Timeout = 99999999



        Dim commodityGroup As commodityGroupFeed = New commodityGroupFeed()
        Dim myVal As commodityGroupFeedEntry
        commodityGroupRequest.RequestFeed(commodityGroup)

        '// If we found a record return it
        If (commodityGroupRequest.IsStatusValidForVerb And commodityGroup.Entries IsNot Nothing And commodityGroup.Entries.Count > 0) Then
            Console.WriteLine("We found " & commodityGroup.Entries.Count.ToString & " entries.")
            For Each item As commodityGroupFeedEntry In commodityGroup.Entries
                Return item
            Next

        End If
    End Function


End Class
