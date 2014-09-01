Public Class Form1

    Private Sub Login1_Click(sender As Object, e As EventArgs) Handles Login1.Click
        Process.Start("net", "use z: https://dav.box.com/dav /user:" & UserName.Text() & " " & PassWord.Text())
        MsgBox("Login Effettuato!")
    End Sub


    Private Sub Login2_Click(sender As Object, e As EventArgs) Handles Login2.Click
        Process.Start("net", "use z: https://dav.box.com/dav /user:" & UserName.Text() & " " & PassWord.Text() & " /PERSISTENT:YES")
        MsgBox("Successful Login!")
    End Sub

    Private Sub ViewFile_Click(sender As Object, e As EventArgs) Handles ViewFile.Click
        Process.Start("explorer.exe", "Z:\")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        language.Items.Add("EN")
        language.Items.Add("IT")
        language.Items.Add("ESP")
        language.Items.Add("FR")

    End Sub

    Private Sub language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles language.SelectedIndexChanged
        If language.Text() = "EN" Then
            Logout1.Text = "Logout"
            Login1.Text = "Login (always ask for credentials)"
            Login2.Text = "Login (save credentials)"
            ViewFile.Text = "displays files Box.com"
            Label3.Text = "Change language:"
            Label4.Text = "Do not close the Command Prompt"
        End If
        If language.Text() = "IT" Then
            Logout1.Text = "Logout"
            Login1.Text = "Login (chiedi sempre credenziali)"
            Login2.Text = "Login (salva credenziali)"
            ViewFile.Text = "visualizza file di Box.com"
            Label3.Text = "Cambia lingua:"
            Label4.Text = "Non chiudere la finestra del Prompt dei comandi"
        End If
        If language.Text() = "ESP" Then
            Logout1.Text = "Logout"
            Login1.Text = "Login (siempre pide las credenciales)"
            Login2.Text = "Login (guardar las credenciales)"
            ViewFile.Text = "muestra los file Box.com"
            Label3.Text = "Cambiar idioma:"
            Label4.Text = "No cierre el Command Prompt"

        End If
        If language.Text() = "FR" Then
            Logout1.Text = "Logout"
            Login1.Text = "Login (toujours demander des informations d'identification)"
            Login2.Text = "Login (enregistrer des informations d'identification)"
            ViewFile.Text = "affiche les file Box.com"
            Label3.Text = "Changer la langue:"
            Label4.Text = "Ne fermez pas l'invite de Command Prompt"

        End If
    End Sub

    Private Sub PassWord_TextChanged(sender As Object, e As EventArgs) Handles PassWord.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Logout1_Click_1(sender As Object, e As EventArgs) Handles Logout1.Click
        Process.Start("net", "use z: /delete")
        MsgBox("Successful Logout!")
    End Sub
End Class
