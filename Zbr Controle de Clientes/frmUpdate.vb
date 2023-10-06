Public Class frmUpdate
    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Label3.Text = "Inicio download"
        DownloadArquivo("ftp://ftp.jjninfo.com.br/" & LinkUpdateNovo, "u120316547.zbr", "Zbr456300")
    End Sub
    Public Sub UpdateCompleto()
        Dim arquivo As String = "updatedownload.zip"
        Dim SalvarEM As String = "-MESMAPASTA"


        Dim proc = Process.Start(Application.StartupPath & "\netcoreapp3.1\ExtractFiles.exe", arquivo & " " & SalvarEM)
        Label3.Text = "Extraindo arquivos novos"
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class