<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(201, 198)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "Build CSV"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(694, 198)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 1
        Button2.Text = "Write CSV"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(4, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 28)
        Label1.TabIndex = 2
        Label1.Text = "Enter Customer Info Below"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(201, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(587, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 20)
        Label2.TabIndex = 4
        Label2.Text = "Customer Name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(201, 99)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(587, 27)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(4, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 20)
        Label3.TabIndex = 6
        Label3.Text = "Customer Address:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(4, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(174, 20)
        Label4.TabIndex = 7
        Label4.Text = "Customer Contact Name:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(201, 132)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(587, 27)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(201, 165)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(587, 27)
        TextBox4.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(4, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(175, 20)
        Label5.TabIndex = 10
        Label5.Text = "Customer Contact Phone:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(444, 195)
        Label6.Name = "Label6"
        Label6.Size = New Size(138, 20)
        Label6.TabIndex = 11
        Label6.Text = "I'm bored already :)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(444, 215)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 20)
        Label7.TabIndex = 12
        Label7.Text = "-Daniel 2025"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DarkOrchid
        Label8.Location = New Point(458, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(330, 28)
        Label8.TabIndex = 13
        Label8.Text = "ShredOS Customer CSV Generator"
        Label8.TextAlign = ContentAlignment.TopRight
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 239)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(818, 286)
        MinimumSize = New Size(818, 286)
        Name = "Form1"
        Text = "ShredOS Customer CSV Generator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
