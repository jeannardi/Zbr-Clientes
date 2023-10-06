Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Module recibo
    Public Sub GerarReciboMes(ByVal Nome As String, ByVal Valor As String, ByVal Data As List(Of Date), ByVal DataPAGOU As Date, ByVal Obs As String)

        KillPDFHeader()

        Dim document As PdfDocument = New PdfDocument
        document.Info.Title = "ZBR - Recibo"
        document.Info.Subject = "Pagamento Mensalidade"
        document.SecuritySettings.PermitModifyDocument = False


        Dim page As PdfPage = document.AddPage

        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
        'Fontes
        Dim fontTitulo As XFont = New XFont("Verdana", 14, XFontStyle.Bold)
        Dim FontNormalNegrito As XFont = New XFont("Verdana", 13, XFontStyle.Bold)
        Dim FontNormal As XFont = New XFont("Verdana", 13, XFontStyle.Regular)
        Dim FonteNegritos As XFont = New XFont("Verdana", 11, XFontStyle.Bold)
        Dim FontTexto As XFont = New XFont("Verdana", 10, XFontStyle.Regular)
        'Canetas
        Dim Pen As XPen = New XPen(XColors.Gray, 0.8)
        Dim Pen2 As XPen = New XPen(XColors.Black, 1)

        gfx.DrawString("ZBR - ZELADORIA DE IMÓVEIS LTDA - ME", fontTitulo, XBrushes.Black,
    New XRect(0, 0, page.Width.Point, 45), XStringFormats.Center)
        gfx.DrawString("ALARME MONITORADO", FonteNegritos, XBrushes.Black,
    New XRect(0, 0, page.Width.Point, 70), XStringFormats.Center)
        'Imagens

        Dim image As XImage = XImage.FromFile("zbr logo.png")
        gfx.DrawImage(image, 15, 10, 40, 40)
        ' image = XImage.FromFile("pago.png")
        'gfx.DrawImage(image, 290, 80)

        gfx.DrawRectangle(Pen2, 450, 65, 120, 25) 'Dinheiro Quadrado
        gfx.DrawString("RECIBO", FontNormalNegrito, XBrushes.Black,
            New XRect(450, 0, 0, 110), XStringFormats.CenterLeft)
        gfx.DrawString("R$ " & Valor, FontNormal, XBrushes.Black,
            New XRect(452, 0, 0, 153), XStringFormats.CenterLeft)


        Dim AlturaLinha As Integer = 200
        'MSG1
        gfx.DrawString("Recebemos de: ", FonteNegritos, XBrushes.Black,
            New XRect(20, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'Nome do Cliente
        gfx.DrawString(Nome, FontTexto, XBrushes.Black,
            New XRect(120, 0, 0, AlturaLinha), XStringFormats.CenterLeft)

        'DATA RECEBEU
        gfx.DrawString("na data: ", FonteNegritos, XBrushes.Black,
            New XRect(450, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'DATA
        gfx.DrawString(DataPAGOU.Date.ToString("dd/MM/yyyy"), FontTexto, XBrushes.Black,
            New XRect(510, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'NOVA LINHA ----------- 02
        AlturaLinha = AlturaLinha + 30
        'A Importancia do valor
        gfx.DrawString("A importância de: ", FonteNegritos, XBrushes.Black,
            New XRect(20, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'Valor por extenço
        gfx.DrawString(NumeroToExtenso(Valor), FontTexto, XBrushes.Black,
            New XRect(135, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'NOVA LINHA ----------- 03
        AlturaLinha = AlturaLinha + 30
        Dim MSGMES As String = "Referente ao monitoramento, dos mêses abaixo: "
        If Data.Count - 1 >= 1 Then
            MSGMES = "Referente ao monitoramento, dos mêses abaixo:"
        Else
            MSGMES = "Referente ao monitoramento, do mês abaixo:"
        End If
        gfx.DrawString(MSGMES, FonteNegritos, XBrushes.Black,
            New XRect(20, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'NOVA LINHA ----------- 04
        AlturaLinha = AlturaLinha + 10
        For Each DataImprimir As Date In Data
            AlturaLinha = AlturaLinha + 30
            gfx.DrawString(DataImprimir.Date.ToString("MMMM/yyyy").ToUpper, FontTexto, XBrushes.Black,
                New XRect(25, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        Next
        Dim LarguraQuadrado As Integer = 15.5 * Data.Count - 1
        Dim LarguraQuadradoFora As Integer = 15.6 * Data.Count - 2


        If obs <> "" Then
            AlturaLinha = AlturaLinha + 45 + Data.Count - 1
            gfx.DrawString("Observação: " + Obs, FontTexto, XBrushes.Black,
                New XRect(20, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
            gfx.DrawRectangle(Pen2, 10, 10, 570, 160 + LarguraQuadradoFora) 'Quadrado de fora
        Else
            gfx.DrawRectangle(Pen2, 10, 10, 570, 142 + LarguraQuadradoFora) 'Quadrado de fora
        End If

        'gfx.DrawRectangle(Pen2, 10, 10, 570, 160 + LarguraQuadradoFora) 'Quadrado de fora
        gfx.DrawRectangle(Pen2, 20, 143, 120, LarguraQuadrado) 'Dinheiro Quadrado

        Dim filename As String = "recibo.pdf"
        document.Save(filename)


        ' ...and start a viewer.

        Try
            Process.Start(filename)
        Catch ex As Exception
            MsgBox("Documento aberto por outro aplicativo")
        End Try
    End Sub
    Public Function NumeroToExtenso(ByVal number As Decimal) As String
        Dim cent As Integer
        Try
            ' se for =0 retorna 0 reais
            If number = 0 Then
                Return "Zero Reais"
            End If
            ' Verifica a parte decimal, ou seja, os centavos
            cent = Decimal.Round((number - Int(number)) * 100, MidpointRounding.ToEven)
            ' Verifica apenas a parte inteira
            number = Int(number)
            ' Caso existam centavos
            If cent > 0 Then
                ' Caso seja 1 não coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um Real e " + getDecimal(cent) + "centavos"
                    ' Caso o valor seja inferior a 1 Real
                ElseIf number = 0 Then
                    Return getDecimal(cent) + "centavos"
                Else
                    Return getInteger(number) + " Reais e " + getDecimal(cent) + "centavos"
                End If
            Else
                ' Caso seja 1 não coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um Real"
                Else
                    Return getInteger(number) + " Reais"
                End If
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
    ''' <summary>
    ''' Função auxiliar - Parte decimal a converter
    ''' </summary>
    ''' <param name="number">Parte decimal a converter</param>
    Public Function getDecimal(ByVal number As Byte) As String
        Try
            Select Case number
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                       {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis",
                        "Sete", "Oito", "Nove", "Dez", "Onze",
                        "Doze", "Treze", "Quatorze", "Quinze",
                        "Dezesseis", "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(number - 1) + " "
                Case 20 To 99
                    Dim strArray() As String =
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta",
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2) + " "
                    Else
                        Return strArray(number \ 10 - 2) + " e " + getDecimal(number Mod 10) + " "
                    End If
                Case Else
                    Return ""
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function
    ''' <summary>
    ''' Função auxiliar - Parte inteira a converter
    ''' </summary>
    ''' <param name="number">Parte inteira a converter</param>
    Public Function getInteger(ByVal number As Decimal) As String
        Try
            number = Int(number)
            Select Case number
                Case Is < 0
                    Return "-" & getInteger(-number)
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                        {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis",
                        "Sete", "Oito", "Nove", "Dez", "Onze", "Doze",
                        "Treze", "Quatorze", "Quinze", "Dezesseis",
                        "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(number - 1) + " "
                Case 20 To 99
                    Dim strArray() As String =
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta",
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) + " e " + getInteger(number Mod 10)
                    End If
                Case 100
                    Return "Cem"
                Case 101 To 999
                    Dim strArray() As String =
                           {"Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos",
                           "Seiscentos", "Setecentos", "Oitocentos", "Novecentos"}
                    If (number Mod 100) = 0 Then
                        Return strArray(number \ 100 - 1) + " "
                    Else
                        Return strArray(number \ 100 - 1) + " e " + getInteger(number Mod 100)
                    End If
                Case 1000 To 1999
                    Select Case (number Mod 1000)
                        Case 0
                            Return "Mil"
                        Case Is <= 100
                            Return "Mil e " + getInteger(number Mod 1000)
                        Case Else
                            Return "Mil, " + getInteger(number Mod 1000)
                    End Select
                Case 2000 To 999999
                    Select Case (number Mod 1000)
                        Case 0
                            Return getInteger(number \ 1000) & "Mil"
                        Case Is <= 100
                            Return getInteger(number \ 1000) & "Mil e " & getInteger(number Mod 1000)
                        Case Else
                            Return getInteger(number \ 1000) & "Mil, " & getInteger(number Mod 1000)
                    End Select
                Case 1000000 To 1999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return "Um Milhão"
                        Case Is <= 100
                            Return getInteger(number \ 1000000) + "Milhão e " & getInteger(number Mod 1000000)
                        Case Else
                            Return getInteger(number \ 1000000) + "Milhão, " & getInteger(number Mod 1000000)
                    End Select
                Case 2000000 To 999999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return getInteger(number \ 1000000) + " Milhões"
                        Case Is <= 100
                            Return getInteger(number \ 1000000) + "Milhões e " & getInteger(number Mod 1000000)
                        Case Else
                            Return getInteger(number \ 1000000) + "Milhões, " & getInteger(number Mod 1000000)
                    End Select
                Case 1000000000 To 1999999999
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return "Um Bilhão"
                        Case Is <= 100
                            Return getInteger(number \ 1000000000) + "Bilhão e " + getInteger(number Mod 1000000000)
                        Case Else
                            Return getInteger(number \ 1000000000) + "Bilhão, " + getInteger(number Mod 1000000000)
                    End Select
                Case Else
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return getInteger(number \ 1000000000) + " Bilhões"
                        Case Is <= 100
                            Return getInteger(number \ 1000000000) + "Bilhões e " + getInteger(number Mod 1000000000)
                        Case Else
                            Return getInteger(number \ 1000000000) + "Bilhões, " + getInteger(number Mod 1000000000)
                    End Select
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Sub GerarReciboNovo(ByVal Nome As String, ByVal Valor As String, ByVal Referente As String, ByVal DataPAGOU As Date)
        KillPDFHeader()


        Dim document As PdfDocument = New PdfDocument
        document.Info.Title = "ZBR - Recibo"
        document.Info.Subject = "Pagamento Mensalidade"
        document.SecuritySettings.PermitModifyDocument = False


        Dim page As PdfPage = document.AddPage

        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
        'Fontes
        Dim fontTitulo As XFont = New XFont("Verdana", 14, XFontStyle.Bold)
        Dim FontNormalNegrito As XFont = New XFont("Verdana", 13, XFontStyle.Bold)
        Dim FontNormal As XFont = New XFont("Verdana", 13, XFontStyle.Regular)
        Dim FonteNegritos As XFont = New XFont("Verdana", 11, XFontStyle.Bold)
        Dim FontTexto As XFont = New XFont("Verdana", 10, XFontStyle.Regular)
        'Canetas
        Dim Pen As XPen = New XPen(XColors.Gray, 0.8)
        Dim Pen2 As XPen = New XPen(XColors.Black, 1)

        gfx.DrawString("ZBR - ZELADORIA DE IMÓVEIS LTDA - ME", fontTitulo, XBrushes.Black,
    New XRect(0, 0, page.Width.Point, 45), XStringFormats.Center)
        gfx.DrawString("ALARME MONITORADO", FonteNegritos, XBrushes.Black,
    New XRect(0, 0, page.Width.Point, 70), XStringFormats.Center)
        'Imagens

        Dim image As XImage = XImage.FromFile("zbr logo.png")
        gfx.DrawImage(image, 15, 10, 40, 40)
        ' image = XImage.FromFile("pago.png")
        'gfx.DrawImage(image, 290, 80)

        gfx.DrawRectangle(Pen2, 450, 65, 120, 25) 'Dinheiro Quadrado
        gfx.DrawString("RECIBO", FontNormalNegrito, XBrushes.Black,
            New XRect(450, 0, 0, 110), XStringFormats.CenterLeft)
        gfx.DrawString("R$ " & Valor, FontNormal, XBrushes.Black,
            New XRect(452, 0, 0, 153), XStringFormats.CenterLeft)


        Dim AlturaLinha As Integer = 200
        'MSG1
        gfx.DrawString("Recebemos de: ", FonteNegritos, XBrushes.Black,
            New XRect(20, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'Nome do Cliente
        gfx.DrawString(Nome, FontTexto, XBrushes.Black,
            New XRect(120, 0, 0, AlturaLinha), XStringFormats.CenterLeft)

        'DATA RECEBEU
        gfx.DrawString("na data: ", FonteNegritos, XBrushes.Black,
            New XRect(450, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'DATA
        gfx.DrawString(DataPAGOU.Date.ToString("dd/MM/yyyy"), FontTexto, XBrushes.Black,
            New XRect(510, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'NOVA LINHA ----------- 02
        AlturaLinha = AlturaLinha + 30
        'A Importancia do valor
        gfx.DrawString("A importância de: ", FonteNegritos, XBrushes.Black,
            New XRect(20, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'Valor por extenço
        gfx.DrawString(NumeroToExtenso(Valor), FontTexto, XBrushes.Black,
            New XRect(135, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'NOVA LINHA ----------- 03
        AlturaLinha = AlturaLinha + 30

        gfx.DrawString("Referente a: ", FonteNegritos, XBrushes.Black,
            New XRect(20, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        'NOVA LINHA ----------- 04

        gfx.DrawString(Referente, FontTexto, XBrushes.Black,
                New XRect(100, 0, 0, AlturaLinha), XStringFormats.CenterLeft)


        gfx.DrawRectangle(Pen2, 10, 10, 570, 135) 'Quadrado de fora


        Dim filename As String = "recibonovo.pdf"
        document.Save(filename)


        ' ...and start a viewer.

        Try
            Process.Start(filename)
        Catch ex As Exception
            MsgBox("Documento aberto por outro aplicativo")
        End Try
    End Sub
    Public Sub KillPDFHeader()
        Try
            Process.GetProcessesByName("FoxitReader")(0).Kill()
        Catch ex As Exception

        End Try
        Try
            Process.GetProcessesByName("Acrobat")(0).Kill()
        Catch ex As Exception

        End Try
        Try
            Process.GetProcessesByName("Acrord32")(0).Kill()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub GerarClientesPag(ByVal Tabela As DataTable, ByVal Modelo As String)
        KillPDFHeader()


        Dim document As PdfDocument = New PdfDocument
        document.Info.Title = "ZBR "
        document.Info.Subject = "Pagamento Mensalidade"
        document.SecuritySettings.PermitModifyDocument = False

        Dim AlturaLinha As Integer = 200

        Dim page As PdfPage = document.AddPage

        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
        'Fontes
        Dim fontTitulo As XFont = New XFont("Verdana", 14, XFontStyle.Bold)
        Dim FontNormalNegrito As XFont = New XFont("Verdana", 13, XFontStyle.Bold)
        Dim FontNormal As XFont = New XFont("Verdana", 13, XFontStyle.Regular)
        Dim FonteNegritos As XFont = New XFont("Verdana", 11, XFontStyle.Bold)
        Dim FontTexto As XFont = New XFont("Verdana", 10, XFontStyle.Regular)
        'Canetas
        Dim Pen As XPen = New XPen(XColors.Gray, 0.8)
        Dim Pen2 As XPen = New XPen(XColors.Black, 1)

        gfx.DrawString("ZBR - ZELADORIA DE IMÓVEIS LTDA - ME", fontTitulo, XBrushes.Black,
    New XRect(0, 0, page.Width.Point, 45), XStringFormats.Center)
        gfx.DrawString("ALARME MONITORADO", FonteNegritos, XBrushes.Black,
    New XRect(0, 0, page.Width.Point, 70), XStringFormats.Center)
        'Imagens

        Dim image As XImage = XImage.FromFile("zbr logo.png")
        gfx.DrawImage(image, 15, 10, 40, 40)
        ' image = XImage.FromFile("pago.png")
        'gfx.DrawImage(image, 290, 80)
        'MSG1
        gfx.DrawString("Modelo Pagamento: " & Modelo, FonteNegritos, XBrushes.Black,
            New XRect(0, 0, page.Width.Point, 120), XStringFormats.Center)

        gfx.DrawString("NOME DOS CLIENTES: ", FontTexto, XBrushes.Black,
            New XRect(20, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
        AlturaLinha = AlturaLinha + 30

        If Tabela.Rows.Count >= 0 Then


            For Each linha As DataRow In Tabela.Rows
                If AlturaLinha > 1650 Then
                    gfx.Dispose()
                    page = document.AddPage

                    gfx = XGraphics.FromPdfPage(page)
                    '-----------------cabeçalho
                    gfx.DrawString("ZBR - ZELADORIA DE IMÓVEIS LTDA - ME", fontTitulo, XBrushes.Black,
                     New XRect(0, 0, page.Width.Point, 45), XStringFormats.Center)
                    gfx.DrawString("ALARME MONITORADO", FonteNegritos, XBrushes.Black,
                    New XRect(0, 0, page.Width.Point, 70), XStringFormats.Center)
                    'Imagens


                    gfx.DrawImage(image, 15, 10, 40, 40)
                    ' image = XImage.FromFile("pago.png")
                    'gfx.DrawImage(image, 290, 80)
                    'MSG1
                    gfx.DrawString("Modelo Pagamento: " & Modelo, FonteNegritos, XBrushes.Black,
            New XRect(0, 0, page.Width.Point, 120), XStringFormats.Center)

                    '-----------------cabeçalho

                    AlturaLinha = 200

                    gfx.DrawString("NOME DOS CLIENTES: ", FontTexto, XBrushes.Black,
                     New XRect(20, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
                    AlturaLinha = AlturaLinha + 30
                End If
                gfx.DrawString(linha.Item(1).ToString, FontTexto, XBrushes.Black,
                                New XRect(20, 0, 0, AlturaLinha), XStringFormats.CenterLeft)
                'NOVA LINHA ----------- 02
                AlturaLinha = AlturaLinha + 30

            Next

            ' gfx.DrawRectangle(Pen2, 10, 10, 570, 135) 'Quadrado de fora

        End If

        For i = 0 To document.Pages.Count - 1
            Dim total As Integer = document.Pages.Count
            Dim desenha As XGraphics
            Try
                desenha = XGraphics.FromPdfPage(document.Pages(i))

            Catch ex As Exception
                gfx.Dispose()
                desenha = XGraphics.FromPdfPage(document.Pages(i))
            End Try
            desenha.DrawString("Pagina " & i + 1 & " de " & total, FontTexto, XBrushes.Black,
                                    New XRect(-20, 0, page.Width.Point, 1650), XStringFormats.CenterRight)
        Next


        Dim filename As String = "clientspag.pdf"
        document.Save(filename)


        Try
            Process.Start(filename)
        Catch ex As Exception
            MsgBox("Documento aberto por outro aplicativo")
        End Try

    End Sub
End Module
