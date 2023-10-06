Imports MySql.Data.MySqlClient

Public Class frmEditarRecibo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand


        ConecxaoSQL.ConnectionString = StringdeConexao
        Try

            ConecxaoSQL.Open()
            Try
                ComandoSql.Connection = ConecxaoSQL
                ComandoSql.Parameters.AddWithValue("@obs", TxtOBS.Text)
                ComandoSql.Parameters.AddWithValue("@IDRecibo", (frmRecibos.ListDeClientes.SelectedRows(0).Cells(0).Value))
                ComandoSql.CommandText = "UPDATE recibos SET obs=@obs WHERE id = @IDRecibo;"
                ComandoSql.ExecuteNonQuery()
                ConecxaoSQL.Close()
                frmRecibos.ClientesCarrega(frmPrincipal.ClienteID)
                Me.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException
            MsgBox("Não foi salvo sem conexão com o servidor verifique o wifi/rede")

        End Try
    End Sub
End Class