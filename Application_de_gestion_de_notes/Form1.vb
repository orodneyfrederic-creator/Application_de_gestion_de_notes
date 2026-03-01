Imports MySql.Data.MySqlClient

Public Class Form1
    ' Mot de passe vidé pour correspondre à la config root par défaut
    Dim connString As String = "server=localhost;userid=root;password=root;database=gestion_vacataire"
    ' --- BOUTON INSCRIPTION ---
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtNom.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs !")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Vérifie si l'utilisateur existe déjà pour éviter les doublons
                Dim checkSql As String = "SELECT COUNT(*) FROM utilisateurs WHERE username = @nom"
                Dim checkCmd As New MySqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@nom", txtNom.Text)

                If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("Ce nom d'utilisateur est déjà pris !")
                    Return
                End If

                ' Insertion
                Dim sql As String = "INSERT INTO utilisateurs (username, password) VALUES (@nom, @pass)"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nom", txtNom.Text)
                cmd.Parameters.AddWithValue("@pass", txtPass.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Compte créé avec succès !")

            Catch ex As Exception
                MessageBox.Show("Erreur de base de données : " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- BOUTON CONNEXION ---
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim sql As String = "SELECT COUNT(*) FROM utilisateurs WHERE username = @nom AND password = @pass"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nom", txtNom.Text)
                cmd.Parameters.AddWithValue("@pass", txtPass.Text)

                Dim resultat As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If resultat > 0 Then
                    MessageBox.Show("Connexion réussie ! Bienvenue " & txtNom.Text)
                    ' Basculement vers le menu principal
                    Dim f2 As New Acceuil()
                    f2.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Nom ou mot de passe incorrect.")
                End If

            Catch ex As Exception
                MessageBox.Show("Erreur de connexion : " & ex.Message)
            End Try
        End Using
    End Sub
End Class