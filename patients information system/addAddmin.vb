Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class addAddmin
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "A3sKDC7NgdnCGjVCExpISuAcEx4696PAS5nUlwf7",
        .BasePath = "https://patient-information-syst-2210f-default-rtdb.firebaseio.com/"
        }

    Private clients As IFirebaseClient

    Private Sub addAddmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            clients = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MsgBox("no connection")
        End Try


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnaddusers.Click
        If (String.IsNullOrEmpty(txtaddusername.Text) Or String.IsNullOrEmpty(txtaddpassword.Text) Or String.IsNullOrEmpty(txtaddfullname.Text) Or String.IsNullOrEmpty(txtaddIdnum.Text)) Then
            MessageBox.Show("Fill-Up the blank Form")

        Else
            Dim newAdmin As New usersData() With
            {
               .userName = txtaddusername.Text,
               .FullName = txtaddfullname.Text,
               .IdNumber = txtaddIdnum.Text,
               .Password = txtaddpassword.Text
            }

            Dim setter = clients.Set("Users/" + txtaddusername.Text, newAdmin)

            MessageBox.Show("add succesfully")
        End If

    End Sub

End Class