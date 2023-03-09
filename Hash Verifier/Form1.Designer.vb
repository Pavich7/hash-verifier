<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        ProgressBar1 = New ProgressBar()
        Label2 = New Label()
        Label3 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Button1 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Panel1 = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        OpenFileDialog2 = New OpenFileDialog()
        TextBox1 = New TextBox()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        TextBox2 = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 128)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(334, 10)
        ProgressBar1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 28)
        Label2.TabIndex = 2
        Label2.Text = "② Select mode"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 28)
        Label3.TabIndex = 3
        Label3.Text = "③ Enter hash"' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(251, 46)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 29)
        Button1.TabIndex = 4
        Button1.Text = "Select"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(24, 125)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(53, 21)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "MD5"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Enabled = False
        RadioButton2.Font = New Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.ForeColor = SystemColors.ControlText
        RadioButton2.Location = New Point(24, 152)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(112, 21)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "Coming Soon...."
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(ProgressBar1)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(0, 344)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(358, 185)
        Panel1.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ControlText
        Label9.Location = New Point(24, 94)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 17)
        Label9.TabIndex = 17
        Label9.Text = "Hash Type : "' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(24, 49)
        Label8.Name = "Label8"
        Label8.Size = New Size(116, 21)
        Label8.TabIndex = 16
        Label8.Text = "Hash Match : ☐"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Cursor = Cursors.Hand
        Label7.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(24, 74)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 17)
        Label7.TabIndex = 12
        Label7.Text = "File Hash : "' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(198, 144)
        Button5.Name = "Button5"
        Button5.Size = New Size(71, 29)
        Button5.TabIndex = 15
        Button5.Text = "About"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(275, 144)
        Button4.Name = "Button4"
        Button4.Size = New Size(71, 29)
        Button4.TabIndex = 14
        Button4.Text = "Help"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(12, 144)
        Button3.Name = "Button3"
        Button3.Size = New Size(180, 29)
        Button3.TabIndex = 12
        Button3.Text = "Start"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(12, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 28)
        Label6.TabIndex = 12
        Label6.Text = "④ Result"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(24, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(191, 21)
        Label5.TabIndex = 10
        Label5.Text = "or Select hash file to verify..."' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(251, 295)
        Button2.Name = "Button2"
        Button2.Size = New Size(95, 29)
        Button2.TabIndex = 9
        Button2.Text = "Select"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog2"' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(24, 256)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(322, 25)
        TextBox1.TabIndex = 11
        TextBox1.Text = "Enter hash here..."' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 28)
        Label1.TabIndex = 1
        Label1.Text = "① Select file"' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(24, 179)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(104, 21)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "Calculate only"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(24, 48)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(221, 25)
        TextBox2.TabIndex = 13
        TextBox2.Text = "Select your file..."' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(358, 529)
        Controls.Add(TextBox2)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hash Verifier"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
End Class
