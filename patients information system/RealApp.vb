Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Imports System.Security.Cryptography.X509Certificates
Imports System.Runtime.Remoting
Imports System.IO

Public Class RealApp
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "A3sKDC7NgdnCGjVCExpISuAcEx4696PAS5nUlwf7",
        .BasePath = "https://patient-information-syst-2210f-default-rtdb.firebaseio.com/"
        }

    Private clients As IFirebaseClient


    Dim lv As ListViewItem

    Sub updateData(ByVal records As Dictionary(Of String, patientsData))

        ListView1.Clear()
        With ListView1
            .HideSelection = True
            .FullRowSelect = True
            .View = View.Details
            .GridLines = True
            .Columns.Add("Patient ID", 100)
            .Columns.Add("Patient Name", 300)

        End With

        If (records Is Nothing) Then
        Else


            For Each items In records

                lv = New ListViewItem(items.Key)
                Dim getData = clients.Get("Patients/" + items.Key + "/PatientsData")
                Dim res = getData.ResultAs(Of patientsData)

                lv.SubItems.Add(res.firstname + " " + res.middlename + " " + res.lastname)

                ListView1.Items.Add(lv)
            Next

        End If


    End Sub


    Private Sub RealApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnsee.Enabled = False
        btnUpdate.Hide()
        btnAddPatient.Show()
        
        txtpid.Enabled = True

        Me.btnAddPatient.Enabled = True
        Me.btnUpdate.Hide()
        Try
            clients = New FireSharp.FirebaseClient(fcon)
            Dim getData As FirebaseResponse = clients.Get("Patients")
            Dim Data As Dictionary(Of String, patientsData) = JsonConvert.DeserializeObject(Of Dictionary(Of String, patientsData))(getData.Body.ToString())
            updateData(Data)

        Catch ex As Exception
            MsgBox("no connections")
        End Try
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        If (String.IsNullOrWhiteSpace(txtPLastName.Text) Or String.IsNullOrWhiteSpace(txtPFirstName.Text) Or String.IsNullOrWhiteSpace(label100.Text) Or String.IsNullOrWhiteSpace(txtPAge.Text) Or String.IsNullOrWhiteSpace(txtPAddress.Text) Or String.IsNullOrWhiteSpace(txtPContact.Text) Or String.IsNullOrWhiteSpace(dtPDateArrived.Text) Or String.IsNullOrWhiteSpace(txtPReason.Text)) Then
            MessageBox.Show("Fill-Up the blank Form")
        Else

            If MsgBox("Are You sure you want to add this record?", (vbYesNo + vbQuestion)) = vbYes Then

                Dim newpatient As New patientsData() With
                {
                    .firstname = txtPFirstName.Text,
                    .lastname = txtPLastName.Text,
                    .middlename = TextBox3.Text,
                    .age = txtPAge.Text,
                    .gender = cmbPGender.Text,
                    .address = txtPAddress.Text,
                    .contactnumber = txtPContact.Text,
                    .PatientId = txtpid.Text
                }
                Dim addnewdate As New patientsData() With
                {
                    .reason = txtPReason.Text,
                    .datearrived = dtPDateArrived.Text,
                    .timearrived = dttime.Text
                }

                Dim getter = clients.Get("Patients/" + txtpid.Text)

                Dim res = getter.ResultAs(Of patientsData)

                If (getter IsNot Nothing) Then
                    Dim setter = clients.Set("Patients/" + txtpid.Text + "/PatientsData", newpatient)
                    Dim addsetter = clients.Set("Patients/" + txtpid.Text + "/Description/" + dtPDateArrived.Text + " " + dttime.Text, addnewdate)
                End If

                Try
                    Dim getData As FirebaseResponse = clients.Get("Patients/")
                    Dim Data As Dictionary(Of String, patientsData) = JsonConvert.DeserializeObject(Of Dictionary(Of String, patientsData))(getData.Body.ToString())
                    MessageBox.Show("Added succesfully")
                    updateData(Data)
                    clear()
                Catch ex As Exception
                    MsgBox("no connection")
                End Try


            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsee.Click
        If MsgBox("Do you want to see this Patient History?", (vbQuestion + vbYesNo)) = vbYes Then
            Me.Hide()
            Dim f2 = New Form2
            f2.ShowDialog()
            Me.txtpid.Text = ""
            Me.txtPFirstName.Text = ""
            Me.txtPLastName.Text = ""
            Me.TextBox3.Text = ""
            btnAddPatient.Show()
            txtpid.Enabled = True
            btnUpdate.Hide()
            Me.txtPAddress.Text = ""
            Me.txtPAge.Text = ""
            Me.cmbPGender.Text = ""
            Me.txtPContact.Text = ""
            Me.txtPReason.Text = ""
            Me.btnAddPatient.Text = "Add"

        End If
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        clients = New FireSharp.FirebaseClient(fcon)
        btnUpdate.Show()
        btnAddPatient.Hide()
        btnsee.Enabled = True
        txtpid.Enabled = False



        Dim i As Integer
        For i = 0 To ListView1.SelectedItems.Count - 1
            Dim Selected = ListView1.SelectedItems(i).Text
            Dim getData As FirebaseResponse = clients.Get("Patients/" + Selected.ToString + "/PatientsData")
            Dim res = getData.ResultAs(Of patientsData)
            Me.txtpid.Text = res.PatientId
            Me.txtPLastName.Text = res.lastname
            Me.txtPFirstName.Text = res.firstname
            Me.TextBox3.Text = res.middlename
            Me.txtPAddress.Text = res.address
            Me.txtPAge.Text = res.age
            Me.cmbPGender.Text = res.gender
            Me.txtPContact.Text = res.contactnumber

            Dim form2data As New Form2
            Form2.patientFullName = Me.txtPFirstName.Text + " " + Me.TextBox3.Text + " " + Me.txtPLastName.Text
            Form2.patientAddress = Me.txtPAddress.Text
            Form2.patientID = Me.txtpid.Text
            Form2.contacts = Me.txtPContact.Text
        Next
    End Sub



    Sub clear()
        Me.txtpid.Text = ""
        Me.txtPFirstName.Text = ""
        Me.txtPLastName.Text = ""
        Me.TextBox3.Text = ""
        btnAddPatient.Show()
        Me.txtPAddress.Text = ""
        Me.txtPAge.Text = ""
        Me.cmbPGender.Text = ""
        Me.txtPContact.Text = ""
        Me.txtPReason.Text = ""
        Me.btnAddPatient.Text = "Add"
        btnsee.Enabled = False
        Me.btnAddPatient.Enabled = True
        Me.btnUpdate.Hide()
        txtpid.Enabled = True

    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updatePatient As New patientsData() With
    {
        .firstname = txtPFirstName.Text,
        .lastname = txtPLastName.Text,
        .middlename = TextBox3.Text,
        .age = txtPAge.Text,
        .gender = cmbPGender.Text,
        .address = txtPAddress.Text,
        .contactnumber = txtPContact.Text,
        .PatientId = txtpid.Text
        }
        Dim addnewdate As New patientsData() With
                {
                    .reason = txtPReason.Text,
                    .datearrived = dtPDateArrived.Text,
                    .timearrived = dttime.Text
                }

        Dim inttgetter = clients.Get("Patients/" + txtpid.Text)

        Dim res = inttgetter.ResultAs(Of patientsData)
        Dim setter

        If (String.IsNullOrWhiteSpace(txtPLastName.Text) Or String.IsNullOrWhiteSpace(txtPFirstName.Text) Or String.IsNullOrWhiteSpace(label100.Text) Or String.IsNullOrWhiteSpace(txtPAge.Text) Or String.IsNullOrWhiteSpace(txtPAddress.Text) Or String.IsNullOrWhiteSpace(txtPContact.Text) Or String.IsNullOrWhiteSpace(dtPDateArrived.Text) Or String.IsNullOrWhiteSpace(txtPReason.Text)) Then
            MsgBox("Please Fill-Up The Form")
        Else

            If MsgBox("Are you sure you want to Update The information?", (vbYesNo + vbQuestion)) = vbYes Then

                setter = clients.Update("Patients/" + txtpid.Text + "/PatientsData", updatePatient)

                Dim addsetter = clients.Set("Patients/" + txtpid.Text + "/Description/" + dtPDateArrived.Text + " " + dttime.Text, addnewdate)
                Try
                    Dim getData As FirebaseResponse = clients.Get("Patients/")
                    Dim Data As Dictionary(Of String, patientsData) = JsonConvert.DeserializeObject(Of Dictionary(Of String, patientsData))(getData.Body.ToString())
                    MessageBox.Show("Updated")
                    updateData(Data)
                    clear()
                Catch ex As Exception
                    MsgBox("no connection")
                End Try
            Else

            End If
        End If



    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If MsgBox("Are you sure you want to log out?", (vbYesNo + vbQuestion)) = vbYes Then
            Dim f1 = New Form1
            Me.Hide()
            f1.ShowDialog()
        End If
    End Sub
End Class