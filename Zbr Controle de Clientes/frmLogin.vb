Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Verifica_User(txtUsuario.Text, txtSenha.Text)
        txtUsuario.Focus()
    End Sub
    Public Sub Verifica_User(ByVal Usuario As String, ByVal Senha As String)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim DadosTabela As New DataTable
        Dim Meses As String = "Relatorio de pagamento" & vbNewLine
        Application.DoEvents()

        ConecxaoSQL.ConnectionString = StringdeConexao
        Try

            ConecxaoSQL.Open()
            Try
                ComandoSql.Connection = ConecxaoSQL
                ComandoSql.Parameters.AddWithValue("@Filtro", txtUsuario.Text)


                ComandoSql.CommandText = "SELECT * FROM usuarios WHERE usuario = @Filtro limit 1;"
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql
                DadosTabela = New DataTable
                AdaptadorTabela.Fill(DadosTabela)

                If DadosTabela.Rows.Count = 1 And DadosTabela.Columns.Count > 4 Then
                    Dim pw As String = DadosTabela.Rows.Item(0).Item(3).ToString
                    Dim SUPER As String = DadosTabela.Rows.Item(0).Item(4).ToString
                    If pw = txtSenha.Text Then
                        UsuarioLogado = DadosTabela.Rows.Item(0).Item(1).ToString
                        frmPrincipal.btLogin.Text = UsuarioLogado
                        LoginPass = True
                        Me.Close()
                        txtSenha.Text = ""
                        frmPrincipal.btLogin.Text = UsuarioLogado & " [Sair]"
                        frmPrincipal.btTrocarSenha.Enabled = True
                        If SUPER = "9" Then
                            frmPrincipal.btUsuarios.Enabled = True
                            frmPrincipal.btUsuarios.Visible = True
                        Else
                            frmPrincipal.btUsuarios.Enabled = False
                            frmPrincipal.btUsuarios.Visible = False
                        End If
                    Else
                        LoginPass = False
                        UsuarioLogado = ""
                        txtSenha.Text = ""
                        frmPrincipal.btTrocarSenha.Enabled = False


                        frmPrincipal.btLogin.Text = " [Entrar]"

                        frmPrincipal.btUsuarios.Enabled = False
                        frmPrincipal.btUsuarios.Visible = False
                        MsgBox("Usuario ou senha invalido")
                    End If
                Else
                    UsuarioLogado = ""
                    txtSenha.Text = ""
                    LoginPass = False
                    frmPrincipal.btTrocarSenha.Enabled = False


                    frmPrincipal.btLogin.Text = " [Entrar]"

                    frmPrincipal.btUsuarios.Enabled = False
                    frmPrincipal.btUsuarios.Visible = False
                    MsgBox("Usuario ou senha invalido")

                End If

                ConecxaoSQL.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                ConecxaoSQL.Close()
            End Try
        Catch ex As Exception
            MsgBox("Não foi salvo sem conexão com o servidor verifique o wifi/rede")
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs) Handles txtSenha.TextChanged

    End Sub

    Private Sub txtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyValue = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class