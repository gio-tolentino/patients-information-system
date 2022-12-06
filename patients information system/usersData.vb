Public Class usersData
    Public Property userName() As String
    Public Property Password() As String
    Public Property IdNumber() As String
    Public Property FullName() As String

    Private Shared errmsg = "the user is not found"

    Public Shared Sub showError()
        MessageBox.Show(errmsg)

    End Sub


    Public Shared Function IsEqual(user1 As usersData, user2 As usersData)
        If (user1 Is Nothing Or user2 Is Nothing) Then
            errmsg = "the user is not found"
            Return False
        End If

        If (user1.userName <> user2.userName) Then
            errmsg = "username is not found"
            Return False
        End If

        If (user1.Password <> user2.Password) Then
            errmsg = "Username and password is mismatch"
            Return False
        End If
        Form1.Hide()

        Return True

    End Function

End Class
