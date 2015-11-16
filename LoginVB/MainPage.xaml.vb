' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub Login_Click(sender As Object, e As RoutedEventArgs) Handles Login.Click
        MainFrame.Navigate(GetType(LoginPage))

    End Sub

    Private Sub Page_Loaded(sender As Object, e As RoutedEventArgs)
        Me.DataContext = App.LoginUser

    End Sub
End Class