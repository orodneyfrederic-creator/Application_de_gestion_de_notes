Imports MySql.Data.MySqlClient

Public Class FormCours

    ' --- CORRECTION 1 : Mot de passe vide et ajout de SslMode pour éviter les erreurs ---
    Dim connString As String = "server=localhost;user=root;password=root;database=gestion_vacataire"
    Dim conn As New MySqlConnection(connString)

    Private Sub FormCours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' L'ordre est bon
        RemplirCombo()
        RemplirGrille()
    End Sub

    ' --- CHARGER LA COMBOBOX ---
    Private Sub RemplirCombo()
        Try
            ' On vérifie l'état pour éviter les erreurs "Already Open"
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "SELECT id_etablissement, nom FROM etablissements"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            cmbEtablissement.DataSource = table
            cmbEtablissement.DisplayMember = "nom"
            cmbEtablissement.ValueMember = "id_etablissement"
            conn.Close()
        Catch ex As Exception
            MsgBox("Erreur Combo : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' --- CHARGER LE DATAGRIDVIEW ---
    Private Sub RemplirGrille()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            ' Jointure SQL : Indispensable pour voir le nom de l'établissement
            Dim query As String = "SELECT C.id_cours As ID, C.libelle As Cours, E.nom As Etablissement " &
                                 "FROM Cours C " &
                                 "INNER JOIN Etablissements E ON C.id_etablissement = E.id_etablissement"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvCours.DataSource = table
            conn.Close()
        Catch ex As Exception
            MsgBox("Erreur Grille : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    ' --- BOUTON RETOUR (Button1) ---

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Acceuil.Show()
        Me.Hide()
    End Sub


    ' --- BOUTON AJOUTER (Button2) ---
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If txtLibelle.Text = "" Then
            MsgBox("Veuillez saisir le nom du cours.")
            Return
        End If

        Try
            conn.Open()
            Dim query = "INSERT INTO Cours (libelle, id_etablissement) VALUES (@lib, @id_etab)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@lib", txtLibelle.Text)
            cmd.Parameters.AddWithValue("@id_etab", cmbEtablissement.SelectedValue)

            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Cours ajouté !")
            RemplirGrille()
            txtLibelle.Clear()
        Catch ex As Exception
            MsgBox("Erreur Ajout : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    ' --- BOUTON RAFRAÎCHIR (Button5) ---
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        txtLibelle.Clear()
        RemplirCombo()
        RemplirGrille()
    End Sub



    ' --- BOUTON SUPPRIMER (Button4) ---
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If dgvCours.CurrentRow Is Nothing Then Exit Sub

        Dim resultat = MsgBox("Supprimer ce cours ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If resultat = MsgBoxResult.Yes Then
            Try
                conn.Open()
                Dim query = "DELETE FROM Cours WHERE id_cours=@id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", dgvCours.CurrentRow.Cells("ID").Value)
                cmd.ExecuteNonQuery()

                ' Reset Auto-incrément
                Dim cmdReset As New MySqlCommand("ALTER TABLE Cours AUTO_INCREMENT = 1", conn)
                cmdReset.ExecuteNonQuery()

                conn.Close()
                MsgBox("Cours supprimé !")
                RemplirGrille()
                txtLibelle.Clear()
            Catch ex As Exception
                MsgBox("Erreur Suppression : " & ex.Message)
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If
    End Sub


    ' --- BOUTON MODIFIER (Button3) ---

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If dgvCours.CurrentRow Is Nothing Then Exit Sub

        Try
            conn.Open()
            Dim query = "UPDATE Cours SET libelle=@lib, id_etablissement=@id_etab WHERE id_cours=@id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@lib", txtLibelle.Text)
            cmd.Parameters.AddWithValue("@id_etab", cmbEtablissement.SelectedValue)
            cmd.Parameters.AddWithValue("@id", dgvCours.CurrentRow.Cells("ID").Value)

            cmd.ExecuteNonQuery()
            conn.Close()

            MsgBox("Cours mis à jour !")
            RemplirGrille()
        Catch ex As Exception
            MsgBox("Erreur Modification : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub



    ' --- CORRECTION 2 : Clic sur la grille (Utiliser CellClick au lieu de CellContentClick) ---
    Private Sub dgvCours_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCours.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row = dgvCours.Rows(e.RowIndex)
            txtLibelle.Text = row.Cells("Cours").Value.ToString
            cmbEtablissement.Text = row.Cells("Etablissement").Value.ToString
        End If
    End Sub
End Class