Public Class Home
    

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        Dim _details As New Details
        _details.Show()
        Me.Visible = False
    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        Dim _retrieve As New Retrive_Data
        _retrieve.Show()
        Me.Visible = False
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub
End Class