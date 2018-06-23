Imports System.ComponentModel

Public Class Clientecollection

    Inherits BindingList(Of ClienteClass)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New ClienteClass()
    End Sub

End Class
