Imports MySql.Data.MySqlClient

Public Class frmUserAdmin
    Private userID As Integer
    Private Sub CarregaClientes()
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


                ComandoSql.CommandText = "SELECT * FROM usuarios;"
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql
                DadosTabela = New DataTable
                AdaptadorTabela.Fill(DadosTabela)
                DataGridView1.DataSource = DadosTabela

                If DataGridView1.Columns.Count > 4 Then
                    DataGridView1.Columns(0).Visible = False
                    DataGridView1.Columns(4).Visible = False
                    DataGridView1.Columns(3).Visible = False

                    DataGridView1.Columns(1).HeaderText = "Usuario"
                    DataGridView1.Columns(1).Width = "160"
                    DataGridView1.Columns(2).HeaderText = "Telefone"
                    DataGridView1.Columns(2).Width = "100"
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

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
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
                If txtUsuario.Text.Length < 4 Then
                    MsgBox("Nome de usuario precisar ter pelo menos 4 letras!", MsgBoxStyle.Exclamation, "Usuario Invalido")
                    Exit Sub
                End If
                If txtSenha.Text.Length < 4 Then
                    MsgBox("Senha precisar ter pelo menos 4 letras!", MsgBoxStyle.Exclamation, "Senha Invalida")
                    Exit Sub
                End If
                ComandoSql.Connection = ConecxaoSQL
                ComandoSql.Parameters.AddWithValue("@id", userID)
                ComandoSql.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                ComandoSql.Parameters.AddWithValue("@telefone", txtTelefone.Text)
                ComandoSql.Parameters.AddWithValue("@senha", txtSenha.Text)
                ComandoSql.Parameters.AddWithValue("@super", "0")
                If CheckBox1.Checked = True Then
                    ComandoSql.Parameters("@super").Value = "9"
                End If
                If btExcluir.Enabled = True Then
                    ComandoSql.CommandText = "UPDATE usuarios SET senha = @senha,usuario = @usuario,telefone = @telefone,super = @super WHERE id=@id;"
                    ComandoSql.ExecuteNonQuery()
                Else
                    ComandoSql.CommandText = "INSERT INTO usuarios (usuario,telefone,senha,super)
                    VALUES (@usuario, @telefone, @senha,@super);"
                    ComandoSql.ExecuteNonQuery()
                End If
                DataGridView1.Enabled = True
                ConecxaoSQL.Close()
                MsgBox("Cliente alterado com sucesso!", MsgBoxStyle.Information, "Sucesso!")


                'recarrega clientes
                CarregaClientes()
            Catch ex As MySqlException

                ConecxaoSQL.Close()
                If ex.Number = 1062 Then
                    MsgBox("Este usuario ja existe, escolha outro nome de usuario!", MsgBoxStyle.Exclamation, "Error ao salvar")
                    Exit Sub
                Else
                    MsgBox(ex.Message & ex.Number)
                End If


            End Try
            btNovo.Enabled = True
            brModificar.Enabled = True
            'bloqueio de controles
            btCancelar.Enabled = False
            btExcluir.Enabled = False
            BtSalvar.Enabled = False
            CheckBox1.Enabled = False
            'somente leitura
            txtSenha.ReadOnly = True
            txtTelefone.ReadOnly = True
            txtUsuario.ReadOnly = True
        Catch ex As Exception
            MsgBox("Não foi salvo sem conexão com o servidor verifique o wifi/rede")
        End Try
    End Sub

    Private Sub frmUserAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaClientes()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            userID = DataGridView1.SelectedRows(0).Cells(0).Value
            txtUsuario.Text = DataGridView1.SelectedRows(0).Cells(1).Value
            txtTelefone.Text = DataGridView1.SelectedRows(0).Cells(2).Value
            txtSenha.Text = DataGridView1.SelectedRows(0).Cells(3).Value
            If DataGridView1.SelectedRows(0).Cells(4).Value Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
        End If

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        DataGridView1.ClearSelection()
        DataGridView1.Enabled = False

        btNovo.Enabled = False
        brModificar.Enabled = False
        btExcluir.Enabled = False


        btCancelar.Enabled = True
        BtSalvar.Enabled = True

        CheckBox1.Enabled = True
        'libera para escrita
        txtUsuario.ReadOnly = False
        txtSenha.ReadOnly = False
        txtTelefone.ReadOnly = False

        'limpa todos os campos
        txtUsuario.Text = ""
        txtTelefone.Text = ""
        txtSenha.Text = ""
        CheckBox1.Checked = False
    End Sub

    Private Sub brModificar_Click(sender As Object, e As EventArgs) Handles brModificar.Click
        btNovo.Enabled = False
        brModificar.Enabled = False

        btCancelar.Enabled = True
        BtSalvar.Enabled = True
        btExcluir.Enabled = True
        CheckBox1.Enabled = True
        'libera para escrita
        txtSenha.ReadOnly = False
        txtTelefone.ReadOnly = False
        txtUsuario.ReadOnly = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        DataGridView1.Enabled = True
        CarregaClientes()
        btNovo.Enabled = True
        brModificar.Enabled = True

        'bloqueio de controles
        btCancelar.Enabled = False
        btExcluir.Enabled = False
        BtSalvar.Enabled = False
        CheckBox1.Enabled = False
        'somente leitura
        txtSenha.ReadOnly = True
        txtTelefone.ReadOnly = True
        txtUsuario.ReadOnly = True
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
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
                ComandoSql.Parameters.AddWithValue("@id", userID)
                ComandoSql.CommandText = "DELETE FROM usuarios WHERE id = @id;"
                ComandoSql.ExecuteNonQuery()

                DataGridView1.Enabled = True
                ConecxaoSQL.Close()
                MsgBox("Cliente excluido com sucesso!!", MsgBoxStyle.Information, "Excluido!")

                'recarrega clientes
                CarregaClientes()
            Catch ex As MySqlException

                ConecxaoSQL.Close()

                MsgBox(ex.Message)



            End Try
            btNovo.Enabled = True
            brModificar.Enabled = True
            'bloqueio de controles
            btCancelar.Enabled = False
            btExcluir.Enabled = False
            BtSalvar.Enabled = False
            CheckBox1.Enabled = False
            'somente leitura
            txtSenha.ReadOnly = True
            txtTelefone.ReadOnly = True
            txtUsuario.ReadOnly = True
        Catch ex As Exception
            MsgBox("Não foi salvo sem conexão com o servidor verifique o wifi/rede")
        End Try
    End Sub
End Class