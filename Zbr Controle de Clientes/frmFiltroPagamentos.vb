Imports System.Text
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmFiltroPagamentos
    Dim TabelaPendentes As New DataTable
    Private Sub btFiltrar_Click(sender As Object, e As EventArgs) Handles btFiltrar.Click

        TabelaPendentes.Clear()
        TreeView1.Nodes.Clear()
        'adiciona na table
        Dim diff As Integer = DateDiff(DateInterval.Month, DateTimePicker1.Value, DateTimePicker2.Value)
        Dim data As Date = DateTimePicker1.Value
        Dim dateInicio As Date = DateTimePicker1.Value
        For i = 1 To diff + 1

            TabelaPendentes.Clear()
            Dim MesAno As String = data.Date.ToString("MM")
            Dim Ano As String = data.Date.Year.ToString
            PendentesPagamento(MesAno, Ano, dateInicio)
            data = data.Date.AddMonths(1)
            Application.DoEvents()
        Next

    End Sub
    Private Sub PendentesPagamento(ByVal mes As String, ByVal ano As String, ByVal DataAtual As Date)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter



        Application.DoEvents()

        ConecxaoSQL.ConnectionString = StringdeConexao
        Try
            ConecxaoSQL.Open()
            Try

                ' BackgroundWorker1.ReportProgress(20)
                ComandoSql.Connection = ConecxaoSQL

                ComandoSql.Parameters.AddWithValue("@mes", mes)
                ComandoSql.Parameters.AddWithValue("@ano", ano)
                ComandoSql.Parameters.AddWithValue("@data", DataAtual)
                'ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM pagamentos WHERE nome LIKE '%' @Filtro '%' ORDER BY nome ASC"

                'Mês Vigente
                If CheckBox1.Checked = True Then
                    ComandoSql.CommandText = "SELECT id, alarmecodigo,nome FROM clientes
                          WHERE date(@data) >= date(clientes.datacontrato) AND NOT EXISTS (SELECT id FROM pagamentos WHERE mes = @mes AND ano= @ano AND clientes.id = pagamentos.idcliente);"

                Else
                    ComandoSql.CommandText = "SELECT id, alarmecodigo,nome FROM clientes
                          WHERE NOT EXISTS (SELECT id FROM pagamentos WHERE mes = @mes AND ano= @ano AND clientes.id = pagamentos.idcliente);"
                End If




                ComandoSql.ExecuteNonQuery()
                ' BackgroundWorker1.ReportProgress(80) 'Busca Conlcuida
                AdaptadorTabela.SelectCommand = ComandoSql
                'TabelaPendentes.Clear()
                'TabelaPendentes = New DataTable
                AdaptadorTabela.Fill(TabelaPendentes)


                ConecxaoSQL.Close()

                'joga pro listview
                If TabelaPendentes.Rows.Count > 0 Then
                    For Each Linha As DataRow In TabelaPendentes.Rows
                        'MsgBox(Linha(0).ToString)
                        Dim MyNode() As TreeNode
                        MyNode = TreeView1.Nodes.Find(Linha(0).ToString, False)
                        If MyNode.Length = 1 Then
                            'adiciona mes em cliente que ja existe
                            Dim MesNaoPago As String = mes & "/" & ano
                            MyNode(0).Nodes.Add(Linha(0).ToString & MesNaoPago, MesNaoPago, 7)
                            Select Case MyNode(0).Nodes.Count
                                Case 1
                                    MyNode(0).ImageIndex = 0
                                Case 2
                                    MyNode(0).ImageIndex = 1
                                Case 3
                                    MyNode(0).ImageIndex = 2
                                Case 4
                                    MyNode(0).ImageIndex = 3
                                Case 5
                                    MyNode(0).ImageIndex = 4
                                Case 6
                                    MyNode(0).ImageIndex = 5
                                Case 6 To 100
                                    MyNode(0).ImageIndex = 6
                            End Select


                        ElseIf (MyNode.Length = 0) Then
                            'Cria novo cliente na tabela
                            TreeView1.Nodes.Add(Linha(0).ToString, Linha(2).ToString, 0)
                            'Adiciona mes não pago
                            Dim MesNaoPago As String = mes & "/" & ano
                            TreeView1.Nodes(Linha(0).ToString).Nodes.Add(Linha(0).ToString & MesNaoPago, MesNaoPago, 7)
                        End If
                    Next
                End If
                'BackgroundWorker1.ReportProgress(100)
            Catch ex As MySqlException
                MsgBox("Problema com seleção de dados")
                'BackgroundWorker1.ReportProgress(100)
                ' ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException
            MsgBox("Ocorreu um erro de conexão verfique se seu computador ou o servidor estao conectados a um rede!", vbInformation, "Sem conexão.")
            'BackgroundWorker1.ReportProgress(100)

        End Try

    End Sub
    Function SoTexto(ByVal S As String) As String
        Dim nova As String = RegularExpressions.Regex.Replace(S, "\d", "")
        nova = nova.Replace(" - (", "")
        nova = nova.Replace(")", "")
        Return RegularExpressions.Regex.Replace(nova, "\d", "")
    End Function
    Function SoNumeros(ByVal S As String) As String
        Return RegularExpressions.Regex.Replace(S, "[^\d]", "")
    End Function

    Private Sub btProcurarCliente_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim encontrou = False
        TreeView1.SelectedNode = Nothing
        Application.DoEvents()
        For Each n As TreeNode In Me.TreeView1.Nodes

            If encontrou = False Then
                If n.Text.ToUpper.Contains(TextBox1.Text.ToUpper) Then
                    TreeView1.SelectedNode = n
                    TreeView1.Focus()
                    Button1.Enabled = True
                    encontrou = True
                    Exit For
                End If
            End If

        Next
        If encontrou = False Then
            TextBox1.BackColor = Color.Red
            Application.DoEvents()
            System.Threading.Thread.Sleep(1000) : Application.DoEvents()
            TextBox1.BackColor = Color.White
        End If

        Button1.Enabled = True

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            Button1.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub
End Class