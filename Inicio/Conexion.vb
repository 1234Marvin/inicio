Imports System.Data.SqlClient
Public Class Conexion
    Protected cnn As New SqlConnection
    Protected Function conectado()
        Try
            cnn = New SqlConnection("Data Source=DESKTOP-TQV5KKA\MSSQLSERVER01;Initial Catalog=BDLAMK;Integrated Security=True")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
End Class
