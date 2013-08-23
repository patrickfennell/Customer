﻿Public Class Details

    Private Sub Details_Load(sender As Object,
                             e As EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub btnSubmit_Click(sender As Object,
                                e As EventArgs) Handles btnSubmit.Click

        Dim CustomerAccess As New CustomerAccess()
        Dim _customer As New Customer()
        Try
            _customer.FirstName = txtFIrstName.Text
            _customer.LastName = txtLastName.Text
            _customer.EMail = txtEmail.Text
            _customer.Gender = cboGender.Text
            _customer.Age = cboAge.Text

            CustomerAccess.SaveCustomer(_customer)

        Catch ex As Exception

            MsgBox("All Data fields are not filled")

        End Try
        txtFIrstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        cboGender.Text = ""
        cboAge.Text = ""


    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        Dim _home As New Home
        _home.Show()
        Me.Visible = False
    End Sub
End Class