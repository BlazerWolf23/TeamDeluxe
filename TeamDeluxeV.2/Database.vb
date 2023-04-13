Imports Microsoft.Win32
Module Database
    Public Username As String
    Public Password As String
    Public ServerBD As String
    Public DatabaseBD As String
    Public Connection As New ADODB.Connection

    Public Sub InicializarBD(user As String, pass As String, Server As String, Database As String)
        Try
            Username = Trim(user)
            Password = Trim(pass)
            ServerBD = Trim(Server)
            DatabaseBD = Trim(Database)
            Connection = New ADODB.Connection

            Connection.Open("Provider=SQLNCLI10;Persist Security Info=False;Data Source=" & Server & ";Initial Catalog=" & Database &
                ";User ID=" & Username & ";Password=" & Password & ";")
            GuardarDatosEnRegistro("ServerSQL", ServerBD)
            GuardarDatosEnRegistro("UsernameSQL", Username)
            GuardarDatosEnRegistro("PasswordSQL", Password)
            GuardarDatosEnRegistro("DatabaseSQL", DatabaseBD)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub GuardarDatosEnRegistro(NomVariable As String, valorVariable As String)
        Dim ServidorBD As RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\TeamDeluxe")
        ServidorBD.SetValue(NomVariable, valorVariable, RegistryValueKind.String)
    End Sub

End Module
