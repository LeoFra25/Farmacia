Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Form2

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click, Label3.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Principal.Show()
        If (TextBox1.Text = " " Or TextBox2.Text = " " Or TextBox3.Text = " " Or ComboBox1.Text = " ") Then
            MsgBox("Faltan datos")
        Else
            Try
                Dim comando = New MySqlCommand("INSERT INTO Productos(productname,category,price,quantity) VALUES('" + TextBox1.Text + "','" + ComboBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", Conex)
                Dim resultado = comando.ExecuteNonQuery
                MsgBox("Producto agregado", MsgBoxStyle.Information, "Éxito")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class