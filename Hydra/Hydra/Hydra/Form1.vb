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
Imports ArchwaySageUtils

Public Class Form1

    Dim commodityGroup As commodityGroupFeed

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Console.WriteLine("The Get Product Categories (CommodityGroup) button was clicked")

        'Look up the first commodity (product) record 
        Dim commodityGroupUri As SDataUri = New Sage.Common.Syndication.SDataUri()
        commodityGroupUri.BuildLocalPath("Accounts50", "GCRM", "-", "commodityGroups")
        commodityGroupUri.Where = "name ne 'Boom'"
        Console.WriteLine("URI: " & commodityGroupUri.ToString)

        Dim commodityGroupRequest As SDataRequest = New SDataRequest(commodityGroupUri.Uri)
        commodityGroupRequest.Username = "MANAGER"
        commodityGroupRequest.Password = "water"
        commodityGroupRequest.Timeout = 99999999



        commodityGroup = New commodityGroupFeed()
        commodityGroupRequest.RequestFeed(commodityGroup)

        '// If we found a record return it
        If (commodityGroupRequest.IsStatusValidForVerb And commodityGroup.Entries IsNot Nothing And commodityGroup.Entries.Count > 0) Then
            Console.WriteLine("We found " & commodityGroup.Entries.Count.ToString & " entries.")
            For Each item As commodityGroupFeedEntry In commodityGroup.Entries
                Console.WriteLine("Commodity Group name: " & item.name)
                Console.WriteLine(ControlChars.Tab & "UUID: " & item.UUID.ToString)
                Console.WriteLine(ControlChars.Tab & "Description: " & item.description)
                Console.WriteLine(ControlChars.Tab & "Active: " & item.active)
                'Console.WriteLine(ControlChars.Tab & "Classification: " & item.commodity.classification)

            Next

        End If
        Console.WriteLine("We're finished!!!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Console.WriteLine("The Get Financial Account button was clicked")

        'Look up the first commodity (product) record 
        Dim financialAccountsUri As SDataUri = New Sage.Common.Syndication.SDataUri()
        financialAccountsUri.BuildLocalPath("Accounts50", "GCRM", "-", "financialAccounts")
        'financialAccountsUri.Count = 1
        Console.WriteLine("URI: " & financialAccountsUri.ToString)

        Dim financialAccountsRequest As SDataRequest = New SDataRequest(financialAccountsUri.Uri)
        financialAccountsRequest.Username = "MANAGER"
        financialAccountsRequest.Password = "water"
        financialAccountsRequest.Timeout = 99999



        Dim financialAccount As financialAccountFeed = New financialAccountFeed()
        financialAccountsRequest.RequestFeed(financialAccount)

        '// If we found a record return it
        If (financialAccountsRequest.IsStatusValidForVerb And financialAccount.Entries IsNot Nothing And financialAccount.Entries.Count > 0) Then
            Console.WriteLine("We found " & financialAccount.Entries.Count.ToString & " entries.")
            For Each item As financialAccountFeedEntry In financialAccount.Entries
                Console.WriteLine("Financial Account UUID: " & item.UUID.ToString & " Item Description: " & item.name.ToString)

            Next

        End If
        Console.WriteLine("We're finished!!!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Console.WriteLine("The Get Commodity Identifiers button was clicked")

        'Look up the first commodity (product) record 
        Dim commodityIdentifierUri As SDataUri = New Sage.Common.Syndication.SDataUri()
        commodityIdentifierUri.BuildLocalPath("Accounts50", "GCRM", "-", "commodityIdentifiers")
        'commodityIdentifierUri.Where = "Active eq 'True'"
        commodityIdentifierUri.Where = "identifier eq '0-376-12'"
        Console.WriteLine("URI: " & commodityIdentifierUri.ToString)

        Dim commodityIdentifierRequest As SDataRequest = New SDataRequest(commodityIdentifierUri.Uri)
        commodityIdentifierRequest.Username = "MANAGER"
        commodityIdentifierRequest.Password = "water"
        commodityIdentifierRequest.Timeout = 99999999



        Dim commodityIdentifier As commodityIdentifierFeed = New commodityIdentifierFeed()
        commodityIdentifierRequest.RequestFeed(commodityIdentifier)

        '// If we found a record return it
        If (commodityIdentifierRequest.IsStatusValidForVerb And commodityIdentifier.Entries IsNot Nothing And commodityIdentifier.Entries.Count > 0) Then
            Console.WriteLine("We found " & commodityIdentifier.Entries.Count.ToString & " entries.")
            For Each item As commodityIdentifierFeedEntry In commodityIdentifier.Entries
                Console.WriteLine("Product Code: " & item.identifier)
                Console.WriteLine(ControlChars.Tab & "UUID: " & item.UUID.ToString)
                Console.WriteLine(ControlChars.Tab & "Description: " & item.description)
                Console.WriteLine(ControlChars.Tab & "Active: " & item.active)
                Console.WriteLine(ControlChars.Tab & "applicationId: " & item.applicationID)
                Console.WriteLine(ControlChars.Tab & "availableQuantity: " & item.availableQuantity)
                Console.WriteLine(ControlChars.Tab & "barcode: " & item.barcode)
                Console.WriteLine(ControlChars.Tab & "buyingAllowed: " & item.buyingAllowed)
                Console.WriteLine(ControlChars.Tab & "creationDate: " & item.creationDate)
                Console.WriteLine(ControlChars.Tab & "expirationDate: " & item.expirationDate)
                Console.WriteLine(ControlChars.Tab & "Id: " & item.Id)
                Console.WriteLine(ControlChars.Tab & "inStockFlag: " & item.inStockFlag)
                Console.WriteLine(ControlChars.Tab & "internaluuid: " & item.internaluuid)
                Console.WriteLine(ControlChars.Tab & "isUniqueFlag: " & item.isUniqueFlag)
                Console.WriteLine(ControlChars.Tab & "lastMovementDate: " & item.lastMovementDate)
                Console.WriteLine(ControlChars.Tab & "lastPurchaseDate: " & item.lastPurchaseDate)
                Console.WriteLine(ControlChars.Tab & "lastSaleDate: " & item.lastSaleDate)
                Console.WriteLine(ControlChars.Tab & "movementAllowed: " & item.movementAllowed)
                Console.WriteLine(ControlChars.Tab & "movementQuantity: " & item.movementQuantity)
                Console.WriteLine(ControlChars.Tab & "name: " & item.name)
                Console.WriteLine(ControlChars.Tab & "reference: " & item.reference)
                Console.WriteLine(ControlChars.Tab & "reference2: " & item.reference2)
                Console.WriteLine(ControlChars.Tab & "reservedQuantity: " & item.reservedQuantity)
                Console.WriteLine(ControlChars.Tab & "saleQuantity: " & item.saleQuantity)
                Console.WriteLine(ControlChars.Tab & "sellingAllowed: " & item.sellingAllowed)
                Console.WriteLine(ControlChars.Tab & "status: " & item.status)
                Console.WriteLine(ControlChars.Tab & "Title: " & item.Title)
                Console.WriteLine(ControlChars.Tab & "type: " & item.type)
                Console.WriteLine(ControlChars.Tab & "useByDate: " & item.useByDate)

                ' Console.WriteLine(ControlChars.Tab & "commodityGroup (Product Category): " & item.commodity.commodityGroup.name)

                'Dim classification As commodityGroupFeedEntry = item.commodity.commodityGroup.name
                'If (commodityGroup.Entries.Contains(item.commodity.commodityGroup)) Then
                'commodityGroup.Entries.f
                'End If

                If (item.Categories IsNot Nothing) Then
                    Console.WriteLine(ControlChars.Tab & "Product Category (commodityGroup): " & item.commodity.commodityGroup.name)
                End If

            Next

        End If
        Console.WriteLine("We're finished!!!")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Console.WriteLine("What are commodities button was clicked")

        'Look up the first commodity (product) record 
        Dim commodityUri As SDataUri = New Sage.Common.Syndication.SDataUri()
        commodityUri.BuildLocalPath("Accounts50", "GCRM", "-", "commodities")
        'commodityUri.Where = "Active eq 'True'"
        'commodityUri.Where = "identifier eq '0-376-12'"
        Console.WriteLine("URI: " & commodityUri.ToString)

        Dim commoditiesRequest As SDataRequest = New SDataRequest(commodityUri.Uri)
        commoditiesRequest.Username = "MANAGER"
        commoditiesRequest.Password = "water"
        commoditiesRequest.Timeout = 99999999



        Dim commodity As commodityFeed = New commodityFeed()
        commoditiesRequest.RequestFeed(commodity)

        '// If we found a record return it
        If (commoditiesRequest.IsStatusValidForVerb And commodity.Entries IsNot Nothing And commodity.Entries.Count > 0) Then
            Console.WriteLine("We found " & commodity.Entries.Count.ToString & " entries.")
            For Each item As commodityFeedEntry In commodity.Entries
                'Console.WriteLine("Product Code: " & item.identifier)
                'Console.WriteLine(ControlChars.Tab & "UUID: " & item.UUID.ToString)
                'Console.WriteLine(ControlChars.Tab & "Description: " & item.description)
                'Console.WriteLine(ControlChars.Tab & "Active: " & item.active)
                'Console.WriteLine(ControlChars.Tab & "applicationId: " & item.applicationID)
                'Console.WriteLine(ControlChars.Tab & "availableQuantity: " & item.availableQuantity)
                'Console.WriteLine(ControlChars.Tab & "barcode: " & item.barcode)
                'Console.WriteLine(ControlChars.Tab & "buyingAllowed: " & item.buyingAllowed)
                'Console.WriteLine(ControlChars.Tab & "creationDate: " & item.creationDate)
                'Console.WriteLine(ControlChars.Tab & "expirationDate: " & item.expirationDate)
                'Console.WriteLine(ControlChars.Tab & "Id: " & item.Id)
                'Console.WriteLine(ControlChars.Tab & "inStockFlag: " & item.inStockFlag)
                'Console.WriteLine(ControlChars.Tab & "internaluuid: " & item.internaluuid)
                'Console.WriteLine(ControlChars.Tab & "isUniqueFlag: " & item.isUniqueFlag)
                'Console.WriteLine(ControlChars.Tab & "lastMovementDate: " & item.lastMovementDate)
                'Console.WriteLine(ControlChars.Tab & "lastPurchaseDate: " & item.lastPurchaseDate)
                'Console.WriteLine(ControlChars.Tab & "lastSaleDate: " & item.lastSaleDate)
                'Console.WriteLine(ControlChars.Tab & "movementAllowed: " & item.movementAllowed)
                'Console.WriteLine(ControlChars.Tab & "movementQuantity: " & item.movementQuantity)
                'Console.WriteLine(ControlChars.Tab & "name: " & item.name)
                'Console.WriteLine(ControlChars.Tab & "reference: " & item.reference)
                'Console.WriteLine(ControlChars.Tab & "reference2: " & item.reference2)
                'Console.WriteLine(ControlChars.Tab & "reservedQuantity: " & item.reservedQuantity)
                'Console.WriteLine(ControlChars.Tab & "saleQuantity: " & item.saleQuantity)
                'Console.WriteLine(ControlChars.Tab & "sellingAllowed: " & item.sellingAllowed)
                'Console.WriteLine(ControlChars.Tab & "status: " & item.status)
                'Console.WriteLine(ControlChars.Tab & "Title: " & item.Title)
                'Console.WriteLine(ControlChars.Tab & "type: " & item.type)
                'Console.WriteLine(ControlChars.Tab & "useByDate: " & item.useByDate)

                'Console.WriteLine(ControlChars.Tab & "Location: " & item.location.name)

                'Dim classification As commodityGroupFeedEntry = item.commodity.commodityGroup.name
                'If (commodityGroup.Entries.Contains(item.commodity.commodityGroup)) Then
                'commodityGroup.Entries.f
                'End If

                'If (item.Categories IsNot Nothing) Then
                ' Console.WriteLine(ControlChars.Tab & "Product Category (commodityGroup): " & item.commodity.commodityGroup.name)
                'End If

            Next

        End If
        Console.WriteLine("We're finished!!!")
    End Sub


End Class
