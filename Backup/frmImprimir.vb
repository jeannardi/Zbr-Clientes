Imports System.Drawing.Printing

Public Class frmImprimir
    Private MyDataGridViewPrinter As DataGridViewPrinter
    Private Nome As String = "Cliente GPM ALARMES"
    Private Sub DGVImprimir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVImprimir.CellContentClick

    End Sub

    Private Sub frmImprimir_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Function SetupThePrinting() As Boolean
        Dim MyPrintDialog As New PrintDialog()
        MyPrintDialog.AllowCurrentPage = False
        MyPrintDialog.AllowPrintToFile = False
        MyPrintDialog.AllowSelection = False
        MyPrintDialog.AllowSomePages = False
        MyPrintDialog.PrintToFile = False
        MyPrintDialog.ShowHelp = False
        MyPrintDialog.ShowNetwork = False
        MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape = False

        If MyPrintDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        MyPrintDocument.DocumentName = "GPM ALARMES 24h - OCORRENCIAS "
        Dim Titulo As String = "GPM ALARMES 24H :: OCORRENCIAS" & vbNewLine & "Cliente: " & Nome
        MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings
        MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        MyPrintDocument.DefaultPageSettings.Margins = New Margins(5, 5, 5, 5)


        ' If MessageBox.Show("Deseja centralizar o conteudo da tablela?", "Centralizar conteudo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        MyDataGridViewPrinter = New DataGridViewPrinter(DGVImprimir, MyPrintDocument, True, True, Titulo, New Font("Tahoma", 12, FontStyle.Bold, GraphicsUnit.Point),
                Color.Black, True)
        ' Else
        ' MyDataGridViewPrinter = New DataGridViewPrinter(DGVImprimir, MyPrintDocument, False, True, DGVImprimir.Item(1, 0).Value.ToString + " - GPM Alarmes", New Font("Tahoma", 12, FontStyle.Bold, GraphicsUnit.Point),
        ' Color.Black, True)
        ' End If

        Return True
    End Function

    Private Sub MyPrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles MyPrintDocument.PrintPage
        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)
        If more = True Then
            e.HasMorePages = True
        End If
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        If SetupThePrinting() Then
            Dim MyPrintPreviewDialog As New PrintPreviewDialog()
            MyPrintPreviewDialog.Document = MyPrintDocument
            MyPrintPreviewDialog.ShowDialog()
        End If
    End Sub

    Private Sub DGVImprimir_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DGVImprimir.ColumnAdded
        If e.Column.Index = 1 Then
            e.Column.ReadOnly = True
        End If
    End Sub
End Class