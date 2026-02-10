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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        ImageList1 = New ImageList(components)
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Button1.Location = New Point(103, 101)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 60)
        Button1.TabIndex = 0
        Button1.Tag = "0"
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Button2.Location = New Point(103, 167)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 60)
        Button2.TabIndex = 1
        Button2.Tag = "0"
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Button3.Location = New Point(290, 101)
        Button3.Name = "Button3"
        Button3.Size = New Size(169, 60)
        Button3.TabIndex = 2
        Button3.Tag = "1"
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Button4.Location = New Point(290, 167)
        Button4.Name = "Button4"
        Button4.Size = New Size(169, 60)
        Button4.TabIndex = 3
        Button4.Tag = "1"
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Button5.Location = New Point(482, 101)
        Button5.Name = "Button5"
        Button5.Size = New Size(169, 60)
        Button5.TabIndex = 4
        Button5.Tag = "2"
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Button6.Location = New Point(482, 167)
        Button6.Name = "Button6"
        Button6.Size = New Size(169, 60)
        Button6.TabIndex = 5
        Button6.Tag = "2"
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "photo_٢٠٢٦-٠٢-١١_٠٠-٣١-٠٥ (2).jpg")
        ImageList1.Images.SetKeyName(1, "photo_٢٠٢٦-٠٢-١١_٠٠-٣١-٠٥.jpg")
        ImageList1.Images.SetKeyName(2, "photo_2026-02-11_00-31-14.jpg")
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer

End Class
