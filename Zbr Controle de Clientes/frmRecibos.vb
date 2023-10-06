Imports MySql.Data.MySqlClient

Public Class frmRecibos

    Private Sub frmRecibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientesCarrega(frmPrincipal.ClienteID)
    End Sub
    Public Sub ClientesCarrega(ByVal Filtro As String)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim DadosTabela As New DataTable


        Application.DoEvents()
        ' ResetMes()


        ConecxaoSQL.ConnectionString = StringdeConexao
        Try

            ConecxaoSQL.Open()
            Try


                ComandoSql.Connection = ConecxaoSQL
                'Limpeza
                ComandoSql.Parameters.AddWithValue("@Filtro", Filtro)
                ComandoSql.CommandText = "Delete from recibos where clientid = @Filtro and tipo = 'Mensalidade' and id not in (select codrecibo from pagamentos);"
                ComandoSql.ExecuteNonQuery()
                ComandoSql.CommandText = "SELECT id, tipo,data,valortotal,obs FROM recibos WHERE clientid = @Filtro ORDER BY CAST(data AS UNSIGNED ) DESC"



                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql
                DadosTabela = New DataTable
                AdaptadorTabela.Fill(DadosTabela)

                If ListDeClientes.Columns.Count > 0 Then
                    ListDeClientes.Columns.Clear()
                End If
                ListDeClientes.DataSource = DadosTabela


                If ListDeClientes.Columns.Count >= 2 Then
                    ListDeClientes.Columns(0).Visible = False
                    ListDeClientes.Columns(1).HeaderText = "Tipo"
                    ListDeClientes.Columns(1).Width = 80
                    ListDeClientes.Columns(1).Visible = True
                    ListDeClientes.Columns(2).HeaderText = "Gerado em:"
                    ListDeClientes.Columns(2).Width = 120
                    ListDeClientes.Columns(2).DefaultCellStyle.Format = "dd/MM/yyyy"
                    ListDeClientes.Columns(3).HeaderText = "Total"
                    ListDeClientes.Columns(3).Width = 120
                    ListDeClientes.Columns(4).HeaderText = "Obs"
                    ListDeClientes.Columns(4).Width = 310
                    ' ListDeClientes.Columns(4).Visible = False

                End If

                ConecxaoSQL.Close()
            Catch ex As MySqlException
                MsgBox("Problema com seleção de dados")
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
            If ListDeClientes.SelectedRows.Count >= 1 Then
                BtImprimir.Enabled = True
            Else
                BtImprimir.Enabled = False
            End If
        Catch ex As MySqlException


        End Try

    End Sub
    Public Sub GeraBoletoM(ByVal Filtro As String, ByVal Valor As String, ByVal DataPagamento As Date, ByVal Obs As String)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim DadosTabela As New DataTable


        Application.DoEvents()
        ' ResetMes()


        ConecxaoSQL.ConnectionString = StringdeConexao
        Try

            ConecxaoSQL.Open()
            Try


                ComandoSql.Connection = ConecxaoSQL


                ComandoSql.CommandText = "SELECT id, mes,ano,data FROM pagamentos WHERE codrecibo = @Filtro ORDER BY CAST(ano AS UNSIGNED ) ASC, CAST(mes AS UNSIGNED ) ASC;"


                ComandoSql.Parameters.AddWithValue("@Filtro", Filtro)
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql
                DadosTabela = New DataTable
                AdaptadorTabela.Fill(DadosTabela)

                Dim datas As New List(Of Date)

                If DadosTabela.Columns.Count > 0 Then
                    For Each Linhas As DataRow In DadosTabela.Rows
                        datas.Add(Linhas(1) & "/" & Linhas(2))

                    Next
                End If
                GerarReciboMes(frmPrincipal.txtNome.Text, Valor, datas, DataPagamento, Obs)

                ConecxaoSQL.Close()
            Catch ex As MySqlException
                MsgBox("Problema com seleção de dados")
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException


        End Try

    End Sub

    Private Sub ListDeClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListDeClientes.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtNovoRecibo.Click
        frmNovoRecibo.ComboBox1.Text = "Pagamento"
        frmNovoRecibo.btPDF.Text = "Salvar / Imprimir"
        frmNovoRecibo.Formulario = New frmRecibos
        frmNovoRecibo.Show()
        Me.Close()
    End Sub

    Private Sub ListDeClientes_ColumnHeadersHeightChanged(sender As Object, e As EventArgs) Handles ListDeClientes.ColumnHeadersHeightChanged

    End Sub

    Private Sub ListDeClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListDeClientes.CellDoubleClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtImprimir.Click
        If ListDeClientes.SelectedRows.Count = 1 Then
            If (ListDeClientes.SelectedRows(0).Cells(1).Value) = "Mensalidade" Then
                Imprimir("Mensalidade")
            Else
                Imprimir("Outro")
            End If
        End If
    End Sub
    Private Sub Imprimir(ByVal TIPO As String)
        Try


            If TIPO = "Mensalidade" Then
                Dim obs As String = ""
                Try
                    obs = CStr((ListDeClientes.SelectedRows(0).Cells(4).Value))
                Catch ex As Exception
                    obs = ""
                End Try

                Me.TopMost = False
                Dim PegaData As Date
                Try
                    PegaData = CDate(ListDeClientes.SelectedRows(0).Cells(2).Value)
                Catch ex As Exception
                    MsgBox("Este recebio não tinha data informada, será colocado a data de hoje mas você pode alterar antes de gerar o recibo em PDF.", MsgBoxStyle.Information, "Sem data")
                    PegaData = Now.Date.ToString("dd/MM/yyyy")
                End Try

                Dim Referente As String = InputBox("Data que aparece no recibo", "Definir data", PegaData.Date.ToString("dd/MM/yyyy"))
                If Referente.Length > 0 Then
                    GeraBoletoM((ListDeClientes.SelectedRows(0).Cells(0).Value), (ListDeClientes.SelectedRows(0).Cells(3).Value), Referente, obs)
                End If
                Me.TopMost = True
            Else
                Me.TopMost = False
                Dim Referente As String = InputBox("Este recibo e referente a: Ex Pagamento Alarme ", "Definir referencia", ListDeClientes.SelectedRows(0).Cells(1).Value)
                If Referente.Length > 0 Then
                    GerarReciboNovo((ListDeClientes.SelectedRows(0).Cells(0).Value), (ListDeClientes.SelectedRows(0).Cells(3).Value), Referente, CDate(ListDeClientes.SelectedRows(0).Cells(2).Value))
                End If
                Me.TopMost = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListDeClientes_SelectionChanged(sender As Object, e As EventArgs) Handles ListDeClientes.SelectionChanged
        If ListDeClientes.SelectedRows.Count >= 1 Then
            BtImprimir.Enabled = True
        Else
            BtImprimir.Enabled = False
        End If
    End Sub

    Private Sub ListDeClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles ListDeClientes.KeyDown
        If e.KeyCode = 13 Then
            Dim obs As String = ""
            Try
                obs = CStr((ListDeClientes.SelectedRows(0).Cells(4).Value))
            Catch ex As Exception
                obs = ""
            End Try
            frmEditarRecibo.TxtOBS.Text = obs
            frmEditarRecibo.ShowDialog()

        End If
    End Sub
End Class