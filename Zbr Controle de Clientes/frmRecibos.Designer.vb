<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibos))
        Me.ListDeClientes = New System.Windows.Forms.DataGridView()
        Me.BtNovoRecibo = New System.Windows.Forms.Button()
        Me.BtImprimir = New System.Windows.Forms.Button()
        CType(Me.ListDeClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListDeClientes
        '
        Me.ListDeClientes.AllowUserToAddRows = False
        Me.ListDeClientes.AllowUserToDeleteRows = False
        Me.ListDeClientes.AllowUserToResizeRows = False
        Me.ListDeClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListDeClientes.BackgroundColor = System.Drawing.Color.White
        Me.ListDeClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ListDeClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ListDeClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListDeClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ListDeClientes.GridColor = System.Drawing.SystemColors.HotTrack
        Me.ListDeClientes.Location = New System.Drawing.Point(12, 53)
        Me.ListDeClientes.MultiSelect = False
        Me.ListDeClientes.Name = "ListDeClientes"
        Me.ListDeClientes.RowHeadersWidth = 15
        Me.ListDeClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListDeClientes.Size = New System.Drawing.Size(648, 249)
        Me.ListDeClientes.StandardTab = True
        Me.ListDeClientes.TabIndex = 20
        '
        'BtNovoRecibo
        '
        Me.BtNovoRecibo.Image = CType(resources.GetObject("BtNovoRecibo.Image"), System.Drawing.Image)
        Me.BtNovoRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtNovoRecibo.Location = New System.Drawing.Point(387, 3)
        Me.BtNovoRecibo.Name = "BtNovoRecibo"
        Me.BtNovoRecibo.Size = New System.Drawing.Size(132, 44)
        Me.BtNovoRecibo.TabIndex = 21
        Me.BtNovoRecibo.Text = "Criar novo recibo"
        Me.BtNovoRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtNovoRecibo.UseVisualStyleBackColor = True
        '
        'BtImprimir
        '
        Me.BtImprimir.Image = CType(resources.GetObject("BtImprimir.Image"), System.Drawing.Image)
        Me.BtImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtImprimir.Location = New System.Drawing.Point(525, 3)
        Me.BtImprimir.Name = "BtImprimir"
        Me.BtImprimir.Size = New System.Drawing.Size(133, 44)
        Me.BtImprimir.TabIndex = 22
        Me.BtImprimir.Text = "Imprimir Recibo Selecionado"
        Me.BtImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtImprimir.UseVisualStyleBackColor = True
        '
        'frmRecibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 314)
        Me.Controls.Add(Me.BtImprimir)
        Me.Controls.Add(Me.BtNovoRecibo)
        Me.Controls.Add(Me.ListDeClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecibos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibos do Cliente"
        Me.TopMost = True
        CType(Me.ListDeClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListDeClientes As DataGridView
    Friend WithEvents BtNovoRecibo As Button
    Friend WithEvents BtImprimir As Button
End Class
