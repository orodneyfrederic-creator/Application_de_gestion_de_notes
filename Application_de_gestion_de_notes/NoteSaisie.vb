Imports MySql.Data.MySqlClient

Public Class NoteSaisie

    Dim connString As String = "server=localhost;user=root;password=root;database=gestion_vacataire"
    Dim conn As New MySqlConnection(connString)



    Private Sub NoteSaisie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuration du NumericUpDown par code (Sécurité 0-20)
        numNote.Minimum = 0
        numNote.Maximum = 20
        numNote.DecimalPlaces = 2

        ' Chargement des données au démarrage
        RemplirComboEtudiants()
        RemplirComboEtablissements()
        RemplirGrille()
    End Sub

    ' --- 1. CHARGER LA LISTE DES ÉTUDIANTS ---
    Private Sub RemplirComboEtudiants()
        Try
            Using conn As New MySqlConnection(connString)
                Dim query As String = "SELECT id_etudiant, CONCAT(nom, ' ', prenom) AS nom_complet FROM etudiants ORDER BY nom ASC"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbEtudiant.DataSource = table
                cmbEtudiant.DisplayMember = "nom_complet"
                cmbEtudiant.ValueMember = "id_etudiant"
            End Using
        Catch ex As Exception
            MsgBox("Erreur Combo Etudiants : " & ex.Message)
        End Try

    End Sub



    ' --- 2. CHARGER LES ÉTABLISSEMENTS ---
    Private Sub RemplirComboEtablissements()
        Try
            Using conn As New MySqlConnection(connString)
                Dim query As String = "SELECT id_etablissement, nom FROM etablissements ORDER BY nom ASC"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbEtablissement.DataSource = table
                cmbEtablissement.DisplayMember = "nom"
                cmbEtablissement.ValueMember = "id_etablissement"
            End Using
        Catch ex As Exception
            MsgBox("Erreur Combo Etablissements : " & ex.Message)
        End Try
    End Sub




    ' --- 3. CHARGER LES COURS FILTRÉS PAR ÉTABLISSEMENT ---
    Private Sub RemplirComboCours(ByVal idEtab As Integer)
        Try
            Using conn As New MySqlConnection(connString)
                ' On ne récupère que les cours dont l'id_etablissement correspond au choix
                Dim query As String = "SELECT id_cours, libelle FROM cours WHERE id_etablissement = @idEtab ORDER BY libelle ASC"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@idEtab", idEtab)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbCours.DataSource = table
                cmbCours.DisplayMember = "libelle"
                cmbCours.ValueMember = "id_cours"
            End Using
        Catch ex As Exception
            MsgBox("Erreur filtrage cours : " & ex.Message)
        End Try
    End Sub




    ' --- 4. AFFICHER LA GRILLE DES NOTES (Ordonnée) ---
    Public Sub RemplirGrille()
        Try
            Using conn As New MySqlConnection(connString)
                ' On trie par nom d'étudiant puis par nom de cours
                Dim query As String = "SELECT N.id_note As ID, E.nom As Etudiant, C.libelle As cours, N.valeur_note As note " &
                                     "FROM notes N " &
                                     "INNER JOIN etudiants E ON N.id_etudiant = E.id_etudiant " &
                                     "INNER JOIN cours C ON N.id_cours = C.id_cours " &
                                     "ORDER BY E.nom ASC, C.libelle ASC"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvNotes.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox("Erreur Grille : " & ex.Message)
        End Try
    End Sub




    '----Bouton Enregistrer ----
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Vérification que les sélections sont faites
        If cmbEtudiant.SelectedValue Is Nothing Or cmbCours.SelectedValue Is Nothing Then
            MsgBox("Veuillez sélectionner un étudiant et un cours.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Vérifier si la note existe déjà
                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM notes WHERE id_etudiant=@idE AND id_cours=@idC", conn)
                checkCmd.Parameters.AddWithValue("@idE", cmbEtudiant.SelectedValue)
                checkCmd.Parameters.AddWithValue("@idC", cmbCours.SelectedValue)

                If Convert.ToInt32(checkCmd.ExecuteScalar) > 0 Then
                    MsgBox("Cet étudiant possède déjà une note pour ce cours !")
                    Return
                End If

                ' Insertion
                Dim insertCmd As New MySqlCommand("INSERT INTO notes (id_etudiant, id_cours, valeur_note) VALUES (@idE, @idC, @val)", conn)
                insertCmd.Parameters.AddWithValue("@idE", cmbEtudiant.SelectedValue)
                insertCmd.Parameters.AddWithValue("@idC", cmbCours.SelectedValue)
                insertCmd.Parameters.AddWithValue("@val", numNote.Value)
                insertCmd.ExecuteNonQuery()
                MsgBox("Note enregistrée avec succès !")
            End Using

            RemplirGrille()
            CalculerMoyenne()
        Catch ex As Exception
            MsgBox("Erreur Enregistrement : " & ex.Message)
        End Try

    End Sub





    ' --- 5. CALCUL DE LA MOYENNE DU COURS ---
    Private Sub CalculerMoyenne()
        Dim idA As Integer
        ' On récupère l'étudiant sélectionné
        If cmbEtudiant.SelectedValue Is Nothing OrElse Not Integer.TryParse(cmbEtudiant.SelectedValue.ToString(), idA) Then
            lblMoyenne.Text = "Moyenne : --"
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                'On laisse MySQL calculer la moyenne
                Dim cmd As New MySqlCommand("SELECT AVG(valeur_note) FROM notes WHERE id_etudiant = @idA", conn)
                cmd.Parameters.AddWithValue("@idA", idA)
                Dim result = cmd.ExecuteScalar()

                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Dim moyenne As Double = Convert.ToDouble(result)

                    lblMoyenne.Text = "Moyenne du cours :" & "" & moyenne.ToString("N2") & "/20"
                    lblMoyenne.ForeColor = If(moyenne >= 10, Color.Green, Color.Red)
                Else
                    lblMoyenne.Text = "Moyenne : N/A"
                    lblMoyenne.ForeColor = Color.Black
                End If
            End Using
        Catch ex As Exception
            lblMoyenne.Text = "Erreur" & ex.Message
        End Try

    End Sub



    ' --- ÉVÉNEMENTS DE SYNCHRONISATION ---
    ' Quand on change d'établissement -> On filtre les cours
    Private Sub cmbEtablissement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEtablissement.SelectedIndexChanged
        Dim idEtab As Integer
        If cmbEtablissement.SelectedValue IsNot Nothing AndAlso Integer.TryParse(cmbEtablissement.SelectedValue.ToString(), idEtab) Then
            RemplirComboCours(idEtab)
        End If

    End Sub

    ' Quand on change de cours on recalcule la moyenne
    Private Sub cmbCours_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCours.SelectedIndexChanged

        ' Me.Created permet d'éviter le calcul pendant que le formulaire s'initialise
        If Me.Created Then
            CalculerMoyenne()
        End If


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RemplirComboEtudiants()
        RemplirComboEtablissements()
        RemplirGrille()
        numNote.Value = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Acceuil.Show()
        Me.Hide()
    End Sub


End Class