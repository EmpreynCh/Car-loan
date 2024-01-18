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
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Toyota", "Honda", "Nissan", "Kia"})
        ComboBox1.Location = New Point(160, 59)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(237, 36)
        ComboBox1.TabIndex = 0
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(724, 59)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(237, 36)
        ComboBox2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(160, 156)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(302, 248)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(659, 156)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(302, 248)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(201, 427)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(288, 43)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(201, 497)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(288, 43)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(201, 563)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(109, 43)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Enabled = False
        TextBox4.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(201, 627)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(288, 43)
        TextBox4.TabIndex = 2
        ' 
        ' TextBox5
        ' 
        TextBox5.Enabled = False
        TextBox5.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(201, 691)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(288, 43)
        TextBox5.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(842, 563)
        Button2.Name = "Button2"
        Button2.Size = New Size(54, 32)
        Button2.TabIndex = 3
        Button2.Text = "NEW TRANSACTION"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(724, 540)
        Button1.Name = "Button1"
        Button1.Size = New Size(185, 66)
        Button1.TabIndex = 3
        Button1.Text = "COMPUTE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(108, 443)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 27)
        Label1.TabIndex = 4
        Label1.Text = "Price:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(17, 702)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 27)
        Label2.TabIndex = 4
        Label2.Text = "Monthly Dues:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(21, 508)
        Label3.Name = "Label3"
        Label3.Size = New Size(174, 27)
        Label3.TabIndex = 4
        Label3.Text = "Year(s) to Pay:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(4, 574)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 27)
        Label4.TabIndex = 4
        Label4.Text = "Annual Interest:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(46, 638)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 27)
        Label5.TabIndex = 4
        Label5.Text = "Total Price:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGoldenrod
        ClientSize = New Size(1118, 779)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
