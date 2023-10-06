
Public Class FrmMysql
    Dim IPANTIGO As String = StringdeConexao.Substring(7, StringdeConexao.IndexOf(";") - 7)
    Private Sub FrmMysql_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = IPANTIGO
    End Sub

    Private Sub FrmMysql_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        IPANTIGO = StringdeConexao.Substring(7, StringdeConexao.IndexOf(";") - 7)
        StringdeConexao = StringdeConexao.Replace(IPANTIGO, TextBox1.Text)
        If frmPrincipal.TesteConexao(StringdeConexao) Then
            Try
                My.Computer.FileSystem.WriteAllText("config.ccf", StringdeConexao, False)
                Application.Restart()
                End
            Catch ex As Exception
                MsgBox("Não é possivel salvar o arquivo de configurações." & ex.Message)
                End
            End Try
            MsgBox("Sucesso, o aplicativo ira reiniciar com as novas configurações", MsgBoxStyle.Information)
        Else
            MsgBox("O Servidor não foi encontrado digite o ip e tente novamente.", MsgBoxStyle.Exclamation)
        End If
        Button1.Enabled = True
    End Sub

    Private Sub FrmMysql_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class