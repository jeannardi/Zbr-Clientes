Imports MySql.Data.MySqlClient
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class frmBusca
    Private Sub frmBusca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbFiltro.SelectedIndex = 0
        ClientesCarrega("")
    End Sub
    Private Sub ClientesCarrega(ByVal Filtro As String)
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

                Select Case cmbFiltro.SelectedIndex
                    Case 0
                        ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM clientes WHERE nome LIKE '%' @Filtro '%' ORDER BY CAST(nome AS UNSIGNED ) ASC"
                    Case 1
                        ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM clientes WHERE alarmecodigo LIKE '%' @Filtro '%' ORDER BY alarmecodigo ASC"
                    Case 2
                        ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM clientes WHERE alarmeendereco LIKE '%' @Filtro '%' ORDER BY alarmeendereco ASC"
                    Case 3
                        ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero FROM clientes WHERE alarmeendereconumero LIKE '%' @Filtro '%' ORDER BY alarmeendereconumero ASC"
                    Case 4

                        ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero,datacontrato FROM clientes WHERE datacontrato LIKE '%' @Filtro '%' ORDER BY datacontrato ASC"
                    Case 5

                        ComandoSql.CommandText = "SELECT id, alarmecodigo,nome,alarmeendereco,alarmeendereconumero,datacontrato FROM clientes where datacontrato IS NULL ORDER BY nome ASC"

                End Select

                ComandoSql.Parameters.AddWithValue("@Filtro", Filtro)
                ComandoSql.ExecuteNonQuery()
                AdaptadorTabela.SelectCommand = ComandoSql
                DadosTabela = New DataTable
                AdaptadorTabela.Fill(DadosTabela)

                If ListDeClientes.Columns.Count > 0 Then
                    ListDeClientes.Columns.Clear()
                End If
                ListDeClientes.DataSource = DadosTabela


                If ListDeClientes.Columns.Count >= 5 Then
                    ListDeClientes.Columns(0).Visible = False
                    ListDeClientes.Columns(1).HeaderText = "Codigo Alarme"
                    ListDeClientes.Columns(1).Width = 80
                    ListDeClientes.Columns(2).HeaderText = "Nome"
                    ListDeClientes.Columns(2).Width = 350
                    ListDeClientes.Columns(3).HeaderText = "Endereço"
                    ListDeClientes.Columns(3).Width = 200
                    ListDeClientes.Columns(4).HeaderText = "Numero"
                    ListDeClientes.Columns(4).Width = 80
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

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        ClientesCarrega(txtFiltro.Text)
    End Sub

    Private Sub ListDeClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListDeClientes.CellContentClick

    End Sub

    Private Sub ListDeClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListDeClientes.CellDoubleClick

        Try

            frmPrincipal.btCancelar.PerformClick()

            frmPrincipal.ClientesCarrega(ListDeClientes.SelectedRows(0).Cells(0).Value)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btPDF.Click
        Dim SubTitulo As String = InputBox("Digite abaixo o subtiutlo ex Av. Paraguassu.", "Informe abaixo", txtFiltro.Text)
        If SubTitulo <> "" Then
            KillPDFHeader()
            Dim Linha As Integer = 18
            Dim document As PdfDocument = New PdfDocument
            document.Info.Title = "Created with PDFsharp"
            document.Info.Subject = "Endereço Clientes"
            document.SecuritySettings.PermitModifyDocument = False


            Dim page As PdfPage = document.AddPage

            Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
            'Dim image As XImage = XImage.FromFile("C:\Users\Jean\Pictures\ICONES\maketing.png")
            'gfx.DrawImage(image, 0, 0, 100, 100)



            Dim fontTitulo As XFont = New XFont("Verdana", 20, XFontStyle.Bold)
            Dim FontNormal As XFont = New XFont("Verdana", 14, XFontStyle.Regular)
            Dim FontTexto As XFont = New XFont("Verdana", 10, XFontStyle.Regular)
            Dim FontTextoNegrito As XFont = New XFont("Verdana", 10, XFontStyle.Bold)
            gfx.DrawString(SubTitulo, fontTitulo, XBrushes.Black,
        New XRect(0, 0, page.Width.Point, Linha), XStringFormats.Center)
            Linha += 60

            'Codigo a esquerda
            Dim Primeiro As String = "(Código Alarme)"
            gfx.DrawString(Primeiro, FontTextoNegrito, XBrushes.Black,
                New XRect(10, 0, 0, Linha), XStringFormats.CenterLeft)
            'Nome meio
            Primeiro = "(Cliente Nome)"
            gfx.DrawString(Primeiro, FontTextoNegrito, XBrushes.Black,
       New XRect(-20, 0, page.Width.Point, Linha), XStringFormats.Center)
            'Nome meio
            Primeiro = "(Numero Casa)"
            gfx.DrawString(Primeiro, FontTextoNegrito, XBrushes.Black,
       New XRect(500, 0, 0, Linha), XStringFormats.CenterLeft)
            Linha += 22
            Dim linhas As Integer = 0
            For i = 0 To ListDeClientes.Rows.Count - 1
                If Linha >= 1620 Then
                    Dim NovaPagina = document.AddPage()
                    gfx = XGraphics.FromPdfPage(NovaPagina)
                    Linha = 10
                End If
                Linha += 22

                'Codigo a esquerda
                Dim Imprimi As String = ListDeClientes.Rows(i).Cells(1).Value.ToString
                gfx.DrawString(Imprimi, FontTexto, XBrushes.Black,
                New XRect(10, 0, 0, Linha), XStringFormats.CenterLeft)
                'Nome meio
                Imprimi = ListDeClientes.Rows(i).Cells(2).Value.ToString
                gfx.DrawString(Imprimi, FontTexto, XBrushes.Black,
       New XRect(-20, 0, page.Width.Point, Linha), XStringFormats.Center)
                'Nome meio
                Imprimi = ListDeClientes.Rows(i).Cells(4).Value.ToString
                gfx.DrawString(Imprimi, FontTexto, XBrushes.Black,
       New XRect(520, 0, 0, Linha), XStringFormats.CenterLeft)
            Next
            ' Save the document...
            Dim filename As String = "ListaEnd.pdf"
            document.Save(filename)


            ' ...and start a viewer.
            Process.Start(filename)


        End If
    End Sub

    Private Sub ListDeClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles ListDeClientes.KeyDown
        If e.KeyCode = 13 Then
            Try

                frmPrincipal.btCancelar.PerformClick()

                frmPrincipal.ClientesCarrega(ListDeClientes.SelectedRows(0).Cells(0).Value)
                Me.Close()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub frmBusca_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged
        If cmbFiltro.SelectedIndex = 2 Then
            btPDF.Visible = True
        Else
            btPDF.Visible = False
        End If
    End Sub
End Class