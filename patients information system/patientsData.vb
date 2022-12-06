Public Class patientsData

    Public Property lastname() As String
    Public Property firstname() As String
    Public Property middlename() As String
    Public Property gender() As String
    Public Property age() As String
    Public Property address() As String
    Public Property contactnumber() As String
    Public Property datearrived() As String
    Public Property timearrived() As String
    Public Property reason() As String
    Public Property PatientId() As String

  

    Public Shared errMsg = "the user is not found"

    Public Shared Sub showErrmsg()
        MessageBox.Show(errMsg)
    End Sub




End Class
