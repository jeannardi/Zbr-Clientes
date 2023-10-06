<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEquipamentos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEquipamentos))
        Me.ListDeClientes = New System.Windows.Forms.DataGridView()
        Me.BtReciboNovo = New System.Windows.Forms.Button()
        Me.BtNovo = New System.Windows.Forms.Button()
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
        Me.ListDeClientes.GridColor = System.Drawing.Color.RoyalBlue
        Me.ListDeClientes.Location = New System.Drawing.Point(12, 73)
        Me.ListDeClientes.MultiSelect = False
        Me.ListDeClientes.Name = "ListDeClientes"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListDeClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ListDeClientes.RowHeadersWidth = 15
        Me.ListDeClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListDeClientes.Size = New System.Drawing.Size(774, 396)
        Me.ListDeClientes.StandardTab = True
        Me.ListDeClientes.TabIndex = 20
        '
        'BtReciboNovo
        '
        Me.BtReciboNovo.Image = CType(resources.GetObject("BtReciboNovo.Image"), System.Drawing.Image)
        Me.BtReciboNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtReciboNovo.Location = New System.Drawing.Point(152, 4)
        Me.BtReciboNovo.Name = "BtReciboNovo"
        Me.BtReciboNovo.Size = New System.Drawing.Size(147, 63)
        Me.BtReciboNovo.TabIndex = 22
        Me.BtReciboNovo.Text = "Recibo / Imprimir"
        Me.BtReciboNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtReciboNovo.UseVisualStyleBackColor = True
        '
        'BtNovo
        '
        Me.BtNovo.Image = CType(resources.GetObject("BtNovo.Image"), System.Drawing.Image)
        Me.BtNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtNovo.Location = New System.Drawing.Point(12, 4)
        Me.BtNovo.Name = "BtNovo"
        Me.BtNovo.Size = New System.Drawing.Size(134, 63)
        Me.BtNovo.TabIndex = 21
        Me.BtNovo.Text = "Novo registro"
        Me.BtNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtNovo.UseVisualStyleBackColor = True
        '
        'FrmEquipamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 481)
        Me.Controls.Add(Me.BtReciboNovo)
        Me.Controls.Add(Me.BtNovo)
        Me.Controls.Add(Me.ListDeClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEquipamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipamentos"
        CType(Me.ListDeClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListDeClientes As DataGridView
    Friend WithEvents BtNovo As Button
    Friend WithEvents BtReciboNovo As Button
End Class
