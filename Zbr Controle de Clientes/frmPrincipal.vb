Imports System.ComponentModel
Imports System.Net
Imports System.Net.NetworkInformation
Imports MySql.Data.MySqlClient

Public Class frmPrincipal
    Public ClienteID As String = ""
    Public ClientNome As String = ""
    Public TabelaPendentes As New DataTable
    Public DTAniversarios As New DataTable
    Public DTAniversariosContratos As New DataTable
    Public TabelaPagamentos As New DataTable
    Public aniverhj As Boolean = False
    Public Caniverhj As Boolean = False
    Public Shared SistemStuatus = "Carregando configurações de banco de dados"
    Public CpfDuplicados As String = ""
    Private Sub txtCelular1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCelular1.MaskInputRejected

    End Sub
    Public Sub ClientesCarrega(ByVal Filtro As String)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim DadosTabela As New DataTable

        ClearTextBox()
        TravarOuLiberar(True)
        btSalvar.Enabled = False
        btCancelar.Enabled = False
        btExcluir.Enabled = False
        btNovo.Enabled = True

        Application.DoEvents()
        btCancelar.PerformClick()
        ConecxaoSQL.ConnectionString = StringdeConexao
        Try
            ConecxaoSQL.Open()
            Try


                ComandoSql.Connection = ConecxaoSQL

                ComandoSql.CommandText = "SELECT * FROM clientes WHERE id = @Filtro limit 1;"


                ComandoSql.Parameters.AddWithValue("@Filtro", Filtro)
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql
                DadosTabela = New DataTable
                AdaptadorTabela.Fill(DadosTabela)
                If DadosTabela.Rows.Count >= 0 And DadosTabela.Columns.Count >= 18 Then

                    ClientNome = DadosTabela.Rows.Item(0).Item(1).ToString
                    txtNome.Text = DadosTabela.Rows.Item(0).Item(1).ToString
                    'CPF OU CNPJ
                    Dim CPF As String = DadosTabela.Rows.Item(0).Item(2).ToString
                    If CPF.Length <= 14 Then
                        CheckCPF.Checked = True
                        txtCPF.Mask = "999,999,999-99"


                    End If
                    If CPF.Length > 14 Then
                        CheckCNPJ.Checked = True
                        txtCPF.Mask = "99,999,999/9999-99"

                    End If
                    txtCPF.Text = CPF

                    txtEndereco.Text = DadosTabela.Rows.Item(0).Item(3).ToString
                    txtBairro.Text = DadosTabela.Rows.Item(0).Item(4).ToString
                    txtCidade.Text = DadosTabela.Rows.Item(0).Item(5).ToString
                    txtCep.Text = DadosTabela.Rows.Item(0).Item(6).ToString
                    txtDataNascimento.Text = DadosTabela.Rows.Item(0).Item(7).ToString
                    txtCelular1.Text = DadosTabela.Rows.Item(0).Item(8).ToString
                    txtCelular2.Text = DadosTabela.Rows.Item(0).Item(9).ToString
                    txtCelular3.Text = DadosTabela.Rows.Item(0).Item(10).ToString
                    txtEmail.Text = DadosTabela.Rows.Item(0).Item(11).ToString
                    txtObservacao.Text = DadosTabela.Rows.Item(0).Item(12).ToString
                    txtAlarmeCodigo.Text = DadosTabela.Rows.Item(0).Item(13).ToString
                    txtEnderecoAlarme.Text = DadosTabela.Rows.Item(0).Item(14).ToString
                    txtEndereNumeroAlarme.Text = DadosTabela.Rows.Item(0).Item(15).ToString
                    txtAutorizados.Text = DadosTabela.Rows.Item(0).Item(16).ToString
                    txtDataContrato.Text = DadosTabela.Rows.Item(0).Item(17).ToString
                    TxtMensalValor.Text = DadosTabela.Rows.Item(0).Item(18).ToString
                    Dim UsuarioCadastro As String = DadosTabela.Rows.Item(0).Item(19).ToString
                    Dim UltimaMod As String = DadosTabela.Rows.Item(0).Item(20).ToString
                    cmbPagamento.Text = DadosTabela.Rows.Item(0).Item(21).ToString
                    lblNotifica.Visible = False
                    If UltimaMod <> vbNullString Then
                        lblNotifica.Text = "Última atualização [" & UltimaMod & "] feita pelo usuario: " & UsuarioCadastro
                        lblNotifica.Visible = True
                    End If

                    ClienteID = Filtro
                    btAlterar.Enabled = True
                    btEquipamento.Enabled = True
                    btMensalidade.Enabled = True
                    btRecibo.Enabled = True
                End If
                'Quantos Equipamentos nao foram pagos
                ComandoSql.CommandText = "SELECT id FROM equipamentos WHERE clienteid = @Filtro AND pago = 'Não' Limit 1000;"
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql
                DadosTabela = New DataTable
                AdaptadorTabela.Fill(DadosTabela)
                If DadosTabela.Rows.Count > 0 Then
                    btEquipamento.Text = "Equipamentos (" & DadosTabela.Rows.Count & ")"
                    btEquipamento.ForeColor = Color.Red
                Else
                    btEquipamento.ForeColor = Color.Black
                    btEquipamento.Text = "Equipamentos"
                End If
                ConecxaoSQL.Close()
                TabControl1.SelectedIndex = 0
            Catch ex As MySqlException
                MsgBox("Problema com seleção de dados")
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()


        Catch ex As MySqlException


        End Try
    End Sub
    Private Function CorrigeNumeroCelular(ByVal Cel As String)
        Dim numero As String = Cel.Replace(" ", "")
        numero = numero.Replace("(", "")
        numero = numero.Replace(")", "")
        numero = numero.Replace("-", "")
        Return numero
    End Function

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub IPATUALIZA()
        On Error Resume Next
        Dim hostName As String = Dns.GetHostName
        Console.WriteLine("Host Name : " & hostName & vbNewLine)
        For Each address In Dns.GetHostEntry(hostName).AddressList()
            If address.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                LBLIP.Text = "  IP: " & address.ToString

            End If
        Next

    End Sub
    Public Function TesteConexao(ByVal StringCONECTAR As String) As Boolean

        Dim ConecxaoSQL As New MySqlConnection

        ConecxaoSQL.ConnectionString = StringdeConexao


        Try
            ConecxaoSQL.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try

        Return False
    End Function
    Private Sub MudarStatusSplash(ByVal TXT As String)
        Invoke(Sub()
                   frmSlash.Label2.Text = TXT
               End Sub)
    End Sub
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim verificaerro As String = VerificarAtualizacoes()
        LBLIP.Visible = False
        Try
            If Environment.GetCommandLineArgs(1) = "IP" Then
                LBLIP.Visible = True
                Timer2.Enabled = True
            Else
                LBLIP.Visible = False
            End If
        Catch ex As Exception
            LBLIP.Visible = True
        End Try

        Try
            If Environment.GetCommandLineArgs(1) = "t" Then
                LBLIP.Visible = False
            End If
        Catch ex As Exception

        End Try

        If verificaerro.Contains("127.0.0.1") Then

        End If
        MudarStatusSplash("Iniciando formularios de sistema.")
        IPATUALIZA()
        MudarStatusSplash("Carregando configurações de banco de dados.")
        Try
            StringdeConexao = My.Computer.FileSystem.ReadAllText("config.ccf")
        Catch ex As Exception
            MsgBox("Existe um problema grave na conexão contate o desenvolvedor")
            End
        End Try
        MudarStatusSplash("Verificando conexão com banco de dados.")
        If TesteConexao(StringdeConexao) = False Then
            MudarStatusSplash("Problema de conexão !")
            FrmMysql.ShowDialog()
        Else
            MudarStatusSplash("Tudo pronto!")
            btAtualiza.Enabled = False
            BackgroundWorker2.RunWorkerAsync()
            BackgroundWorker1.RunWorkerAsync()

            BackgroundWorker3.RunWorkerAsync()
            BackgroundWorker4.RunWorkerAsync()

        End If



    End Sub
    Private Sub TravarOuLiberar(ByVal Bloquear As Boolean)
        If Bloquear = True Then
            'cliente
            txtNome.ReadOnly = True
            txtCPF.ReadOnly = True
            txtEndereco.ReadOnly = True
            txtBairro.ReadOnly = True
            txtCidade.ReadOnly = True
            txtCep.ReadOnly = True
            txtDataNascimento.ReadOnly = True
            txtCelular1.ReadOnly = True
            txtCelular2.ReadOnly = True
            txtCelular3.ReadOnly = True
            txtEmail.ReadOnly = True
            txtObservacao.ReadOnly = True
            CheckCNPJ.Enabled = False
            CheckCPF.Enabled = False
            'alarme
            txtAlarmeCodigo.ReadOnly = True
            txtEnderecoAlarme.ReadOnly = True
            txtEndereNumeroAlarme.ReadOnly = True
            txtAutorizados.ReadOnly = True
            txtDataContrato.ReadOnly = True
            TxtMensalValor.ReadOnly = True
            cmbPagamento.Enabled = False
        Else
            'cliente
            txtNome.ReadOnly = False
            txtCPF.ReadOnly = False
            txtEndereco.ReadOnly = False
            txtBairro.ReadOnly = False
            txtCidade.ReadOnly = False
            txtCep.ReadOnly = False
            txtDataNascimento.ReadOnly = False
            txtCelular1.ReadOnly = False
            txtCelular2.ReadOnly = False
            txtCelular3.ReadOnly = False
            txtEmail.ReadOnly = False
            txtObservacao.ReadOnly = False
            txtDataContrato.ReadOnly = False
            CheckCNPJ.Enabled = True
            CheckCPF.Enabled = True
            'alarme
            txtAlarmeCodigo.ReadOnly = False
            txtEnderecoAlarme.ReadOnly = False
            txtEndereNumeroAlarme.ReadOnly = False
            txtAutorizados.ReadOnly = False
            TxtMensalValor.ReadOnly = False
            cmbPagamento.Enabled = True
        End If
        ErrorProvider1.Clear()
    End Sub
    Private Sub ClearTextBox()
        txtNome.Text = ""
        txtCPF.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtCep.Text = ""
        txtDataNascimento.Text = ""
        txtCelular1.Text = ""
        txtCelular2.Text = ""
        txtCelular3.Text = ""
        txtEmail.Text = ""
        txtObservacao.Text = ""
        txtDataContrato.Text = ""
        'alarme
        txtAlarmeCodigo.Text = ""
        txtEnderecoAlarme.Text = ""
        txtEndereNumeroAlarme.Text = ""
        txtAutorizados.Text = ""
        TxtMensalValor.Text = "0,00"
        cmbPagamento.Text = "Mensal"
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        If LoginPass = True Then
            If txtNome.TextLength > 2 And LoginPass = True Then
                Dim ConecxaoSQL As New MySqlConnection
                Dim ComandoSql As New MySqlCommand
                Dim AdaptadorTabela As New MySqlDataAdapter
                Dim DadosTabela As New DataTable
                Application.DoEvents()
                ConecxaoSQL.ConnectionString = StringdeConexao
                Try
                    ConecxaoSQL.Open()

                    Try

                        ComandoSql.Connection = ConecxaoSQL
                        ComandoSql.Parameters.AddWithValue("@nome", txtNome.Text)
                        ComandoSql.Parameters.AddWithValue("@cpf", txtCPF.Text)
                        ComandoSql.Parameters.AddWithValue("@end", txtEndereco.Text)
                        ComandoSql.Parameters.AddWithValue("@bairro", txtBairro.Text)
                        ComandoSql.Parameters.AddWithValue("@cidade", txtCidade.Text)
                        ComandoSql.Parameters.AddWithValue("@ceep", txtCep.Text)

                        If (txtDataNascimento.Text <> "00/00/0000") Then
                            Try
                                Dim Aniversario As Date = CDate(txtDataNascimento.Text)
                                ComandoSql.Parameters.AddWithValue("@datanascimento", Aniversario)
                            Catch ex As Exception
                                ComandoSql.Parameters.AddWithValue("@datanascimento", DBNull.Value)
                            End Try

                        Else
                            ComandoSql.Parameters.AddWithValue("@datanascimento", DBNull.Value)
                        End If
                        'data contrato
                        If (txtDataContrato.Text <> "00/00/0000") Then
                            Try
                                Dim contrato As Date = CDate(txtDataContrato.Text)
                                ComandoSql.Parameters.AddWithValue("@contrato", contrato)
                            Catch ex As Exception
                                ComandoSql.Parameters.AddWithValue("@contrato", DBNull.Value)
                            End Try

                        Else
                            ComandoSql.Parameters.AddWithValue("@contrato", DBNull.Value)
                        End If
                        ComandoSql.Parameters.AddWithValue("@celular1", CorrigeNumeroCelular(txtCelular1.Text))
                        ComandoSql.Parameters.AddWithValue("@celular2", CorrigeNumeroCelular(txtCelular2.Text))
                        ComandoSql.Parameters.AddWithValue("@celular3", CorrigeNumeroCelular(txtCelular3.Text))
                        ComandoSql.Parameters.AddWithValue("@email", txtEmail.Text)
                        ComandoSql.Parameters.AddWithValue("@obs", txtObservacao.Text)

                        ComandoSql.Parameters.AddWithValue("@alarmecodigo", txtAlarmeCodigo.Text)
                        ComandoSql.Parameters.AddWithValue("@alarmeendereco", txtEnderecoAlarme.Text)
                        ComandoSql.Parameters.AddWithValue("@alarmeendereconumero", txtEndereNumeroAlarme.Text)
                        ComandoSql.Parameters.AddWithValue("@autorizados", txtAutorizados.Text)
                        ComandoSql.Parameters.AddWithValue("@id", ClienteID)
                        ComandoSql.Parameters.AddWithValue("@Mensal", TxtMensalValor.Text)
                        ComandoSql.Parameters.AddWithValue("@usuario", UsuarioLogado)
                        ComandoSql.Parameters.AddWithValue("@moddata", Now)
                        ComandoSql.Parameters.AddWithValue("@cmbpaga", cmbPagamento.Text)
                        If ClienteID = "novo" Then
                            'Incluir Cadastro

                            ComandoSql.CommandText = "INSERT INTO clientes (nome, cpf, endereco,bairro,cidade,ceep,datanascimento,celular1,celular2,celular3,email,obs,alarmecodigo,alarmeendereco,alarmeendereconumero,autorizados,datacontrato,mensalvalor,usuario,pagalarme)
