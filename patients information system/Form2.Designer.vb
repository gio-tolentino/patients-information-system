<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpname = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpaddress = New System.Windows.Forms.Label()
        Me.txtpid = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRevove = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblcontacts = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient's History"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Full Name     :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Address        :"
        '
        'txtpname
        '
        Me.txtpname.AutoSize = True
        Me.txtpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpname.Location = New System.Drawing.Point(139, 97)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(39, 15)
        Me.txtpname.TabIndex = 4
        Me.txtpname.Text = "name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(431, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 5
        '
        'txtpaddress
        '
        Me.txtpaddress.AutoSize = True
        Me.txtpaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaddress.Location = New System.Drawing.Point(139, 120)
        Me.txtpaddress.Name = "txtpaddress"
        Me.txtpaddress.Size = New System.Drawing.Size(51, 15)
        Me.txtpaddress.TabIndex = 6
        Me.txtpaddress.Text = "address"
        '
        'txtpid
        '
        Me.txtpid.AutoSize = True
        Me.txtpid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpid.Location = New System.Drawing.Point(69, 9)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(0, 13)
        Me.txtpid.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Patient ID :"
        '
        'ListView1
        '
        Me.ListView1.Enabled = False
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(60, 145)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(670, 473)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(514, 624)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Go Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRevove
        '
        Me.btnRevove.Location = New System.Drawing.Point(606, 624)
        Me.btnRevove.Name = "btnRevove"
        Me.btnRevove.Size = New System.Drawing.Size(124, 34)
        Me.btnRevove.TabIndex = 11
        Me.btnRevove.Text = "Remove History"
        Me.btnRevove.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(420, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contact Number: "
        '
        'lblcontacts
        '
        Me.lblcontacts.AutoSize = True
        Me.lblcontacts.Location = New System.Drawing.Point(511, 97)
        Me.lblcontacts.Name = "lblcontacts"
        Me.lblcontacts.Size = New System.Drawing.Size(39, 13)
        Me.lblcontacts.TabIndex = 13
        Me.lblcontacts.Text = "Label6"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 670)
        Me.Controls.Add(Me.lblcontacts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRevove)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtpid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtpaddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpname As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpaddress As Label
    Friend WithEvents txtpid As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRevove As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblcontacts As Label
End Class
