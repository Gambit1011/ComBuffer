Imports System.IO
Public Class Form1

    Private Sub Psetsave_btn_Click(sender As Object, e As EventArgs) Handles Psetsave_btn.Click
        Dim FILE_NAME As String = Application.StartupPath & "\com.bk"
        Dim x As Boolean

        If System.IO.File.Exists(FILE_NAME) Then
            x = True
        End If
        If x = True Then

            File.Delete(FILE_NAME)
            File.Create(FILE_NAME).Dispose()
            Dim i As Integer
            Dim aryText(5) As String

            aryText(0) = ComboBox1.SelectedItem
            aryText(1) = Bit_text.Text
            aryText(2) = Dbit_text.Text
            aryText(3) = Par_text.Text
            aryText(4) = Stobit_text.Text
            aryText(5) = Flcon_text.Text

            ' Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            Dim filereader As System.IO.StreamWriter = IO.File.AppendText(FILE_NAME)
            For i = 0 To 5

                filereader.WriteLine(aryText(i))

            Next

            filereader.Close()
            Me.Show()
        Else
            System.IO.File.Create(FILE_NAME).Dispose()

            Dim i As Integer
            Dim aryText(5) As String

            aryText(0) = ComboBox1.SelectedItem
            aryText(1) = Bit_text.Text
            aryText(2) = Dbit_text.Text
            aryText(3) = Par_text.Text
            aryText(4) = Stobit_text.Text
            aryText(5) = Flcon_text.Text

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            For i = 0 To 5

                objWriter.WriteLine(aryText(i))

            Next

            objWriter.Close()

        End If

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Com1")
        ComboBox1.Items.Add("Com2")
        ComboBox1.Items.Add("Com3")
        ComboBox1.Items.Add("Com4")
        ComboBox1.Items.Add("Com5")
        ComboBox1.Items.Add("Com6")
        ComboBox1.Items.Add("Com7")

        Dim FILE_NAME As String = Application.StartupPath & "\com.bk"
        Dim fileReader As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(FILE_NAME)
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim stringReader As String
            stringReader = fileReader.ReadLine()
            ComboBox1.Text = stringReader

            stringReader = fileReader.ReadLine()
            Bit_text.Text = stringReader

            stringReader = fileReader.ReadLine()
            Dbit_text.Text = stringReader

            stringReader = fileReader.ReadLine()
            Par_text.Text = stringReader

            stringReader = fileReader.ReadLine()
            Stobit_text.Text = stringReader

            stringReader = fileReader.ReadLine()
            Flcon_text.Text = stringReader
        Else
        End If
        fileReader.Close()

    End Sub
End Class
