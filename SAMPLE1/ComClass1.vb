<ComClass(ComClass1.ClassId, ComClass1.InterfaceId, ComClass1.EventsId)> _
Public Class ComClass1

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "889cdf5e-532c-4ae2-9b01-7c7e1354f101"
    Public Const InterfaceId As String = "0858cba1-6149-4db3-95cd-ef86a15ee802"
    Public Const EventsId As String = "619b28be-13f8-417e-9156-4942f6c35b84"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
    End Sub

End Class


