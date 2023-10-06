
Imports System.IO
Imports System.Net
Imports System.Net.FtpWebRequest

Module Module1
    Public StringdeConexao As String = My.Computer.FileSystem.ReadAllText("config.ccf")
    Public UsuarioLogado As String = ""
    Public UsuarioSenha As String = ""
    Public LoginPass As Boolean = False
    Public Version As Integer = 2500
    Public novaVersion As Integer = 0
    Public PWUP As String = "Zbr456300"
    Public LinkUpdateNovo As String = ""
    Public Function VerificarAtualizacoes() As String
        Dim oWebRequest As WebRequest
        Dim oWebResponse As WebResponse = Nothing
        Dim strBuffer As String()
        Dim objSR As StreamReader = Nothing
        'conecta com o website
        Try
            oWebRequest = HttpWebRequest.Create("https://jjninfo.com.br/zbrcliupdate/update.conf")
            oWebRequest.Credentials = New System.Net.NetworkCredential("zbr", PWUP)
            oWebResponse = oWebRequest.GetResponse()
            'Le a resposta do web site e armazena em uma stream
            objSR = New StreamReader(oWebResponse.GetResponseStream)
            strBuffer = objSR.ReadToEnd.Split(New Char() {Convert.ToChar(13), Convert.ToChar(10)}, StringSplitOptions.RemoveEmptyEntries)
            novaVersion = strBuffer(0) 'linha 0

            If Version < novaVersion Then
                LinkUpdateNovo = strBuffer(1) 'linha 1
                frmUpdate.ShowDialog()

            End If
            Return ""
        Catch ex As WebException

            If objSR IsNot Nothing Then
                objSR.Close()
            End If
            If oWebResponse IsNot Nothing Then
                oWebResponse.Close()
            End If
            Return ("Servidor update: " & ex.Message)
        End Try

    End Function
    Public Function DownloadArquivo(ByVal URL As String, ByVal Usuario As String, ByVal Senha As String) As Boolean
        Dim request As FtpWebRequest =
    WebRequest.Create(URL)
        request.Credentials = New NetworkCredential(Usuario, Senha)
        request.Method = WebRequestMethods.Ftp.DownloadFile

        Using ftpStream As Stream = request.GetResponse().GetResponseStream(),
              fileStream As Stream = File.Create("updatedownload.zip")
            Dim buffer As Byte() = New Byte(10240 - 1) {}
            Dim read As Integer
            Do
                read = ftpStream.Read(buffer, 0, buffer.Length)
                If read > 0 Then
                    Application.DoEvents()
                    fileStream.Write(buffer, 0, read)
                    Console.WriteLine("Downloaded {0} bytes", fileStream.Position)
                    Try
                        frmUpdate.ProgressBar1.Maximum = fileStream.Length
                        frmUpdate.ProgressBar1.Value = fileStream.Position
                        frmUpdate.ProgressBar1.Refresh()
                        frmUpdate.Label3.Text = "Downloaded " & fileStream.Position
                        Application.DoEvents()
                    Catch ex As Exception

                    End Try

                End If
            Loop While read > 0
            frmUpdate.UpdateCompleto()
        End Using
        Return (True)
    End Function


End Module
