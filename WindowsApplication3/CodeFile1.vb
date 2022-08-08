Module MainModule
    Public comst As String = "com1"
    Public bit As String = "4800"
    Public dbit As String = "8"
    Public par As String = "none"
    Public stobit As String = "1"
    Public flcon As String = "Hardware"
    Private fileReader As System.IO.StreamReader
    Sub main()

        Dim FILE_NAME As String = Application.StartupPath & "\com.bk"

        If System.IO.File.Exists(FILE_NAME) = True Then
            'Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(FILE_NAME)
            Dim stringReader As String
            stringReader = fileReader.ReadLine()
            comst = stringReader

            stringReader = fileReader.ReadLine()
            bit = stringReader

            stringReader = fileReader.ReadLine()
            dbit = stringReader

            stringReader = fileReader.ReadLine()
            par = stringReader

            stringReader = fileReader.ReadLine()
            stobit = stringReader

            stringReader = fileReader.ReadLine()
            flcon = stringReader
            fileReader.Close()
        Else
        End If

        ' Dim frm As New Form2
        'fileReader.Close()
        Application.Run(Form2)
    End Sub
End Module
