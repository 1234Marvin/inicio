Public Class Login

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim dts As New Datos
            Dim funciones As New funcion
            dts.gusuario = Me.UsernameTextBox.Text
            dts.gcontraseña = Me.PasswordTextBox.Text
            dts.gtipo = Me.ComboBox1.SelectedItem

            If funciones.validar(dts) = True Then
                Dim fr As New Form1
                fr.Show()
                Me.Hide()
            Else
                MessageBox.Show("datos incorrectos", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.UsernameTextBox.Clear()
                Me.PasswordTextBox.Clear()
                Me.UsernameTextBox.Focus()

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try






    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
