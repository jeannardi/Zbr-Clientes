Imports MySql.Data.MySqlClient

Public Class frmEquipamentosadd
    Public Incluir As Boolean = False
    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim DadosTabela As New DataTable


        Application.DoEvents()
        ' ResetMes()

        BtSalvar.Enabled = False
        ConecxaoSQL.ConnectionString = StringdeConexao

        Try

                ConecxaoSQL.Open()
                Try


                    ComandoSql.Connection = ConecxaoSQL
                'Limpeza
                If Incluir = False Then
                    Dim seila As String = FrmEquipamentos.ListDeClientes.SelectedRows.Count

                    ComandoSql.Parameters.AddWithValue("@id", FrmEquipamentos.ListDeClientes.SelectedRows(0).Cells(0).Value)

                End If

                Dim dataa As Date
                    Try
                        dataa = CDate(TxtData.Text)
                    Catch ex As Exception

                        MsgBox("Data de troca está incorreta.")
                        TxtData.Focus()
                        ConecxaoSQL.Close()
                        BtSalvar.Enabled = True
                        Exit Sub
                    End Try

                ComandoSql.Parameters.AddWithValue("@material", TxtMaterial.Text)
                    ComandoSql.Parameters.AddWithValue("@filtro", frmPrincipal.ClienteID)
                    ComandoSql.Parameters.AddWithValue("@data", dataa)
                    ComandoSql.Parameters.AddWithValue("@valor", TxtValor.Text)
                ComandoSql.Parameters.AddWithValue("@pago", CmbPago.Text)

                Try
                    ComandoSql.Parameters.AddWithValue("@datapagamento", CDate(txtDataRecibo.Text))
                Catch ex As Exception
                    ComandoSql.Parameters.AddWithValue("@datapagamento", Nothing)
                End Try

                If Incluir = False Then
                    ComandoSql.CommandText = "UPDATE equipamentos SET material = @material,data = @data,valor = @valor,pago = @pago,datapagamento = @datapagamento WHERE id = @id;"
                    ComandoSql.ExecuteNonQuery()
                    ComandoSql.Parameters.AddWithValue("@reciboid", FrmEquipamentos.ListDeClientes.SelectedRows(0).Cells(6).Value)
                    ComandoSql.CommandText = "UPDATE recibos SET valortotal = @valor WHERE id = @reciboid;"
                    ComandoSql.ExecuteNonQuery()
                Else

                    ComandoSql.Parameters.AddWithValue("@nome", frmPrincipal.txtNome.Text)
                    ComandoSql.CommandText = "INSERT INTO recibos (clientid, clientnome, tipo, data, valortotal) VALUES (@filtro,@nome ,'Equipamento', @data, @Valor); SELECT LAST_INSERT_ID();"
                    ComandoSql.ExecuteNonQuery()

                    ComandoSql.Parameters.AddWithValue("@reciboid", ComandoSql.LastInsertedId)
                    ComandoSql.CommandText = "INSERT INTO equipamentos (clienteid, material, data, valor, pago,reciboid,datapagamento) VALUES (@filtro, @material, @data, @Valor,@pago,@reciboid,@datapagamento);"
                    ComandoSql.ExecuteNonQuery()
                End If




                ConecxaoSQL.Close()
                    Me.Close()
                    FrmEquipamentos.ClientesCarrega(frmPrincipal.ClienteID)
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    ConecxaoSQL.Close()
                End Try

                'fecha conecão mysql
                ConecxaoSQL.Close()
            Catch ex As MySqlException


            End Try

        BtSalvar.Enabled = True
        frmPrincipal.TabIndex = 3

    End Sub

    Private Sub TxtValor_TextChanged(sender As Object, e As EventArgs) Handles TxtValor.TextChanged

    End Sub

    Private Sub TxtValor_LostFocus(sender As Object, e As EventArgs) Handles TxtValor.LostFocus
        Try
            TxtValor.Text = FormatCurrency(TxtValor.Text, 2, TriState.True, TriState.True,
            TriState.True).Replace("R$", "").Trim
        Catch ex As Exception
            TxtValor.Text = "0,0"
        End Try
    End Sub

    Private Sub frmEquipamentosadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        txtDataRecibo.Text = Now.Date
    End Sub
End Class