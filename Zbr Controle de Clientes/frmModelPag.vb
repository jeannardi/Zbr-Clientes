Imports MySql.Data.MySqlClient

Public Class frmModelPag
    Dim DadosTabela As New DataTable
    Private Sub ClientesCarrega(ByVal Filtro As String)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter



        Application.DoEvents()



        ConecxaoSQL.ConnectionString = StringdeConexao
        Try
            ConecxaoSQL.Open()
            Try


                ComandoSql.Connection = ConecxaoSQL


                ComandoSql.CommandText = "SELECT id,nome FROM clientes WHERE pagalarme = @Filtro ORDER BY CAST(nome AS UNSIGNED ) ASC"

                ComandoSql.Parameters.AddWithValue("@Filtro", Filtro)
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql

                DadosTabela.Clear()
                AdaptadorTabela.Fill(DadosTabela)

                If ListDeClientes.Columns.Count > 0 Then
                    ListDeClientes.Columns.Clear()
                End If
                ListDeClientes.DataSource = DadosTabela


                If ListDeClientes.Columns.Count >= 1 Then
                    ListDeClientes.Columns(0).Visible = False
                    ListDeClientes.Columns(1).HeaderText = "Nome"
                    ListDeClientes.Columns(1).Width = 600
                End If

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
    Private Sub btcarrega_Click(sender As Object, e As EventArgs) Handles btcarrega.Click
        ListDeClientes.DataSource = Nothing
        ClientesCarrega(ComboBox1.Text)
        TiposCliente()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListDeClientes.Rows.Count >= 0 Then
            GerarClientesPag(DadosTabela, "Mensal")
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListDeClientes.DataSource = Nothing
        ClientesCarrega(ComboBox1.Text)
    End Sub

    Private Sub frmModelPag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 2
        TiposCliente()
    End Sub
    Private Sub TiposCliente()
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim Tabelinha As New DataTable


        Application.DoEvents()



        ConecxaoSQL.ConnectionString = StringdeConexao
        Try
            ConecxaoSQL.Open()
            Try


                ComandoSql.Connection = ConecxaoSQL
                AdaptadorTabela.SelectCommand = ComandoSql

                'Clientes MES
                ComandoSql.Parameters.AddWithValue("@Filtro", "Mensal")
                ComandoSql.CommandText = "SELECT id,nome FROM clientes WHERE pagalarme = @Filtro;"
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.Fill(Tabelinha)
                Dim ContaMes As Integer = 0
                ContaMes = Tabelinha.Rows.Count

                'Clientes Anual
                Tabelinha.Clear()
                ComandoSql.Parameters.Item(0).Value = "Anual"
                ComandoSql.CommandText = "SELECT id,nome FROM clientes WHERE pagalarme = @Filtro;"
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.Fill(Tabelinha)
                Dim ContaAnual As Integer = 0
                ContaAnual = Tabelinha.Rows.Count

                'Clientes Promoção
                Tabelinha.Clear()
                ComandoSql.Parameters.Item(0).Value = "Promoção"
                ComandoSql.CommandText = "SELECT id,nome FROM clientes WHERE pagalarme = @Filtro;"
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.Fill(Tabelinha)
                Dim ContaPromoção As Integer = 0
                ContaPromoção = Tabelinha.Rows.Count



                Label1.Text = ("Mensal (" & ContaMes & ")         Anual (0" & ContaAnual & ")         Promoção (" & ContaPromoção & ")")
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
End Class