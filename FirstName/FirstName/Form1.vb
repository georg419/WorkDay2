Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click

        Dim fullname As String
        'Read the input from the user'
        fullname = txtFullName.Text
        'Store input from the user

        Dim fullnameTrimmed As String
        'Trims the input so to remove leading spaces (space character infront of name)
        fullnameTrimmed = fullname.Trim()


        Dim idxSpace As Integer
        'find index of first space 
        idxSpace = fullnameTrimmed.IndexOf(" ")
        'find where the space character is located

        Dim firstName As String
        firstName = fullnameTrimmed.Substring(0, idxSpace)
        'Extracts the first name


        txtFirstName.Text = firstName
        'Display input from user into First Name Box





    End Sub
End Class
