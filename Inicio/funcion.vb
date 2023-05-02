Imports System.Data.SqlClient
Public Class funcion
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function validar(dts As Datos) As Boolean
        Try
            Me.conectado()
            cmd = New SqlCommand("validar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@usario", dts.gusuario)
            cmd.Parameters.AddWithValue("@contraseña", dts.gcontraseña)
            cmd.Parameters.AddWithValue("@tipo", dts.gtipo)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Me.desconectado()
        End Try
    End Function

End Class
