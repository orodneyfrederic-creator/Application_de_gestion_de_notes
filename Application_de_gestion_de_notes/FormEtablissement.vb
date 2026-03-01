Imports MySql.Data.MySqlClient

Public Class FormEtablissement

    ' Configuration de la connexion
    Dim connString As String = "server=localhost;user=root;password=root;database=gestion_vacataire"
    Dim conn As New MySqlConnection(connString)

    ' 1. CHARGEMENT DU FORMULAIRE
    Private Sub FormEtablissement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirGrille()
    End Sub


    ' 2. MÉTHODE POUR REMPLIR LE DATAGRIDVIEW
    Public Sub RemplirGrille()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            ' Utilisation d'alias (As) pour des entêtes de colonnes propres
            Dim query As String = "SELECT id_etablissement As ID, nom As Nom, ville As Ville FROM etablissements"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table
            conn.Close()
        Catch ex As Exception
            MsgBox("Erreur lors du chargement : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub




    ' 3. BOUTON AJOUTER (Button2)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If txtNom.Text = "" Or txtVille.Text = "" Then
            MsgBox("Veuillez remplir tous les champs avant d'ajouter.")
            Return
        End If

        Try
            conn.Open()
            Dim query = "INSERT INTO etablissements (nom, ville) VALUES (@nom, @ville)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nom", txtNom.Text)
            cmd.Parameters.AddWithValue("@ville", txtVille.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MsgBox("Établissement ajouté avec succès !")
            RemplirGrille()
            txtNom.Clear()
            txtVille.Clear()
        Catch ex As Exception
            MsgBox("Erreur d'ajout : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub


    ' 4. CLIC SUR LA GRILLE (Pour remplir les TextBox automatiquement)

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        ' On vérifie que la ligne cliquée est valide
        If e.RowIndex >= 0 Then
            Dim row = DataGridView1.Rows(e.RowIndex)
            ' On récupère les valeurs pour les mettre dans les TextBox
            txtNom.Text = row.Cells("Nom").Value.ToString
            txtVille.Text = row.Cells("Ville").Value.ToString
        End If
    End Sub


    ' 5. BOUTON MODIFIER (Button3)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MsgBox("Sélectionnez un établissement dans la liste.")
            Return
        End If

        Dim id As Integer = DataGridView1.CurrentRow.Cells("ID").Value

        Try
            conn.Open()
            Dim query = "UPDATE etablissements SET nom=@nom, ville=@ville WHERE id_etablissement=@id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nom", txtNom.Text)
            cmd.Parameters.AddWithValue("@ville", txtVille.Text)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            conn.Close()

            MsgBox("Modification réussie !")
            RemplirGrille()
        Catch ex As Exception
            MsgBox("Erreur de modification : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub



    ' 6. BOUTON SUPPRIMER (Button4)
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If DataGridView1.CurrentRow Is Nothing Then Return

        Dim id As Integer = DataGridView1.CurrentRow.Cells("ID").Value
        Dim resultat = MsgBox("Voulez-vous vraiment supprimer cet établissement ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resultat = MsgBoxResult.Yes Then
            Try
                conn.Open()
                Dim query = "DELETE FROM etablissements WHERE id_etablissement=@id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                conn.Close()

                RemplirGrille()
                txtNom.Clear()
                txtVille.Clear()
            Catch ex As Exception
                MsgBox("Erreur : Impossible de supprimer car cet établissement est lié à des cours ou étudiants.")
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If

    End Sub



    ' 7. BOUTON RAFRAÎCHIR (Button5)
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RemplirGrille()
        txtNom.Clear()
        txtVille.Clear()
        MsgBox("Liste actualisée.")
    End Sub


    ' 8. BOUTON RETOUR (Button1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Acceuil.Show()
        Hide()

    End Sub




End Class