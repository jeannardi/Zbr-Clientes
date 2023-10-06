Imports MySql.Data.MySqlClient

Public Class frmNovoRecibo
    Public Formulario As New Form
    Public NovoReciboCadastro As Boolean = True
    Private Sub btPDF_Click(sender As Object, e As EventArgs) Handles btPDF.Click
        CadastraReciboNovo()
    End Sub
    Private Sub CadastraReciboNovo()
        Dim ConecxaoSQL As New MySqlConnection
        Dim ComandoSql As New MySqlCommand
        Dim AdaptadorTabela As New MySqlDataAdapter
        Dim DadosTabela As New DataTable


        Application.DoEvents()
        ' ResetMes()

        btPDF.Enabled = False
        ConecxaoSQL.ConnectionString = StringdeConexao
        Try

            ConecxaoSQL.Open()
            Try

                If NovoReciboCadastro = True Then
                    ComandoSql.Connection = ConecxaoSQL
                    'Limpeza
                    ComandoSql.Parameters.AddWithValue("@id", FrmEquipamentos.EquipamendoID)
                    ComandoSql.Parameters.AddWithValue("@nome", frmPrincipal.txtNome.Text)
                    ComandoSql.Parameters.AddWithValue("@filtro", frmPrincipal.ClienteID)
                    ComandoSql.Parameters.AddWithValue("@data", Now.Date)
                    ComandoSql.Parameters.AddWithValue("@valor", txtValor.Text)
                    ComandoSql.Parameters.AddWithValue("@tipo", ComboBox1.Text)



                    ComandoSql.CommandText = "INSERT INTO recibos (clientid, clientnome, tipo, data, valortotal) VALUES (@filtro,@nome ,@tipo, @data, @Valor);"
                    ComandoSql.ExecuteNonQuery()

                End If

                ConecxaoSQL.Close()

                    GerarReciboNovo(frmPrincipal.txtNome.Text, txtValor.Text, txtReferente.Text, Now.Date.ToString("dd/MM/yyyy"))

                Me.Close()
                FrmEquipamentos.ClientesCarrega(frmPrincipal.ClienteID)
            Catch ex As MySqlException
                MsgBox(ex.Message)
                ConecxaoSQL.Close()
            End Try

            'fecha conecão mysql
            ConecxaoSQL.Close()
        Catch ex As MySqlException
            MsgBox("Verifique a rede/wifi não e possivel conectar ao servidor")

        End Try
        btPDF.Enabled = True
    End Sub


    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        If txtValor.Text <> "" And txtReferente.Text <> "" And ComboBox1.Text <> "" Then
            btPDF.Enabled = True
        Else
            btPDF.Enabled = False
        End If
    End Sub
    Private Sub txtValor_LostFocus(sender As Object, e As EventArgs) Handles txtValor.LostFocus
        Try
            txtValor.Text = FormatCurrency(txtValor.Text, 2, TriState.True, TriState.True,
                                TriState.True).Replace("R$", "").Trim

        Catch ex As Exception
            txtValor.Text = "0,0"
        End Try


    End Sub

    Private Sub txtReferente_TextChanged(sender As Object, e As EventArgs) Handles txtReferente.TextChanged
        If txtValor.Text <> "" And txtReferente.Text <> "" And ComboBox1.Text <> "" Then
            btPDF.Enabled = True
        Else
            btPDF.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If txtValor.Text <> "" And txtReferente.Text <> "" And ComboBox1.Text <> "" Then
            btPDF.Enabled = True
        Else
            btPDF.Enabled = False
        End If
    End Sub

    Private Sub frmNovoRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmNovoRecibo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Formulario.Show()
    End Sub
End Class