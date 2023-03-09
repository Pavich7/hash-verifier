Imports System.IO
Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Function md5hash(ByVal file_name As String)
        Dim hash = MD5.Create()
        Dim hashValue() As Byte
        Dim fileStream As FileStream = File.OpenRead(file_name)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = PrintByteArray(hashValue)
        fileStream.Close()
        Return hash_hex
    End Function

    Public Function PrintByteArray(ByVal array() As Byte)
        Dim hex_value As String = ""
        Dim i As Integer
        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("X2")
        Next i
        Return hex_value.ToLower
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If RadioButton1.Checked = True Then
                Dim hashfinal = md5hash(TextBox2.Text)
                If CheckBox1.Checked = True Then
                    Label8.Text = "Hash Match : ☐"
                    Label9.Text = "Hash Type : MD5"
                    Label7.Text = "File Hash : " + hashfinal
                    Label8.ForeColor = Color.Black
                    Label7.ForeColor = Color.Black
                    Label9.ForeColor = Color.Black
                Else
                    If TextBox1.Text = hashfinal Then
                        Label8.Text = "Hash Match : ✅"
                        Label8.ForeColor = Color.Green
                        Label7.ForeColor = Color.Green
                        Label9.ForeColor = Color.Green
                    Else
                        Label8.Text = "Hash Match : ❎"
                        Label8.ForeColor = Color.Red
                        Label7.ForeColor = Color.Red
                        Label9.ForeColor = Color.Red
                    End If
                    Label9.Text = "Hash Type : MD5"
                    Label7.Text = "File Hash : " + hashfinal
                End If
            Else
                MessageBox.Show("Select mode first!", "Failed!")
            End If
        Catch ex As Exception
            MessageBox.Show("Something went wrong!" + vbCrLf + ex.Message, "Failed!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Title = "Select your file to hash..."
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog2.Multiselect = False
        OpenFileDialog2.Title = "Select hash file to verify..."
        OpenFileDialog2.Filter = "Hash Files|*.txt;*.md5"
        If OpenFileDialog2.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog2.FileName)
            Dim stringReader As String
            stringReader = fileReader.ReadLine()
            TextBox1.Text = stringReader
        End If
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Try
            Dim str As String = Label7.Text
            str = str.Remove(0, 12)
            Clipboard.SetText(str)
            MessageBox.Show("Copied to clipboard!", "Completed!")
        Catch ex As Exception
            MessageBox.Show("Start calculate first!", "Failed!")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Enabled = False
            Label5.Enabled = False
            Label3.Enabled = False
            Button2.Enabled = False
        Else
            TextBox1.Enabled = True
            Label5.Enabled = True
            Label3.Enabled = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Version : Beta 1 " + vbCrLf + "© 2023 Pavich Komansil", "About")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Help article not available in this version", "Coming Soon...")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
