<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Me.salvar = New System.Windows.Forms.SaveFileDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.Barra = New System.Windows.Forms.ToolStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBackup = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblBackup = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbTable = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtLocalSalvar = New System.Windows.Forms.TextBox()
        Me.btCriarBackup = New System.Windows.Forms.Button()
        Me.TabRestaura = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btBuscarBkp = New System.Windows.Forms.Button()
        Me.txtRestaurar = New System.Windows.Forms.TextBox()
        Me.pbRestaurar = New System.Windows.Forms.ProgressBar()
        Me.filerestaurar = New System.Windows.Forms.OpenFileDialog()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Barra.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabBackup.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRestaura.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salvar
        '
        Me.salvar.Filter = "Backup Monitor JJRN|*.jjrnsql"
        Me.salvar.Title = "Salvar Backup"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Timer10
        '
        Me.Timer10.Enabled = True
        Me.Timer10.Interval = 10
        '
        'Barra
        '
        Me.Barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.Barra.Location = New System.Drawing.Point(0, 196)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(483, 25)
        Me.Barra.TabIndex = 47
        Me.Barra.Text = "ToolStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 22)
        Me.lblStatus.Text = "Pronto"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(392, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Restaurar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabBackup)
        Me.TabControl1.Controls.Add(Me.TabRestaura)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(483, 196)
        Me.TabControl1.TabIndex = 49
        '
        'tabBackup
        '
        Me.tabBackup.Controls.Add(Me.PictureBox1)
        Me.tabBackup.Controls.Add(Me.lblBackup)
        Me.tabBackup.Controls.Add(Me.Label1)
        Me.tabBackup.Controls.Add(Me.pbTable)
        Me.tabBackup.Controls.Add(Me.Button3)
        Me.tabBackup.Controls.Add(Me.txtLocalSalvar)
        Me.tabBackup.Controls.Add(Me.btCriarBackup)
        Me.tabBackup.Location = New System.Drawing.Point(4, 22)
        Me.tabBackup.Name = "tabBackup"
        Me.tabBackup.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBackup.Size = New System.Drawing.Size(475, 170)
        Me.tabBackup.TabIndex = 0
        Me.tabBackup.Text = "Criar Backup"
        Me.tabBackup.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Backup.My.Resources.Resources.usbpendrive_unmount2
        Me.PictureBox1.Location = New System.Drawing.Point(407, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'lblBackup
        '
        Me.lblBackup.AutoSize = True
        Me.lblBackup.Location = New System.Drawing.Point(8, 108)
        Me.lblBackup.Name = "lblBackup"
        Me.lblBackup.Size = New System.Drawing.Size(25, 13)
        Me.lblBackup.TabIndex = 57
        Me.lblBackup.Text = "Lab"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Local de salvar o backup"
        '
        'pbTable
        '
        Me.pbTable.Location = New System.Drawing.Point(11, 141)
        Me.pbTable.Name = "pbTable"
        Me.pbTable.Size = New System.Drawing.Size(456, 23)
        Me.pbTable.TabIndex = 55
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(438, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(29, 23)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = ".."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtLocalSalvar
        '
        Me.txtLocalSalvar.BackColor = System.Drawing.Color.White
        Me.txtLocalSalvar.Location = New System.Drawing.Point(8, 72)
        Me.txtLocalSalvar.Name = "txtLocalSalvar"
        Me.txtLocalSalvar.ReadOnly = True
        Me.txtLocalSalvar.Size = New System.Drawing.Size(424, 20)
        Me.txtLocalSalvar.TabIndex = 53
        '
        'btCriarBackup
        '
        Me.btCriarBackup.Enabled = False
        Me.btCriarBackup.Location = New System.Drawing.Point(380, 98)
        Me.btCriarBackup.Name = "btCriarBackup"
        Me.btCriarBackup.Size = New System.Drawing.Size(87, 23)
        Me.btCriarBackup.TabIndex = 52
        Me.btCriarBackup.Text = "Criar Backup"
        Me.btCriarBackup.UseVisualStyleBackColor = True
        '
        'TabRestaura
        '
        Me.TabRestaura.Controls.Add(Me.PictureBox2)
        Me.TabRestaura.Controls.Add(Me.Label2)
        Me.TabRestaura.Controls.Add(Me.btBuscarBkp)
        Me.TabRestaura.Controls.Add(Me.txtRestaurar)
        Me.TabRestaura.Controls.Add(Me.pbRestaurar)
        Me.TabRestaura.Controls.Add(Me.Button2)
        Me.TabRestaura.Location = New System.Drawing.Point(4, 22)
        Me.TabRestaura.Name = "TabRestaura"
        Me.TabRestaura.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRestaura.Size = New System.Drawing.Size(475, 170)
        Me.TabRestaura.TabIndex = 1
        Me.TabRestaura.Text = "Restaurar Banco de dados"
        Me.TabRestaura.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Backup.My.Resources.Resources.Black_Drive
        Me.PictureBox2.Location = New System.Drawing.Point(409, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Local do arquivo de backup"
        '
        'btBuscarBkp
        '
        Me.btBuscarBkp.Location = New System.Drawing.Point(440, 82)
        Me.btBuscarBkp.Name = "btBuscarBkp"
        Me.btBuscarBkp.Size = New System.Drawing.Size(29, 23)
        Me.btBuscarBkp.TabIndex = 58
        Me.btBuscarBkp.Text = ".."
        Me.btBuscarBkp.UseVisualStyleBackColor = True
        '
        'txtRestaurar
        '
        Me.txtRestaurar.BackColor = System.Drawing.Color.White
        Me.txtRestaurar.Location = New System.Drawing.Point(17, 82)
        Me.txtRestaurar.Name = "txtRestaurar"
        Me.txtRestaurar.ReadOnly = True
        Me.txtRestaurar.Size = New System.Drawing.Size(417, 20)
        Me.txtRestaurar.TabIndex = 57
        '
        'pbRestaurar
        '
        Me.pbRestaurar.Location = New System.Drawing.Point(6, 141)
        Me.pbRestaurar.Name = "pbRestaurar"
        Me.pbRestaurar.Size = New System.Drawing.Size(461, 23)
        Me.pbRestaurar.TabIndex = 56
        '
        'filerestaurar
        '
        Me.filerestaurar.Filter = "Backup Monitor JJRN|*.jjrnsql"
        Me.filerestaurar.Title = "Selecione o backup"
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 221)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup / Restaurar"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Barra.ResumeLayout(False)
        Me.Barra.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabBackup.ResumeLayout(False)
        Me.tabBackup.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRestaura.ResumeLayout(False)
        Me.TabRestaura.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents salvar As SaveFileDialog
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Timer10 As Timer
    Friend WithEvents Barra As ToolStrip
    Friend WithEvents lblStatus As ToolStripLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabBackup As TabPage
    Friend WithEvents pbTable As ProgressBar
    Friend WithEvents Button3 As Button
    Friend WithEvents txtLocalSalvar As TextBox
    Friend WithEvents btCriarBackup As Button
    Friend WithEvents TabRestaura As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents pbRestaurar As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents btBuscarBkp As Button
    Friend WithEvents txtRestaurar As TextBox
    Friend WithEvents filerestaurar As OpenFileDialog
    Friend WithEvents lblBackup As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
