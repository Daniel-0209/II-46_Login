Public Class Usuario
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Email As String
    Public Property Password As String
    ' Constructor por defecto
    Public Sub New()
        ' Inicializar propiedades si es necesario
    End Sub
    Public Function Validar() As Boolean
        Return Not String.IsNullOrEmpty(Email) AndAlso Not String.IsNullOrEmpty(Password)
    End Function

    Public Function dtToUsuario(dt As DataTable) As Usuario
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            Return Nothing
        End If
        Dim usuario As New Usuario()
        Dim row As DataRow = dt.Rows(0)
        usuario.Id = If(row("Id") IsNot DBNull.Value, Convert.ToInt32(row("Id")), 0)
        usuario.Nombre = If(row("Nombre") IsNot DBNull.Value, row("Nombre").ToString(), String.Empty)
        usuario.Apellido = If(row("Apellido") IsNot DBNull.Value, row("Apellido").ToString(), String.Empty)
        usuario.Email = If(row("Email") IsNot DBNull.Value, row("Email").ToString(), String.Empty)
        usuario.Password = If(row("Contraseña") IsNot DBNull.Value, row("Contraseña").ToString(), String.Empty)
        Return usuario
    End Function


End Class
