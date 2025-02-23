Imports System.Reflection.Metadata.Ecma335

Public Class Form1

    Dim MyDocuments As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Const Quote = Chr(34)
        Dim csvFilePath As String = MyDocuments & "\nwipe_customers.csv"
        Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFilePath, False)
        outFile.WriteLine("Customer Name;" & Quote & "Contact Name" & Quote & ";" & Quote & "Customer Address" & Quote & ";" & Quote & "Contact Phone" & Quote)
        outFile.WriteLine(TextBox1.Text & ";" & Quote & TextBox2.Text & Quote & ";" & Quote & TextBox3.Text & Quote & ";" & Quote & TextBox4.Text & Quote)
        outFile.WriteLine("Not Applicable;" & Quote & "Not Applicable" & Quote & ";" & Quote & "Not Applicable" & Quote & ";" & Quote & "Not Applicable" & Quote)
        outFile.Close()
        Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFilePath))

        If My.Computer.FileSystem.FileExists(MyDocuments & "\nwipe_customers.csv") Then
            MessageBox.Show("CSV Successfully Built!")
        Else MessageBox.Show("Something went wrong, CSV not built, please try again.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.FileExists(MyDocuments & "\nwipe_customers.csv") Then
            If My.Computer.FileSystem.DirectoryExists("D:\etc") Then
                My.Computer.FileSystem.DeleteFile("D:\etc\nwipe\nwipe_customers.csv")
                My.Computer.FileSystem.CopyFile(MyDocuments & "\nwipe_customers.csv", "D:\etc\nwipe\nwipe_customers.csv", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                If My.Computer.FileSystem.FileExists("D:\etc\nwipe\nwipe_customers.csv") Then
                    MessageBox.Show("CSV successfully written to the D: drive!")
                Else MessageBox.Show("Something went wrong, CSV has not been written, please try again.")
                End If
            End If

            If My.Computer.FileSystem.DirectoryExists("E:\etc") Then
                My.Computer.FileSystem.DeleteFile("E:\etc\nwipe\nwipe_customers.csv")
                My.Computer.FileSystem.CopyFile(MyDocuments & "\nwipe_customers.csv", "E:\etc\nwipe\nwipe_customers.csv", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                If My.Computer.FileSystem.FileExists("E:\etc\nwipe\nwipe_customers.csv") Then
                    MessageBox.Show("CSV successfully written to the E: drive!")
                Else MessageBox.Show("Something went wrong, CSV has not been written, please try again.")
                End If
            End If

            If My.Computer.FileSystem.DirectoryExists("F:\etc") Then
                My.Computer.FileSystem.DeleteFile("F:\etc\nwipe\nwipe_customers.csv")
                My.Computer.FileSystem.CopyFile(MyDocuments & "\nwipe_customers.csv", "F:\etc\nwipe\nwipe_customers.csv", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                If My.Computer.FileSystem.FileExists("F:\etc\nwipe\nwipe_customers.csv") Then
                    MessageBox.Show("CSV successfully written to the F: drive!")
                Else MessageBox.Show("Something went wrong, CSV has not been written, please try again.")
                End If
            End If

            If My.Computer.FileSystem.DirectoryExists("G:\etc") Then
                My.Computer.FileSystem.DeleteFile("G:\etc\nwipe\nwipe_customers.csv")
                My.Computer.FileSystem.CopyFile(MyDocuments & "\nwipe_customers.csv", "G:\etc\nwipe\nwipe_customers.csv", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                If My.Computer.FileSystem.FileExists("G:\etc\nwipe\nwipe_customers.csv") Then
                    MessageBox.Show("CSV successfully written to the G: drive!")
                Else MessageBox.Show("Something went wrong, CSV has not been written, please try again.")
                End If
            End If

            My.Computer.FileSystem.DeleteFile(MyDocuments & "\nwipe_customers.csv")
        Else MessageBox.Show("You have not built a CSV yet!")
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.DoubleClick
        MessageBox.Show("You found the easter egg, well done, do something more useful please!")
    End Sub
End Class
