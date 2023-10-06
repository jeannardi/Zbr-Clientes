Imports MySql.Data.MySqlClient

Public Class frmMensal
    Private Sub frmMensal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        lblMensal.Parent = PictureBox1
        ListDeClientes.ClearSelection()

    End Sub
    Public Sub ClientesCarrega(ByVal Filtro As String, ByVal Ano As String)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim DadosTabela As New DataTable


        Application.DoEvents()
        ResetMes()
        ListDeClientes.ClearSelection()

        ConecxaoSQL.ConnectionString = StringdeConexao
        Try

            ConecxaoSQL.Open()
            Try


                ComandoSql.Connection = ConecxaoSQL


                ComandoSql.CommandText = "SELECT id, idcliente,mes,ano,nome,recebido,usuario,formadepagamento,valor,codrecibo,data,datarecibo FROM pagamentos WHERE idcliente = @Filtro and ano = @ano ORDER BY CAST(mes AS UNSIGNED ) ASC Limit 15;"


                ComandoSql.Parameters.AddWithValue("@Filtro", Filtro)
                ComandoSql.Parameters.AddWithValue("@ano", Ano)
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql
                DadosTabela = New DataTable
                AdaptadorTabela.Fill(DadosTabela)



                If ListDeClientes.Columns.Count > 0 Then
                    ListDeClientes.Columns.Clear()
                End If
                ListDeClientes.DataSource = DadosTabela

                Try
                    ListDeClientes.ClearSelection()
                Catch ex As Exception

                End Try

                If ListDeClientes.Columns.Count >= 6 Then
                    ListDeClientes.Columns(0).Visible = False
                    ListDeClientes.Columns(1).HeaderText = "id Client"
                    ListDeClientes.Columns(1).Width = 80
                    ListDeClientes.Columns(1).Visible = False
                    ListDeClientes.Columns(2).HeaderText = "Mês"
                    ListDeClientes.Columns(2).Width = 30
                    ListDeClientes.Columns(3).HeaderText = "Ano"
                    ListDeClientes.Columns(3).Width = 40
                    ListDeClientes.Columns(4).HeaderText = "Nome"
                    ListDeClientes.Columns(4).Width = 230
                    ListDeClientes.Columns(5).HeaderText = "Recebeu Pag."
                    ListDeClientes.Columns(6).Width = 110
                    ListDeClientes.Columns(6).HeaderText = "Usuario Cad."
                    ListDeClientes.Columns(5).Width = 110
                    ListDeClientes.Columns(7).HeaderText = "Forma de Pagamento"
                    ListDeClientes.Columns(7).Width = 100
                    ListDeClientes.Columns(8).HeaderText = "Valor"
                    ListDeClientes.Columns(8).Width = 65
                    ListDeClientes.Columns(9).HeaderText = "Cod Recibo"
                    ListDeClientes.Columns(9).Width = 75
                    ListDeClientes.Columns(9).Visible = False
                    ListDeClientes.Columns(10).HeaderText = "Data Recibo"
                    ListDeClientes.Columns(10).Width = 110
                    ListDeClientes.Columns(11).HeaderText = "Data Registro"
                    ListDeClientes.Columns(11).Width = 100
                    For i = 0 To ListDeClientes.Rows.Count - 1
                        Select Case ListDeClientes.Rows(i).Cells(2).Value
                            Case "01"
                                btJaneiro.Image = ImageList1.Images.Item("valido.png")

                            Case "02"
                                btFevereiro.Image = ImageList1.Images.Item("valido.png")

                            Case "03"
                                btMarco.Image = ImageList1.Images.Item("valido.png")

                            Case "04"
                                btAbril.Image = ImageList1.Images.Item("valido.png")

                            Case "05"
                                btMaio.Image = ImageList1.Images.Item("valido.png")

                            Case "06"
                                btJunho.Image = ImageList1.Images.Item("valido.png")

                            Case "07"
                                btJulho.Image = ImageList1.Images.Item("valido.png")

                            Case "08"
                                btAgosto.Image = ImageList1.Images.Item("valido.png")

                            Case "09"
                                btSetembro.Image = ImageList1.Images.Item("valido.png")

                            Case "10"
                                btoutubro.Image = ImageList1.Images.Item("valido.png")

                            Case "11"
                                btNovembro.Image = ImageList1.Images.Item("valido.png")

                            Case "12"
                                btDezembro.Image = ImageList1.Images.Item("valido.png")

                        End Select
                    Next
                End If

                ConecxaoSQL.Close()
                Label1.Text = Ano
            Catch ex As MySqlException
                MsgBox("Problema com seleção de dados")
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException
            MsgBox("Não foi salvo sem conexão com o servidor verifique o wifi/rede")
            ListDeClientes.Enabled = True
            Me.Hide()
            ListDeClientes.Columns.Clear()

        End Try

    End Sub
    Private Sub ResetMes()
        btJaneiro.Image = ImageList1.Images.Item("invalido.png")
        btFevereiro.Image = ImageList1.Images.Item("invalido.png")
        btMarco.Image = ImageList1.Images.Item("invalido.png")
        btAbril.Image = ImageList1.Images.Item("invalido.png")
        btMaio.Image = ImageList1.Images.Item("invalido.png")
        btJunho.Image = ImageList1.Images.Item("invalido.png")
        btJulho.Image = ImageList1.Images.Item("invalido.png")
        btAgosto.Image = ImageList1.Images.Item("invalido.png")
        btSetembro.Image = ImageList1.Images.Item("invalido.png")
        btoutubro.Image = ImageList1.Images.Item("invalido.png")
        btNovembro.Image = ImageList1.Images.Item("invalido.png")
        btDezembro.Image = ImageList1.Images.Item("invalido.png")


    End Sub
    Private Sub CorrigeIcones()


        Try
            If ListDeClientes.Columns.Count >= 5 Then
                For i = 0 To ListDeClientes.Rows.Count - 1
                    Select Case ListDeClientes.Rows(i).Cells(2).Value
                        Case "01"
                            btJaneiro.Image = ImageList1.Images.Item("valido.png")

                        Case "02"
                            btFevereiro.Image = ImageList1.Images.Item("valido.png")

                        Case "03"
                            btMarco.Image = ImageList1.Images.Item("valido.png")

                        Case "04"
                            btAbril.Image = ImageList1.Images.Item("valido.png")

                        Case "05"
                            btMaio.Image = ImageList1.Images.Item("valido.png")

                        Case "06"
                            btJunho.Image = ImageList1.Images.Item("valido.png")

                        Case "07"
                            btJulho.Image = ImageList1.Images.Item("valido.png")

                        Case "08"
                            btAgosto.Image = ImageList1.Images.Item("valido.png")

                        Case "09"
                            btSetembro.Image = ImageList1.Images.Item("valido.png")

                        Case "10"
                            btoutubro.Image = ImageList1.Images.Item("valido.png")

                        Case "11"
                            btNovembro.Image = ImageList1.Images.Item("valido.png")

                        Case "12"
                            btDezembro.Image = ImageList1.Images.Item("valido.png")

                    End Select
                Next

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btJaneiro_Click(sender As Object, e As EventArgs) Handles btJaneiro.Click
        SelecionaLinha("01")
    End Sub

    Private Sub btoutubro_Click(sender As Object, e As EventArgs) Handles btoutubro.Click
        SelecionaLinha(10)
    End Sub
    Private Sub SelecionaLinha(ByVal Mes As String)

        Try

            Dim rowindex As String
            Dim encontrou As Boolean = False

            For Each row As DataGridViewRow In ListDeClientes.Rows
                If row.Cells.Item(2).Value = Mes Then
                    rowindex = row.Index.ToString()
                    ListDeClientes.Focus()
                    ListDeClientes.CurrentCell = ListDeClientes.Rows(rowindex).Cells(2)
                    IconeSelecionado(Mes)
                    Exit Sub
                End If
            Next
            If encontrou = False Then
                Dim valordataselecionada As Date = CDate(Mes & "/" & DateTimePicker1.Value.Year.ToString)
                frmaddmes.DateTimePicker1.Value = valordataselecionada
                frmaddmes.NumericUpDown1.Value = 1
                frmaddmes.DateTimePicker2.Value = Now.ToString("dd/MM/yyyy HH:mm")
                frmaddmes.txtValor.Text = frmPrincipal.TxtMensalValor.Text
                frmaddmes.txtValorTotal.Text = frmPrincipal.TxtMensalValor.Text
                CorrigeIcones()
                ListDeClientes.ClearSelection()
                frmaddmes.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub IconeSelecionado(ByVal Mes As String)

        CorrigeIcones()
        Try
            If ListDeClientes.Columns.Count >= 5 Then
                Select Case Mes
                    Case "01"
                        btJaneiro.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "02"
                        btFevereiro.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "03"
                        btMarco.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "04"
                        btAbril.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "05"
                        btMaio.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "06"
                        btJunho.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "07"
                        btJulho.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "08"
                        btAgosto.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "09"
                        btSetembro.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "10"
                        btoutubro.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "11"
                        btNovembro.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "12"
                        btDezembro.Image = ImageList1.Images.Item("validoselecionado.png")

                End Select
            End If
            For Each LinhaAtual As DataGridViewRow In ListDeClientes.SelectedRows
                Dim SelecionadoJa As String = LinhaAtual.Cells(2).Value
                Select Case SelecionadoJa
                    Case "01"
                        btJaneiro.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "02"
                        btFevereiro.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "03"
                        btMarco.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "04"
                        btAbril.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "05"
                        btMaio.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "06"
                        btJunho.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "07"
                        btJulho.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "08"
                        btAgosto.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "09"
                        btSetembro.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "10"
                        btoutubro.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "11"
                        btNovembro.Image = ImageList1.Images.Item("validoselecionado.png")
                    Case "12"
                        btDezembro.Image = ImageList1.Images.Item("validoselecionado.png")

                End Select
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim MesAno As String = DateTimePicker1.Value.ToString("MM")
        Dim Ano As String = DateTimePicker1.Value.Year.ToString
        If ListDeClientes.Enabled = True Then
            ListDeClientes.Enabled = False
            Label1.Text = Ano
            ListDeClientes.ClearSelection()
            ClientesCarrega(frmPrincipal.ClienteID, Ano)
            DateTimePicker1.Enabled = True
            ListDeClientes.Enabled = True
        End If
    End Sub

    Private Sub btFevereiro_Click(sender As Object, e As EventArgs) Handles btFevereiro.Click
        SelecionaLinha("02")
    End Sub

    Private Sub btMarco_Click(sender As Object, e As EventArgs) Handles btMarco.Click
        SelecionaLinha("03")
    End Sub

    Private Sub btAbril_Click(sender As Object, e As EventArgs) Handles btAbril.Click
        SelecionaLinha("04")
    End Sub

    Private Sub btMaio_Click(sender As Object, e As EventArgs) Handles btMaio.Click
        SelecionaLinha("05")
    End Sub

    Private Sub btJunho_Click(sender As Object, e As EventArgs) Handles btJunho.Click
        SelecionaLinha("06")
    End Sub

    Private Sub btJulho_Click(sender As Object, e As EventArgs) Handles btJulho.Click
        SelecionaLinha("07")
    End Sub

    Private Sub btAgosto_Click(sender As Object, e As EventArgs) Handles btAgosto.Click
        SelecionaLinha("08")
    End Sub

    Private Sub btSetembro_Click(sender As Object, e As EventArgs) Handles btSetembro.Click
        SelecionaLinha("09")
    End Sub

    Private Sub btNovembro_Click(sender As Object, e As EventArgs) Handles btNovembro.Click
        SelecionaLinha("11")
    End Sub

    Private Sub btDezembro_Click(sender As Object, e As EventArgs) Handles btDezembro.Click
        SelecionaLinha("12")
    End Sub



    Private Sub ListDeClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles ListDeClientes.KeyDown
        If e.KeyCode = 13 Then
            If ListDeClientes.SelectedRows.Count = 1 Then

                Me.TopMost = False
                FrmMesEdit.DateTimePicker1.Value = CDate(ListDeClientes.SelectedRows(0).Cells(2).Value & "/" & ListDeClientes.SelectedRows(0).Cells(3).Value)
                FrmMesEdit.txtDataRecibo.Text = ListDeClientes.SelectedRows(0).Cells(10).Value.ToString
                Try
                    FrmMesEdit.DateTimePicker1.Value = CDate(ListDeClientes.SelectedRows(0).Cells(11).Value.ToString)
                Catch ex As Exception

                End Try

                FrmMesEdit.txtRecebeu.Text = ListDeClientes.SelectedRows(0).Cells(5).Value
                FrmMesEdit.txtPagamento.Text = ListDeClientes.SelectedRows(0).Cells(7).Value
                FrmMesEdit.txtValor.Text = ListDeClientes.SelectedRows(0).Cells(8).Value
                FrmMesEdit.ShowDialog()
                Me.TopMost = True
            End If
        End If
        If e.KeyCode = 46 And ListDeClientes.SelectedRows.Count >= 1 Then

            Dim ConecxaoSQL As New MySqlConnection
            Dim ComandoSql As New MySqlCommand
            Dim AdaptadorTabela As New MySqlDataAdapter
            Dim DadosTabela As New DataTable


            ConecxaoSQL.ConnectionString = StringdeConexao
            Dim MesesExcluir As String = vbNewLine
            For Each LinhaAtual As DataGridViewRow In ListDeClientes.SelectedRows
                Dim DataMes As Date = "01/" & LinhaAtual.Cells(2).Value & "/" & LinhaAtual.Cells(3).Value
                MesesExcluir &= DataMes.Date.ToString("MMMM/yyyy") & vbNewLine
            Next
            If MsgBox("Excluir pagamento de: " & MesesExcluir, MsgBoxStyle.YesNo, "Excluir Registro") = MsgBoxResult.Yes Then
                Try
                    ConecxaoSQL.Open()

                    Try
                        ComandoSql.Connection = ConecxaoSQL
                        For Each LinhaAtual As DataGridViewRow In ListDeClientes.SelectedRows
                            ' MsgBox(datarow.Cells(2).Value)

                            Dim idDeleta As Integer = CInt(LinhaAtual.Cells(0).Value)
                            Dim codigRecibo As Integer = CInt(LinhaAtual.Cells(9).Value)
                            Dim ValorM As String = LinhaAtual.Cells(8).Value


                            'Deletar Cadastro
                            ComandoSql.Parameters.Clear()
                            ComandoSql.Parameters.AddWithValue("@id", idDeleta)
                            ComandoSql.CommandText = "DELETE FROM pagamentos where id=@id;"
                            ComandoSql.ExecuteNonQuery()
                            'Pega Valor total
                            ComandoSql.Parameters.AddWithValue("@cod", codigRecibo)
                            ComandoSql.CommandText = "Select valortotal FROM recibos where id=@cod;"
                            ComandoSql.ExecuteNonQuery()
                            'Atualiza
                            DadosTabela = New DataTable
                            AdaptadorTabela.SelectCommand = ComandoSql
                            AdaptadorTabela.Fill(DadosTabela)



                            If DadosTabela.Rows.Count = 1 Then
                                Dim valortotal As Double
                                Try
                                    valortotal = DadosTabela.Rows(0).Item(0)
                                Catch ex As Exception
                                    valortotal = 0
                                End Try

                                valortotal = Math.Abs(valortotal)
                                Dim novoValor As String = FormatCurrency(CDbl(valortotal) - CDbl(ValorM), 2, TriState.True, TriState.True,
                                    TriState.True).Replace("R$", "").Trim

                                ComandoSql.Parameters.AddWithValue("@novovalor", novoValor)
                                ComandoSql.CommandText = "UPDATE recibos SET valortotal = @novovalor WHERE id = @cod;"
                                ComandoSql.ExecuteNonQuery()
                            End If


                        Next
                        ConecxaoSQL.Close()
                        Try
                            Me.ListDeClientes.ClearSelection()
                        Catch ex As Exception

                        End Try
                        ClientesCarrega(frmPrincipal.ClienteID, DateTimePicker1.Value.Year.ToString)

                    Catch ex As MySqlException

                        MsgBox(ex.Message, MsgBoxStyle.Information, "Erro ao salvar")
                        ConecxaoSQL.Close()
                    End Try
                Catch ex As MySqlException
                    MsgBox("Não e possivel conectar com servidor", MsgBoxStyle.Information, "Erro ao salvar")
                    ConecxaoSQL.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ListDeClientes_SelectionChanged(sender As Object, e As EventArgs) Handles ListDeClientes.SelectionChanged
        Try

            IconeSelecionado(ListDeClientes.SelectedRows(0).Cells(2).Value)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListDeClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListDeClientes.CellContentClick

    End Sub
End Class