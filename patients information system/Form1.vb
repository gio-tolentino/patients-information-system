Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Text = ""
        txtpassword.Text = ""

        Try
            clients = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MsgBox("no connection")
        End Try

    End Sub

    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "A3sKDC7NgdnCGjVCExpISuAcEx4696PAS5nUlwf7",
        .BasePath = "https://patient-information-syst-2210f-default-rtdb.firebaseio.com/"
        }

    Private clients As IFirebaseClient

    Public Sub cleartxt()
        Me.txtusername.Text = ""
        Me.txtpassword.Text = ""
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If (String.IsNullOrWhiteSpace(txtusername.Text) Or String.IsNullOrWhiteSpace(txtpassword.Text)) Then
            MsgBox("Please Fill-up the Blank")
            Return
        End If
        Dim res = clients.Get("Users/" + txtusername.Text)
        Dim resUser = res.ResultAs(Of usersData)

        Dim Curuser As New usersData With
            {
                .userName = txtusername.Text,
                .Password = txtpassword.Text
            }

        If (usersData.IsEqual(resUser, Curuser)) Then
            Dim real = New RealApp
            Me.Hide()
            real.ShowDialog()


        Else
            usersData.showError()
        End If
    End Sub
End Class
