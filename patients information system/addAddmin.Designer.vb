<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAddmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtaddusername = New System.Windows.Forms.TextBox()
        Me.txtaddpassword = New System.Windows.Forms.TextBox()
        Me.btnaddusers = New System.Windows.Forms.Button()
        Me.txtaddfullname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtaddIdnum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'txtaddusername
        '
        Me.txtaddusername.Location = New System.Drawing.Point(159, 141)
        Me.txtaddusername.Name = "txtaddusername"
        Me.txtaddusername.Size = New System.Drawing.Size(165, 20)
        Me.txtaddusername.TabIndex = 2
        '
        'txtaddpassword
        '
        Me.txtaddpassword.Location = New System.Drawing.Point(159, 179)
        Me.txtaddpassword.Name = "txtaddpassword"
        Me.txtaddpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtaddpassword.Size = New System.Drawing.Size(165, 20)
        Me.txtaddpassword.TabIndex = 3
        '
        'btnaddusers
        '
        Me.btnaddusers.Location = New System.Drawing.Point(205, 301)
        Me.btnaddusers.Name = "btnaddusers"
        Me.btnaddusers.Size = New System.Drawing.Size(81, 37)
        Me.btnaddusers.TabIndex = 4
        Me.btnaddusers.Text = "Registration"
        Me.btnaddusers.UseVisualStyleBackColor = True
        '
        'txtaddfullname
        '
        Me.txtaddfullname.Location = New System.Drawing.Point(159, 215)
        Me.txtaddfullname.Name = "txtaddfullname"
        Me.txtaddfullname.Size = New System.Drawing.Size(165, 20)
        Me.txtaddfullname.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Full Name:"
        '
        'txtaddIdnum
        '
        Me.txtaddIdnum.Location = New System.Drawing.Point(159, 253)
        Me.txtaddIdnum.Name = "txtaddIdnum"
        Me.txtaddIdnum.Size = New System.Drawing.Size(165, 20)
        Me.txtaddIdnum.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ID No.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 28)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Register a New Admin"
        '
        'addAddmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 415)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtaddIdnum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtaddfullname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnaddusers)
        Me.Controls.Add(Me.txtaddpassword)
        Me.Controls.Add(Me.txtaddusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addAddmin"
        Me.Text = "Register a new Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtaddusername As TextBox
    Friend WithEvents txtaddpassword As TextBox
    Friend WithEvents btnaddusers As Button
    Friend WithEvents txtaddfullname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtaddIdnum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
