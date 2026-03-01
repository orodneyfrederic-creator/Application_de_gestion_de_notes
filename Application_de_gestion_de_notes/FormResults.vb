Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing




Public Class FormResults
    Dim connString As String = "server=localhost;user=root;password=root;database=gestion_vacataire"

    Private Sub FormResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerResultats()
    End Sub


    Private Sub ChargerResultats()


        Try
            Using conn As New MySqlConnection(connString)
                Dim query As String = "
SELECT
E.nom As Nom,
E.prenom As Prenom,
Et.nom As etablissement,

MIN(N.valeur_note) AS Note_Min,
MAX(N.valeur_note) AS Note_Max,
AVG(N.valeur_note) AS moyenne 

FROM notes N
INNER JOIN etudiants E ON N.id_etudiant = E.id_etudiant
INNER JOIN cours C ON N.id_cours = C.id_cours
INNER JOIN etablissements ET ON C.id_etablissement
GROUP BY E.id_etudiant, E.nom, E.prenom, ET.nom
ORDER BY E.nom ASC"

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvResultats.DataSource = table
            End Using

        Catch ex As Exception
            MessageBox.Show("Erreur :" & ex.Message)

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Acceuil.Show
        Hide
    End Sub


    'Voici le code de mon button d'impression PDF 
    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        ' On prépare le document d'impression
        Dim pd As New Printing.PrintDocument()

        ' On définit ce qui doit être dessiné sur la page
        AddHandler pd.PrintPage, AddressOf ImprimerContenu

        ' On affiche la boîte de dialogue d'impression
        Dim printDlg As New PrintDialog()
        printDlg.Document = pd

        ' L'utilisateur choisit "Microsoft Print to PDF"
        If printDlg.ShowDialog() = DialogResult.OK Then
            pd.Print()
        End If
    End Sub


    Private Sub ImprimerContenu(sender As Object, e As PrintPageEventArgs)


        Dim x As Integer = 50 ' Marge gauche
        Dim y As Integer = 100 ' Marge haute
        Dim cellPadding As Integer = 5
        Dim rowHeight As Integer = 25
        Dim colWidth As Integer = 120

        ' 1. Police pour le titre et le contenu
        Dim fontTitre As New Font("Arial", 16, FontStyle.Bold)
        Dim fontHeader As New Font("Arial", 10, FontStyle.Bold)
        Dim fontCorps As New Font("Arial", 10, FontStyle.Regular)

        ' 2. Dessiner le titre
        e.Graphics.DrawString("RAPPORT DE RÉSULTATS ACADÉMIQUES", fontTitre, Brushes.Black, x, 40)
        e.Graphics.DrawString("Date : " & DateTime.Now.ToShortDateString(), fontCorps, Brushes.Black, x, 70)

        ' 3. Dessiner l'en-tête du tableau
        Dim pen As New Pen(Color.Black, 1)
        Dim currentX As Integer = x

        ' Fond gris pour l'en-tête
        e.Graphics.FillRectangle(Brushes.LightGray, x, y, dgvResultats.Columns.Count * colWidth, rowHeight)

        For Each col As DataGridViewColumn In dgvResultats.Columns
            ' Dessiner le rectangle de la cellule
            e.Graphics.DrawRectangle(pen, currentX, y, colWidth, rowHeight)
            ' Dessiner le texte de l'en-tête
            e.Graphics.DrawString(col.HeaderText, fontHeader, Brushes.Black, currentX + cellPadding, y + cellPadding)
            currentX += colWidth
        Next

        ' 4. Dessiner les lignes de données
        y += rowHeight ' On descend à la ligne suivante

        For Each row As DataGridViewRow In dgvResultats.Rows
            If Not row.IsNewRow Then
                currentX = x
                For Each cell As DataGridViewCell In row.Cells
                    ' Dessiner la bordure de la cellule
                    e.Graphics.DrawRectangle(pen, currentX, y, colWidth, rowHeight)
                    ' Dessiner la valeur de la note ou du nom
                    Dim texte As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                    e.Graphics.DrawString(texte, fontCorps, Brushes.Black, currentX + cellPadding, y + cellPadding)
                    currentX += colWidth
                Next
                y += rowHeight ' On passe à la ligne suivante
            End If
        Next
    End Sub





    'Code interne du bouton pour la conception des doc. Excel
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Fichier Excel (*.xls)|*.xls"
            saveFileDialog.FileName = "Export_Resultats.xls"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim sb As New System.Text.StringBuilder()

                ' 1. Entête du fichier XML pour Excel
                sb.AppendLine("<?xml version=""1.0""?><Workbook xmlns=""urn:schemas-microsoft-com:office:spreadsheet"" xmlns:ss=""urn:schemas-microsoft-com:office:spreadsheet"">")
                sb.AppendLine("<Worksheet ss:Name=""Notes""><Table>")

                ' 2. Création de la ligne des en-têtes
                sb.AppendLine("<Row>")
                For Each col As DataGridViewColumn In dgvResultats.Columns
                    sb.AppendLine("<Cell><Data ss:Type=""String"">" & col.HeaderText & "</Data></Cell>")
                Next
                sb.AppendLine("</Row>")

                ' 3. Remplissage des données
                For Each row As DataGridViewRow In dgvResultats.Rows
                    If Not row.IsNewRow Then
                        sb.AppendLine("<Row>")
                        For Each cell As DataGridViewCell In row.Cells
                            ' On gère les valeurs nulles pour éviter les plantages
                            Dim valeur As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                            sb.AppendLine("<Cell><Data ss:Type=""String"">" & valeur & "</Data></Cell>")
                        Next
                        sb.AppendLine("</Row>")
                    End If
                Next

                ' 4. Fermeture des balises
                sb.AppendLine("</Table></Worksheet></Workbook>")

                ' 5. Enregistrement physique du fichier
                System.IO.File.WriteAllText(saveFileDialog.FileName, sb.ToString(), System.Text.Encoding.UTF8)

                MessageBox.Show("Le fichier Excel a été généré avec succès !", "Export réussi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'export Excel : " & ex.Message)
        End Try

    End Sub


    'Code interne pour la gen. des document Word
    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Document Word (*.doc)|*.doc"
            saveFileDialog.FileName = "Rapport_Resultats.doc"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim sb As New System.Text.StringBuilder()

                ' 1. Structure HTML compatible Word avec encodage UTF-8
                sb.AppendLine("<html xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:w='urn:schemas-microsoft-com:office:word'>")
                sb.AppendLine("<head><meta charset='utf-8'><style>")
                ' Style CSS pour le tableau (bordures, polices, couleurs)
                sb.AppendLine("table { border-collapse: collapse; width: 100%; font-family: Arial; }")
                sb.AppendLine("th { background-color: #4A90E2; color: white; padding: 10px; border: 1px solid #ddd; }")
                sb.AppendLine("td { padding: 8px; border: 1px solid #ddd; text-align: left; }")
                sb.AppendLine("h2 { color: #333; text-align: center; }")
                sb.AppendLine("</style></head><body>")

                ' 2. Titre et Date
                sb.AppendLine("<h2>LISTE OFFICIELLE DES RÉSULTATS</h2>")
                sb.AppendLine("<p style='text-align:right;'>Généré le : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm") & "</p>")

                ' 3. Début du tableau
                sb.AppendLine("<table><thead><tr>")

                ' En-têtes des colonnes
                For Each col As DataGridViewColumn In dgvResultats.Columns
                    sb.AppendLine("<th>" & col.HeaderText & "</th>")
                Next
                sb.AppendLine("</tr></thead><tbody>")

                ' 4. Remplissage des données
                For Each row As DataGridViewRow In dgvResultats.Rows
                    If Not row.IsNewRow Then
                        sb.AppendLine("<tr>")
                        For Each cell As DataGridViewCell In row.Cells
                            Dim valeur As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                            sb.AppendLine("<td>" & valeur & "</td>")
                        Next
                        sb.AppendLine("</tr>")
                    End If
                Next

                sb.AppendLine("</tbody></table></body></html>")

                ' 5. Écriture du fichier
                System.IO.File.WriteAllText(saveFileDialog.FileName, sb.ToString(), System.Text.Encoding.UTF8)

                MessageBox.Show("Le document Word a été généré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'export Word : " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using conn As New MySqlConnection(connString)
                ' La requête corrigée avec la jointure exacte
                Dim query As String = "
                SELECT 
                    E.nom As Nom, 
                    E.prenom As Prenom, 
                    ET.nom As etablissement,
                    MIN(N.valeur_note) AS Note_Min, 
                    MAX(N.valeur_note) AS Note_Max, 
                    ROUND(AVG(N.valeur_note), 2) AS moyenne 
                FROM notes N
                INNER JOIN etudiants E ON N.id_etudiant = E.id_etudiant
                INNER JOIN cours C ON N.id_cours = C.id_cours
                INNER JOIN etablissements ET ON C.id_etablissement = ET.id_etablissement
                GROUP BY E.id_etudiant, E.nom, E.prenom, ET.nom
                ORDER BY E.nom ASC"

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Mise à jour du tableau
                dgvResultats.DataSource = table
            End Using

            ' Message de confirmation optionnel
            ' MessageBox.Show("Données rafraîchies !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erreur lors du rafraîchissement : " & ex.Message)
        End Try
    End Sub
End Class