VALUES (@nome, @cpf, @end, @bairro, @cidade, @ceep, @datanascimento, @celular1, @celular2, @celular3, @email, @obs, @alarmecodigo, @alarmeendereco, @alarmeendereconumero, @autorizados,@contrato,@Mensal,@usuario,@cmbpaga); SELECT LAST_INSERT_ID();"
                            ComandoSql.ExecuteNonQuery()

                            ClienteID = ComandoSql.LastInsertedId
                            ClientesCarrega(ClienteID)
                        ElseIf (ClienteID <> "") Then
                            'Atualizar cadastro
                            ComandoSql.CommandText = "UPDATE Clientes
                                                SET nome = @nome,
                                                    cpf = @cpf,
                                                    endereco = @end,
                                                    bairro = @bairro,
                                                    cidade = @cidade,
                                                    ceep = @ceep,
                                                    datanascimento = @datanascimento,
                                                    celular1 = @celular1,
                                                    celular2 = @celular2,
                                                    celular3 = @celular3,
                                                    email = @email,
                                                    obs = @obs,
                                                    alarmecodigo = @alarmecodigo,
                                                    alarmeendereco = @alarmeendereco,
                                                    alarmeendereconumero = @alarmeendereconumero,
                                                    datacontrato=@contrato,
                                                    mensalvalor=@Mensal,
                                                    usuario=@Usuario,
                                                    modificacao=@moddata,
                                                    pagalarme=@cmbpaga,
                                                    autorizados = @autorizados WHERE id = @id;"
                            ComandoSql.ExecuteNonQuery()
                            lblNotifica.Visible = False

                        Else
                            MsgBox("Nao foi possivel salvar alterações o softwarer nao encontra o registro do cliente no banco de dados")

                        End If


                        TravarOuLiberar(True)
                        btSalvar.Enabled = False
                        btAlterar.Enabled = True
                        btCancelar.Enabled = False
                        btExcluir.Enabled = False
                        btNovo.Enabled = True
                        ErrorProvider1.Clear()
                        ConecxaoSQL.Close()
                    Catch ex As MySqlException

                        MsgBox(ex.Message, MsgBoxStyle.Information, "Erro ao salvar")
                        ConecxaoSQL.Close()
                    End Try

                Catch ex As MySqlException
                    MsgBox("Não e possivel conectar com servidor", MsgBoxStyle.Information, "Erro ao salvar")
                    ConecxaoSQL.Close()
                End Try

            Else
                txtNome.Focus()
                ErrorProvider1.SetError(Label1, "Digite um nome com mais de 2 letras para o Cliente")
            End If
        Else
            frmLogin.ShowDialog()
        End If

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        If LoginPass = True Then
            ClienteID = "novo"
            ClientNome = ""
            btSalvar.Text = "Incluir Cadastro"
            TravarOuLiberar(False)
            btEquipamento.Enabled = False
            btMensalidade.Enabled = False
            btRecibo.Enabled = False
            btSalvar.Enabled = True
            btCancelar.Enabled = True
            btNovo.Enabled = False
            btAlterar.Enabled = False
            ClearTextBox()
        Else
            frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        TravarOuLiberar(True)
        btSalvar.Enabled = False
        btCancelar.Enabled = False
        btExcluir.Enabled = False
        btNovo.Enabled = True
        If ClienteID <> "novo" And ClienteID <> "" Then
            btAlterar.Enabled = True
            ClientesCarrega(ClienteID)
        Else
            btAlterar.Enabled = False
            ClearTextBox()
        End If
    End Sub

    Private Sub txtAutorizados_TextChanged(sender As Object, e As EventArgs) Handles txtAutorizados.TextChanged

    End Sub



    Private Sub txtCep_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCep.MaskInputRejected

    End Sub

    Private Sub txtCep_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCep.KeyDown
        If e.KeyCode = 13 Then

            Try
                Dim ds As New DataSet()
                Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCep.Text)
                ds.ReadXml(xml)
                If ds.Tables(0).Rows(0)("resultado").ToString() > 0 Then
                    txtEndereco.Text = ds.Tables(0).Rows(0)("tipo_logradouro").ToString() & " " & ds.Tables(0).Rows(0)("logradouro").ToString()
                    txtBairro.Text = ds.Tables(0).Rows(0)("bairro").ToString()
                    txtCidade.Text = ds.Tables(0).Rows(0)("cidade").ToString()
                    txtCep.ForeColor = Color.Green
                    'txtUF.Text = ds.Tables(0).Rows(0)("uf").ToString()
                    ErrorProvider1.Clear()
                Else
                    txtCep.ForeColor = Color.Gold
                End If
                Timer1.Enabled = True
            Catch ex As Exception
                MessageBox.Show("CEEP consulta falhou, verifique se existe conexão com a internet ou tenta mais tarde!")
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub btAlterar_Click(sender As Object, e As EventArgs) Handles btAlterar.Click
        If LoginPass = True Then

            btNovo.Enabled = False
            btAlterar.Enabled = False
            btSalvar.Text = "Salvar Alterações"
            TravarOuLiberar(False)
            btSalvar.Enabled = True
            btCancelar.Enabled = True
            btExcluir.Enabled = True

        Else
            frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub txtDataNascimento_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtDataNascimento.MaskInputRejected

    End Sub

    Private Sub txtDataNascimento_LostFocus(sender As Object, e As EventArgs) Handles txtDataNascimento.LostFocus
        txtDataNascimento.ValidateText()
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim DadosTabela As New DataTable
        If LoginPass = True Then
            ConecxaoSQL.ConnectionString = StringdeConexao
            If MsgBox("Realmente deseja excluir o cadastro do cliente?", MsgBoxStyle.YesNo, "Excluir Registro") = MsgBoxResult.Yes Then
                Try
                    ConecxaoSQL.Open()

                    Try

                        ComandoSql.Connection = ConecxaoSQL


                        'Deletar Cadastro
                        ComandoSql.Parameters.AddWithValue("@id", ClienteID)
                        ComandoSql.CommandText = "DELETE FROM clientes where id=@id"
                        ComandoSql.ExecuteNonQuery()
                        btAlterar.Enabled = True


                        TravarOuLiberar(True)
                        btSalvar.Enabled = False
                        btAlterar.Enabled = False
                        btCancelar.Enabled = False
                        btExcluir.Enabled = False
                        btEquipamento.Enabled = False
                        btMensalidade.Enabled = False
                        btRecibo.Enabled = False
                        btNovo.Enabled = True
                        ClearTextBox()
                        ClienteID = ""
                        ClientNome = ""
                        ErrorProvider1.Clear()
                        ConecxaoSQL.Close()
                    Catch ex As MySqlException

                        MsgBox(ex.Message, MsgBoxStyle.Information, "Erro ao salvar")
                        ConecxaoSQL.Close()
                    End Try

                Catch ex As MySqlException
                    MsgBox("Não e possivel conectar com servidor", MsgBoxStyle.Information, "Erro ao salvar")
                    ConecxaoSQL.Close()
                End Try
            End If
        Else
            frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btAtualizaMes.Click
        'Dim MesAno As String = DateTimePicker1.Value.Month.ToString & "/" & DateTimePicker1.Value.Year.ToString
        ' PendentesPagamento(MesAno)
        btAtualizaMes.Enabled = False
        pbPendentes.Visible = True

        TabelaPendentes.Clear()
        ListaPendentes.Columns.Clear()
        BackgroundWorker1.RunWorkerAsync()

    End Sub
    Private Sub PendentesEquipamentos()
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter



        Application.DoEvents()

        ConecxaoSQL.ConnectionString = StringdeConexao
        Try
            ConecxaoSQL.Open()
            Try

                BackgroundWorker3.ReportProgress(20)
                ComandoSql.Connection = ConecxaoSQL


                'ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM pagamentos WHERE nome LIKE '%' @Filtro '%' ORDER BY nome ASC"

                'Mês Vigente
                ComandoSql.CommandText = "SELECT clientes.id,clientes.nome,equipamentos.material,equipamentos.data, equipamentos.valor FROM clientes,equipamentos
                WHERE equipamentos.clienteid=clientes.id AND equipamentos.pago = 'Não';"



                ComandoSql.ExecuteNonQuery()
                BackgroundWorker3.ReportProgress(80) 'Busca Conlcuida
                AdaptadorTabela.SelectCommand = ComandoSql
                TabelaPagamentos.Clear()
                TabelaPagamentos = New DataTable
                AdaptadorTabela.Fill(TabelaPagamentos)


                ConecxaoSQL.Close()


                'MsgBox(TabelaPagamentos.Rows.Count)
                BackgroundWorker3.ReportProgress(100)
            Catch ex As MySqlException
                MsgBox("Problema com seleção de dados")
                BackgroundWorker3.ReportProgress(100)
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException
            MsgBox("Ocorreu um erro de conexão verfique se seu computador ou o servidor estao conectados a um rede!", vbInformation, "Sem conexão.")
            BackgroundWorker3.ReportProgress(100)

        End Try
    End Sub
    Private Sub VERIFICAR_CPF_CNPJ(ByVal Filtro As String)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim TabelaVErifica As New DataTable


        Application.DoEvents()

        ConecxaoSQL.ConnectionString = StringdeConexao
        Try
            ConecxaoSQL.Open()
            Try


                ComandoSql.Connection = ConecxaoSQL

                ComandoSql.Parameters.AddWithValue("@Filtro", Filtro)
                ComandoSql.Parameters.AddWithValue("@ID", ClienteID)

                'ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM pagamentos WHERE nome LIKE '%' @Filtro '%' ORDER BY nome ASC"

                'Mês Vigente
                ComandoSql.CommandText = "SELECT nome,cpf FROM clientes WHERE cpf=@filtro and id <> @id;"


                ComandoSql.ExecuteNonQuery()

                AdaptadorTabela.SelectCommand = ComandoSql

                TabelaVErifica = New DataTable
                AdaptadorTabela.Fill(TabelaVErifica)


                ConecxaoSQL.Close()
                CpfDuplicados = ""
                If TabelaVErifica.Rows.Count > 0 Then

                    For Each Linha As DataRow In TabelaVErifica.Rows
                        CpfDuplicados &= Linha.Item(0) & ", " & Linha.Item(1) & vbNewLine
                    Next

                    LblCPFVerificado.ForeColor = Color.Red
                    LblCPFVerificado.Text = "(Duplicado)"

                Else
                    LblCPFVerificado.ForeColor = Color.Green
                    LblCPFVerificado.Text = "(Único)"
                End If

            Catch ex As MySqlException
                MsgBox("Erro ao verificar se existe CPF ou CNPJ já existe no banco de dados")

                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException

        End Try

    End Sub
    Private Sub PendentesPagamento(ByVal Filtro As String, ByVal Ano As String)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter



        Application.DoEvents()

        ConecxaoSQL.ConnectionString = StringdeConexao
        Try
            ConecxaoSQL.Open()
            Try

                BackgroundWorker1.ReportProgress(20)
                ComandoSql.Connection = ConecxaoSQL

                ComandoSql.Parameters.AddWithValue("@mes", Filtro)
                ComandoSql.Parameters.AddWithValue("@ano", Ano)
                'ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM pagamentos WHERE nome LIKE '%' @Filtro '%' ORDER BY nome ASC"

                'Mês Vigente
                ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM clientes
                WHERE NOT EXISTS (SELECT * FROM pagamentos WHERE mes = @mes AND ano= @ano AND clientes.id = pagamentos.idcliente);"

                'teste entre duas datas


                ComandoSql.Parameters.AddWithValue("@Filtro", Filtro)
                ComandoSql.ExecuteNonQuery()
                BackgroundWorker1.ReportProgress(80) 'Busca Conlcuida
                AdaptadorTabela.SelectCommand = ComandoSql
                TabelaPendentes.Clear()
                TabelaPendentes = New DataTable
                AdaptadorTabela.Fill(TabelaPendentes)


                ConecxaoSQL.Close()

                BackgroundWorker1.ReportProgress(100)
            Catch ex As MySqlException
                MsgBox("Problema com seleção de dados")
                BackgroundWorker1.ReportProgress(100)
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException
            MsgBox("Ocorreu um erro de conexão verfique se seu computador ou o servidor estao conectados a um rede!", vbInformation, "Sem conexão.")
            BackgroundWorker1.ReportProgress(100)

        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        If btAtualizaMes.Enabled = True Then
            Dim MesAno As String = DateTimePicker1.Value.ToString("MM") & "/" & DateTimePicker1.Value.Year.ToString
            Label17.Text = "Mês / Ano ->  ( " & MesAno & " )"
            DateTimePicker1.Enabled = False
            btAtualizaMes.PerformClick()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim MesAno As String = DateTimePicker1.Value.ToString("MM")
        Dim Ano As String = DateTimePicker1.Value.Year.ToString
        PendentesPagamento(MesAno, Ano)

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If ListaPendentes.Columns.Count > 0 Then
            ListaPendentes.Columns.Clear()
        End If
        ListaPendentes.DataSource = TabelaPendentes
        If ListaPendentes.Columns.Count >= 5 Then
            ListaPendentes.Columns(0).Visible = False
            ListaPendentes.Columns(1).HeaderText = "Codigo Alarme"
            ListaPendentes.Columns(1).Width = 80
            ListaPendentes.Columns(2).HeaderText = "Nome"
            ListaPendentes.Columns(2).Width = 350
            ListaPendentes.Columns(3).HeaderText = "Endereço"
            ListaPendentes.Columns(3).Width = 200
            ListaPendentes.Columns(4).HeaderText = "Numero"
            ListaPendentes.Columns(4).Width = 80
        End If
        pbPendentes.Visible = False
        DateTimePicker1.Enabled = True
        btAtualizaMes.Enabled = True
        If ListaPendentes.Rows.Count > 0 Then
            TabPage2.Text = "Relatorio Mensalidades Pendentes (" & ListaPendentes.Rows.Count & ")"
        Else
            TabPage2.Text = "Relatorio Mensalidades Pendentes"
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        pbPendentes.Value = e.ProgressPercentage
    End Sub

    Private Sub ListaPendentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaPendentes.CellContentClick

    End Sub

    Private Sub ListaPendentes_KeyDown(sender As Object, e As KeyEventArgs) Handles ListaPendentes.KeyDown
        If e.KeyCode = 13 Then
            Try

                ClientesCarrega(ListaPendentes.SelectedRows(0).Cells(0).Value)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btBuscaCliente_Click(sender As Object, e As EventArgs) Handles btBuscaCliente.Click
        If LoginPass = True Then
            frmBusca.Show()
        Else
            frmLogin.ShowDialog()
            If LoginPass = True Then
                frmBusca.Show()
            End If
        End If
    End Sub

    Private Sub btMensalidade_Click(sender As Object, e As EventArgs) Handles btMensalidade.Click
        If LoginPass = True Then
            If ClienteID <> "" And ClienteID <> "novo" Then
                frmMensal.Show()
                frmMensal.lblMensal.Text = "Mensalidade: R$ " & TxtMensalValor.Text
                frmMensal.ClientesCarrega(ClienteID, Now.Date.Year.ToString)
            End If
        Else
            frmLogin.ShowDialog()
            If LoginPass = True Then
                frmMensal.Show()
                frmMensal.lblMensal.Text = "Mensalidade: R$ " & TxtMensalValor.Text
                frmMensal.ClientesCarrega(ClienteID, Now.Date.Year.ToString)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If btAtualizaMes.Enabled = True Then
            Dim MesAno As String = DateTimePicker1.Value.ToString("MM") & "/" & DateTimePicker1.Value.Year.ToString
            DateTimePicker1.Value = Now
            DateTimePicker1.Enabled = False
        End If
    End Sub

    Private Sub btRecibo_Click(sender As Object, e As EventArgs) Handles btRecibo.Click
        'Dim listaPAGAS As New List(Of Date)
        ' listaPAGAS.Add(Now)
        ' listaPAGAS.Add(Now.AddMonths(1))
        ' listaPAGAS.Add(Now.AddMonths(2))
        ' listaPAGAS.Add(Now.AddMonths(3))
        ''listaPAGAS.Add(Now.AddMonths(4))
        '  listaPAGAS.Add(Now.AddMonths(5))
        ' GerarReciboMes("Juliano bono Torresmo da silva mendes de mattos", "8.966,00", listaPAGAS)
        If LoginPass = True Then
            If ClienteID <> "" And ClienteID <> "novo" Then
                frmRecibos.Show()
                frmRecibos.ClientesCarrega(ClienteID)
            End If
        Else
            frmLogin.ShowDialog()
            If LoginPass = True Then
                If ClienteID <> "" And ClienteID <> "novo" Then
                    frmRecibos.Show()
                    frmRecibos.ClientesCarrega(ClienteID)
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtCep.ForeColor = Color.Black
        Timer1.Enabled = False
    End Sub

    Private Sub btAniversario_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub AniversariosContrato(ByVal Filtro As Integer)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter




        Try
            Application.DoEvents()

            ConecxaoSQL.ConnectionString = StringdeConexao
            Caniverhj = False
            ConecxaoSQL.Open()


            Try

                BackgroundWorker4.ReportProgress(20)
                ComandoSql.Connection = ConecxaoSQL
                ComandoSql.Parameters.AddWithValue("@filtro", Filtro)

                'ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM pagamentos WHERE nome LIKE '%' @Filtro '%' ORDER BY nome ASC"

                'Mês Vigente
                ComandoSql.CommandText = "SELECT id,nome,datacontrato,email FROM clientes WHERE DATE(datacontrato + INTERVAL (YEAR(NOW()) - YEAR(datacontrato)) YEAR)
      BETWEEN
      DATE(NOW() )
      AND
      DATE(NOW() + INTERVAL 6 DAY);"


                ComandoSql.ExecuteNonQuery()
                BackgroundWorker4.ReportProgress(80) 'Busca Conlcuida
                AdaptadorTabela.SelectCommand = ComandoSql
                DTAniversariosContratos.Clear()
                DTAniversariosContratos = New DataTable
                AdaptadorTabela.Fill(DTAniversariosContratos)

                ConecxaoSQL.Close()
                DTAniversariosContratos.Columns.Add(New DataColumn("Tempo"))
                If DTAniversariosContratos.Rows.Count > 0 Then
                    For Each Linha As DataRow In DTAniversariosContratos.Rows
                        Dim dataPega As Date = CDate(Linha.Item(2))
                        dataPega = CDate(dataPega.Date.ToString("dd") & "/" & dataPega.Date.ToString("MM") & "/" & Now.Year)
                        Dim restam As Integer = DateDiff(DateInterval.Day, Now.Date, dataPega)

                        If restam = 0 Then
                            Linha.Item(4) = "0 Dia - Hoje!!"
                            Caniverhj = True
                        Else
                            Linha.Item(4) = restam & " Dias"
                        End If


                    Next
                End If
                BackgroundWorker4.ReportProgress(100)
            Catch ex As MySqlException
                MsgBox(ex.Message)
                BackgroundWorker4.ReportProgress(100)
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException

            BackgroundWorker4.ReportProgress(100)

        End Try

    End Sub
    Private Sub Aniversarios(ByVal Filtro As Integer)
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter



        Application.DoEvents()

        ConecxaoSQL.ConnectionString = StringdeConexao
        aniverhj = False
        Try
            ConecxaoSQL.Open()
            Try

                BackgroundWorker2.ReportProgress(20)
                ComandoSql.Connection = ConecxaoSQL
                ComandoSql.Parameters.AddWithValue("@filtro", Filtro)

                'ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM pagamentos WHERE nome LIKE '%' @Filtro '%' ORDER BY nome ASC"

                'Mês Vigente
                ComandoSql.CommandText = "SELECT id,nome,datanascimento,email FROM clientes WHERE DATE(datanascimento + INTERVAL (YEAR(NOW()) - YEAR(datanascimento)) YEAR)
      BETWEEN
      DATE(NOW() )
      AND
      DATE(NOW() + INTERVAL 6 DAY);"


                ComandoSql.ExecuteNonQuery()
                BackgroundWorker2.ReportProgress(80) 'Busca Conlcuida
                AdaptadorTabela.SelectCommand = ComandoSql
                DTAniversarios.Clear()
                DTAniversarios = New DataTable
                AdaptadorTabela.Fill(DTAniversarios)

                ConecxaoSQL.Close()
                DTAniversarios.Columns.Add(New DataColumn("Tempo"))
                If DTAniversarios.Rows.Count > 0 Then
                    For Each Linha As DataRow In DTAniversarios.Rows
                        Dim dataPega As Date = CDate(Linha.Item(2))
                        dataPega = CDate(dataPega.Date.ToString("dd") & "/" & dataPega.Date.ToString("MM") & "/" & Now.Year)
                        Dim restam As Integer = DateDiff(DateInterval.Day, Now.Date, dataPega)

                        If restam = 0 Then
                            Linha.Item(4) = "0 Dia - Hoje!!"
                            aniverhj = True
                        Else
                            Linha.Item(4) = restam & " Dias"
                        End If


                    Next
                End If
                BackgroundWorker2.ReportProgress(100)
            Catch ex As MySqlException
                MsgBox(ex.Message)
                BackgroundWorker2.ReportProgress(100)
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException

            BackgroundWorker2.ReportProgress(100)

        End Try

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Aniversarios(7)
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If DTAniversarios IsNot Nothing AndAlso DTAniversarios.Rows.Count > 0 Then
            dataGridAniversario.DataSource = DTAniversarios
        End If

        dataGridAniversario.DataSource = Nothing
        dataGridAniversario.DataSource = DTAniversarios
        If dataGridAniversario.Columns.Count = 5 Then
            dataGridAniversario.Columns(0).Visible = False
            dataGridAniversario.Columns(1).HeaderText = "Nome"
            dataGridAniversario.Columns(1).Width = 350
            dataGridAniversario.Columns(2).HeaderText = "Data Nascimento"
            dataGridAniversario.Columns(2).Width = 85
            dataGridAniversario.Columns(3).HeaderText = "Email"
            dataGridAniversario.Columns(3).Width = 120
            dataGridAniversario.Columns(4).HeaderText = "Tempo"
            dataGridAniversario.Columns(4).Width = 120
        End If
        If dataGridAniversario.Rows.Count > 0 Then
            TabPage3.Text = "Aniversarios (" & dataGridAniversario.Rows.Count & ")"
            TabPage3.ImageKey = "aniverhj.png"
        Else
            TabPage3.Text = "Aniversarios"
            TabPage3.ImageKey = "aniver.png"
        End If

        btAtualiza.Enabled = True
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btAtualiza.Click
        btAtualiza.Enabled = False

        DTAniversarios.Clear()
        DGVContratos.DataSource = Nothing
        DGVContratos.Refresh()
        BackgroundWorker2.RunWorkerAsync()
    End Sub



    Private Sub dataGridAniversario_KeyDown(sender As Object, e As KeyEventArgs) Handles dataGridAniversario.KeyDown
        If e.KeyCode = 13 Then
            Try

                ClientesCarrega(dataGridAniversario.SelectedRows(0).Cells(0).Value)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub dataGridAniversario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridAniversario.CellContentClick

    End Sub

    Private Sub btEquipamento_Click(sender As Object, e As EventArgs) Handles btEquipamento.Click
        If LoginPass = True Then
            FrmEquipamentos.Show()
        Else
            frmLogin.ShowDialog()
            If LoginPass = True Then
                FrmEquipamentos.Show()
            End If
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Process.Start("Calc.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btBackup_Click(sender As Object, e As EventArgs) Handles btBackup.Click
        If LoginPass = True Then
            Try
                Process.Start("Backup.exe")
            Catch ex As Exception

            End Try
        Else
            frmLogin.ShowDialog()
            If LoginPass = True Then
                Try
                    Process.Start("Backup.exe")
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    Private Sub TxtMensalValor_TextChanged(sender As Object, e As EventArgs) Handles TxtMensalValor.TextChanged

    End Sub

    Private Sub TxtMensalValor_LostFocus(sender As Object, e As EventArgs) Handles TxtMensalValor.LostFocus
        Dim valor As String = "0,00"
        If TxtMensalValor.Text = String.Empty Then
            valor = 0
        End If
        Try

            TxtMensalValor.Text = FormatCurrency(TxtMensalValor.Text, 2, TriState.True, TriState.True,
                                TriState.True).Replace("R$", "").Trim
        Catch ex As Exception
            TxtMensalValor.Text = "0,0"
        End Try

    End Sub

    Private Sub frmPrincipal_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btAtualizaEquipamentos.Click
        btAtualizaEquipamentos.Enabled = False
        TabelaPagamentos.Clear()
        dtgvEquipamentos.Columns.Clear()
        BackgroundWorker3.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        PendentesEquipamentos()
    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        If dtgvEquipamentos.Columns.Count > 0 Then
            dtgvEquipamentos.Columns.Clear()
        End If
        dtgvEquipamentos.DataSource = TabelaPagamentos
        If dtgvEquipamentos.Columns.Count >= 5 Then
            dtgvEquipamentos.Columns(0).Visible = False
            dtgvEquipamentos.Columns(1).HeaderText = "Nome"
            dtgvEquipamentos.Columns(1).Width = 350
            dtgvEquipamentos.Columns(2).HeaderText = "Equipamento"
            dtgvEquipamentos.Columns(2).Width = 200
            dtgvEquipamentos.Columns(3).HeaderText = "Data Troca"
            dtgvEquipamentos.Columns(3).Width = 100
            dtgvEquipamentos.Columns(4).HeaderText = "Valor"
            dtgvEquipamentos.Columns(4).Width = 100
        End If
        pbPendentes.Visible = False
        DateTimePicker1.Enabled = True
        btAtualizaEquipamentos.Enabled = True
        If TabelaPagamentos.Rows.Count > 0 Then
            TabPage4.Text = "Equipamentos a receber (" & TabelaPagamentos.Rows.Count & ")"
        Else
            TabPage4.Text = "Equipamentos a receber"
        End If
    End Sub

    Private Sub CheckCNPJ_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCNPJ.CheckedChanged
        If CheckCNPJ.Checked = True Then
            CheckCPF.Checked = False
            txtCPF.Mask = "99,999,999/9999-99"
        Else
            txtCPF.Mask = "999,999,999-99"
            CheckCPF.Checked = True
        End If
    End Sub

    Private Sub CheckCPF_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCPF.CheckedChanged
        If CheckCPF.Checked = True Then
            CheckCNPJ.Checked = False
            txtCPF.Mask = "999,999,999-99"
        Else
            txtCPF.Mask = "99,999,999/9999-99"
            CheckCNPJ.Checked = True
        End If

    End Sub

    Private Sub txtCPF_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCPF.MaskInputRejected

    End Sub

    Private Sub txtCPF_TextChanged(sender As Object, e As EventArgs) Handles txtCPF.TextChanged
        If txtCPF.Text.Length > 14 Then
            CheckCPF.Checked = False
            CheckCNPJ.Checked = True
        ElseIf txtCPF.Text.Length < 14 Then
            CheckCPF.Checked = True
            CheckCNPJ.Checked = False
            LblCPFVerificado.Text = ""
        End If
        If txtCPF.MaskCompleted = True Then
            LblCPFVerificado.Visible = True
            If txtCPF.ReadOnly = False Then
                VERIFICAR_CPF_CNPJ(txtCPF.Text)
            End If
        Else
            LblCPFVerificado.Visible = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        On Error Resume Next
        IPATUALIZA()
    End Sub

    Private Sub dtgvEquipamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvEquipamentos.CellContentClick

    End Sub

    Private Sub dtgvEquipamentos_KeyDown(sender As Object, e As KeyEventArgs) Handles dtgvEquipamentos.KeyDown
        If e.KeyCode = 13 Then
            Try

                ClientesCarrega(dtgvEquipamentos.SelectedRows(0).Cells(0).Value)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtCPF_LostFocus(sender As Object, e As EventArgs) Handles txtCPF.LostFocus
        If txtCPF.MaskCompleted = True Then
            LblCPFVerificado.Visible = True
            If txtCPF.ReadOnly = False Then
                VERIFICAR_CPF_CNPJ(txtCPF.Text)
            End If
        Else
            LblCPFVerificado.Visible = False
        End If

    End Sub

    Private Sub LblCPFVerificado_Click(sender As Object, e As EventArgs) Handles LblCPFVerificado.Click
        If LblCPFVerificado.Text = "(Duplicado)" Then
            MsgBox(CpfDuplicados)
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtAtualizaContratadoAniver.Click
        BtAtualizaContratadoAniver.Enabled = False

        DTAniversariosContratos.Clear()
        DGVContratos.DataSource = Nothing
        DGVContratos.Refresh()
        BackgroundWorker4.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        AniversariosContrato(7)
    End Sub

    Private Sub BackgroundWorker4_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker4.RunWorkerCompleted

        Try



            If DTAniversariosContratos IsNot Nothing AndAlso DTAniversariosContratos.Rows.Count > 0 Then
                DGVContratos.DataSource = DTAniversariosContratos
            End If

            If DGVContratos.Columns.Count = 5 Then
                DGVContratos.Columns(0).Visible = False
                DGVContratos.Columns(1).HeaderText = "Nome"
                DGVContratos.Columns(1).Width = 350
                DGVContratos.Columns(2).HeaderText = "Contrato Inicio"
                DGVContratos.Columns(2).Width = 85
                DGVContratos.Columns(3).HeaderText = "Email"
                DGVContratos.Columns(3).Width = 120
                DGVContratos.Columns(4).HeaderText = "Tempo"
                DGVContratos.Columns(4).Width = 120
            End If
            If DGVContratos.Rows.Count > 0 Then
                TabPage5.Text = "Aniver Contratos (" & DGVContratos.Rows.Count.ToString & ")"
                TabPage5.ImageKey = "aniverhj.png"
            Else
                TabPage5.Text = "Aniver Contratos"
                TabPage5.ImageKey = "aniver.png"
            End If

            BtAtualizaContratadoAniver.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGVContratos_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = 13 Then
            Try
                If DGVContratos.SelectedRows.Count > -1 Then
                    ClientesCarrega(DGVContratos.SelectedRows(0).Cells(0).Value)
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btUsuarios_Click(sender As Object, e As EventArgs) Handles btUsuarios.Click
        frmUserAdmin.Show()
    End Sub



    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Notificar As New frmNotifica

        Notificar.Left = Me.Left + 650
        Notificar.Top = Me.Top + 380
        Notificar.Show()
    End Sub
    Public Sub Fechaforms()
        My.Application.OpenForms.Cast(Of Form)() _
      .Except({Me}) _
      .ToList() _
      .ForEach(Sub(form) form.Close())
    End Sub

    Private Sub btLogin_ButtonClick(sender As Object, e As EventArgs) Handles btLogin.ButtonClick
        If LoginPass = False Then
            btLogin.Text = "[Entrar]"
            Fechaforms()
            frmLogin.ShowDialog()
        Else
            LoginPass = False
            UsuarioLogado = ""
            UsuarioSenha = ""
            btTrocarSenha.Enabled = False

            btLogin.Text = "[Entrar]"
            Fechaforms()
            btUsuarios.Visible = False
            btUsuarios.Enabled = False
        End If
    End Sub

    Private Sub btTrocarSenha_Click(sender As Object, e As EventArgs) Handles btTrocarSenha.Click
        frmTrocaSenha.ShowDialog()
        frmTrocaSenha.txtNovaSenha.Text = ""
        frmTrocaSenha.txtSenhaAtual.Text = ""
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub btRMensalP_Click(sender As Object, e As EventArgs) Handles btRMensalP.Click
        If LoginPass = True Then
            frmFiltroPagamentos.Show()
        Else
            frmLogin.ShowDialog()
            If LoginPass = True Then
                frmFiltroPagamentos.Show()
            End If
        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If LoginPass = True Then
            frmModelPag.ShowDialog()
        Else
            frmLogin.ShowDialog()
            If LoginPass = True Then
                frmModelPag.ShowDialog()
            End If
        End If
    End Sub
End Class
