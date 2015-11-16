Public Class User
    Implements INotifyPropertyChanged

    Private nameValue As String = String.Empty

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ' This method is called by the Set accessor of each property.
    ' The CallerMemberName attribute that is applied to the optional propertyName
    ' parameter causes the property name of the caller to be substituted as an argument.
    Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Property Name() As String
        Get
            Return Me.nameValue
        End Get

        Set(ByVal value As String)
            If Not (value = nameValue) Then
                Me.nameValue = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
End Class