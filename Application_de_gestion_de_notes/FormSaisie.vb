Imports MySql.Data.MySqlClient

Public Class FormSaisie
    Dim connString As String = "server=localhost;user=root;password=root;database=gestion_vacataire"
    Dim conn As New MySqlConnection(connString)

    Private Sub Saisie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirCombo()
        RemplirGrille()

    End Sub

    ' --- REMPLIR LA LISTE DES ÉCOLES ---
    Private Sub RemplirCombo()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT id_etablissement, nom FROM Etablissements", conn)
            adapter.Fill(table)

            cmbEtablissement.DataSource = table
            cmbEtablissement.DisplayMember = "nom"
            cmbEtablissement.ValueMember = "id_etablissement"
            conn.Close()
        Catch ex As Exception
            MsgBox("Erreur Combo : " & ex.Message)
        End Try
    End Sub

    ' --- AFFICHER LES ÉTUDIANTS (Avec le nom de leur école) ---
    Public Sub RemplirGrille()
        Try
            conn.Open()
            ' On fait une jointure pour afficher le NOM de l'école au lieu de l'ID
            Dim query As String = "SELECT T.id_etudiant As ID, T.nom As Nom, T.prenom As Prenom, E.nom As Etablissement " &
                                 "FROM Etudiants T " &
                                 "INNER JOIN Etablissements E ON T.id_etablissement = E.id_etablissement"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvEtudiants.DataSource = table
            conn.Close()
        Catch ex As Exception
            MsgBox("Erreur Grille : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    ' --- BOUTON AJOUTER ---
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO Etudiants (nom, prenom, id_etablissement) VALUES (@nom, @pre, @id_etab)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nom", txtNom.Text)
            cmd.Parameters.AddWithValue("@pre", txtPrenom.Text)
            cmd.Parameters.AddWithValue("@id_etab", cmbEtablissement.SelectedValue)

            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Étudiant ajouté avec succès !")
            RemplirGrille()
        Catch ex As Exception
            MsgBox("Erreur Ajout : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub dgvEtudiants_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEtudiants.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEtudiants.Rows(e.RowIndex)
            txtNom.Text = row.Cells("Nom").Value.ToString()
            txtPrenom.Text = row.Cells("Prenom").Value.ToString()
            cmbEtablissement.Text = row.Cells("Etablissement").Value.ToString()
        End If
    End Sub



    ' --- BOUTON MODIFIER ---
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgvEtudiants.CurrentRow Is Nothing Then Exit Sub

        Try
            conn.Open()
            Dim query = "UPDATE etudiants SET nom=@nom, prenom=@pre, id_etablissement=@id_etab WHERE id_etudiant=@id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@nom", txtNom.Text)
            cmd.Parameters.AddWithValue("@pre", txtPrenom.Text)
            cmd.Parameters.AddWithValue("@id_etab", cmbEtablissement.SelectedValue)


            ' On récupère l'ID de la ligne sélectionnée dans la grille
            cmd.Parameters.AddWithValue("@id", dgvEtudiants.CurrentRow.Cells("ID").Value)


            cmd.ExecuteNonQuery()
            conn.Close()

            MsgBox(" mis à jour !")
            RemplirGrille()
        Catch ex As Exception
            MsgBox("Erreur Modification : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    ' --- BOUTON SUPPRIMER ---
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dgvEtudiants.CurrentRow Is Nothing Then Exit Sub

        Dim resultat = MsgBox("Supprimer cet apprenant ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If resultat = MsgBoxResult.Yes Then
            Try
                conn.Open()
                Dim query = "DELETE FROM Etudiants WHERE id_etudiant=@id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", dgvEtudiants.CurrentRow.Cells("ID").Value)
                cmd.ExecuteNonQuery()

                ' Reset Auto-incrément
                Dim cmdReset As New MySqlCommand("ALTER TABLE Cours AUTO_INCREMENT = 1", conn)
                cmdReset.ExecuteNonQuery()

                conn.Close()
                MsgBox("Apprenant supprimé avec succès!")
                RemplirGrille()
                txtNom.Clear()
                txtPrenom.Clear()
            Catch ex As Exception
                MsgBox("Erreur Suppression : " & ex.Message)
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If
    End Sub


    ' --- BOUTON RAFRAICHIR ---
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtNom.Clear()
        txtPrenom.Clear()
        RemplirCombo()
        RemplirGrille()
    End Sub


    ' --- BOUTON RETOUR ---
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Acceuil.Show()
        Me.Hide()
    End Sub
End Class