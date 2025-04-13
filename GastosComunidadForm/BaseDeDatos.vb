Imports MySql.Data.MySqlClient

Public Class BaseDeDatos
    Private connectionString As String = "server=localhost;user=root;password=tu_contraseña;database=nombre_base_de_datos"

    ' Método para insertar un gasto
    Public Sub InsertarGasto(descripcion As String, monto As Decimal, comunidad As String, deudaInicial As Decimal)
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO Gastos (Descripcion, Monto, Comunidad, DeudaInicial) VALUES (@Descripcion, @Monto, @Comunidad, @DeudaInicial)", conn)
                cmd.Parameters.AddWithValue("@Descripcion", descripcion)
                cmd.Parameters.AddWithValue("@Monto", monto)
                cmd.Parameters.AddWithValue("@Comunidad", comunidad)
                cmd.Parameters.AddWithValue("@DeudaInicial", deudaInicial)

                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error al insertar gasto: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Método para calcular el saldo pendiente (deuda - pagos realizados)
    Public Function CalcularSaldo(comunidad As String, deudaInicial As Decimal) As Decimal
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT SUM(Monto) FROM Gastos WHERE Comunidad = @Comunidad", conn)
                cmd.Parameters.AddWithValue("@Comunidad", comunidad)

                Dim totalGastos As Object = cmd.ExecuteScalar()
                If totalGastos IsNot DBNull.Value Then
                    Return deudaInicial - Convert.ToDecimal(totalGastos)
                Else
                    Return deudaInicial
                End If
            Catch ex As Exception
                MessageBox.Show("Error al calcular saldo: " & ex.Message)
                Return deudaInicial
            End Try
        End Using
    End Function
End Class
