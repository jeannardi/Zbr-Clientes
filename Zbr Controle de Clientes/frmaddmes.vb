Imports System.Globalization
Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class frmaddmes
    Public AlteradoMes As Boolean = True
    Public AlteradoTotal As Boolean = False
    Private Sub frmaddmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtValor.Text <> "" And txtRecebeu.Text <> "" And txtValorTotal.Text <> "" And txtPagamento.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
    Private Sub Pagar(ByVal Numero As Integer)

        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim DadosTabela As New DataTable
        Dim Meses As String = "Relatorio de pagamento" & vbNewLine
        Application.DoEvents()


        Dim DataPagamento As Date = DateTimePicker1.Value

        Dim datas As New List(Of Date)
        'If MsgBox("Está tudo pronto. basta clicar em SIM para confirmar o pagamento no sistema.", MsgBoxStyle.YesNo, "Efetuar Pagamento") = MsgBoxResult.Yes Then
        Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")
        ConecxaoSQL.ConnectionString = StringdeConexao
        Try

            ConecxaoSQL.Open()
            Try


                ComandoSql.Connection = ConecxaoSQL


                ComandoSql.Parameters.AddWithValue("@Filtro", frmPrincipal.ClienteID)
                ComandoSql.Parameters.AddWithValue("@mes", DataPagamento.Month.ToString("D2"))
                ComandoSql.Parameters.AddWithValue("@ano", DataPagamento.Year.ToString)
                ComandoSql.Parameters.AddWithValue("@Recebeu", txtRecebeu.Text)
                ComandoSql.Parameters.AddWithValue("@Valor", txtValor.Text)
                ComandoSql.Parameters.AddWithValue("@nome", frmPrincipal.ClientNome)
                ComandoSql.Parameters.AddWithValue("@pagamento", txtPagamento.Text)
                ComandoSql.Parameters.AddWithValue("@total", txtValorTotal.Text)
                ComandoSql.Parameters.AddWithValue("@datarecibo", DateTimePicker2.Value) '<----- Agora e data de registro ficou com nome errado
                ComandoSql.Parameters.AddWithValue("@obs", TxtOBS.Text)

                Try
                    ComandoSql.Parameters.AddWithValue("@data", CDate(txtDataRecibo.Text))
                Catch ex As Exception
                    ComandoSql.Parameters.AddWithValue("@data", Nothing)
                End Try

                'Criando Recibo deste pagamento
                ComandoSql.CommandText = "INSERT INTO recibos (tipo,clientnome,clientid,valortotal,data,obs)
