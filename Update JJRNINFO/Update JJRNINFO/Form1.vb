Imports System.Net
Imports System.IO
Imports System.IO.Compression
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DownloadArquivo("ftp://217.21.76.89/ZbrCliUpdate/atualiza.txt", "u120316547.armazemdanet.store", "Patopolis50")
        Beep()

        Dim startPath As String = "c:\example\start"
        Dim zipPath As String = "update.zip"
        Dim extractPath As String = "c:\example\extract"

        'ZipFile.CreateFromDirectory(startPath, zipPath)
        ZipFile.ExtractToDirectory(zipPath, Application.StartupPath, True)

    End Sub

    Public Function DownloadArquivo(ByVal URL As String, ByVal Usuario As String, ByVal Senha As String) As Boolean
        Dim request As FtpWebRequest =
    WebRequest.Create(URL)
        request.Credentials = New NetworkCredential(Usuario, Senha)
        request.Method = WebRequestMethods.Ftp.DownloadFile

        Using ftpStream As Stream = request.GetResponse().GetResponseStream(),
              fileStream As Stream = File.Create("baixo.txt")
            Dim buffer As Byte() = New Byte(10240 - 1) {}
            Dim read As Integer
            Do
                read = ftpStream.Read(buffer, 0, buffer.Length)
                If read > 0 Then
                    Application.DoEvents()
                    fileStream.Write(buffer, 0, read)
                    Console.WriteLine("Downloaded {0} bytes", fileStream.Position)
                    Application.DoEvents()
                End If
            Loop While read > 0
        End Using
        Return (True)
    End Function
End Class
