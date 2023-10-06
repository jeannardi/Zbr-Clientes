<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusca))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.ListDeClientes = New System.Windows.Forms.DataGridView()
        Me.btPDF = New System.Windows.Forms.Button()
        CType(Me.ListDeClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Filtro:"
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(515, 7)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 21
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(177, 8)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(332, 20)
        Me.txtFiltro.TabIndex = 20
        '
        'cmbFiltro
        '
        Me.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"Cliente", "Alarme Codigo", "Endereço do Alarme", "Nume da Casa", "Data Contrato", "Sem Data de Contrato"})
        Me.cmbFiltro.Location = New System.Drawing.Point(50, 7)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 19
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
        Me.ListDeClientes.Location = New System.Drawing.Point(5, 36)
        Me.ListDeClientes.MultiSelect = False
        Me.ListDeClientes.Name = "ListDeClientes"
        Me.ListDeClientes.RowHeadersWidth = 15
        Me.ListDeClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListDeClientes.Size = New System.Drawing.Size(774, 457)
        Me.ListDeClientes.StandardTab = True
        Me.ListDeClientes.TabIndex = 18
        '
        'btPDF
        '
        Me.btPDF.Location = New System.Drawing.Point(596, 7)
        Me.btPDF.Name = "btPDF"
        Me.btPDF.Size = New System.Drawing.Size(101, 23)
        Me.btPDF.TabIndex = 23
        Me.btPDF.Text = "Lista Em PDF"
        Me.btPDF.UseVisualStyleBackColor = True
        '
        'frmBusca
        '
        Me.AcceptButton = Me.btBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 497)
        Me.Controls.Add(Me.btPDF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.ListDeClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBusca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecionar Cliente"
        CType(Me.ListDeClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents cmbFiltro As ComboBox
    Friend WithEvents ListDeClientes As DataGridView
    Friend WithEvents btPDF As Button
End Class