VALUES ('Mensalidade', @nome, @Filtro,@total,@data,@obs); SELECT LAST_INSERT_ID();"
                ComandoSql.ExecuteNonQuery()

                'add parametro do id do recibo
                ComandoSql.Parameters.AddWithValue("@codrecibo", ComandoSql.LastInsertedId)
                Dim SQLInsert As String = ("INSERT INTO pagamentos (idcliente,nome, recebido,usuario, mes,ano,valor,formadepagamento,codrecibo,data,datarecibo)
VALUES ")
                Dim primeiro As Boolean = True
                For i = 1 To Numero
                    ComandoSql.CommandText = "SELECT id, idcliente,mes,ano,nome,recebido,valor,datarecibo FROM pagamentos WHERE idcliente = @Filtro AND mes = @mes AND ano = @ano Limit 1;"
                    ComandoSql.ExecuteNonQuery()
                    AdaptadorTabela.SelectCommand = ComandoSql
                    DadosTabela = New DataTable
                    AdaptadorTabela.Fill(DadosTabela)

                    If DadosTabela.Rows().Count = 1 Then
                        Meses &= DataPagamento.ToString("MM/yyyy") & " <- Já estava pago" & vbNewLine
                        i = i - 1

                    Else
                        Meses &= DataPagamento.ToString("MM/yyyy") & " Pago com sucesso" & vbNewLine
                        'Paga o mês

                        If primeiro = True Then
                            primeiro = False
                            SQLInsert &= "(@Filtro, @nome,'" & txtRecebeu.Text & "', '" & UsuarioLogado & "', '" & DataPagamento.Month.ToString("D2") & "', '" & DataPagamento.Year.ToString & "', @valor, @pagamento,@codrecibo,@data,@datarecibo)"
                        Else
                            SQLInsert &= ", (@Filtro, @nome,'" & txtRecebeu.Text & "', '" & UsuarioLogado & "', '" & DataPagamento.Month.ToString("D2") & "', '" & DataPagamento.Year.ToString & "', @valor, @pagamento,@codrecibo,@data,@datarecibo)"
                        End If
                        datas.Add(DataPagamento.Date)
                    End If
                    DataPagamento = DataPagamento.AddMonths(1)
                    ComandoSql.Parameters.Item(1).Value = DataPagamento.Month.ToString("D2")
                    ComandoSql.Parameters.Item(2).Value = DataPagamento.Year.ToString
                    DadosTabela.Clear()

                Next

                ComandoSql.CommandText = SQLInsert
                ComandoSql.ExecuteNonQuery()
                '---------Atualiza MES
                Dim MesAno As String = frmMensal.DateTimePicker1.Value.ToString("MM")
                Dim Ano As String = frmMensal.DateTimePicker1.Value.Year.ToString
                frmMensal.DateTimePicker1.Enabled = False
                frmMensal.Label1.Text = Ano
                frmMensal.ClientesCarrega(frmPrincipal.ClienteID, Ano)
                frmMensal.DateTimePicker1.Enabled = True
                '---------Atualiza MES
                MsgBox(Meses)
                ConecxaoSQL.Close()
                Me.Close()
                If MsgBox("Imprimir/Visualizar Recibo de pagamento agora?", vbYesNo, "Imprimir Recibo?") = vbYes Then
                    GerarReciboMes(frmPrincipal.ClientNome, txtValorTotal.Text, datas, Now.Date, TxtOBS.Text)
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException
            MsgBox("Não foi salvo sem conexão com o servidor verifique o wifi/rede")

        End Try
        ' End If
        Button1.Enabled = True
        Try
            frmMensal.ListDeClientes.ClearSelection()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tudook As Boolean = False
        Try
            Dim valor = CDbl(txtValor.Text)
            Dim valorT = CDbl(txtValorTotal.Text)
            Button1.Enabled = False
            Pagar(NumericUpDown1.Value)
        Catch ex As Exception
            MsgBox("Existe um erro no valor digite novamente por favor.")
            txtValor.Focus()
        End Try

    End Sub

    Private Sub txtValorTotal_LostFocus(sender As Object, e As EventArgs) Handles txtValorTotal.LostFocus
        Dim valor As String = "0,00"
        If txtValorTotal.Text = String.Empty Then
            valor = 0
        End If
        Try
            txtValorTotal.Text = FormatCurrency(txtValorTotal.Text, 2, TriState.True, TriState.True,
                                TriState.True).Replace("R$", "").Trim

            txtValor.Text = FormatCurrency(txtValorTotal.Text / NumericUpDown1.Value, 2, TriState.True, TriState.True,
                                TriState.True).Replace("R$", "").Trim
        Catch ex As Exception
            txtValorTotal.Text = "0,0"
        End Try

        If txtValor.Text <> "" And txtRecebeu.Text <> "" And txtValorTotal.Text <> "" And txtPagamento.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
        AlteradoTotal = True
        AlteradoMes = False
    End Sub


    Private Sub txtValor_LostFocus(sender As Object, e As EventArgs) Handles txtValor.LostFocus
        Dim valor As String = "0,00"
        If txtValor.Text = String.Empty Then
            valor = 0
        End If
        Try
            txtValorTotal.Text = FormatCurrency(txtValor.Text * NumericUpDown1.Value, 2, TriState.True, TriState.True,
                                TriState.True).Replace("R$", "").Trim
            txtValor.Text = FormatCurrency(txtValor.Text, 2, TriState.True, TriState.True,
                                TriState.True).Replace("R$", "").Trim
        Catch ex As Exception
            txtValor.Text = "0,0"
        End Try

        If txtValor.Text <> "" And txtRecebeu.Text <> "" And txtValorTotal.Text <> "" And txtPagamento.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
        AlteradoMes = True
        AlteradoTotal = False
    End Sub

    Private Sub txtValorTotal_KeyUp(sender As Object, e As KeyEventArgs) Handles txtValorTotal.KeyUp
        Dim valor As String = "0,00"
        If txtValorTotal.Text = String.Empty Then
            txtValorTotal.Text = "0,00"
        End If
        Try
            txtValor.Text = FormatCurrency(txtValorTotal.Text / NumericUpDown1.Value, 2, TriState.True, TriState.True,
                                TriState.True).Replace("R$", "").Trim

        Catch ex As Exception

        End Try

        If txtValor.Text <> "" And txtRecebeu.Text <> "" And txtValorTotal.Text <> "" And txtPagamento.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
        AlteradoTotal = True
        AlteradoMes = False
    End Sub

    Private Sub txtValor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtValor.KeyUp
        Dim valor As String = "0,00"
        If txtValor.Text = String.Empty Then
            valor = 0
        End If
        Try
            txtValorTotal.Text = FormatCurrency(txtValor.Text * NumericUpDown1.Value, 2, TriState.True, TriState.True,
                                TriState.True).Replace("R$", "").Trim

        Catch ex As Exception

        End Try

        If txtValor.Text <> "" And txtRecebeu.Text <> "" And txtValorTotal.Text <> "" And txtPagamento.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
        AlteradoMes = True
        AlteradoTotal = False
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")
        If AlteradoTotal = True And AlteradoMes = False Then
            Dim valor As String = "0,00"
            If txtValor.Text = String.Empty Then
                valor = 0
            End If
            Try
                txtValor.Text = FormatCurrency(txtValorTotal.Text / NumericUpDown1.Value, 2, TriState.True, TriState.True,
                                    TriState.True).Replace("R$", "").Trim
            Catch ex As Exception

            End Try
            Label3.Text = "Valor mês (" & valor & ")"
            If txtValor.Text <> "" And txtRecebeu.Text <> "" Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        End If
        If AlteradoTotal = False And AlteradoMes = True Then
            Dim valor As String = "0,00"
            If txtValor.Text = String.Empty Then
                valor = 0
            End If
            Try
                Dim v As Double = FormatCurrency(txtValor.Text, 2, TriState.True, TriState.True,
                                    TriState.True).Replace("R$", "").Trim
                Dim resultado As Double = v * NumericUpDown1.Value
                resultado = Math.Abs(resultado)
                txtValorTotal.Text = FormatCurrency(resultado, 2, TriState.True, TriState.True,
                                    TriState.True).Replace("R$", "").Trim

            Catch ex As Exception

            End Try

            If txtValor.Text <> "" And txtRecebeu.Text <> "" And txtValorTotal.Text <> "" And txtPagamento.Text <> "" Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtValorTotal_TextChanged(sender As Object, e As EventArgs) Handles txtValorTotal.TextChanged

    End Sub

    Private Sub txtRecebeu_TextChanged(sender As Object, e As EventArgs) Handles txtRecebeu.TextChanged
        If txtValor.Text <> "" And txtRecebeu.Text <> "" And txtValorTotal.Text <> "" And txtPagamento.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub txtPagamento_TextChanged(sender As Object, e As EventArgs) Handles txtPagamento.TextChanged
        If txtValor.Text <> "" And txtRecebeu.Text <> "" And txtValorTotal.Text <> "" And txtPagamento.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        txtDataRecibo.Text = Now.Date
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        txtValor.Text = Replace(txtValor.Text, "-", "")
    End Sub

    Private Sub txtValor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValor.KeyDown

    End Sub
End Class