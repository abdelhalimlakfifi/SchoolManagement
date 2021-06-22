Imports System.Net
Imports System.Net.FtpWebRequest
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Compression
Public Class fileManager
    Dim path As String
    Dim nextpath As String
    

    Private Sub fileManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ZipFile.CreateFromDirectory("C:\Users\Pitcho\Desktop\test", "destination.zip", CompressionLevel.Optimal, False)

        On Error Resume Next
        Dim Dirlist As New List(Of String) 'I prefer List() instead of an array
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & pdo.ipServer & "/students/" & pdo.path), FtpWebRequest)
        'My.Computer.Network.UploadFile("C:/Users/Pitcho/Downloads/Compressed/Bunifu_UI_v1.52.zip", "ftp://" & pdo.ipServer & "/students/" & pdo.path & "/folder.zip", "miage", "miage", True, 500)
        request.Method = WebRequestMethods.Ftp.ListDirectory
        request.Credentials = New NetworkCredential("miage", "miage")

        Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream

        Using reader As New StreamReader(responseStream)
            For Each x In reader.ReadToEnd.Split(vbNewLine)
                Dim lastpart As String = x.Substring(x.LastIndexOf(".") + 1)
                If lastpart = "zip" Then
                    ListView1.Items.Add(x.Substring(x.LastIndexOf("/") + 1), ImageList1.Images.Count() - 1)
                ElseIf lastpart = Nothing Then

                Else
                    ListView1.Items.Add(x.Substring(x.LastIndexOf("/") + 1), ImageList1.Images.Count() - 2)
                End If
            Next
            MsgBox(reader.ReadToEnd)

        End Using

        response.Close()
        ' path = "E:"
        'For Each i In My.Computer.FileSystem.GetDirectories(path)
        'ListView1.Items.Add("tets", ImageList1.Images.Count() - 2)
        'Next
        'For Each i In My.Computer.FileSystem.GetDirectories(path)
        ' ListView1.Items.Add("dasda", ImageList1.Images.Count() - 1)
        'Next
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        nextpath = path + "\" + e.Item.Text
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        'MsgBox(ListView1.SelectedItems.Item(0).Text)
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.Network.DownloadFile("ftp://" & pdo.ipServer & "/students/" & pdo.path & "/" & ListView1.SelectedItems.Item(0).Text, FolderBrowserDialog1.SelectedPath & "/" & ListView1.SelectedItems.Item(0).Text, "miage", "miage")
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' FolderBrowserDialog1.SelectedPath
            Dim x As New DirectoryInfo(FolderBrowserDialog1.SelectedPath)

            ZipFile.CreateFromDirectory(FolderBrowserDialog1.SelectedPath, x.Name & ".zip", CompressionLevel.Optimal, False)

            My.Computer.Network.UploadFile(x.Name & ".zip", "ftp://" & pdo.ipServer & "/students/" & pdo.path & "/" & x.Name & ".zip", "miage", "miage", True, 500)

            My.Computer.FileSystem.DeleteFile(x.Name & ".zip")

            ListView1.Clear()
            On Error Resume Next
            Dim Dirlist As New List(Of String) 'I prefer List() instead of an array
            Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & pdo.ipServer & "/students/" & pdo.path), FtpWebRequest)
            'My.Computer.Network.UploadFile("C:/Users/Pitcho/Downloads/Compressed/Bunifu_UI_v1.52.zip", "ftp://" & pdo.ipServer & "/students/" & pdo.path & "/folder.zip", "miage", "miage", True, 500)
            request.Method = WebRequestMethods.Ftp.ListDirectory
            request.Credentials = New NetworkCredential("miage", "miage")

            Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
            Dim responseStream As Stream = response.GetResponseStream

            Using reader As New StreamReader(responseStream)
                For Each y In reader.ReadToEnd.Split(vbNewLine)
                    Dim lastpart As String = y.Substring(y.LastIndexOf(".") + 1)
                    If lastpart = "zip" Then
                        ListView1.Items.Add(y.Substring(y.LastIndexOf("/") + 1), ImageList1.Images.Count() - 1)
                    ElseIf lastpart = Nothing Then

                    Else
                        ListView1.Items.Add(y.Substring(y.LastIndexOf("/") + 1), ImageList1.Images.Count() - 2)
                    End If
                Next
                MsgBox(reader.ReadToEnd)

            End Using

            response.Close()

        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim whole As String = OpenFileDialog1.FileName
            'MsgBox(whole.Substring(whole.LastIndexOf("\") + 1))
            My.Computer.Network.UploadFile(whole, "ftp://" & pdo.ipServer & "/students/" & pdo.path & "/" & whole.Substring(whole.LastIndexOf("\") + 1), "miage", "miage", True, 500)
            ListView1.Clear()
            On Error Resume Next
            Dim Dirlist As New List(Of String) 'I prefer List() instead of an array
            Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & pdo.ipServer & "/students/" & pdo.path), FtpWebRequest)
            'My.Computer.Network.UploadFile("C:/Users/Pitcho/Downloads/Compressed/Bunifu_UI_v1.52.zip", "ftp://" & pdo.ipServer & "/students/" & pdo.path & "/folder.zip", "miage", "miage", True, 500)
            request.Method = WebRequestMethods.Ftp.ListDirectory
            request.Credentials = New NetworkCredential("miage", "miage")

            Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
            Dim responseStream As Stream = response.GetResponseStream

            Using reader As New StreamReader(responseStream)
                For Each y In reader.ReadToEnd.Split(vbNewLine)
                    Dim lastpart As String = y.Substring(y.LastIndexOf(".") + 1)
                    If lastpart = "zip" Then
                        ListView1.Items.Add(y.Substring(y.LastIndexOf("/") + 1), ImageList1.Images.Count() - 1)
                    ElseIf lastpart = Nothing Then

                    Else
                        ListView1.Items.Add(y.Substring(y.LastIndexOf("/") + 1), ImageList1.Images.Count() - 2)
                    End If
                Next
                MsgBox(reader.ReadToEnd)

            End Using

            response.Close()
        End If
    End Sub
End Class