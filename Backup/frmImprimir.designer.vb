<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimir
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimir))
        Me.DGVImprimir = New System.Windows.Forms.DataGridView()
        Me.Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ocorrencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZonaUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Providência = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGVImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVImprimir
        '
        Me.DGVImprimir.AllowUserToAddRows = False
        Me.DGVImprimir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVImprimir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Entrada, Me.Ocorrencia, Me.ZonaUser, Me.Providência})
        Me.DGVImprimir.Location = New System.Drawing.Point(1, 30)
        Me.DGVImprimir.Name = "DGVImprimir"
        Me.DGVImprimir.Size = New System.Drawing.Size(809, 303)
        Me.DGVImprimir.TabIndex = 1
        '
        'Entrada
        '
        Me.Entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Entrada.HeaderText = "Data Hora"
        Me.Entrada.Name = "Entrada"
        Me.Entrada.Width = 81
        '
        'Ocorrencia
        '
        Me.Ocorrencia.HeaderText = "Ocorrencia"
        Me.Ocorrencia.Name = "Ocorrencia"
        Me.Ocorrencia.Width = 180
        '
        'ZonaUser
        '
        Me.ZonaUser.HeaderText = "Zona/Usuario"
        Me.ZonaUser.Name = "ZonaUser"
        '
        'Providência
        '
        Me.Providência.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Providência.HeaderText = "Providencia"
        Me.Providência.Name = "Providência"
        Me.Providência.Width = 88
        '
        'MyPrintDocument
        '
        Me.MyPrintDocument.DocumentName = "GPM ALARMES"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(810, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
        Me.ImprimirToolStripMenuItem.Text = "Visualizar e Imprimir"
        '
        'frmImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 335)
        Me.Controls.Add(Me.DGVImprimir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmImprimir"
        Me.Text = "Editar antes de imprimir"
        CType(Me.DGVImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVImprimir As DataGridView
    Friend WithEvents Entrada As DataGridViewTextBoxColumn
    Friend WithEvents Ocorrencia As DataGridViewTextBoxColumn
    Friend WithEvents ZonaUser As DataGridViewTextBoxColumn
    Friend WithEvents Providência As DataGridViewTextBoxColumn
    Friend WithEvents MyPrintDocument As Printing.PrintDocument
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
End Class
