Imports System.IO.Ports
Imports System.IO

Public Class Form2
    Private comst As String = MainModule.comst
    Private bit As String = MainModule.bit
    Private dbit As String = MainModule.dbit
    Private par As String = MainModule.par
    Private stobit As String = MainModule.stobit
    Private flcon As String = MainModule.flcon
    Public st As String = Nothing
    Public Event DataReceived As SerialDataReceivedEventHandler



    Private port As New SerialPort(comst, bit, Parity.None, dbit, StopBits.One)
    Dim rcvQ As New Queue(Of Byte()) 'a queue of buffers
    Dim rcvQLock As New Object
    Dim strs As String = ""
    'an approach
    Private Sub port_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        Do While port.IsOpen AndAlso port.BytesToRead <> 0
            Me.RichTextBox1.AppendText(port.ReadExisting)
            'what if the number of bytes available changes at ANY point?
            Dim bytsToRead As Integer = port.BytesToRead
            Dim buf(bytsToRead - 1) As Byte

            bytsToRead = port.Read(buf, 0, bytsToRead)

            '        place the buffer in a queue that can be processed somewhere else
            'Threading.Monitor.Enter(rcvQLock)
            ' rcvQ.Enqueue(buf)
            'Threading.Monitor.Exit(rcvQLock)

        Loop
        'Dim i As Integer = 0
        'Do Until i = 10000
        'i = +1
        'Me.RichTextBox1.AppendText(port.ReadExisting)
        'Loop
        'st = port.ReadLine()
        'Me.RichTextBox1.AppendText(st)
        'MsgBox("stop")
    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler port.DataReceived, New SerialDataReceivedEventHandler(AddressOf port_DataReceived)

        RichTextBox.CheckForIllegalCrossThreadCalls = False
        port.Open()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fr As New Form1
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim foldername As String = Application.StartupPath & "\" & "Calibration"
        Dim cfilename As String = Application.StartupPath & "\" & "calibration\" & Labid_txt.Text & ".txt"
        If CheckBox1.Checked = True Then
            If (Not System.IO.Directory.Exists(foldername)) Then
                System.IO.Directory.CreateDirectory(foldername)
                RichTextBox1.SaveFile(cfilename, RichTextBoxStreamType.PlainText)
                If System.IO.File.Exists(cfilename) = True Then
                    Dim fi As New System.IO.FileInfo(cfilename)
                    Using r As StreamReader = New StreamReader(cfilename)
                        Dim line As String
                        line = r.ReadLine
                        If line Is Nothing Then
                            MsgBox("File was created but nothing was saved")
                        Else
                            MsgBox("file was saved")
                        End If
                    End Using


                End If
                'If (Not System.IO.File.Exists("\test\output.txt")) Then
                'System.IO.File.Create("\test\output.txt")
                'End If
            Else
                RichTextBox1.SaveFile(cfilename, RichTextBoxStreamType.PlainText)
                If System.IO.File.Exists(cfilename) = True Then
                    Dim fi As New System.IO.FileInfo(cfilename)
                    Using r As StreamReader = New StreamReader(cfilename)
                        Dim line As String
                        line = r.ReadLine
                        If line Is Nothing Then
                            MsgBox("File was created but nothing was saved")
                        Else
                            MsgBox("file was saved")
                        End If
                    End Using


                End If
            End If
        Else
            If Labid_txt.Text = Nothing Then
                MsgBox("please provide ID")
            Else
                Dim filename As String = Application.StartupPath & "\" & Labid_txt.Text & ".txt"
                RichTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText)
                If System.IO.File.Exists(filename) = True Then
                    Dim fi As New System.IO.FileInfo(filename)
                    Using r As StreamReader = New StreamReader(filename)
                        Dim line As String
                        line = r.ReadLine
                        If line Is Nothing Then
                            MsgBox("File was created but nothing was saved")
                        Else
                            MsgBox("file was saved")
                        End If
                    End Using


                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Clear()
    End Sub
End Class