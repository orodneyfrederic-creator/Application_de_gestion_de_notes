Imports MySql.Data.MySqlClient

Public Class Acceuil
    Dim connString As String = "server=localhost;database=gestion_vacataire;user=root;password=root"

    Public Sub AfficherStats()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' --- CALCUL DU TOTAL DES ÉTUDIANTS ---
                ' La commande COUNT(*) compte toutes les lignes de la table etudiants
                Dim cmdEtud As New MySqlCommand("SELECT COUNT(*) FROM etudiants", conn)
                AffichementEtudiants.Text = cmdEtud.ExecuteScalar().ToString()

                ' --- CALCUL DU TOTAL DES ÉTABLISSEMENTS ---
                Dim cmdEtab As New MySqlCommand("SELECT COUNT(*) FROM etablissements", conn)
                AffichageEtab.Text = cmdEtab.ExecuteScalar().ToString()

                ' --- CALCUL DES ÉTUDIANTS EN DIFFICULTÉ ---
                ' On sélectionne les étudiants dont la moyenne (AVG) est strictement inférieure à 10
                Dim sqlDiff As String = "SELECT COUNT(*) FROM (SELECT id_etudiant FROM notes GROUP BY id_etudiant HAVING AVG(valeur_note) < 10) AS TableTemp"
                Dim cmdDiff As New MySqlCommand(sqlDiff, conn)
                Dim nbDiff As Integer = Convert.ToInt32(cmdDiff.ExecuteScalar())

                Label5.Text = nbDiff.ToString()

                ' Détail visuel : Rouge si danger (<10), Vert si tout va bien
                If nbDiff > 0 Then
                    Label5.ForeColor = Color.Red
                Else
                    Label5.ForeColor = Color.Green
                End If

            End Using
        Catch ex As Exception
            ' Si le serveur MySQL n'est pas lancé, l'erreur s'affichera ici
            MessageBox.Show("Erreur de connexion : " & ex.Message)
        End Try
    End Sub

    'Mise à jour après ouverture du formulaire
    Private Sub FrmTableauBord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AfficherStats()
    End Sub



    ' MISE À JOUR : Quand on revient sur cette fenêtre (Automatisme total)
    ' Si tu ajoutes un étudiant ailleurs, le chiffre change dès que tu reviens ici
    Private Sub FrmTableauBord_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        AfficherStats()
    End Sub


    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnEteablissements_Click(sender As Object, e As EventArgs) Handles BtnEteablissements.Click
        FormEtablissement.Show()
        Me.Hide() ' Optionnel : cache le menu si tu ne veux pas encombrer l'écran

    End Sub

    Private Sub BtnCours_Click(sender As Object, e As EventArgs) Handles BtnCours.Click
        FormCours.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSaisiedesnotes_Click(sender As Object, e As EventArgs) Handles BtnSaisiedesnotes.Click
        FormSaisie.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDéconnexion_Click(sender As Object, e As EventArgs) Handles BtnDéconnexion.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NoteSaisie.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormResults.Show()
        Me.Hide()
    End Sub



    'Affichement du nombre total d'étudiants
    Private Sub AffichementEtudiants_Click(sender As Object, e As EventArgs) Handles AffichementEtudiants.Click

    End Sub




    'Affichage du nombre total d'établissements
    Private Sub AffichageEtab_Click(sender As Object, e As EventArgs) Handles AffichageEtab.Click

    End Sub



    'Affichage du nombre total d'étudiant
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class