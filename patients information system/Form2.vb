Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2

    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "A3sKDC7NgdnCGjVCExpISuAcEx4696PAS5nUlwf7",
        .BasePath = "https://patient-information-syst-2210f-default-rtdb.firebaseio.com/"
        }

    Private clients As IFirebaseClient

    Public Shared patientFullName As String
    Public Shared patientAddress As String
    Public Shared patientID As String
    Public Shared contacts As String
    Dim lv As ListViewItem


    Sub updateData(ByVal records As Dictionary(Of String, patientsData))

        ListView1.Clear()


        With ListView1
            .HideSelection = True
            .FullRowSelect = True
            .View = View.Details
            .GridLines = True
            .Columns.Add("Time And Date", 300)
            .Columns.Add("Description", 400)

        End With

        If (records Is Nothing) Then
        Else


            For Each items In records
                lv = New ListViewItem(items.Key)
                lv.SubItems.Add(items.Value.reason.ToUpper)

                ListView1.Items.Add(lv)
            Next

        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RealApp.Hide()
        txtpname.Text = patientFullName
        txtpaddress.Text = patientAddress
        txtpid.Text = patientID
        lblcontacts.Text = contacts
        ListView1.Clear()
        Try
            clients = New FireSharp.FirebaseClient(fcon)
            Dim getData = clients.Get("Patients/" + patientID + "/Description/")

            Dim res = getData.ResultAs(Of patientsData)

            Dim Data As Dictionary(Of String, patientsData) = JsonConvert.DeserializeObject(Of Dictionary(Of String, patientsData))(getData.Body.ToString())
            updateData(Data)

        Catch ex As Exception
            MsgBox("no connections")
        End Try

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Are You sure? ", (vbQuestion + vbYesNo)) = vbYes Then
            Me.Close()
            RealApp.Show()
        End If

    End Sub

    Private Sub txtpaddress_Click(sender As Object, e As EventArgs) Handles txtpaddress.Click

    End Sub

    Private Sub txtpname_Click(sender As Object, e As EventArgs) Handles txtpname.Click

    End Sub

    Private Sub btnRevove_Click(sender As Object, e As EventArgs) Handles btnRevove.Click
        If MsgBox("Are you sure you want to delete all of this information?", (vbYesNo + vbQuestion)) = vbYes Then
            Dim real As New patientsData

            Dim bin = clients.Get("Patients/" + patientID + "/PatientsData")
            Dim results = bin.ResultAs(Of patientsData)
            Dim getdatas As New patientsData() With
            {
                .firstname = results.firstname,
                .lastname = results.lastname,
                .middlename = results.middlename,
                .address = results.address,
                .age = results.age,
                .contactnumber = results.contactnumber
            }

            Dim setter = clients.Set("Backups/" + patientID, getdatas)


            Dim delete = clients.Delete("Patients/" + patientID)

            Dim realm = New RealApp
            Me.Hide()
            realm.ShowDialog()


        Else

        End If

    End Sub
End Class