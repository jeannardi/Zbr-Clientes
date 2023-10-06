<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModelPag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModelPag))
        Me.ListDeClientes = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btcarrega = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.ListDeClientes.Location = New System.Drawing.Point(12, 69)
        Me.ListDeClientes.MultiSelect = False
        Me.ListDeClientes.Name = "ListDeClientes"
        Me.ListDeClientes.RowHeadersWidth = 15
        Me.ListDeClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListDeClientes.Size = New System.Drawing.Size(647, 478)
        Me.ListDeClientes.StandardTab = True
        Me.ListDeClientes.TabIndex = 19
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Promoção", "Anual", "Mensal"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox1.TabIndex = 20
        '
        'btcarrega
        '
        Me.btcarrega.Location = New System.Drawing.Point(182, 6)
        Me.btcarrega.Name = "btcarrega"
        Me.btcarrega.Size = New System.Drawing.Size(83, 21)
        Me.btcarrega.TabIndex = 21
        Me.btcarrega.Text = "&Atualizar"
        Me.btcarrega.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 21)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Gerar PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Mensal (0)         Anual (0)         Promoção (0)         "
        '
        'frmModelPag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 559)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btcarrega)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListDeClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModelPag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modelo de pagamento dos clientes"
        CType(Me.ListDeClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListDeClientes As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btcarrega As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
