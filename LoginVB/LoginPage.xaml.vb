﻿' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class LoginPage
    Inherits Page

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        App.LoginUser.Name = UserName.Text

    End Sub
End Class