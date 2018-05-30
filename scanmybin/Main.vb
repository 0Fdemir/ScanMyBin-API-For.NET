Imports System.Text
Imports System.Threading
Imports Newtonsoft.Json

Public Class Main

#Region "Constants"

    Private scanID As String
    Private wc As New Net.WebClient

    Private Const apiKey As String = "yourapikey" 'Apikey here
    Private Const websiteLink As String = "https://scanmybin.net/result/"
    Private Const scanUrl As String = "https://scanmybin.net/api/new/"
    Private Const statusURL As String = "https://scanmybin.net/api/status/"
    Private Const resultURL As String = "https://scanmybin.net/api/scan/"

    ''' <summary>
    ''' 0 => "Scan created.",
    ''' 1 => "The uploaded file exceeds the upload_max_filesize.",
    ''' 2 => "The uploaded file exceeds the MAX_FILE_SIZE directive that was specified in the HTML form.",
    ''' 3 => "The uploaded file was only partially uploaded.",
    ''' 4 => "Invalid API key.",
    ''' 5 => "This API key is expired.",
    ''' 6 => "This key can't be used for API.",
    ''' 7 => "Max authorized IP for this API."
    ''' 8 => "Maintenance mode."
    ''' </summary>
    Private Enum UploadFlags
        CREATED = 0
        UPLOAD_MAX_FILESIZE = 1
        MAX_FILE_SIZE = 2
        PARTIALLY_UPLOAD = 3
        INVALID_APIKEY = 4
        EXPIRED_APIKEY = 5
        CANT_USED = 6
        MAX_AUTHORIZED = 7
        MAINTENANCE = 8
    End Enum

#End Region

#Region "Functions"

    Private Delegate Sub SetStatusDelegate(ByVal text As String)
    Public Sub SetStatus(ByVal text As String)
        If Me.InvokeRequired Then
            Dim del As New SetStatusDelegate(AddressOf SetStatus)
            Me.BeginInvoke(del, New Object() {text})
        Else
            Me.lblProgress.Text = text
        End If

    End Sub

    Public Function ScanFile(filename As String) As JsonResult
        Dim request As String

        SetStatus("Uploading...")

        Try
            request = Encoding.UTF8.GetString(wc.UploadFile(scanUrl & apiKey, filename))
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try

        Dim uploadJson As JsonUpload = JsonConvert.DeserializeObject(Of JsonUpload)(request)

        If uploadJson.Status <> UploadFlags.CREATED Then
            SetStatus(uploadJson.Status_strg)
            MsgBox(uploadJson.Status_strg, MsgBoxStyle.Critical)

            Return Nothing
        End If

        scanID = uploadJson.scan_id

        Do
            SetStatus("Scanning...")
            Threading.Thread.Sleep(2000)
        Loop While GetStatus().Status = 0 ' 0 => "scannig", 1 => "finish"

        SetStatus("Finish")

        Dim resultJson As JsonResult = GetResult()

        Return resultJson

    End Function

    Private Function GetStatus() As JsonStatus

        Try
            Dim result As String = wc.DownloadString(statusURL & scanID)

            Dim parsedJson As JsonStatus = JsonConvert.DeserializeObject(Of JsonStatus)(result)

            Return parsedJson
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try

    End Function

    Private Function GetResult() As JsonResult

        Try
            Dim result As String = wc.DownloadString(resultURL & scanID & "/full")

            Dim parsedJson As JsonResult = JsonConvert.DeserializeObject(Of JsonResult)(result)

            Dim typeOfDate = New With {.date = ""}

            Dim _date = JsonConvert.DeserializeAnonymousType(result, typeOfDate)

            parsedJson._Date = _date.date.ToString

            Return parsedJson
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try

    End Function

    Public Function ParseAvResults(ByVal _jsonResult As JsonResult) As Dictionary(Of String, String)
        Try
            Dim avResults As New Dictionary(Of String, String)

            For Each x In _jsonResult.Data
                avResults.Add(x.Key, x.Value)
            Next

            Return avResults
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function

    Public Function GetResultLink() As String
        Return websiteLink & scanID
    End Function

    Private Sub EnableDisableButton()

        Dim Buttons() As Button = New Button() {Button1, Button2, Button3}

        For Each ButtonObj In Buttons
            If ButtonObj.Enabled = True Then
                ButtonObj.Enabled = False
            Else
                ButtonObj.Enabled = True
            End If
            ButtonObj.Refresh()
        Next

    End Sub

    Private Sub ScanThread()

        Try

            EnableDisableButton()

            Dim result As JsonResult = ScanFile(fileName.Text)

            If result IsNot Nothing Then
                txtMD5.Text = result.Md5
                resultLink.Text = GetResultLink()
                lblRatio.Text = result.Detection & "/" & result.Total
                lblDate.Text = result._Date.ToString()

                For Each x In result.Data
                    grid.Rows.Add(New String() {x.Key.ToString, x.Value.ToString})
                Next
            End If

            EnableDisableButton()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            EnableDisableButton()
        End Try

    End Sub

#End Region

#Region "Buttons"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using dialog As New OpenFileDialog
            dialog.Filter = "All Files (*.*)|*.*"
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            fileName.Text = dialog.FileName
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If resultLink.Text IsNot Nothing Then Clipboard.SetText(resultLink.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IO.File.Exists(fileName.Text) = False Then
            MsgBox("File not found!", MsgBoxStyle.Critical)
            Return
        End If

        grid.Rows.Clear()

        Call New Thread(AddressOf ScanThread).Start()

    End Sub
#End Region

#Region "Events"
    Private Sub grid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grid.CellFormatting
        Dim cell As DataGridViewCell = grid.Rows(e.RowIndex).Cells(e.ColumnIndex)

        If cell.ColumnIndex = 1 Then
            If cell.Value = "Clean" Then
                e.CellStyle.ForeColor = Color.Green
            Else
                e.CellStyle.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
#End Region

End Class
