Imports MySql.Data.MySqlClient

Public Class FrmMesEdit
    Private Sub txtRecebeu_TextChanged(sender As Object, e As EventArgs) Handles txtRecebeu.TextChanged

    End Sub

    Private Sub txtRecebeu_LostFocus(sender As Object, e As EventArgs) Handles txtRecebeu.LostFocus
        Dim valor As String = "0,00"
        If txtValor.Text = String.Empty Then
            valor = 0
        End If
        Try

            txtValor.Text = FormatCurrency(txtValor.Text, 2, TriState.True, TriState.True,
                                TriState.True).Replace("R$", "").Trim
        Catch ex As Exception
            txtValor.Text = "0,0"
        End Try

        If txtValor.Text <> "" And txtRecebeu.Text <> "" And txtPagamento.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim DadosTabela As New DataTable
        Dim Meses As String = "Relatorio de pagamento" & vbNewLine
        Application.DoEvents()


        Dim DataPagamento As Date = DateTimePicker1.Value
        If LoginPass = True Then
            'If MsgBox("Está tudo pronto. basta clicar em SIM para confirmar o pagamento no sistema.", MsgBoxStyle.YesNo, "Efetuar Pagamento") = MsgBoxResult.Yes Then
            ConecxaoSQL.ConnectionString = StringdeConexao
            Try

                ConecxaoSQL.Open()
                Try


                    ComandoSql.Connection = ConecxaoSQL



                    ComandoSql.Parameters.AddWithValue("@Filtro", frmMensal.ListDeClientes.SelectedRows(0).Cells(0).Value)
                    ComandoSql.Parameters.AddWithValue("@mes", DataPagamento.Month.ToString("D2"))
                    ComandoSql.Parameters.AddWithValue("@Recebeu", txtRecebeu.Text)
                    ComandoSql.Parameters.AddWithValue("@Valor", txtValor.Text)
                    ComandoSql.Parameters.AddWithValue("@nome", frmPrincipal.ClientNome)
                    ComandoSql.Parameters.AddWithValue("@pagamento", txtPagamento.Text)
                    ComandoSql.Parameters.AddWithValue("@datarecibo", DateTimePicker2.Value)
                    Try
                        ComandoSql.Parameters.AddWithValue("@data", CDate(txtDataRecibo.Text)) ' <------- esse data recibo na verdade e a data de inclusao foi mudado
                    Catch ex As Exception
                        ComandoSql.Parameters.AddWithValue("@data", Nothing) ' <------- esse data recibo na verdade e a data de inclusao foi mudado
                    End Try

                    ComandoSql.Parameters.AddWithValue("@IDRecibo", frmMensal.ListDeClientes.SelectedRows(0).Cells(9).Value)
                    ComandoSql.Parameters.AddWithValue("@login", UsuarioLogado)
                    'add parametro do id do recibo
                    ' ComandoSql.Parameters.AddWithValue("@codrecibo", ComandoSql.LastInsertedId)


                    '---------Atualiza registro do Ano salva alteracoes e seleciona o recibo
                    ComandoSql.CommandText = "UPDATE pagamentos SET mes = @mes, formadepagamento = @pagamento, usuario = @login, valor = @Valor, recebido = @Recebeu,data = @data,datarecibo = @datarecibo WHERE id = @Filtro;
                 SELECT valor FROM pagamentos  WHERE codrecibo = @IDRecibo;"

                    ComandoSql.ExecuteNonQuery()
                    ComandoSql.CommandText = "UPDATE pagamentos SET data = @data,datarecibo = @datarecibo WHERE codrecibo = @IDRecibo;
                 SELECT valor FROM pagamentos  WHERE codrecibo = @IDRecibo;"

                    ComandoSql.ExecuteNonQuery()
                    AdaptadorTabela.SelectCommand = ComandoSql
                    DadosTabela = New DataTable
                    AdaptadorTabela.Fill(DadosTabela)
                    If DadosTabela.Rows.Count >= 0 Then
                        Dim ValorTotal As String = "0,0"
                        For Each linha As DataRow In DadosTabela.Rows

                            Dim valoragora As Double = 0
                            Try
                                valoragora = CDbl(linha.Item("valor"))
                            Catch ex As Exception
                                valoragora = 0
                            End Try

                            ValorTotal = FormatCurrency(CDbl(ValorTotal) + valoragora, 2, TriState.True, TriState.True,
                                                     TriState.True).Replace("R$", "").Trim


                        Next
                        'MsgBox(ValorTotal)
                        ValorTotal = FormatCurrency(ValorTotal, 2, TriState.True, TriState.True,
                                    TriState.True).Replace("R$", "").Trim
                        ComandoSql.Parameters.AddWithValue("@total", ValorTotal)

                        ComandoSql.CommandText = "UPDATE recibos SET valortotal = @total,data=@data WHERE id = @IDRecibo;"

                        ComandoSql.ExecuteNonQuery()
                    End If




                    '---------Atuliza DatagridView do ano
                    Dim MesAno As String = frmMensal.DateTimePicker1.Value.ToString("MM")
                    Dim Ano As String = frmMensal.DateTimePicker1.Value.Year.ToString
                    frmMensal.DateTimePicker1.Enabled = False
                    frmMensal.Label1.Text = Ano
                    frmMensal.ClientesCarrega(frmPrincipal.ClienteID, Ano)
                    frmMensal.DateTimePicker1.Enabled = True
                    '---------Atualiza MES

                    ConecxaoSQL.Close()
                    Me.Close()
                Catch ex As MySqlException
                    MsgBox(ex.Message & "AQUII")
                    ConecxaoSQL.Close()
                End Try

                'fecha conecão mysql
                ConecxaoSQL.Close()
            Catch ex As MySqlException
                MsgBox("Não foi salvo sem conexão com o servidor verifique o wifi/rede")

            End Try

            Button1.Enabled = True
        Else
            Me.Close()
            frmMensal.Close()
            frmLogin.ShowDialog()
            frmPrincipal.Show()
        End If
        Try
            frmMensal.ListDeClientes.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        txtValor.Text = Replace(txtValor.Text, "-", "")
    End Sub

    Private Sub txtValor_LostFocus(sender As Object, e As EventArgs) Handles txtValor.LostFocus
        Dim valor As String = "0,00"
        If txtValor.Text = String.Empty Then
            valor = 0
        End If
        Try

            txtValor.Text = FormatCurrency(txtValor.Text, 2, TriState.True, TriState.True,
                                TriState.True).Replace("R$", "").Trim
        Catch ex As Exception
            txtValor.Text = "0,0"
        End Try

        If txtValor.Text <> "" And txtRecebeu.Text <> "" And txtPagamento.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

    End Sub

    Private Sub FrmMesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        txtDataRecibo.Text = Now.Date
    End Sub
End Class