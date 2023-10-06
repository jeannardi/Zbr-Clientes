<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAdmin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtSalvar = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.brModificar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(15, 210)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(134, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Telefone (Contato)"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(15, 259)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.ReadOnly = True
        Me.txtSenha.Size = New System.Drawing.Size(134, 20)
        Me.txtSenha.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Senha:"
        '
        'BtSalvar
        '
        Me.BtSalvar.Enabled = False
        Me.BtSalvar.Location = New System.Drawing.Point(202, 318)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(86, 35)
        Me.BtSalvar.TabIndex = 5
        Me.BtSalvar.Text = "Salvar"
        Me.BtSalvar.UseVisualStyleBackColor = True
        '
        'btExcluir
        '
        Me.btExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btExcluir.Enabled = False
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExcluir.ForeColor = System.Drawing.Color.White
        Me.btExcluir.Location = New System.Drawing.Point(386, 318)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(86, 35)
        Me.btExcluir.TabIndex = 6
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.UseVisualStyleBackColor = False
        '
        'btNovo
        '
        Me.btNovo.Location = New System.Drawing.Point(15, 318)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(86, 35)
        Me.btNovo.TabIndex = 4
        Me.btNovo.Text = "Novo"
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(155, 262)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Administrador Usuarios"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.Blue
        Me.DataGridView1.Location = New System.Drawing.Point(15, 21)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(457, 144)
        Me.DataGridView1.TabIndex = 7
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(155, 210)
        Me.txtTelefone.Mask = "(99) 000-000000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.ReadOnly = True
        Me.txtTelefone.Size = New System.Drawing.Size(139, 20)
        Me.txtTelefone.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Selecione o usuario:"
        '
        'brModificar
        '
        Me.brModificar.Location = New System.Drawing.Point(107, 318)
        Me.brModificar.Name = "brModificar"
        Me.brModificar.Size = New System.Drawing.Size(86, 35)
        Me.brModificar.TabIndex = 9
        Me.brModificar.Text = "Alterar"
        Me.brModificar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Enabled = False
        Me.btCancelar.Location = New System.Drawing.Point(294, 318)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(86, 35)
        Me.btCancelar.TabIndex = 10
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Zbr_Controle_de_Clientes.My.Resources.Resources.contactlist_theuser_802
        Me.PictureBox1.Location = New System.Drawing.Point(331, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 133)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmUserAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 365)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.brModificar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.BtSalvar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUserAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtSalvar As Button
    Friend WithEvents btExcluir As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents brModificar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
