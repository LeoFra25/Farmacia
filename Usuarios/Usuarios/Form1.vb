Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Form1
    'Dim cone As New MySqlConnection("server=localhost;User Id=root;database=farmacia")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If (TextBox1.Text = "Admin" And TextBox2.Text = "Admin") Then
        'MsgBox("Welcome Admin", MsgBoxStyle.DefaultButton1)
        'Me.Hide()
        'Principal.Show()   
        If (TextBox2.Text = " ") Then
            MsgBox("Dato vacío")
        Else
            Dim comando = New MySqlCommand("SELECT * FROM usuarios WHERE username = '" + TextBox2.Text + "';", Conex)
            Dim resultado = comando.ExecuteReader
            resultado.Read()
            If (resultado.HasRows) Then
                MsgBox("Nombre: " + resultado("fullname"))
                Me.Hide()
                Principal.Show()
            Else
                MsgBox("ERROR,usuario no encontrado ")
            End If
            resultado.Close()
            'MsgBox("Error,Datos no encontrados!", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Registro.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Conectar()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
