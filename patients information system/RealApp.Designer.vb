<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RealApp
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label100 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPLastName = New System.Windows.Forms.TextBox()
        Me.txtPFirstName = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtPAge = New System.Windows.Forms.TextBox()
        Me.txtPAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtPDateArrived = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbPGender = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPReason = New System.Windows.Forms.TextBox()
        Me.txtPContact = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.txtpid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnsee = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.dttime = New System.Windows.Forms.DateTimePicker()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name"
        '
        'label100
        '
        Me.label100.AutoSize = True
        Me.label100.Location = New System.Drawing.Point(363, 150)
        Me.label100.Name = "label100"
        Me.label100.Size = New System.Drawing.Size(69, 13)
        Me.label100.TabIndex = 3
        Me.label100.Text = "Middle Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address"
        '
        'txtPLastName
        '
        Me.txtPLastName.Location = New System.Drawing.Point(76, 166)
        Me.txtPLastName.Name = "txtPLastName"
        Me.txtPLastName.Size = New System.Drawing.Size(139, 20)
        Me.txtPLastName.TabIndex = 6
        '
        'txtPFirstName
        '
        Me.txtPFirstName.Location = New System.Drawing.Point(221, 166)
        Me.txtPFirstName.Name = "txtPFirstName"
        Me.txtPFirstName.Size = New System.Drawing.Size(139, 20)
        Me.txtPFirstName.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(366, 166)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(139, 20)
        Me.TextBox3.TabIndex = 8
        '
        'txtPAge
        '
        Me.txtPAge.Location = New System.Drawing.Point(221, 264)
        Me.txtPAge.Name = "txtPAge"
        Me.txtPAge.Size = New System.Drawing.Size(139, 20)
        Me.txtPAge.TabIndex = 9
        '
        'txtPAddress
        '
        Me.txtPAddress.Location = New System.Drawing.Point(76, 214)
        Me.txtPAddress.Name = "txtPAddress"
        Me.txtPAddress.Size = New System.Drawing.Size(429, 20)
        Me.txtPAddress.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(698, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Date Today : "
        '
        'dtPDateArrived
        '
        Me.dtPDateArrived.Enabled = False
        Me.dtPDateArrived.Location = New System.Drawing.Point(765, 14)
        Me.dtPDateArrived.Name = "dtPDateArrived"
        Me.dtPDateArrived.Size = New System.Drawing.Size(194, 20)
        Me.dtPDateArrived.TabIndex = 12
        Me.dtPDateArrived.Value = New Date(2022, 12, 6, 10, 56, 32, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(73, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Gender"
        '
        'cmbPGender
        '
        Me.cmbPGender.FormattingEnabled = True
        Me.cmbPGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbPGender.Location = New System.Drawing.Point(76, 264)
        Me.cmbPGender.Name = "cmbPGender"
        Me.cmbPGender.Size = New System.Drawing.Size(139, 21)
        Me.cmbPGender.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(73, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Reason for seeing the Doctor"
        '
        'txtPReason
        '
        Me.txtPReason.Location = New System.Drawing.Point(76, 320)
        Me.txtPReason.Name = "txtPReason"
        Me.txtPReason.Size = New System.Drawing.Size(429, 20)
        Me.txtPReason.TabIndex = 19
        '
        'txtPContact
        '
        Me.txtPContact.Location = New System.Drawing.Point(366, 264)
        Me.txtPContact.Name = "txtPContact"
        Me.txtPContact.Size = New System.Drawing.Size(139, 20)
        Me.txtPContact.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(363, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Contact No."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(197, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(182, 24)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Patient Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(780, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 14
        '
        'btnAddPatient
        '
        Me.btnAddPatient.Location = New System.Drawing.Point(412, 376)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(93, 35)
        Me.btnAddPatient.TabIndex = 24
        Me.btnAddPatient.Text = "Add"
        Me.btnAddPatient.UseVisualStyleBackColor = True
        '
        'txtpid
        '
        Me.txtpid.Location = New System.Drawing.Point(76, 108)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(100, 20)
        Me.txtpid.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Patient ID"
        '
        'btnsee
        '
        Me.btnsee.Location = New System.Drawing.Point(930, 524)
        Me.btnsee.Name = "btnsee"
        Me.btnsee.Size = New System.Drawing.Size(118, 41)
        Me.btnsee.TabIndex = 27
        Me.btnsee.Text = "View Patient History"
        Me.btnsee.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(548, 79)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(500, 439)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'dttime
        '
        Me.dttime.CustomFormat = " "
        Me.dttime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dttime.Location = New System.Drawing.Point(965, 14)
        Me.dttime.Name = "dttime"
        Me.dttime.Size = New System.Drawing.Size(83, 20)
        Me.dttime.TabIndex = 31
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(313, 376)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(93, 35)
        Me.btnclear.TabIndex = 34
        Me.btnclear.Text = "Cancel"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(412, 376)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(93, 35)
        Me.btnUpdate.TabIndex = 35
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(76, 531)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(62, 26)
        Me.btnlogout.TabIndex = 36
        Me.btnlogout.Text = "Log out"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'RealApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1120, 603)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.dttime)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnsee)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpid)
        Me.Controls.Add(Me.btnAddPatient)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPContact)
        Me.Controls.Add(Me.txtPReason)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbPGender)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtPDateArrived)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPAddress)
        Me.Controls.Add(Me.txtPAge)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtPFirstName)
        Me.Controls.Add(Me.txtPLastName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label100)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "RealApp"
        Me.Text = "Patient Information System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label100 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPLastName As TextBox
    Friend WithEvents txtPFirstName As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtPAge As TextBox
    Friend WithEvents txtPAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtPDateArrived As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbPGender As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPReason As TextBox
    Friend WithEvents txtPContact As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents txtpid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnsee As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents dttime As DateTimePicker
    Friend WithEvents btnclear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnlogout As Button
End Class
