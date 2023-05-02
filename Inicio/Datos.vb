Public Class Datos
    Dim usuario As String
    Dim contraseña As String
    Dim tipo As String


    Public Property gusuario()
        Get
            Return usuario
        End Get
        Set(value)
            usuario = value
        End Set
    End Property

    Public Property gcontraseña
        Get
            Return contraseña
        End Get
        Set(value)
            contraseña = value
        End Set
    End Property
    Public Property gtipo()
        Get
            Return tipo
        End Get
        Set(value)
            tipo = value
        End Set
    End Property
End Class
