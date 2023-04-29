Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Module BusBooking_Module
    Public myconn As MySqlConnection = New MySqlConnection
    Public dataset As New DataSet
    Public mycmd As MySqlCommand = New MySqlCommand
    Public myreader As MySqlDataReader
    Public strsql As String
    Public myConnectionString As String

    Public currentDate As DateTime = DateTime.Now
    'Public strpassword = "12345678"
    Public xlsPath As String = "D:\EDP\OLAVARIO_BusBooking_Project\dataXls\TEMPLATE\"
    Public xlsFiles As String = "D:\EDP\OLAVARIO_BusBooking_Project\dataXls\"

    Public Sub connect()

        mycmd.CommandText = strsql
        mycmd.CommandType = CommandType.Text
        mycmd.Connection = myconn
        myconn.Open()
        myreader = mycmd.ExecuteReader

    End Sub

    Public Sub ConnectToDB()
        myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"

        Try
            myconn.Open()
            'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
            'myconn.Close()

        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password")
            End Select

        End Try

    End Sub

    Public Sub DisconnectToDB()
        myconn.Close()
        myconn.Dispose()
    End Sub

    Public Sub ImportToExcel(ByVal mydg As DataGridView, ByVal templatefilename As String)
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(xlsPath & templatefilename)
        xlsSheet = xlsWB.Worksheets(1)

        'Dim x, y As Integer
        '  For x = 0 To mydg.RowCount - 1
        '    For y = 0 To mydg.ColumnCount - 1
        '        xlsSheet.Cells(x + 5, y + 1) = mydg.Rows(x).Cells(y).Value
        '    Next
        'Next

        Dim x, y As Integer
        For x = 0 To mydg.RowCount - 1
            For y = 0 To mydg.ColumnCount - 1
                Dim cellValue As Object = mydg.Rows(x).Cells(y).Value
                If TypeOf cellValue Is Date Then
                    xlsSheet.Cells(x + 5, y + 1).NumberFormat = "hh:mm:ss AM/PM"
                    cellValue = CType(cellValue, Date).ToString("hh:mm:ss tt")
                ElseIf TypeOf cellValue Is Double Then
                    cellValue = CDbl(cellValue)
                ElseIf TypeOf cellValue Is Integer Then
                    cellValue = CInt(cellValue)
                End If
                xlsSheet.Cells(x + 5, y + 1) = cellValue
            Next
        Next

        With xlsSheet.Range(convertToLetters(1) & 5, convertToLetters(mydg.ColumnCount) & x + 4)
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        End With

        templatefilename = templatefilename.Replace(".xlsx", "")
        templatefilename = templatefilename.Replace(".xls", "")
        Dim myfilename As String = templatefilename & " " & currentDate.ToString("MM-dd-yy hh-mm-ss") & ".xlsx"
        MsgBox(myfilename)
        'xlsSheet.Protect(strpassword)
        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False
        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()
        releaseObject(xlsApp)
        releaseObject(xlsWB)
        releaseObject(xlsSheet)
        System.Diagnostics.Process.Start("excel.exe", """" & xlsFiles & myfilename & """")
    End Sub

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Function convertToLetters(ByVal number As Integer) As String
        number -= 1
        Dim result As String = String.Empty

        If (26 > number) Then
            result = Chr(number + 65)
        Else
            Dim column As Integer
            Do
                column = number Mod 26
                number = (number \ 26) - 1
                result = Chr(column + 65) + result
            Loop Until (number < 0)
        End If
        Return result
    End Function

End Module
