Imports MySql.Data.MySqlClient

Public Class FrmEquipamentos
    Public EquipamendoID As Integer
    Private Sub FrmEquipamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                ComandoSql.CommandText = "SELECT id,clienteid, material,data,valor,pago,reciboid,datapagamento FROM equipamentos WHERE clienteid = @Filtro ORDER BY CAST(data AS UNSIGNED ) DESC"
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
                    ListDeClientes.Columns(1).Visible = False
                    ListDeClientes.Columns(2).HeaderText = "Material"
                    ListDeClientes.Columns(2).Width = 250

                    ListDeClientes.Columns(3).HeaderText = "Data da troca"
                    ListDeClientes.Columns(3).Width = 120
                    ListDeClientes.Columns(4).HeaderText = "Valor"
                    ListDeClientes.Columns(4).Width = 120
                    ListDeClientes.Columns(5).HeaderText = "Pago"
                    ListDeClientes.Columns(5).Width = 120
                    ListDeClientes.Columns(6).HeaderText = "Recibo ID"
                    ListDeClientes.Columns(6).Visible = False
                    ListDeClientes.Columns(7).HeaderText = "Data Pagamento"


                End If
                ComandoSql.CommandText = "SELECT id FROM equipamentos WHERE clienteid = @Filtro AND pago = 'Não' Limit 1000;"
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql
                DadosTabela = New DataTable
                AdaptadorTabela.Fill(DadosTabela)
                If DadosTabela.Rows.Count > 0 Then
                    frmPrincipal.btEquipamento.Text = "Equipamentos (" & DadosTabela.Rows.Count & ")"
                    frmPrincipal.btEquipamento.ForeColor = Color.Red
                Else
                    frmPrincipal.btEquipamento.ForeColor = Color.Black
                    frmPrincipal.btEquipamento.Text = "Equipamentos"
                End If
                ConecxaoSQL.Close()

                If ListDeClientes.SelectedRows.Count >= 1 Then
                    BtReciboNovo.Enabled = True
                Else
                    BtReciboNovo.Enabled = False
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

    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        frmEquipamentosadd.TxtData.Text = Now.Date.ToString("dd/MM/yyyy")
        frmEquipamentosadd.TxtMaterial.Text = ""
        frmEquipamentosadd.TxtValor.Text = "0,0"
        frmEquipamentosadd.CmbPago.Text = "Não"
        frmEquipamentosadd.BtSalvar.Text = "Salvar"
        frmEquipamentosadd.TxtData.Text = Now.Date.ToString("dd/MM/yyyy")
        frmEquipamentosadd.Incluir = True
        frmEquipamentosadd.txtDataRecibo.Text = ""
        frmEquipamentosadd.ShowDialog()
        frmEquipamentosadd.Incluir = True
    End Sub

    Private Sub ListDeClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListDeClientes.CellContentClick

    End Sub

    Private Sub ListDeClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles ListDeClientes.KeyDown
        If e.KeyCode = 13 Then
            If ListDeClientes.SelectedRows.Count = 1 Then
                frmEquipamentosadd.Incluir = False
                frmEquipamentosadd.BtSalvar.Text = "Alterar"
                frmEquipamentosadd.TxtMaterial.Text = ListDeClientes.SelectedRows(0).Cells(2).Value
                frmEquipamentosadd.TxtData.Text = ListDeClientes.SelectedRows(0).Cells(3).Value
                frmEquipamentosadd.TxtValor.Text = ListDeClientes.SelectedRows(0).Cells(4).Value
                frmEquipamentosadd.CmbPago.Text = ListDeClientes.SelectedRows(0).Cells(5).Value
                frmEquipamentosadd.txtDataRecibo.Text = ListDeClientes.SelectedRows(0).Cells(7).Value.ToString
                frmEquipamentosadd.ShowDialog()
                frmEquipamentosadd.Incluir = False
            End If
        End If
        If e.KeyCode = 46 Then

            Dim ConecxaoSQL As New MySqlConnection
            Dim ComandoSql As New MySqlCommand
            Dim AdaptadorTabela As New MySqlDataAdapter
            Dim DadosTabela As New DataTable

            ConecxaoSQL.ConnectionString = StringdeConexao

            If MsgBox("Excluir pagamento de: " & ListDeClientes.SelectedRows(0).Cells(2).Value, MsgBoxStyle.YesNo, "Excluir Registro") = MsgBoxResult.Yes Then
                Try
                    ConecxaoSQL.Open()

                    Try

                        ComandoSql.Connection = ConecxaoSQL

                        Dim idDeleta As Integer = CInt(ListDeClientes.SelectedRows(0).Cells(0).Value)
                        Dim IDRecibo As Integer = CInt(ListDeClientes.SelectedRows(0).Cells(6).Value)



                        'Deletar Cadastro
                        ComandoSql.Parameters.AddWithValue("@id", idDeleta)
                        ComandoSql.Parameters.AddWithValue("@idRecibo", IDRecibo)
                        ComandoSql.CommandText = "DELETE FROM equipamentos where id=@id; DELETE FROM recibos where id=@idRecibo;"
                        ComandoSql.ExecuteNonQuery()


                        ClientesCarrega(frmPrincipal.ClienteID)
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

    Private Sub BtReciboNovo_Click(sender As Object, e As EventArgs) Handles BtReciboNovo.Click
        If ListDeClientes.SelectedRows.Count = 1 Then
            Try
                EquipamendoID = ListDeClientes.SelectedRows(0).Cells(0).Value
                frmNovoRecibo.NovoReciboCadastro = False
                frmNovoRecibo.ComboBox1.Text = "Equipamento"
                frmNovoRecibo.btPDF.Text = "Imprimir Recibo"
                frmNovoRecibo.txtValor.Text = ListDeClientes.SelectedRows(0).Cells(4).Value
                frmNovoRecibo.txtReferente.Text = ListDeClientes.SelectedRows(0).Cells(2).Value
                frmNovoRecibo.Formulario = New FrmEquipamentos
                frmEquipamentosadd.Incluir = False
                frmNovoRecibo.Show()
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ListDeClientes_SelectionChanged(sender As Object, e As EventArgs) Handles ListDeClientes.SelectionChanged
        If ListDeClientes.SelectedRows.Count >= 1 Then
            BtReciboNovo.Enabled = True
        Else
            BtReciboNovo.Enabled = False
        End If
    End Sub

    Private Sub ListDeClientes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ListDeClientes.CellFormatting
        If e.ColumnIndex = 5 Then
            If e.Value = "Sim" Then
                e.CellStyle.SelectionBackColor = Color.DarkGreen
                e.CellStyle.ForeColor = Color.DarkGreen
            Else
                e.CellStyle.SelectionBackColor = Color.Red
                e.CellStyle.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub FrmEquipamentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.TabControl1.SelectedTab = frmPrincipal.TabPage4
        frmPrincipal.btAtualizaEquipamentos.PerformClick()
    End Sub
End Class