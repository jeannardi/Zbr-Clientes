Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient

Imports System.IO
Public Class frmBackup
    Dim _currentTableName As String = ""
    Dim _totalRowsInCurrentTable As Integer = 0
    Dim _totalRowsInAllTables As Integer = 0
    Dim _currentRowIndexInCurrentTable As Integer = 0
    Dim _currentRowIndexInAllTable As Integer = 0
    Dim _totalTables As Integer = 0
    Dim _currentTableIndex As Integer = 0

    Dim ImportMaximo As Integer = 100
    Dim ImportValor As Integer = 0
    Dim IniciaBackup As BackgroundWorker
    Dim RestauraBackup As BackgroundWorker

    Dim constring As String = My.Computer.FileSystem.ReadAllText("config.ccf")
    Dim conn As MySqlConnection = New MySqlConnection(constring & ";allowzerodatetime=true;")
    Dim cmd As MySqlCommand = New MySqlCommand()
    Dim mb As MySqlBackup = New MySqlBackup(cmd)

    Public Cancelar As Boolean = False
    Public MODO As String
    Private Sub frmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler mb.ExportProgressChanged, New MySqlBackup.exportProgressChange(AddressOf mb_ExportProgressChanged)
        AddHandler mb.ExportCompleted, New MySqlBackup.exportComplete(AddressOf mb_ExportCompleted)
        AddHandler mb.ImportProgressChanged, New MySqlBackup.importProgressChange(AddressOf ImportProgressChange)
        AddHandler mb.ImportCompleted, New MySqlBackup.importComplete(AddressOf ImportProgressComplete)

        RestauraBackup = New BackgroundWorker
        AddHandler RestauraBackup.DoWork, AddressOf bwImport_DoWork
        AddHandler RestauraBackup.RunWorkerCompleted, AddressOf bwImport_RunWorkerCompleted

        IniciaBackup = New BackgroundWorker
        AddHandler IniciaBackup.DoWork, AddressOf IniciarBkpProcesso
        AddHandler IniciaBackup.RunWorkerCompleted, AddressOf IniciarBkpCompleto

        If conn.State = ConnectionState.Open Then
            MsgBox("open")
        End If
    End Sub

    Private Sub IniciarBkpCompleto(sender As Object, e As RunWorkerCompletedEventArgs)
        conn.Close()
    End Sub

    Private Sub IniciarBkpProcesso(sender As Object, e As DoWorkEventArgs)
        Try
            Dim file As String = txtLocalSalvar.Text
            mb.ExportToFile(File)
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub

    Private Sub bwImport_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        conn.Close()
    End Sub

    Private Sub bwImport_DoWork(sender As Object, e As DoWorkEventArgs)
        Try

            Dim file As String = txtRestaurar.Text
            mb.ImportFromFile(file)
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub

    Private Sub ImportProgressComplete(sender As Object, e As ImportCompleteArgs)
        If e.CompletedType = 0 Then
            MsgBox("Pronto Restaurado com sucesso!")
            Me.Close()
        Else
            MsgBox(e.LastError)
        End If
    End Sub

    Private Sub ImportProgressChange(sender As Object, e As ImportProgressArgs)
        ImportValor = e.CurrentBytes
        ImportMaximo = e.TotalBytes
    End Sub

    Private Sub Restaurar()
        If txtRestaurar.TextLength > 3 Then
            Try
                Dim Banco As String = InputBox("Nome do banco de dados")

                conn.Open()
                Try
                    cmd.Connection = conn
                    cmd.CommandText = "SET GLOBAL max_allowed_packet=1024*1024*1024*1024*1024*1024; "
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "SET GLOBAL max_allowed_packet=1024*1024*1024*1024*1024*1024; "
                    cmd.ExecuteNonQuery()
                    mb.ImportInfo.IntervalForProgressReport = 50

                    mb.ImportInfo.TargetDatabase = Banco
                    RestauraBackup.RunWorkerAsync()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub BuckupOcorrencias()
        Try

            Dim file As String = txtLocalSalvar.Text


            conn.Open()
            Try
                cmd.Connection = conn
                mb.ExportInfo.IntervalForProgressReport = 20
                mb.ExportInfo.AddCreateDatabase = False
                IniciaBackup.RunWorkerAsync()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mb_ExportProgressChanged(sender As Object, e As ExportProgressArgs)
        _currentRowIndexInAllTable = CType(e.CurrentRowIndexInAllTables, Integer)
        _currentRowIndexInCurrentTable = CType(e.CurrentRowIndexInCurrentTable, Integer)
        _currentTableIndex = e.CurrentTableIndex
        _currentTableName = e.CurrentTableName
        _totalRowsInAllTables = CType(e.TotalRowsInAllTables, Integer)
        _totalRowsInCurrentTable = CType(e.TotalRowsInCurrentTable, Integer)
        _totalTables = e.TotalTables

    End Sub

    Private Sub mb_ExportCompleted(sender As Object, e As ExportCompleteArgs)
        conn.Close()
        If e.CompletionType = MySqlBackup.ProcessEndType.Complete Then
            MsgBox("Backup Criado com sucesso", vbInformation, "Pronto.")

        End If
        Me.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        pbTable.Maximum = _totalTables
        If _currentTableIndex <= pbTable.Maximum Then
            pbTable.Value = _currentTableIndex
            lblBackup.Text = "Tabela Atual = " + _currentTableName
        End If
        pbRestaurar.Maximum = ImportMaximo
        If ImportValor <= pbRestaurar.Maximum Then
            pbRestaurar.Value = ImportValor
        End If
        Try
            If Not mb.LastError Is Nothing Then
                If mb.LastError.Message <> "" Then
                    lblStatus.Text = "Problema >>" + mb.LastError.Message
                    mb.StopAllProcess()
                    conn.Clone()
                End If
            End If
        Catch ex As Exception
            lblStatus.Text = "Problema >>" + mb.LastError.Message
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        pbRestaurar.Value = 0
        Restaurar()
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        salvar.ShowDialog()
        txtLocalSalvar.Text = salvar.FileName
    End Sub

    Private Sub btCriarBackup_Click(sender As Object, e As EventArgs) Handles btCriarBackup.Click
        btCriarBackup.Enabled = False
        pbTable.Value = 0
        BuckupOcorrencias()
    End Sub

    Private Sub txtLocalSalvar_TextChanged(sender As Object, e As EventArgs) Handles txtLocalSalvar.TextChanged
        If txtLocalSalvar.Text <> "" Then
            btCriarBackup.Enabled = True
        Else
            btCriarBackup.Enabled = False
        End If
    End Sub

    Private Sub btBuscarBkp_Click(sender As Object, e As EventArgs) Handles btBuscarBkp.Click
        filerestaurar.ShowDialog()
        txtRestaurar.Text = filerestaurar.FileName
    End Sub

    Private Sub tabBackup_Click(sender As Object, e As EventArgs) Handles tabBackup.Click

    End Sub
    Public Sub Tipo(ByVal Estado As String)
        If Estado = "bkp" Then
            MODO = "bkp"
            TabRestaura.Enabled = False
        End If
    End Sub

    Private Sub frmBackup_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MODO = "bkp" Then
            MODO = "bkp"
            End
        End If
    End Sub

    Private Sub Barra_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Barra.ItemClicked

    End Sub
End Class