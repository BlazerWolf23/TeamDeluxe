Imports System.Windows.Controls
Imports MaterialSkin.Controls

Public Class Usuarios
    Dim rs As New ADODB.Recordset

    Public Sub Guardar()
        If Trim(TxID.Text) = "" Then MsgBox("No se puede dejar este campo vacio.") : Exit Sub
        If Trim(TxNombre.Text) = "" Then MsgBox("El campo nombre no se puede dejar vacio.") : Exit Sub
    End Sub

    Public Sub Consulta()
        Dim Row As Integer
        Dim sql As String
        If VariablesAPP.RolUsuario = "Admin" Then
            sql = "Select * from usuario"
        Else
            sql = "Select usuario.*, equipo.nombre as nombreEquipo from usuario Inner Join equipo where usuario.idequipo = equipo.idequipo " &
                " where usuario.idequipo = " & VariablesAPP.EquipoUsuario
        End If
        Dim rs As New ADODB.Recordset
        rs.Open(sql, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)

        Do Until rs.EOF
            Row = DbgUsuarios.Rows.Add
            DbgUsuarios.Rows(Row).Cells(0).Value = Trim(rs("id").Value)
            DbgUsuarios.Rows(Row).Cells(1).Value = Trim(rs("nombre").Value)
            DbgUsuarios.Rows(Row).Cells(2).Value = Trim(rs("apellido").Value)
            DbgUsuarios.Rows(Row).Cells(3).Value = Trim(rs("DNI").Value)
            DbgUsuarios.Rows(Row).Cells(4).Value = Trim(rs("Telefono").Value)
            DbgUsuarios.Rows(Row).Cells(5).Value = Trim(rs("nombreEquipo").Value)
            rs.MoveNext()
        Loop


    End Sub

    Public Sub Eliminar()

    End Sub

    Public Sub Nuevo()
        TxID.Text = "" : TxNombre.Text = ""
        TxApellido.Text = "" : TxDNI.Text = ""
        DTPfechaNac.Value = Now.Date : TxTelefono.Text = ""
        TxDireccion.Text = "" : TxPais.Text = ""
        TxProvincia.Text = "" : TxLocalidad.Text = ""
        If Not CboEquipo.Items.Count <= 0 Then CboEquipo.SelectedIndex = 0
        If Not CboTipoUsuario.Items.Count <= 0 Then CboTipoUsuario.SelectedIndex = 0

        TxIDbus.Text = "" : TxNombreBus.Text = ""
        TxDNIbus.Text = "" : TxApellidoBus.Text = ""
        If CboEquipoBus.Items.Count <= 0 Then CboEquipoBus.SelectedIndex = 0
        TxApellidoBus.Text = ""
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        CargarTipoUsuarios()
        CargarEquipo(CboEquipo)
        CargarEquipo(CboEquipoBus)
    End Sub

    Private Sub CargarTipoUsuarios()
        ' De momento cargar a mano ya que no tengo tabla de tipo de usuarios
        ' Hablar con Javier para decir si esta tabla renta, o renta hacer el cargado a mano
        If Trim(VariablesAPP.RolUsuario) = "Admin" Then
            CboTipoUsuario.Items.Add("Admin")
            CboTipoUsuario.Items.Add("Entrenador")
        End If
        CboTipoUsuario.Items.Add("Jugador")
    End Sub

    Private Sub CargarEquipo(Combo As MaterialComboBox)
        Dim ItemCombo As ComboBoxItem
        Dim rsEquipos As New ADODB.Recordset
        Dim index As Integer
        Dim sql As String
        If Trim(VariablesAPP.RolUsuario) = "Admin" Then
            sql = "Select * from equipos"
        Else
            sql = "Select * from equipos where idUsuario = " & VariablesAPP.IdUsuarioApp
        End If
        rsEquipos.Open(sql, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Do Until rsEquipos.EOF

            index = Combo.Items.Add(Trim(rsEquipos("nombre").Value))
            rsEquipos.MoveNext()
        Loop
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click

    End Sub
End Class