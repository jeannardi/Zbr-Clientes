<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblNotifica = New System.Windows.Forms.Label()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btAlterar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbPagamento = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtMensalValor = New System.Windows.Forms.TextBox()
        Me.txtDataContrato = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAutorizados = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEndereNumeroAlarme = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEnderecoAlarme = New System.Windows.Forms.TextBox()
        Me.txtAlarmeCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblCPFVerificado = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.CheckCNPJ = New System.Windows.Forms.CheckBox()
        Me.CheckCPF = New System.Windows.Forms.CheckBox()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtCelular3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCelular2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCelular1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btRMensalP = New System.Windows.Forms.Button()
        Me.pbPendentes = New System.Windows.Forms.ProgressBar()
        Me.btAtualizaMes = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ListaPendentes = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtgvEquipamentos = New System.Windows.Forms.DataGridView()
        Me.btAtualizaEquipamentos = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btAtualiza = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dataGridAniversario = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DGVContratos = New System.Windows.Forms.DataGridView()
        Me.BtAtualizaContratadoAniver = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btBuscaCliente = New System.Windows.Forms.ToolStripButton()
        Me.btMensalidade = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btEquipamento = New System.Windows.Forms.ToolStripButton()
        Me.btRecibo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btBackup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LBLIP = New System.Windows.Forms.ToolStripLabel()
        Me.btLogin = New System.Windows.Forms.ToolStripSplitButton()
        Me.btTrocarSenha = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ListaPendentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dtgvEquipamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dataGridAniversario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DGVContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "user_add.png")
        Me.ImageList1.Images.SetKeyName(1, "arrow_back_cancel_media_previous_redo_refresh-512.png")
        Me.ImageList1.Images.SetKeyName(2, "user cancel.png")
        Me.ImageList1.Images.SetKeyName(3, "save user.png")
        Me.ImageList1.Images.SetKeyName(4, "user excluir.png")
        Me.ImageList1.Images.SetKeyName(5, "xx.png")
        Me.ImageList1.Images.SetKeyName(6, "pendente.png")
        Me.ImageList1.Images.SetKeyName(7, "newupdate.png")
        Me.ImageList1.Images.SetKeyName(8, "Apple-Timemachine-Border-icon.png")
        Me.ImageList1.Images.SetKeyName(9, "atrasado48.png")
        Me.ImageList1.Images.SetKeyName(10, "document-archive-icon.png")
        Me.ImageList1.Images.SetKeyName(11, "aniver.png")
        Me.ImageList1.Images.SetKeyName(12, "Folder-Sync-icon.png")
        Me.ImageList1.Images.SetKeyName(13, "Calender-icon.png")
        Me.ImageList1.Images.SetKeyName(14, "System-Calendar-icon.png")
        Me.ImageList1.Images.SetKeyName(15, "calendar-selection-all-icon.png")
        Me.ImageList1.Images.SetKeyName(16, "Actions-contact-date-icon.png")
        Me.ImageList1.Images.SetKeyName(17, "contactlist_theuser_802.png")
        Me.ImageList1.Images.SetKeyName(18, "addusergroup_1251.png")
        Me.ImageList1.Images.SetKeyName(19, "keepintouchwiththenew_1216.png")
        Me.ImageList1.Images.SetKeyName(20, "accept_ok_user_16735.png")
        Me.ImageList1.Images.SetKeyName(21, "delete_remove_user_16732.png")
        Me.ImageList1.Images.SetKeyName(22, "Actions-contact-new-icon.png")
        Me.ImageList1.Images.SetKeyName(23, "aniverhj.png")
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(11, 89)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(972, 631)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.lblNotifica)
        Me.TabPage1.Controls.Add(Me.btExcluir)
        Me.TabPage1.Controls.Add(Me.btCancelar)
        Me.TabPage1.Controls.Add(Me.btSalvar)
        Me.TabPage1.Controls.Add(Me.btAlterar)
        Me.TabPage1.Controls.Add(Me.btNovo)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.ImageKey = "xx.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 55)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(964, 572)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = " Registro do Cliente"
        '
        'lblNotifica
        '
        Me.lblNotifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNotifica.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotifica.ForeColor = System.Drawing.Color.White
        Me.lblNotifica.Image = CType(resources.GetObject("lblNotifica.Image"), System.Drawing.Image)
        Me.lblNotifica.Location = New System.Drawing.Point(6, 3)
        Me.lblNotifica.Name = "lblNotifica"
        Me.lblNotifica.Size = New System.Drawing.Size(952, 27)
        Me.lblNotifica.TabIndex = 23
        Me.lblNotifica.Text = "Última atualização [2022-03-17 03:03:16] feita pelo usuario: Jean"
        Me.lblNotifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNotifica.Visible = False
        '
        'btExcluir
        '
        Me.btExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.btExcluir.Enabled = False
        Me.btExcluir.ForeColor = System.Drawing.Color.Red
        Me.btExcluir.ImageKey = "user excluir.png"
        Me.btExcluir.ImageList = Me.ImageList1
        Me.btExcluir.Location = New System.Drawing.Point(853, 496)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(105, 70)
        Me.btExcluir.TabIndex = 23
        Me.btExcluir.Text = "Excluir Cadastro"
        Me.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btExcluir.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btCancelar.Enabled = False
        Me.btCancelar.ImageKey = "user cancel.png"
        Me.btCancelar.ImageList = Me.ImageList1
        Me.btCancelar.Location = New System.Drawing.Point(371, 496)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(105, 70)
        Me.btCancelar.TabIndex = 22
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btSalvar
        '
        Me.btSalvar.BackColor = System.Drawing.SystemColors.Control
        Me.btSalvar.Enabled = False
        Me.btSalvar.ForeColor = System.Drawing.Color.Teal
        Me.btSalvar.ImageKey = "save user.png"
        Me.btSalvar.ImageList = Me.ImageList1
        Me.btSalvar.Location = New System.Drawing.Point(260, 496)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(105, 70)
        Me.btSalvar.TabIndex = 21
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'btAlterar
        '
        Me.btAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.btAlterar.Enabled = False
        Me.btAlterar.ForeColor = System.Drawing.Color.Teal
        Me.btAlterar.ImageKey = "contactlist_theuser_802.png"
        Me.btAlterar.ImageList = Me.ImageList1
        Me.btAlterar.Location = New System.Drawing.Point(116, 496)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(105, 70)
        Me.btAlterar.TabIndex = 20
        Me.btAlterar.Text = "Modificar Cadastro"
        Me.btAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btAlterar.UseVisualStyleBackColor = False
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.SystemColors.Control
        Me.btNovo.ForeColor = System.Drawing.Color.Green
        Me.btNovo.ImageKey = "Actions-contact-new-icon.png"
        Me.btNovo.ImageList = Me.ImageList1
        Me.btNovo.Location = New System.Drawing.Point(5, 496)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(105, 70)
        Me.btNovo.TabIndex = 20
        Me.btNovo.Text = "Novo Cliente"
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.cmbPagamento)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TxtMensalValor)
        Me.GroupBox2.Controls.Add(Me.txtDataContrato)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtAutorizados)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtEndereNumeroAlarme)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtEnderecoAlarme)
        Me.GroupBox2.Controls.Add(Me.txtAlarmeCodigo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 285)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(952, 205)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações do Alarme"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(371, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(113, 13)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Modelo de pagamento"
        '
        'cmbPagamento
        '
        Me.cmbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPagamento.Enabled = False
        Me.cmbPagamento.FormattingEnabled = True
        Me.cmbPagamento.Items.AddRange(New Object() {"", "Anual", "Mensal", "Promoção"})
        Me.cmbPagamento.Location = New System.Drawing.Point(374, 43)
        Me.cmbPagamento.Name = "cmbPagamento"
        Me.cmbPagamento.Size = New System.Drawing.Size(141, 21)
        Me.cmbPagamento.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(240, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 13)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Mensalidade valor"
        '
        'TxtMensalValor
        '
        Me.TxtMensalValor.Location = New System.Drawing.Point(243, 44)
        Me.TxtMensalValor.MaxLength = 10
        Me.TxtMensalValor.Name = "TxtMensalValor"
        Me.TxtMensalValor.ReadOnly = True
        Me.TxtMensalValor.Size = New System.Drawing.Size(125, 20)
        Me.TxtMensalValor.TabIndex = 15
        '
        'txtDataContrato
        '
        Me.txtDataContrato.Location = New System.Drawing.Point(110, 44)
        Me.txtDataContrato.Mask = "00/00/0000"
        Me.txtDataContrato.Name = "txtDataContrato"
        Me.txtDataContrato.ReadOnly = True
        Me.txtDataContrato.Size = New System.Drawing.Size(127, 20)
        Me.txtDataContrato.TabIndex = 14
        Me.txtDataContrato.Text = "00000000"
        Me.txtDataContrato.ValidatingType = GetType(Date)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(107, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Data do Inicio Contrato"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Autorizados"
        '
        'txtAutorizados
        '
        Me.txtAutorizados.Location = New System.Drawing.Point(9, 125)
        Me.txtAutorizados.MaxLength = 450
        Me.txtAutorizados.Multiline = True
        Me.txtAutorizados.Name = "txtAutorizados"
        Me.txtAutorizados.ReadOnly = True
        Me.txtAutorizados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAutorizados.Size = New System.Drawing.Size(506, 66)
        Me.txtAutorizados.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(444, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Numero"
        '
        'txtEndereNumeroAlarme
        '
        Me.txtEndereNumeroAlarme.Location = New System.Drawing.Point(447, 85)
        Me.txtEndereNumeroAlarme.MaxLength = 10
        Me.txtEndereNumeroAlarme.Name = "txtEndereNumeroAlarme"
        Me.txtEndereNumeroAlarme.ReadOnly = True
        Me.txtEndereNumeroAlarme.Size = New System.Drawing.Size(68, 20)
        Me.txtEndereNumeroAlarme.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Endereço"
        '
        'txtEnderecoAlarme
        '
        Me.txtEnderecoAlarme.Location = New System.Drawing.Point(9, 85)
        Me.txtEnderecoAlarme.Name = "txtEnderecoAlarme"
        Me.txtEnderecoAlarme.ReadOnly = True
        Me.txtEnderecoAlarme.Size = New System.Drawing.Size(432, 20)
        Me.txtEnderecoAlarme.TabIndex = 17
        '
        'txtAlarmeCodigo
        '
        Me.txtAlarmeCodigo.HidePromptOnLeave = True
        Me.txtAlarmeCodigo.Location = New System.Drawing.Point(9, 44)
        Me.txtAlarmeCodigo.Mask = "000000"
        Me.txtAlarmeCodigo.Name = "txtAlarmeCodigo"
        Me.txtAlarmeCodigo.ReadOnly = True
        Me.txtAlarmeCodigo.Size = New System.Drawing.Size(82, 20)
        Me.txtAlarmeCodigo.TabIndex = 13
        Me.txtAlarmeCodigo.ValidatingType = GetType(Integer)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Alarme Codigo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LblCPFVerificado)
        Me.GroupBox1.Controls.Add(Me.txtCPF)
        Me.GroupBox1.Controls.Add(Me.CheckCNPJ)
        Me.GroupBox1.Controls.Add(Me.CheckCPF)
        Me.GroupBox1.Controls.Add(Me.txtCep)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtObservacao)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDataNascimento)
        Me.GroupBox1.Controls.Add(Me.txtCelular3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCelular2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCelular1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(6, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(952, 253)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'LblCPFVerificado
        '
        Me.LblCPFVerificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCPFVerificado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblCPFVerificado.Location = New System.Drawing.Point(484, 23)
        Me.LblCPFVerificado.Name = "LblCPFVerificado"
        Me.LblCPFVerificado.Size = New System.Drawing.Size(85, 15)
        Me.LblCPFVerificado.TabIndex = 46
        Me.LblCPFVerificado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(385, 41)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.ReadOnly = True
        Me.txtCPF.Size = New System.Drawing.Size(184, 20)
        Me.txtCPF.TabIndex = 1
        '
        'CheckCNPJ
        '
        Me.CheckCNPJ.AutoSize = True
        Me.CheckCNPJ.Enabled = False
        Me.CheckCNPJ.Location = New System.Drawing.Point(437, 25)
        Me.CheckCNPJ.Name = "CheckCNPJ"
        Me.CheckCNPJ.Size = New System.Drawing.Size(53, 17)
        Me.CheckCNPJ.TabIndex = 45
        Me.CheckCNPJ.Text = "CNPJ"
        Me.CheckCNPJ.UseVisualStyleBackColor = True
        '
        'CheckCPF
        '
        Me.CheckCPF.AutoSize = True
        Me.CheckCPF.Checked = True
        Me.CheckCPF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckCPF.Enabled = False
        Me.CheckCPF.Location = New System.Drawing.Point(385, 25)
        Me.CheckCPF.Name = "CheckCPF"
        Me.CheckCPF.Size = New System.Drawing.Size(46, 17)
        Me.CheckCPF.TabIndex = 44
        Me.CheckCPF.Text = "CPF"
        Me.CheckCPF.UseVisualStyleBackColor = True
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(711, 41)
        Me.txtCep.Mask = "00000-999"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.ReadOnly = True
        Me.txtCep.ResetOnPrompt = False
        Me.txtCep.ResetOnSpace = False
        Me.txtCep.Size = New System.Drawing.Size(158, 20)
        Me.txtCep.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Observações"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(9, 178)
        Me.txtObservacao.MaxLength = 450
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ReadOnly = True
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(570, 66)
        Me.txtObservacao.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(572, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Data de Nascimento"
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.Location = New System.Drawing.Point(575, 41)
        Me.txtDataNascimento.Mask = "00/00/0000"
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.ReadOnly = True
        Me.txtDataNascimento.Size = New System.Drawing.Size(127, 20)
        Me.txtDataNascimento.TabIndex = 3
        Me.txtDataNascimento.Text = "00000000"
        Me.txtDataNascimento.ValidatingType = GetType(Date)
        '
        'txtCelular3
        '
        Me.txtCelular3.Location = New System.Drawing.Point(229, 137)
        Me.txtCelular3.Mask = "(99) 00000-0000"
        Me.txtCelular3.Name = "txtCelular3"
        Me.txtCelular3.ReadOnly = True
        Me.txtCelular3.Size = New System.Drawing.Size(104, 20)
        Me.txtCelular3.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(226, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Celular 3"
        '
        'txtCelular2
        '
        Me.txtCelular2.Location = New System.Drawing.Point(119, 137)
        Me.txtCelular2.Mask = "(99) 00000-0000"
        Me.txtCelular2.Name = "txtCelular2"
        Me.txtCelular2.ReadOnly = True
        Me.txtCelular2.Size = New System.Drawing.Size(104, 20)
        Me.txtCelular2.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(116, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Celular 2"
        '
        'txtCelular1
        '
        Me.txtCelular1.Location = New System.Drawing.Point(9, 137)
        Me.txtCelular1.Mask = "(99) 00000-0000"
        Me.txtCelular1.Name = "txtCelular1"
        Me.txtCelular1.ReadOnly = True
        Me.txtCelular1.Size = New System.Drawing.Size(104, 20)
        Me.txtCelular1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(336, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(339, 137)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(240, 20)
        Me.txtEmail.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Celular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(708, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Ceep"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(599, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Cidade"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(602, 80)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.ReadOnly = True
        Me.txtCidade.Size = New System.Drawing.Size(267, 20)
        Me.txtCidade.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(363, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Bairro"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(366, 80)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.ReadOnly = True
        Me.txtBairro.Size = New System.Drawing.Size(230, 20)
        Me.txtBairro.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Endereço"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(9, 80)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.ReadOnly = True
        Me.txtEndereco.Size = New System.Drawing.Size(351, 20)
        Me.txtEndereco.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nome do Cliente"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(8, 41)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.ReadOnly = True
        Me.txtNome.Size = New System.Drawing.Size(371, 20)
        Me.txtNome.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btRMensalP)
        Me.TabPage2.Controls.Add(Me.pbPendentes)
        Me.TabPage2.Controls.Add(Me.btAtualizaMes)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.DateTimePicker1)
        Me.TabPage2.Controls.Add(Me.ListaPendentes)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.ImageKey = "Actions-contact-date-icon.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 55)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(964, 572)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Relatorio Mensalidades Pendentes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btRMensalP
        '
        Me.btRMensalP.Location = New System.Drawing.Point(334, 42)
        Me.btRMensalP.Name = "btRMensalP"
        Me.btRMensalP.Size = New System.Drawing.Size(118, 26)
        Me.btRMensalP.TabIndex = 25
        Me.btRMensalP.Text = "Avançado (Periodo)"
        Me.btRMensalP.UseVisualStyleBackColor = True
        '
        'pbPendentes
        '
        Me.pbPendentes.Location = New System.Drawing.Point(737, 74)
        Me.pbPendentes.Name = "pbPendentes"
        Me.pbPendentes.Size = New System.Drawing.Size(221, 26)
        Me.pbPendentes.TabIndex = 23
        Me.pbPendentes.Visible = False
        '
        'btAtualizaMes
        '
        Me.btAtualizaMes.Location = New System.Drawing.Point(238, 42)
        Me.btAtualizaMes.Name = "btAtualizaMes"
        Me.btAtualizaMes.Size = New System.Drawing.Size(90, 26)
        Me.btAtualizaMes.TabIndex = 22
        Me.btAtualizaMes.Text = "Atualizar Lista"
        Me.btAtualizaMes.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(67, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Mês / Ano"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMM - yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(70, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(162, 26)
        Me.DateTimePicker1.TabIndex = 20
        '
        'ListaPendentes
        '
        Me.ListaPendentes.AllowUserToAddRows = False
        Me.ListaPendentes.AllowUserToDeleteRows = False
        Me.ListaPendentes.AllowUserToResizeRows = False
        Me.ListaPendentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPendentes.BackgroundColor = System.Drawing.Color.White
        Me.ListaPendentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ListaPendentes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ListaPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaPendentes.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListaPendentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ListaPendentes.GridColor = System.Drawing.SystemColors.HotTrack
        Me.ListaPendentes.Location = New System.Drawing.Point(6, 74)
        Me.ListaPendentes.MultiSelect = False
        Me.ListaPendentes.Name = "ListaPendentes"
        Me.ListaPendentes.RowHeadersWidth = 15
        Me.ListaPendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaPendentes.Size = New System.Drawing.Size(952, 491)
        Me.ListaPendentes.StandardTab = True
        Me.ListaPendentes.TabIndex = 19
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.dtgvEquipamentos)
        Me.TabPage4.Controls.Add(Me.btAtualizaEquipamentos)
        Me.TabPage4.ImageKey = "Folder-Sync-icon.png"
        Me.TabPage4.Location = New System.Drawing.Point(4, 55)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(964, 572)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Equipamentos a receber"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(284, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Clientes / Equipamentos que não foram pagos"
        '
        'dtgvEquipamentos
        '
        Me.dtgvEquipamentos.AllowUserToAddRows = False
        Me.dtgvEquipamentos.AllowUserToDeleteRows = False
        Me.dtgvEquipamentos.AllowUserToResizeRows = False
        Me.dtgvEquipamentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgvEquipamentos.BackgroundColor = System.Drawing.Color.White
        Me.dtgvEquipamentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgvEquipamentos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dtgvEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvEquipamentos.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgvEquipamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgvEquipamentos.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dtgvEquipamentos.Location = New System.Drawing.Point(3, 51)
        Me.dtgvEquipamentos.MultiSelect = False
        Me.dtgvEquipamentos.Name = "dtgvEquipamentos"
        Me.dtgvEquipamentos.RowHeadersWidth = 15
        Me.dtgvEquipamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvEquipamentos.Size = New System.Drawing.Size(952, 491)
        Me.dtgvEquipamentos.StandardTab = True
        Me.dtgvEquipamentos.TabIndex = 20
        '
        'btAtualizaEquipamentos
        '
        Me.btAtualizaEquipamentos.Image = CType(resources.GetObject("btAtualizaEquipamentos.Image"), System.Drawing.Image)
        Me.btAtualizaEquipamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAtualizaEquipamentos.Location = New System.Drawing.Point(758, 3)
        Me.btAtualizaEquipamentos.Name = "btAtualizaEquipamentos"
        Me.btAtualizaEquipamentos.Size = New System.Drawing.Size(197, 42)
        Me.btAtualizaEquipamentos.TabIndex = 21
        Me.btAtualizaEquipamentos.Text = "Atualizar   "
        Me.btAtualizaEquipamentos.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btAtualiza)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.dataGridAniversario)
        Me.TabPage3.ImageKey = "aniver.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 55)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(964, 572)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Aniversarios"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btAtualiza
        '
        Me.btAtualiza.Location = New System.Drawing.Point(231, 23)
        Me.btAtualiza.Name = "btAtualiza"
        Me.btAtualiza.Size = New System.Drawing.Size(136, 26)
        Me.btAtualiza.TabIndex = 22
        Me.btAtualiza.Text = "Visualizar/Atualizar"
        Me.btAtualiza.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(213, 20)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Aniversarios dentro de 7 dias"
        '
        'dataGridAniversario
        '
        Me.dataGridAniversario.AllowUserToAddRows = False
        Me.dataGridAniversario.AllowUserToDeleteRows = False
        Me.dataGridAniversario.AllowUserToResizeRows = False
        Me.dataGridAniversario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridAniversario.BackgroundColor = System.Drawing.Color.White
        Me.dataGridAniversario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataGridAniversario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dataGridAniversario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridAniversario.Cursor = System.Windows.Forms.Cursors.Default
        Me.dataGridAniversario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dataGridAniversario.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dataGridAniversario.Location = New System.Drawing.Point(6, 50)
        Me.dataGridAniversario.MultiSelect = False
        Me.dataGridAniversario.Name = "dataGridAniversario"
        Me.dataGridAniversario.RowHeadersWidth = 15
        Me.dataGridAniversario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridAniversario.Size = New System.Drawing.Size(952, 491)
        Me.dataGridAniversario.StandardTab = True
        Me.dataGridAniversario.TabIndex = 20
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DGVContratos)
        Me.TabPage5.Controls.Add(Me.BtAtualizaContratadoAniver)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.ImageKey = "aniver.png"
        Me.TabPage5.Location = New System.Drawing.Point(4, 55)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(964, 572)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Aniver Contratos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'DGVContratos
        '
        Me.DGVContratos.AllowUserToAddRows = False
        Me.DGVContratos.AllowUserToDeleteRows = False
        Me.DGVContratos.AllowUserToResizeRows = False
        Me.DGVContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVContratos.BackgroundColor = System.Drawing.Color.White
        Me.DGVContratos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVContratos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGVContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVContratos.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGVContratos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVContratos.GridColor = System.Drawing.SystemColors.HotTrack
        Me.DGVContratos.Location = New System.Drawing.Point(6, 41)
        Me.DGVContratos.MultiSelect = False
        Me.DGVContratos.Name = "DGVContratos"
        Me.DGVContratos.RowHeadersWidth = 15
        Me.DGVContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVContratos.Size = New System.Drawing.Size(952, 491)
        Me.DGVContratos.StandardTab = True
        Me.DGVContratos.TabIndex = 26
        '
        'BtAtualizaContratadoAniver
        '
        Me.BtAtualizaContratadoAniver.Location = New System.Drawing.Point(231, 14)
        Me.BtAtualizaContratadoAniver.Name = "BtAtualizaContratadoAniver"
        Me.BtAtualizaContratadoAniver.Size = New System.Drawing.Size(136, 26)
        Me.BtAtualizaContratadoAniver.TabIndex = 25
        Me.BtAtualizaContratadoAniver.Text = "Visualizar/Atualizar"
        Me.BtAtualizaContratadoAniver.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(213, 20)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Aniversarios dentro de 7 dias"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btBuscaCliente, Me.btMensalidade, Me.ToolStripSeparator1, Me.btEquipamento, Me.btRecibo, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.btUsuarios, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.btBackup, Me.ToolStripSeparator4, Me.LBLIP, Me.btLogin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(990, 86)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btBuscaCliente
        '
        Me.btBuscaCliente.Image = CType(resources.GetObject("btBuscaCliente.Image"), System.Drawing.Image)
        Me.btBuscaCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBuscaCliente.Name = "btBuscaCliente"
        Me.btBuscaCliente.Size = New System.Drawing.Size(93, 83)
        Me.btBuscaCliente.Text = "Procurar Ciente"
        Me.btBuscaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btBuscaCliente.ToolTipText = "Adicionar um Novo Cliente"
        '
        'btMensalidade
        '
        Me.btMensalidade.Enabled = False
        Me.btMensalidade.Image = CType(resources.GetObject("btMensalidade.Image"), System.Drawing.Image)
        Me.btMensalidade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btMensalidade.Name = "btMensalidade"
        Me.btMensalidade.Size = New System.Drawing.Size(78, 83)
        Me.btMensalidade.Text = "Mensalidade"
        Me.btMensalidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btMensalidade.ToolTipText = "Adicionar um Novo Cliente"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 86)
        '
        'btEquipamento
        '
        Me.btEquipamento.Enabled = False
        Me.btEquipamento.Image = CType(resources.GetObject("btEquipamento.Image"), System.Drawing.Image)
        Me.btEquipamento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEquipamento.Name = "btEquipamento"
        Me.btEquipamento.Size = New System.Drawing.Size(87, 83)
        Me.btEquipamento.Text = "Equipamentos"
        Me.btEquipamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btEquipamento.ToolTipText = "Adicionar um Novo Cliente"
        '
        'btRecibo
        '
        Me.btRecibo.Enabled = False
        Me.btRecibo.Image = CType(resources.GetObject("btRecibo.Image"), System.Drawing.Image)
        Me.btRecibo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btRecibo.Name = "btRecibo"
        Me.btRecibo.Size = New System.Drawing.Size(68, 83)
        Me.btRecibo.Text = "Recibo"
        Me.btRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btRecibo.ToolTipText = "Adicionar um Novo Cliente"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Zbr_Controle_de_Clientes.My.Resources.Resources.dollar_folder_icon
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(121, 83)
        Me.ToolStripButton2.Text = "Modelo Pagamentos"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton2.ToolTipText = "Adicionar um Novo Cliente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 86)
        '
        'btUsuarios
        '
        Me.btUsuarios.Image = CType(resources.GetObject("btUsuarios.Image"), System.Drawing.Image)
        Me.btUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btUsuarios.Name = "btUsuarios"
        Me.btUsuarios.Size = New System.Drawing.Size(100, 83)
        Me.btUsuarios.Text = "Usuarios Sistema"
        Me.btUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btUsuarios.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(74, 83)
        Me.ToolStripButton1.Text = "Calculadora"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton1.ToolTipText = "Adicionar um Novo Cliente"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 86)
        '
        'btBackup
        '
        Me.btBackup.Image = CType(resources.GetObject("btBackup.Image"), System.Drawing.Image)
        Me.btBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btBackup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBackup.Name = "btBackup"
        Me.btBackup.Size = New System.Drawing.Size(68, 83)
        Me.btBackup.Text = "Backup"
        Me.btBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 86)
        '
        'LBLIP
        '
        Me.LBLIP.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIP.Name = "LBLIP"
        Me.LBLIP.Size = New System.Drawing.Size(118, 83)
        Me.LBLIP.Text = "LocalHost"
        '
        'btLogin
        '
        Me.btLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btLogin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btTrocarSenha})
        Me.btLogin.Image = CType(resources.GetObject("btLogin.Image"), System.Drawing.Image)
        Me.btLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(80, 83)
        Me.btLogin.Text = "[Entrar]"
        Me.btLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btTrocarSenha
        '
        Me.btTrocarSenha.Enabled = False
        Me.btTrocarSenha.Name = "btTrocarSenha"
        Me.btTrocarSenha.Size = New System.Drawing.Size(153, 22)
        Me.btTrocarSenha.Text = "Alterar Senha..."
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        '
        'BackgroundWorker3
        '
        Me.BackgroundWorker3.WorkerReportsProgress = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 160000
        '
        'BackgroundWorker4
        '
        Me.BackgroundWorker4.WorkerReportsProgress = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(990, 723)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZBR Controle de Clientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ListaPendentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dtgvEquipamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dataGridAniversario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DGVContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCelular1 As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDataNascimento As MaskedTextBox
    Friend WithEvents txtCelular3 As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCelular2 As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtAlarmeCodigo As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtAutorizados As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtEndereNumeroAlarme As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEnderecoAlarme As TextBox
    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents btSalvar As Button
    Friend WithEvents btAlterar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents btEquipamento As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btCancelar As Button
    Friend WithEvents btExcluir As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ListaPendentes As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btAtualizaMes As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbPendentes As ProgressBar
    Friend WithEvents btBuscaCliente As ToolStripButton
    Friend WithEvents btMensalidade As ToolStripButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btRecibo As ToolStripButton
    Friend WithEvents txtDataContrato As MaskedTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label19 As Label
    Friend WithEvents dataGridAniversario As DataGridView
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btAtualiza As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents btBackup As ToolStripButton
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtMensalValor As TextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents LBLIP As ToolStripLabel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btAtualizaEquipamentos As Button
    Friend WithEvents dtgvEquipamentos As DataGridView
    Friend WithEvents CheckCNPJ As CheckBox
    Friend WithEvents CheckCPF As CheckBox
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents LblCPFVerificado As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents BtAtualizaContratadoAniver As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btUsuarios As ToolStripButton
    Friend WithEvents lblNotifica As Label
    Friend WithEvents btLogin As ToolStripSplitButton
    Friend WithEvents btTrocarSenha As ToolStripMenuItem
    Friend WithEvents DGVContratos As DataGridView
    Friend WithEvents cmbPagamento As ComboBox
    Friend WithEvents btRMensalP As Button
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Label22 As Label
End Class
