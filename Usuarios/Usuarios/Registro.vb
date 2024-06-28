Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Registro

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click
        Me.Hide()
        Form1.Show()
        If (TextBox1.Text = " " Or TextBox2.Text = " " Or TextBox4.Text = " ") Then
            MsgBox("Faltan datos")
        Else
            Try
                Dim comando = New MySqlCommand("INSERT INTO usuarios(username,password,fullname) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "')", Conex)
                Dim resultado = comando.ExecuteNonQuery
                MsgBox("Dato ingresado", MsgBoxStyle.Information, "Éxito")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If



    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label2.Click, Label4.Click, Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged, TextBox4.TextChanged, TextBox3.TextChanged

    End Sub
End Class