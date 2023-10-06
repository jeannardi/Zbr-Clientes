<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipamentosadd
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEquipamentosadd))
        Me.TxtMaterial = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtData = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.CmbPago = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtSalvar = New System.Windows.Forms.Button()
        Me.txtDataRecibo = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtMaterial
        '
        Me.TxtMaterial.Location = New System.Drawing.Point(12, 111)
        Me.TxtMaterial.Name = "TxtMaterial"
        Me.TxtMaterial.Size = New System.Drawing.Size(182, 20)
        Me.TxtMaterial.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Material"
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(12, 71)
        Me.TxtData.Mask = "00/00/0000"
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(182, 20)
        Me.TxtData.TabIndex = 1
        Me.TxtData.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Data da troca"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(200, 111)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(102, 20)
        Me.TxtValor.TabIndex = 4
        '
        'CmbPago
        '
        Me.CmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPago.FormattingEnabled = True
        Me.CmbPago.Items.AddRange(New Object() {"Sim", "Não"})
        Me.CmbPago.Location = New System.Drawing.Point(200, 71)
        Me.CmbPago.Name = "CmbPago"
        Me.CmbPago.Size = New System.Drawing.Size(102, 21)
        Me.CmbPago.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Valor"
        '
        'BtSalvar
        '
        Me.BtSalvar.Image = CType(resources.GetObject("BtSalvar.Image"), System.Drawing.Image)
        Me.BtSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSalvar.Location = New System.Drawing.Point(221, 137)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(81, 38)
        Me.BtSalvar.TabIndex = 5
        Me.BtSalvar.Text = "Salvar"
        Me.BtSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtSalvar.UseVisualStyleBackColor = True
        '
        'txtDataRecibo
        '
        Me.txtDataRecibo.Location = New System.Drawing.Point(136, 25)
        Me.txtDataRecibo.Mask = "00/00/0000"
        Me.txtDataRecibo.Name = "txtDataRecibo"
        Me.txtDataRecibo.Size = New System.Drawing.Size(166, 20)
        Me.txtDataRecibo.TabIndex = 0
        Me.txtDataRecibo.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(133, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Data Recibo (Click para Hoje)"
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(136, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 38)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmEquipamentosadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 181)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDataRecibo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtSalvar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbPago)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMaterial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEquipamentosadd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Equipamentos novo registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtMaterial As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtData As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents CmbPago As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtSalvar As Button
    Friend WithEvents txtDataRecibo As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
