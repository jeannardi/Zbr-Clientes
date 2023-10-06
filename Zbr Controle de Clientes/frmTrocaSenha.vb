Imports MySql.Data.MySqlClient

Public Class frmTrocaSenha
    Private Sub btAlterar_Click(sender As Object, e As EventArgs) Handles btAlterar.Click
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
                If txtNovaSenha.Text.Length < 4 Then
                    MsgBox("Nova senha precisar ter pelo menos 4 letras!", MsgBoxStyle.Exclamation, "Senha Invalido")
                    Exit Sub
                End If
                ComandoSql.Connection = ConecxaoSQL
                ComandoSql.Parameters.AddWithValue("@Filtro", UsuarioLogado)
                ComandoSql.Parameters.AddWithValue("@NovaSenha", txtNovaSenha.Text)

                ComandoSql.CommandText = "SELECT * FROM usuarios WHERE usuario = @Filtro limit 1;"
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql
                DadosTabela = New DataTable
                AdaptadorTabela.Fill(DadosTabela)

                If DadosTabela.Rows.Count = 1 And DadosTabela.Columns.Count > 4 Then
                    Dim pw As String = DadosTabela.Rows.Item(0).Item(3).ToString
                    If pw = txtSenhaAtual.Text Then
                        UsuarioLogado = DadosTabela.Rows.Item(0).Item(1).ToString
                        frmPrincipal.btLogin.Text = UsuarioLogado
                        ComandoSql.CommandText = "UPDATE usuarios SET senha = @NovaSenha WHERE usuario=@Filtro;"
                        ComandoSql.ExecuteNonQuery()
                        MsgBox("Sua senha foi alterada com sucesso!")
                        'Desloga Usuario
                        LoginPass = False
                        UsuarioLogado = ""
                        frmPrincipal.btTrocarSenha.Enabled = False


                        frmPrincipal.btLogin.Text = " [Entrar]"

                        frmPrincipal.btUsuarios.Enabled = False
                        frmPrincipal.btUsuarios.Visible = False

                        Me.Close()
                        frmPrincipal.Fechaforms()
                    Else
                        MsgBox("Senha atual é invalida!")
                    End If
                Else

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

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtNovaSenha_TextChanged(sender As Object, e As EventArgs) Handles txtNovaSenha.TextChanged

    End Sub

    Private Sub txtNovaSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNovaSenha.KeyDown
        If e.KeyValue = Keys.Enter Then
            btAlterar.PerformClick()
        End If
    End Sub
End Class