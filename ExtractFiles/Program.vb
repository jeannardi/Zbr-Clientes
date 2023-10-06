Imports System
Imports System.IO.Compression


Module Program
    Sub Main(args As String())
        Console.WriteLine("Lendo pasta atual:")
        Dim MinhaPasta As String = System.AppDomain.CurrentDomain.BaseDirectory
        MinhaPasta = Replace(MinhaPasta, "netcoreapp3.1\", "")
        If args.Length > 1 Then
            Console.WriteLine("Inciando Extração")
            Dim zipPath As String = MinhaPasta & args(0) '"updatedownload.zip"
            Dim exrairEm As String = MinhaPasta & args(1) 'System.AppDomain.CurrentDomain.BaseDirectory
            exrairEm = Replace(exrairEm, "-MESMAPASTA", "")
            Console.WriteLine("Iniciando processo de instalação do update")
            Console.WriteLine(zipPath)
            Console.WriteLine(exrairEm)
            Console.WriteLine("Atualização concluida")

            'ZipFile.CreateFromDirectory(startPath, zipPath)
            ZipFile.ExtractToDirectory(zipPath, exrairEm, True)
            Kill(zipPath)
            'Iniciar programa novamente
            Dim proc = Process.Start(exrairEm & "/Zbr Controle de Clientes.exe")
            proc.WaitForInputIdle()
        Else
            Console.Write("Sair")
            Console.ReadKey(True)
        End If
    End Sub
End Module
