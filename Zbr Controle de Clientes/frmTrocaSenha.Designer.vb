<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrocaSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrocaSenha))
        Me.txtSenhaAtual = New System.Windows.Forms.TextBox()
        Me.txtNovaSenha = New System.Windows.Forms.TextBox()
        Me.btAlterar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSenhaAtual
        '
        Me.txtSenhaAtual.Location = New System.Drawing.Point(96, 28)
        Me.txtSenhaAtual.Name = "txtSenhaAtual"
        Me.txtSenhaAtual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaAtual.Size = New System.Drawing.Size(142, 20)
        Me.txtSenhaAtual.TabIndex = 0
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.Location = New System.Drawing.Point(96, 73)
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaSenha.Size = New System.Drawing.Size(142, 20)
        Me.txtNovaSenha.TabIndex = 1
        '
        'btAlterar
        '
        Me.btAlterar.Location = New System.Drawing.Point(168, 114)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(70, 30)
        Me.btAlterar.TabIndex = 2
        Me.btAlterar.Text = "Alterar"
        Me.btAlterar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(98, 114)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(64, 30)
        Me.btCancelar.TabIndex = 3
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Senha Atual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nova Senha"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 66)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmTrocaSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 153)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btAlterar)
        Me.Controls.Add(Me.txtNovaSenha)
        Me.Controls.Add(Me.txtSenhaAtual)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmTrocaSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alterar Senha"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSenhaAtual As TextBox
    Friend WithEvents txtNovaSenha As TextBox
    Friend WithEvents btAlterar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
